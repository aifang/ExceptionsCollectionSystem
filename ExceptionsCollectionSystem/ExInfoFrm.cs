using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using System.Data.OleDb;

namespace ExceptionsCollectionSystem
{
    public partial class ExInfoFrm : Form
    {
        public ExInfoFrm()
        {
            InitializeComponent();
        }
        private DataDisposes dataDisposes = new DataDisposes();//全局数据库链接
        public int ID { get; set; }
        string TypeID = null;
        string ProID = null;
        string UserID = null;

        private void EXInfoFrm_Load(object sender, EventArgs e)
        {
            cmbUser.AutoCompleteCustomSource = getSuggestSource("userinfo", "username", cmbUser);
            cmbPro.AutoCompleteCustomSource = getSuggestSource("projectinfo", "projectName", cmbPro);
            cmbExType.AutoCompleteCustomSource = getSuggestSource("exceptionstype", "typeName", cmbExType);
            txtExName.AutoCompleteCustomSource = getSuggestSource("exceptionsinfo", "exceptionname");
            if (this.Text == "添加异常信息")
            {
                DataTable maxid = (DataTable)dataDisposes.Select("exceptionsinfo", "max(id) as maxid ", "");
                int newid = (int)maxid.Rows[0]["maxid"] + 1;
                txtID.Text = newid.ToString();
            }
            else
            {
                txtID.Text = ID.ToString();
                string[] IDCollections=new string[3];
                string sql = "select * from exceptionsinfo where id="+ID;
                OleDbDataReader odr = DBHelper.GetReader(sql);
                while (odr.Read())
                {
                    IDCollections[0] = odr["userid"].ToString();
                    IDCollections[1] = odr["projectid"].ToString();
                    IDCollections[2] = odr["typeid"].ToString();
                    txtExID.Text = odr["exceptionid"].ToString();
                    txtExName.Text = odr["exceptionName"].ToString();
                    txtDescripe.Text = odr["exceptiondescription"].ToString();
                    txtSolution.Text = odr["solution"].ToString();
                    txtRemarks.Text = odr["remarks"].ToString();
                }
                odr.Close();
                cmbUser.Text = IDtoName("select username from userinfo where userid=" + IDCollections[0], "username");
                cmbPro.Text = IDtoName("select projectname from projectinfo where projectid=" + IDCollections[1], "projectname");
                cmbExType.Text = IDtoName("select typeName from exceptionstype where typeid=" + IDCollections[2], "typeName");

            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                UserID = convertNametoID("select userid from userinfo where username ='" + cmbUser.Text.Trim() + "'", "userid");
                ProID = convertNametoID("select projectid from projectinfo where projectName ='" + cmbPro.Text.Trim() + "'", "projectid");
                if (UserID == null | ProID == null|txtExName.Text.Trim()==null)
                {
                    label10.Text = "  请填正确写必要信息！";
                    return;
                }
            }
            catch (Exception err)
            {
                label10.Text = err.Message;
                return;
            }

            if (this.Text == "添加异常信息")
            {
                string sqlExInfo = "insert into exceptionsInfo values('" + txtID.Text.Trim() + "','"
                    + UserID + "','" + ProID + "','" + TypeID + "','"
                    + txtExID.Text + "','" + txtExName.Text.Trim() + "','" + txtDescripe.Text.Trim() + "','"
                    + txtSolution.Text.Trim() + "','" + txtRemarks.Text.Trim() + "')";
                try
                {
                    DBHelper.ExcuteCommand(sqlExInfo);
                }
                catch (Exception ex)
                {
                    label10.Text="异常类型不存在请添加.";
                    return;
                }
            }
            this.Close();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cmbExType_TextChanged(object sender, EventArgs e)
        {
            setExceptionID();
        }

        /// <summary>
        /// 设置异常ID
        /// </summary>
        private void setExceptionID()
        {
            string sqltypeID = "select typeid from exceptionstype where typename='" + cmbExType.Text.Trim() + "'";
            OleDbDataReader odr = DBHelper.GetReader(sqltypeID);
            if (odr.Read())
            {
                string typid = odr["typeid"].ToString();
                TypeID = typid;
                txtExID.Text = "TLW-" + typid + "-";
                NewMethod();
            }
            else
            {
                txtExID.Text = "";
                //return;
            }
            odr.Close();            
        }

        private void NewMethod()
        {
            string sqlExID = "select max(exceptionid) as idmax from exceptionsinfo where exceptionid in(select exceptionid from exceptionsinfo where exceptionid like '" + txtExID.Text + "%')";
            OleDbDataReader odr1 = DBHelper.GetReader(sqlExID);
            while (odr1.Read())
            {
                string strID = odr1["idmax"].ToString();
                if (strID != "")
                {
                    int exid = Convert.ToInt32(strID.Substring(strID.LastIndexOf('-') + 1)) + 1;
                    txtExID.Text += exid.ToString();
                }
                else
                {
                    txtExID.Text += '1';
                }
            }
            odr1.Close();
        }

        /// <summary>
        /// 获取自动补完字符串
        /// </summary>
        /// <param name="tableName">表明</param>
        /// <param name="column">要填入的列</param>
        private AutoCompleteStringCollection getSuggestSource(string tableName, string column, ComboBox cmb)
        {
            cmb.AutoCompleteCustomSource.Clear();
            cmb.Items.Clear();
            AutoCompleteStringCollection strings = new AutoCompleteStringCollection();
            DataTable userTable = (DataTable)dataDisposes.Select(tableName, "*", "");
            foreach (DataRow dr in userTable.Rows)
            {
                strings.Add(dr[column].ToString());
                cmb.Items.Add(dr[column].ToString());
            }
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            return strings;
        }
        private AutoCompleteStringCollection getSuggestSource(string tableName, string column)
        {
            
            AutoCompleteStringCollection strings = new AutoCompleteStringCollection();
            DataTable userTable = (DataTable)dataDisposes.Select(tableName, "*", "");
            foreach (DataRow dr in userTable.Rows)
            {
                strings.Add(dr[column].ToString());
            }
            return strings;
        }

        private void btnUseradd_Click(object sender, EventArgs e)
        {
            userFrm puserFrom = new userFrm();
            puserFrom.Text = "添加用户";
            puserFrom.UserName = cmbUser.Text.Trim(); 
            puserFrom.ShowDialog();
            if(puserFrom.State)
            cmbUser.AutoCompleteCustomSource = getSuggestSource("userinfo", "username", cmbUser);
        }

        private void btnProadd_Click(object sender, EventArgs e)
        {
            projectfrm pro = new projectfrm();
            pro.Text = "添加项目";
            pro.ProName = cmbPro.Text.Trim();
            pro.ShowDialog();
            if(pro.State)
            cmbPro.AutoCompleteCustomSource = getSuggestSource("projectinfo", "projectName", cmbPro);            
        }

        private void btnTypeadd_Click(object sender, EventArgs e)
        {
            typefrm type = new typefrm();
            type.Text = "添加类型";
            type.TypeName = cmbExType.Text.Trim();
            type.ShowDialog();
            
            if (type.State)
            {
                cmbExType.AutoCompleteCustomSource = getSuggestSource("exceptionstype", "typeName", cmbExType);
                cmbExType.Text = type.TypeName;
                txtExID.Text= "TLW-"+type.ID+"-1";
            }
        }

        private string convertNametoID(string sql,string columnID)
        {
            string id = null;
            OleDbDataReader odr = DBHelper.GetReader(sql);
            while (odr.Read())
            {
                id = odr[columnID].ToString();
            }
            odr.Close();
            return id;
        }

        private string IDtoName(string sql, string ColumnName)
        {
            string name=null;
            OleDbDataReader odr = DBHelper.GetReader(sql);
            while (odr.Read())
                name = odr[ColumnName].ToString();
            odr.Close();
            return name;
        }

        private void cmbExType_TextUpdate(object sender, EventArgs e)
        {
            //setExceptionID();
        }

    }
}
