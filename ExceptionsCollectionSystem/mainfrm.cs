using System;
using System.Collections;
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
    public partial class mainfrm : Form
    {
        public mainfrm()
        {
            InitializeComponent();
        }

        private DataDisposes dataDisposes = new DataDisposes();//全局数据库链接

        private int id;      //记录ID号
        public int ID_m
        {
            get { return id; }
            set { id = value; }
        }

        int UIType = 0;         //界面类型 0-用户管理，1-项目管理，2-类型管理;
        string _exceptInfoID;   //TLW-1-1

        //用户管理
        private void btnUsermanager_Click(object sender, EventArgs e)
        {
            UIType = 0;
            listView1.ContextMenuStrip = cmsUser;
            RefreshTree("userinfo", "DISTINCT province", "用户列表", "username ,userid", "where province='", "userid");
            listView1.Clear();
            string[] arrColumn = { "用户ID", "用户名", "省份", "电话", "备注" };
            foreach (string item in arrColumn) listView1.Columns.Add(item);
        }
        
        //添加用户
        private void tsmtUserCreate_Click(object sender, EventArgs e)
        {
            userFrm puserFrom = new userFrm();
            puserFrom.Text = "添加用户";
            puserFrom.ShowDialog();
            RefreshTree("userinfo", "DISTINCT province", "用户列表", "username ,userid", "where province='", "userid");

        }
        //修改用户
        private void tsmtUserChange_Click(object sender, EventArgs e)
        {
            userFrm puserFrom = new userFrm();
            puserFrom.Text="修改用户";
            puserFrom.ID = ID_m;
            puserFrom.ShowDialog();
            RefreshTree("userinfo", "DISTINCT province", "用户列表", "username ,userid", "where province='", "userid");
        }
        //删除用户
        private void tsmtUserDel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("是否删除此用户？", "警告", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            dataDisposes.Delete("userinfo", "where userid=" + id);
            RefreshTree("userinfo", "DISTINCT province", "用户列表", "username ,userid", "where province='", "userid");
        }
        //项目管理
        private void btnProjectManager_Click(object sender, EventArgs e)
        {
            UIType = 1;
            //treeView1.ContextMenuStrip = cmstProject;
            listView1.ContextMenuStrip = cmstProject;
            RefreshTree("projectinfo", "DISTINCT province", "项目列表", "projectname ,projectid", "where province='", "projectid");
            listView1.Clear();
            string[] arrColumn = { "项目ID", "项目名称", "省份", "备注" };
            foreach (string item in arrColumn) listView1.Columns.Add(item);
        }
        //添加项目
        private void tsmiProAdd_Click(object sender, EventArgs e)
        {
            projectfrm pro = new projectfrm();
            pro.Text = "添加项目";
            pro.ShowDialog();
            RefreshTree("projectinfo", "DISTINCT province", "项目列表", "projectname ,projectid", "where province='", "projectid");
        }
        //修改项目
        private void tsmiProChange_Click(object sender, EventArgs e)
        {
            projectfrm pro = new projectfrm();
            pro.Text = "修改项目";
            pro.ID = ID_m;
            pro.ShowDialog();
            RefreshTree("projectinfo", "DISTINCT province", "项目列表", "projectname ,projectid", "where province='", "projectid");
        }
        //类型管理
        private void btnTypeManager_Click(object sender, EventArgs e)
        {
            UIType = 2;
            listView1.ContextMenuStrip = cmstType;
            RefreshTree("exceptionstype","distinct category","类型列表","typename,typeid","where category='","typeid");
            listView1.Clear();
            string[] arrColumn = { "类型ID", "类型名称", "分类", "备注" };
            foreach (string item in arrColumn) listView1.Columns.Add(item);
        }
        //添加类型
        private void tsmiTypeAdd_Click(object sender, EventArgs e)
        {
            typefrm type = new typefrm();
            type.Text = "添加类型";            
            type.ShowDialog();
            RefreshTree("exceptionstype", "distinct category", "类型列表", "typename,typeid", "where category='", "typeid");
        }
        //修改类型
        private void tsmiTypeChange_Click(object sender, EventArgs e)
        {
            typefrm type = new typefrm();
            type.Text = "修改类型";
            type.ID = ID_m;
            type.ShowDialog();
            RefreshTree("exceptionstype", "distinct category", "类型列表", "typename,typeid", "where category='", "typeid");
        }
        //异常录入
        private void btnExInput_Click(object sender, EventArgs e)
        {
            ExInfoFrm exinfo = new ExInfoFrm();
            exinfo.Text = "添加异常信息";
            exinfo.ShowDialog();
        }
        //异常信息地图显示
        private void tsmiExinfoMapShow_Click(object sender, EventArgs e)
        {
            mapShowfrm mapshow = new mapShowfrm();
            mapshow.ShowDialog();
            mapshow.initializeFrm(_exceptInfoID);
            //mapshow.ShowDialog();
        }
        //异常信息添加
        private void tsmiExinfoAdd_Click(object sender, EventArgs e)
        {
            ExInfoFrm exinfo = new ExInfoFrm();
            exinfo.Text = "添加异常信息";
            exinfo.ShowDialog();

        }
        //异常信息修改
        private void tsmiExinfoChange_Click(object sender, EventArgs e)
        {
            ExInfoFrm exinfo = new ExInfoFrm();
            exinfo.Text = "修改异常信息";
            exinfo.ID = ID_m;
            exinfo.ShowDialog();
        }
        //异常查询
        private void btnQueryInfo_Click(object sender, EventArgs e)
        {
            mapShowfrm mapshow = new mapShowfrm();
            mapshow.initializeFrm(_exceptInfoID);
            mapshow.ShowDialog();
        }

        //左键数据刷新
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Node.Nodes.Count == 0)
            {
                switch (UIType)
                {
                    case 0:
                        //string columnStr1 = "userid as 用户ID,username as 用户名,province as 省份,phone as 电话,remarks as 备注 ";
                        TreeNodeMouseClick(e.Node, "userinfo", "*", "where userid=", "userid", "*");
                        //TreeNodeMouseClick(e.Node, "userinfo", columnStr1, "where userid=", "用户ID", "*");
                        break;
                    case 1:
                        //string columnStr2 = "projectid as 项目ID,projectname as 项目名称,province as 省份,remarks as 备注 ";
                        //TreeNodeMouseClick(e.Node, "projectinfo", columnStr2, "where projectid=", "项目ID", "*");
                        TreeNodeMouseClick(e.Node, "projectinfo", "*", "where projectid=", "projectid", "*");
                        break;
                    case 2:
                        //string columnStr3 = "typeid as 类型ID,typename as 类型名称,category as 类别,remarks as 备注";
                        //TreeNodeMouseClick(e.Node, "exceptionstype", columnStr3, "where typeid=", "类型ID", "*");
                        TreeNodeMouseClick(e.Node, "exceptionstype", "*", "where typeid=", "typeid", "*");
                        break;
                    default:
                        break;
                }
            }
        }
        //右键菜单设置及数据刷新
        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point clickPoint = new Point(e.X, e.Y);
                TreeNode curNode = treeView1.GetNodeAt(clickPoint);
                switch (UIType)
                {
                    case 0:                        
                        if (curNode != null && curNode.Nodes.Count == 0)
                        {
                            treeView1.SelectedNode = curNode;
                            curNode.ContextMenuStrip = cmsUser;
                            id = (int)curNode.Tag;
                            //string columnStr1 = "userid as 用户ID,username as 用户名,province as 省份,remarks as 备注 ";
                            TreeNodeMouseClick(curNode, "userinfo", "*", "where userid=", "userID", "*");
                            //TreeNodeMouseClick(curNode, "userinfo", columnStr1, "where userid=", "用户ID", "*");
                        }
                        else treeView1.ContextMenuStrip = cmstUserAdd;
                        break;
                    case 1:
                        if (curNode != null && curNode.Nodes.Count == 0)
                        {
                            treeView1.SelectedNode = curNode;
                            curNode.ContextMenuStrip = cmstProject;
                            id = (int)curNode.Tag;
                            //string columnStr2 = "projectid as 项目ID,projectname as 项目名称,province as 省份,remarks as 备注 ";
                            //TreeNodeMouseClick(curNode, "projectinfo", columnStr2, "where projectid=", "项目ID", "*");
                            TreeNodeMouseClick(curNode, "projectinfo", "*", "where projectid=", "projectID", "*");
                        }
                        else treeView1.ContextMenuStrip = cmstProjectAdd;
                        break;
                    case 2:
                        if (curNode != null && curNode.Nodes.Count == 0)
                        {
                            treeView1.SelectedNode = curNode;
                            curNode.ContextMenuStrip = cmstType;
                            id = (int)curNode.Tag;
                            //string columnStr3 = "typeid as 类型ID,typename as 类型名称,category as 类别,remarks as 备注";
                            //TreeNodeMouseClick(curNode, "exceptionstype", columnStr3, "where typeid=", "类型ID", "*");
                            TreeNodeMouseClick(curNode, "exceptionstype", "*", "where typeid=", "typeID", "*");

                        }
                        else treeView1.ContextMenuStrip = cmstTypeAdd;
                        break;
                    default:
                        break;
                }
            }
        }
        //listview右键菜单设置
        private void listView2_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right )//&& listView2.SelectedItems.Count == 1)
            {
                ListViewItem lvi = listView2.GetItemAt(e.X, e.Y);
                if (lvi != null)
                {
                    listView2.ContextMenuStrip = cmstExinfo;
                    ID_m = Convert.ToInt32(lvi.Text);
                    _exceptInfoID = lvi.SubItems[4].Text;
                }
                else
                {
                    listView2.ContextMenuStrip = cmstExinfoAdd;
                }
            }            
        }
        //刷新treeview
        private void RefreshTree(string tableName, string columnStr1, string nodeStr, string columnStr2,string whereStr,string idType)
        {
            treeView1.Nodes.Clear();
            DataTable provinceTable = (DataTable)dataDisposes.Select(tableName, columnStr1, "");
            ArrayList arrProvince = new ArrayList();
            for (int i = 0; i < provinceTable.Rows.Count; i++)
            {
                arrProvince.Add(provinceTable.Rows[i][0].ToString());
            }
            TreeNode node0 = new TreeNode();
            node0.Text = nodeStr;

            for (int i = 0; i < arrProvince.Count; i++)
            {
                TreeNode node1 = new TreeNode();
                node1.Text = arrProvince[i].ToString();
                DataTable userNameTable = (DataTable)dataDisposes.Select(tableName, columnStr2, whereStr + node1.Text + "'");
                for (int j = 0; j < userNameTable.Rows.Count; j++)
                {
                    TreeNode node2 = new TreeNode();
                    node2.Text = userNameTable.Rows[j][0].ToString();
                    node2.Tag = userNameTable.Rows[j][idType];
                    node1.Nodes.Add(node2);
                }
                node0.Nodes.Add(node1);
            }
            treeView1.Nodes.Add(node0);
            treeView1.ExpandAll();
        }
        //treeNode 单击事件
        private void TreeNodeMouseClick(TreeNode curNode, string tableName, string columnStr1, string whereStr, string ID, string columnStr2)
        {
            //用户信息填充
            id = (int)curNode.Tag;
            //listView1.Clear();
            listView1.Items.Clear();
            DataTable userInfoTable = (DataTable)dataDisposes.Select(tableName, columnStr1, whereStr + curNode.Tag);            
            ListViewItem lisitem = new ListViewItem(userInfoTable.Rows[0][ID].ToString(), 0);
            for (int i = 1; i < userInfoTable.Columns.Count; i++)
            {
                lisitem.SubItems.Add(userInfoTable.Rows[0][i].ToString());
            }
            listView1.Items.Add(lisitem);

            //异常信息填充
            listView2.Items.Clear();
            List<ExceptionsInfo> list = ExceptionsInfoManage.FindAll(whereStr+curNode.Tag);
            foreach (ExceptionsInfo ex in list)
            {
                ListViewItem lvi = new ListViewItem(ex.ID.ToString());
                lvi.SubItems.Add(ex.UserID);
                lvi.SubItems.Add(ex.ProjectName.ToString());
                lvi.SubItems.Add(ex.TypeID.ToString());
                lvi.SubItems.Add(ex.ExcepitionID);
                lvi.SubItems.Add(ex.ExcepitionName);
                lvi.SubItems.Add(ex.ExcepitionDescri);
                lvi.SubItems.Add(ex.Solution);
                lvi.SubItems.Add(ex.Remarks);
                listView2.Items.Add(lvi);
            }
        }
        
    }
}
