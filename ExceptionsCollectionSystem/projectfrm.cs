using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace ExceptionsCollectionSystem
{
    public partial class projectfrm : Form
    {
        public projectfrm()
        {
            InitializeComponent();
        }

        private DataDisposes dataDisposes = new DataDisposes();//全局数据库链接
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string proName;

        public string ProName
        {
            get { return proName; }
            set { proName = value; }
        }

        public bool State { get; set; }

        private void projectfrm_Load(object sender, EventArgs e)
        {
            State = false;
            if (this.Text == "添加项目")
            {
                DataTable maxid = (DataTable)dataDisposes.Select("projectinfo", "max(projectid) as maxid ", "");
                int newid = (int)maxid.Rows[0]["maxid"] + 1;
                txtProID.Text = newid.ToString();
                txtProName.Text = ProName;
            }
            else
            {
                DataTable curUser = (DataTable)dataDisposes.Select("projectinfo", "*", "where projectid=" + id);
                txtProID.Text = curUser.Rows[0]["projectid"].ToString();
                txtProName.Text = curUser.Rows[0]["projectname"].ToString();
                txtProvince.Text = curUser.Rows[0]["province"].ToString();
                txtRemarks.Text = curUser.Rows[0]["remarks"].ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.Text == "添加项目")
            {
                string strCol = "projectname,province,remarks";
                string strRow = "'" + txtProName.Text.Trim() + "'," + "'" + txtProvince.Text.Trim() + "'," + "'" + txtRemarks.Text.Trim() + "'";
                dataDisposes.Insertfull("projectinfo", strCol, strRow);
            }
            if (this.Text == "修改项目")
            {
                string strCol = "projectname" + "='" + txtProName.Text.Trim() + "'," + "province" + "='" + txtProvince.Text.Trim() + "'," + "remarks" + "='" + txtRemarks.Text.Trim() + "'";
                dataDisposes.Update("projectinfo", strCol, "where projectid=" + txtProID.Text);
            }
            State = true;
            this.Close();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
