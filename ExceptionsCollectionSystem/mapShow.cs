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
        int count = 0;
        List<Button> listbtn = new List<Button>();


        #region  控件事件

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
            {
                DoQuery();
                turnPaper1.setCount(count);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
            turnPaper1.setCount(count);
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

       
        #endregion


        #region 私有方法
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


        /// <summary>
        /// 根据用户选择的查询方式查询
        /// </summary>
        private void DoQuery()
        {
            count = 0;
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
                        return;//完全跳出
                    case "异常类型":
                        List<int> listTypeID = ExceptionsTypeManage.FindByNameArr(txtKeywork.Text.Trim());
                        queryByName(listTypeID);
                        return;//完全跳出
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
                    AddResult(list);
                    count = ExceptionsInfoManage.returnCount(whereStr);
                }
            }
        }
        

        /// <summary>
        /// 通过ID查询异常信息
        /// </summary>
        /// <param name="listID"></param>
        private void queryByName(List<int> listID)
        {
            int _count=0;
            flowLayoutPanel1.Controls.Clear();
            foreach (int ex in listID)
            {
                string whereStr= columnID+"="+ex;
                List<ExceptionsInfo> list = ExceptionsInfoManage.findTop10(1,whereStr);
                AddResult(list);
                _count = ExceptionsInfoManage.returnCount(whereStr);
                count += _count;
            }
            
            pnlResultDorkSetting();
        }
        /// <summary>
        /// 添加结果到列表框里面
        /// </summary>
        /// <param name="list">完整的异常信息list</param>
        private void AddResult(List<ExceptionsInfo> list)
        {
            if (list.Count != 0)
            {
                foreach(ExceptionsInfo n in list)
                {
                    //Button btn = new Button();
                    Button btn = createNewButton(n);
                    flowLayoutPanel1.Controls.Add(btn);
                }
                
            }
            
            pnlResultDorkSetting();
        }


        /// <summary>
        /// 设置查询结果列表框的显示和隐藏
        /// </summary>
        private void pnlResultDorkSetting()
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                pnlResult.Dock = DockStyle.Left;
            }
            else pnlResult.Dock = DockStyle.None;
        }

        /// <summary>
        /// 新建结果按钮
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private Button createNewButton(ExceptionsInfo n)
        {
            Button btn = new Button();
            btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            btn.Size = new System.Drawing.Size(205, 62);
            btn.Text = "ID：" + n.ID + "，" + n.ExcepitionName + "\r\n标签：" + n.ProjectID + "，" + n.UserID + "\r\n异常信息：" + n.ExcepitionID + "，" + n.TypeID + "\r\n问题描述：" + n.ExcepitionDescri;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.UseVisualStyleBackColor = true;
            btn.Click += new System.EventHandler(this.btnResultArr_Click);
            return btn;
        }

        #endregion 
        

    }
}
