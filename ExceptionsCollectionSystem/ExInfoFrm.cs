using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

using DAL;
using BLL;

namespace ExceptionsCollectionSystem
{
    public partial class ExInfoFrm : Form
    {
        public ExInfoFrm()
        {
            InitializeComponent();
        }
        private DataDisposes dataDisposes = new DataDisposes();//全局数据库链接
        public int ID { get; set; }        //传入的ID，用于父窗体调用
        string TypeID = "";              //异常类型
        string ProID = "";               //项目id
        string UserID = "";              //用户id
        string _tempProID = "";          //修改时载入的项目Id
        string _tempTypeID = "";         //修改时载入的异常类型ID
        string _tempExInfoID = "";       //修改时载入的异常信息ID tlw-1-1

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
                    _tempProID = odr["projectid"].ToString();        //初始化tempID值 
                    _tempTypeID = odr["typeid"].ToString();
                    _tempExInfoID = odr["exceptionid"].ToString();

                    IDCollections[0] = odr["userid"].ToString();
                    IDCollections[1] = odr["projectid"].ToString();
                    IDCollections[2] = odr["typeid"].ToString();

                    txtExName.Text = odr["exceptionName"].ToString();
                    txtDescripe.Text = odr["exceptiondescription"].ToString();
                    txtSolution.Text = odr["solution"].ToString();
                    txtRemarks.Text = odr["remarks"].ToString();
                }
                odr.Close();
                cmbUser.Text = IDtoName("select username from userinfo where userid=" + IDCollections[0], "username");
                cmbPro.Text = IDtoName("select projectname from projectinfo where projectid=" + IDCollections[1], "projectname");
                cmbExType.Text = IDtoName("select typeName from exceptionstype where typeid=" + IDCollections[2], "typeName");
                txtExID.Text = _tempExInfoID;    //以免发生变化
            }
        }

        //确定键单击事件
        private void btnOK_Click(object sender, EventArgs e)
        {
            bool check=false;
            try
            {
                UserID = convertNametoID("select userid from userinfo where username ='" + cmbUser.Text.Trim() + "'", "userid");
                ProID = convertNametoID("select projectid from projectinfo where projectName ='" + cmbPro.Text.Trim() + "'", "projectid");
                if (UserID == null | ProID == null|txtExName.Text.Trim()==null)
                {
                    lblErr.Text = "  请填正确写必要信息！";
                    return;
                }
            }
            catch (Exception err)
            {
                lblErr.Text = err.Message;
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
                    lblErr.Text="异常类型不存在请添加.";
                    return;
                }
            }
            if (this.Text == "修改异常信息")
            {
               check=ExceptionsInfoManage.updateExinfo(ID,UserID,ProID,TypeID,txtExID.Text,txtExName.Text.Trim(),txtDescripe.Text.Trim(),txtSolution.Text .Trim(),txtRemarks.Text.Trim());
            }

            if (check)
            {
                this.Close();
                this.Dispose();
            }
            else
                lblErr.Text = "保存失败！";
                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cmbExType_TextChanged(object sender, EventArgs e)
        {
            TypeID = ExceptionsTypeManage.getIDbyName(cmbExType.Text.Trim());
            if (TypeID != "")
            {
                if (TypeID == _tempTypeID)
                {
                    txtExID.Text = _tempExInfoID;
                }
                else
                {
                    string strTemp = "TLW-" + TypeID + "-";
                    txtExID.Text = ExceptionsInfoManage.getMaxExInfoID(strTemp);
                }
            }
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

        //用户添加按钮
        private void btnUseradd_Click(object sender, EventArgs e)
        {
            userFrm puserFrom = new userFrm();
            puserFrom.Text = "添加用户";
            puserFrom.UserName = cmbUser.Text.Trim(); 
            puserFrom.ShowDialog();
            if(puserFrom.State)
            cmbUser.AutoCompleteCustomSource = getSuggestSource("userinfo", "username", cmbUser);
        }

        //项目添加按钮
        private void btnProadd_Click(object sender, EventArgs e)
        {
            projectfrm pro = new projectfrm();
            pro.Text = "添加项目";
            pro.ProName = cmbPro.Text.Trim();
            pro.ShowDialog();
            if(pro.State)
            cmbPro.AutoCompleteCustomSource = getSuggestSource("projectinfo", "projectName", cmbPro);            
        }

        //类型添加按钮
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

        /// <summary>
        /// 名称转为ID
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="columnID"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Id转成名称
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ColumnName"></param>
        /// <returns></returns>
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
