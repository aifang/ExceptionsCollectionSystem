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
    public partial class typefrm : Form
    {
        public typefrm()
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

        private string typeName;

        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }
        public bool State { get; set; }

        private void typefrm_Load(object sender, EventArgs e)
        {
            State = false;
            if (this.Text == "添加类型")
            {
                DataTable maxid = (DataTable)dataDisposes.Select("exceptionstype", "max(typeid) as maxid ", "");
                int newid = (int)maxid.Rows[0]["maxid"] + 1;
                txtTypeID.Text = newid.ToString();
                txtTypeName.Text = TypeName;
            }
            else
            {
                DataTable curUser = (DataTable)dataDisposes.Select("exceptionstype", "*", "where typeid=" + id);
                txtTypeID.Text = curUser.Rows[0]["typeid"].ToString();
                txtTypeName.Text = curUser.Rows[0]["typename"].ToString();
                txtCategory.Text = curUser.Rows[0]["category"].ToString();
                txtRemarks.Text = curUser.Rows[0]["remarks"].ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.Text == "添加类型")
            {
                string strCol = "typename,category,remarks";
                string strRow = "'" + txtTypeName.Text.Trim() + "'," + "'" + txtCategory.Text.Trim() + "'," + "'" + txtRemarks.Text.Trim() + "'";
                dataDisposes.Insertfull("exceptionstype", strCol, strRow);
            }
            if (this.Text == "修改类型")
            {
                string strCol = "typename" + "='" + txtTypeName.Text.Trim() + "'," + "category" + "='" + txtCategory.Text.Trim() + "'," + "remarks" + "='" + txtRemarks.Text.Trim() + "'";
                dataDisposes.Update("exceptionstype", strCol, "where typeid=" + txtTypeID.Text);
            }
            TypeName = txtTypeName.Text;
            ID = Convert.ToInt32(txtTypeID.Text);
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
