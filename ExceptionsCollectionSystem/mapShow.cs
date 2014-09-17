using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Model;
using BLL;

namespace ExceptionsCollectionSystem
{
    public partial class mapShow : Form
    {
        public mapShow()
        {
            InitializeComponent();
        }

        string tableName = null;
        string column = null;
        string columnID = null;
        //int resultCount = -1;
        List<Button> listbtn = new List<Button>();

        private void picShowresult_Click(object sender, EventArgs e)
        {
            Bitmap imageShow = new Bitmap(Application.StartupPath + @"\Resources\show.jpg");
            Bitmap imageun = new Bitmap(Application.StartupPath + @"\Resources\unshow.jpg");
            if (pnlResult.Dock == DockStyle.None)
            {
                pnlResult.Dock = DockStyle.Left;
                picShowresult.Image = imageun;
            }
            else
            {
                pnlResult.Dock = DockStyle.None;
                picShowresult.Image = imageShow;
            }
        }

        private void txtKeywork_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DoQuery();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
        }

        private void cmbo_TextChanged(object sender, EventArgs e)
        {
            txtKeywork.AutoCompleteMode = AutoCompleteMode.Suggest;
            switch (cmbo.Text)
            {
                case "ID":
                    tableName = "exceptionsinfo";
                    column = "id";
                    break;
                case "用户名":
                    tableName = "userinfo";
                    column = "username";
                    columnID = "userID";
                    break;
                case "项目名称":
                    tableName = "projectinfo";
                    column = "projectname";
                    columnID = "projectID";
                    break;
                case "异常类型":
                    tableName = "exceptionstype";
                    column = "typename";
                    columnID = "typeId";
                    break;
                case "异常ID":
                    tableName = "exceptionsinfo";
                    column = "exceptionid";
                    txtKeywork.Text = "TLW-";
                    txtKeywork.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    break;
                case "异常名称":
                    tableName = "exceptionsinfo";
                    column = "exceptionName";
                    break;
                default:
                    break;
            }
            txtKeywork.AutoCompleteCustomSource = getSuggestSource(tableName, column);
        }

        private AutoCompleteStringCollection getSuggestSource(string tableName, string column)
        {
            DataDisposes dataDisposes = new DataDisposes();
            AutoCompleteStringCollection strings = new AutoCompleteStringCollection();
            DataTable userTable = (DataTable)dataDisposes.Select(tableName, "*", "");
            foreach (DataRow dr in userTable.Rows)
            {
                strings.Add(dr[column].ToString());
            }
            return strings;
        }

        private void btnResultArr_Click(object sender, EventArgs e)
        {
            int index=btnResultArr.Text.IndexOf('：');
            int index2=btnResultArr.Text.IndexOf('，');

            string id=btnResultArr.Text.Substring(index+1,index2-index-1);
            ExInfoFrm exInfo = new ExInfoFrm();
            if (id != "")
            {
                exInfo.ID = Convert.ToInt32(id);
                exInfo.Text = "修改异常信息";
                exInfo.Show();
            }
        }
        //查询
        private void DoQuery()
        {
            //resultCount = 0;
            listbtn.Clear();
            if (cmbo.Text != "" && txtKeywork.Text.Trim() != "")
            {
                string whereStr = null;
                List<ExceptionsInfo> list = null;
                switch (cmbo.Text)
                {
                    case "ID":
                        whereStr = "ID like '%" + txtKeywork.Text.Trim() + "%'";
                        break;
                    case "用户名":
                        List<int> listUserID = UserInfoManage.FindByNameArr(txtKeywork.Text.Trim());

                        queryByName(listUserID);
                        return; //完全跳出
                    case "项目名称":
                        List<int> listProID = ProjectInfoManage.FindByNameArr(txtKeywork.Text.Trim());
                        queryByName(listProID);
                        return;////完全跳出
                    case "异常类型":
                        List<int> listTypeID = ExceptionsTypeManage.FindByNameArr(txtKeywork.Text.Trim());
                        queryByName(listTypeID);
                        return;
                    case "异常ID":
                        whereStr = "exceptionID like '%" + txtKeywork.Text.Trim() + "%'";
                        break;
                    case "异常名称":
                        whereStr = "exceptionName like '%" + txtKeywork.Text.Trim() + "%'";
                        break;
                    default:
                        break;
                }

                if (whereStr != null)
                {
                    list = ExceptionsInfoManage.findTop10(1, whereStr);
                    flowLayoutPanel1.Controls.Clear();
                    //getResultCount(list);
                    AddResult(list);
                }
            }
        }
        //汉字转ID查询
        private void queryByName(List<int> listID)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (int ex in listID)
            {
                string whereStr= columnID+"="+ex;
                List<ExceptionsInfo> list = ExceptionsInfoManage.findTop10(1,whereStr);
                //getResultCount(list);
                AddResult(list);
            }
        }
        //添加结果到listbtn里面
        private void AddResult(List<ExceptionsInfo> list)
        {
            if (list.Count != 0)
            {
                foreach(ExceptionsInfo n in list)
                {
                    Button btn = new Button();
                    btn.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
                    btn.Size = new System.Drawing.Size(206, 62);
                    btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    btn.UseVisualStyleBackColor = true;
                    btn.Click += new System.EventHandler(this.btnResultArr_Click);
                    btn.Text = "ID：" + n.ID + "，" + n.ExcepitionName + "\r\n标签：" + n.ProjectID + "，" + n.UserID + "\r\n异常信息：" + n.ExcepitionID + "，" + n.TypeID + "\r\n问题描述：" + n.ExcepitionDescri;
                    flowLayoutPanel1.Controls.Add(btn);
                    //listbtn.Add(btn);
                    
                }
                if (flowLayoutPanel1.Controls.Count > 7)
                {
                    pnlTurnPage.Dock = DockStyle.Bottom;
                }
                else pnlTurnPage.Dock = DockStyle.None;
                pnlResult.Dock = DockStyle.Left;
            }
        }


        //检索结果总量
        //private void getResultCount(List<ExceptionsInfo> list)
        //{
        //    resultCount += list.Count;
        //}
        //private void insertToPanel()
        //{
        //    for(int i=0;i<
        //}
    }
}
