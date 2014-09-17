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

namespace ExceptionsCollectionSystem
{
    public partial class mainfrm : Form
    {
        public mainfrm()
        {
            InitializeComponent();
        }

        private DataDisposes dataDisposes = new DataDisposes();//全局数据库链接
        private int id;

        public int ID_m
        {
            get { return id; }
            set { id = value; }
        }

        //用户管理
        private void btnUsermanager_Click(object sender, EventArgs e)
        {
            listView1.ContextMenuStrip = cmsUser;
            treeView1.Nodes.Clear();            
            DataTable provinceTable = (DataTable)dataDisposes.Select("userinfo", "province", "");
            ArrayList arrProvince = new ArrayList();
            for (int i = 0; i < provinceTable.Rows.Count; i++)
            {
                if (arrProvince.Contains(provinceTable.Rows[i][0].ToString()) == false)
                {
                    arrProvince.Add(provinceTable.Rows[i][0].ToString());
                }
            }
            TreeNode node0 = new TreeNode();
            node0.Text = "用户列表";

            for (int i = 0; i < arrProvince.Count; i++)
            {
                TreeNode node1 = new TreeNode();
                node1.Text = arrProvince[i].ToString();
                DataTable userNameTable = (DataTable)dataDisposes.Select("userinfo", "username ,userid", "where province='" + node1.Text + "'");
                for (int j = 0; j < userNameTable.Rows.Count; j++)
                {
                    TreeNode node2 = new TreeNode();
                    node2.Text = userNameTable.Rows[j][0].ToString();
                    node2.Tag = userNameTable.Rows[j]["userid"];
                    node1.Nodes.Add(node2);
                }
                node0.Nodes.Add(node1);
            }
            treeView1.Nodes.Add(node0);
            treeView1.ExpandAll();
        }

        //增加用户
        private void tsmtUserCreate_Click(object sender, EventArgs e)
        {
            userFrom puserFrom = new userFrom();
            puserFrom.Text = "添加用户";
            puserFrom.ShowDialog();

        }
        //修改用户
        private void tsmtUserChange_Click(object sender, EventArgs e)
        {
            userFrom puserFrom = new userFrom();
            puserFrom.Text="修改用户";
            puserFrom.ID = ID_m;
            puserFrom.ShowDialog();
        }
        //删除用户
        private void tsmtUserDel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("是否删除此用户？", "警告", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            dataDisposes.Delete("userinfo", "where userid=" + id);
        }
        //项目管理
        private void btnProjectManager_Click(object sender, EventArgs e)
        {
            treeView1.ContextMenuStrip = cmstProject;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            info info = new info();
            info.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            treeView1.ContextMenuStrip = cmstType;            
        }

        private void tsmiProAdd_Click(object sender, EventArgs e)
        {
            projectfrm pro = new projectfrm();
            pro.ShowDialog();
        }

        private void tsmiTypeAdd_Click(object sender, EventArgs e)
        {
            typefrm type = new typefrm();
            type.ShowDialog();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Node.Nodes.Count == 0)
            {
                //用户信息填充
                id = (int)e.Node.Tag;
                listView1.Clear();
                listView1.Items.Clear();
                DataTable userInfoTable = (DataTable)dataDisposes.Select("userinfo", "userid as 用户ID,username as 用户名,province as 省份,remarks as 备注 ","where userid=" + e.Node.Tag );  
                foreach (DataColumn pColumn in userInfoTable.Columns)
                {
                    listView1.Columns.Add(pColumn.ColumnName);
                }
                ListViewItem lisitem = new ListViewItem(userInfoTable.Rows[0]["用户ID"].ToString(), 0);
                
                for (int i = 1; i < userInfoTable.Columns.Count; i++)
                {
                    lisitem.SubItems.Add(userInfoTable.Rows[0][i].ToString());
                }
                listView1.Items.Add(lisitem);

                //异常信息填充
                listView2.Clear();
                listView2.Items.Clear();
                //DataTable IDTable = (DataTable)dataDisposes.Select("exceptionsinfo", "xmid,lxid", "where userid=" + e.Node.Tag );
                //int xmID = (int)IDTable.Rows[0]["xmid"];
                //int lxID = (int)IDTable.Rows[0]["lxid"];
                //string str=@"select";
                //DataTable exceptionsInfoTable = (DataTable)dataDisposes.SelectStr(str);
                DataTable exceptionsInfoTable = (DataTable)dataDisposes.Select("exceptionsinfo", "*", "where userid=" + e.Node.Tag);
                
                foreach (DataColumn pColumn in exceptionsInfoTable.Columns)
                {
                    listView2.Columns.Add(pColumn.Caption);
                }                
                for (int i = 0; i < exceptionsInfoTable.Rows.Count; i++)
                {
                    ListViewItem lisitemFill = new ListViewItem(exceptionsInfoTable.Rows[i]["id"].ToString(), 0);
                    for (int j = 1; j < exceptionsInfoTable.Columns.Count; j++)
                    {
                        lisitemFill.SubItems.Add(exceptionsInfoTable.Rows[i][j].ToString());
                    }
                    listView2.Items.Add(lisitemFill);
                }
            }
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point clickPoint = new Point(e.X, e.Y);
                TreeNode curNode = treeView1.GetNodeAt(clickPoint);
                if (curNode != null && curNode.Nodes.Count == 0)
                {
                    treeView1.SelectedNode = curNode;                    
                    curNode.ContextMenuStrip = cmsUser;
                    id = (int)curNode.Tag;
                }
                else
                {
                    treeView1.ContextMenuStrip=cmstUserdel;
                }
            }
        }
    }
}
