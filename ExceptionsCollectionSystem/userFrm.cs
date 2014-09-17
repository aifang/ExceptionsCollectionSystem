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
    public partial class userFrm : Form
    {
        public userFrm()
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

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public bool State { get; set; }

        private void userFrom_Load(object sender, EventArgs e)
        {
            State = false;
            if (this.Text == "添加用户")
            {
                DataTable maxid = (DataTable)dataDisposes.Select("userinfo", "max(userid) as maxid ", "");
                int newid = (int)maxid.Rows[0]["maxid"] + 1;
                txtUserID.Text = newid.ToString();
                txtUserName.Text = UserName;
            }
            else
            {
                DataTable curUser = (DataTable)dataDisposes.Select("userinfo", "*", "where userid=" + id);
                txtUserID.Text = curUser.Rows[0]["userid"].ToString();
                txtUserName.Text = curUser.Rows[0]["username"].ToString();
                txtProvince.Text = curUser.Rows[0]["province"].ToString();
                txtPhone.Text = curUser.Rows[0]["phone"].ToString();
                txtRemark.Text = curUser.Rows[0]["remarks"].ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.Text == "添加用户")
            {
                string strCol = "username,province,remarks";
                string strRow = "'" + txtUserID.Text.Trim() + "'," + "'" + txtUserName.Text.Trim() + "'," + "'" + txtProvince.Text.Trim() + "'," + "'" + txtPhone.Text.Trim()  + "'," + "'" + txtRemark.Text.Trim() + "'";
                //dataDisposes.Insertfull("userinfo", strCol, strRow);
                dataDisposes.Insert("userinfo", strRow);
            }
            if (this.Text == "修改用户")
            {
                string strCol = "username" + "='" + txtUserName.Text.Trim() + "'," + "province" + "='" + txtProvince.Text.Trim() + "'," + "phone" + "='" + txtPhone.Text.Trim() + "'," + "remarks" + "='" + txtPhone.Text.Trim() + "'";
                dataDisposes.Update("userinfo", strCol, "where userid=" + txtUserID.Text);
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
