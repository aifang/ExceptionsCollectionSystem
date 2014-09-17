namespace ExceptionsCollectionSystem
{
    partial class mainfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainfrm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnUsermanager = new System.Windows.Forms.ToolStripButton();
            this.btnProjectManager = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.cmsUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmtUserCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmtUserChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmtUserDel = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cmstProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiProAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChange = new System.Windows.Forms.ToolStripMenuItem();
            this.cmstType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiTypeAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTypeChange = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.cmstExinfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiExinfoAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExinfoChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExinfoMapShow = new System.Windows.Forms.ToolStripMenuItem();
            this.cmstUserdel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUserAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.cmsUser.SuspendLayout();
            this.cmstProject.SuspendLayout();
            this.cmstType.SuspendLayout();
            this.cmstExinfo.SuspendLayout();
            this.cmstUserdel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsermanager,
            this.btnProjectManager,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1180, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnUsermanager
            // 
            this.btnUsermanager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUsermanager.Image = ((System.Drawing.Image)(resources.GetObject("btnUsermanager.Image")));
            this.btnUsermanager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsermanager.Name = "btnUsermanager";
            this.btnUsermanager.Size = new System.Drawing.Size(60, 22);
            this.btnUsermanager.Text = "用户管理";
            this.btnUsermanager.Click += new System.EventHandler(this.btnUsermanager_Click);
            // 
            // btnProjectManager
            // 
            this.btnProjectManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnProjectManager.Image = ((System.Drawing.Image)(resources.GetObject("btnProjectManager.Image")));
            this.btnProjectManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProjectManager.Name = "btnProjectManager";
            this.btnProjectManager.Size = new System.Drawing.Size(60, 22);
            this.btnProjectManager.Text = "项目管理";
            this.btnProjectManager.Click += new System.EventHandler(this.btnProjectManager_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton3.Text = "类型管理";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton4.Text = "异常录入";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton5.Text = "信息查询";
            // 
            // cmsUser
            // 
            this.cmsUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmtUserCreate,
            this.tsmtUserChange,
            this.tsmtUserDel});
            this.cmsUser.Name = "cmsUser";
            this.cmsUser.Size = new System.Drawing.Size(125, 70);
            // 
            // tsmtUserCreate
            // 
            this.tsmtUserCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmtUserCreate.Name = "tsmtUserCreate";
            this.tsmtUserCreate.Size = new System.Drawing.Size(124, 22);
            this.tsmtUserCreate.Text = "添加用户";
            this.tsmtUserCreate.Click += new System.EventHandler(this.tsmtUserCreate_Click);
            // 
            // tsmtUserChange
            // 
            this.tsmtUserChange.Name = "tsmtUserChange";
            this.tsmtUserChange.Size = new System.Drawing.Size(124, 22);
            this.tsmtUserChange.Text = "修改用户";
            this.tsmtUserChange.Click += new System.EventHandler(this.tsmtUserChange_Click);
            // 
            // tsmtUserDel
            // 
            this.tsmtUserDel.Name = "tsmtUserDel";
            this.tsmtUserDel.Size = new System.Drawing.Size(124, 22);
            this.tsmtUserDel.Text = "删除用户";
            this.tsmtUserDel.Click += new System.EventHandler(this.tsmtUserDel_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(230, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(950, 115);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // cmstProject
            // 
            this.cmstProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProAdd,
            this.tsmiChange});
            this.cmstProject.Name = "cmsUser";
            this.cmstProject.Size = new System.Drawing.Size(125, 48);
            // 
            // tsmiProAdd
            // 
            this.tsmiProAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiProAdd.Name = "tsmiProAdd";
            this.tsmiProAdd.Size = new System.Drawing.Size(124, 22);
            this.tsmiProAdd.Text = "添加项目";
            this.tsmiProAdd.Click += new System.EventHandler(this.tsmiProAdd_Click);
            // 
            // tsmiChange
            // 
            this.tsmiChange.Name = "tsmiChange";
            this.tsmiChange.Size = new System.Drawing.Size(124, 22);
            this.tsmiChange.Text = "修改项目";
            // 
            // cmstType
            // 
            this.cmstType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTypeAdd,
            this.tsmiTypeChange});
            this.cmstType.Name = "cmsUser";
            this.cmstType.Size = new System.Drawing.Size(125, 48);
            // 
            // tsmiTypeAdd
            // 
            this.tsmiTypeAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiTypeAdd.Name = "tsmiTypeAdd";
            this.tsmiTypeAdd.Size = new System.Drawing.Size(124, 22);
            this.tsmiTypeAdd.Text = "添加";
            this.tsmiTypeAdd.Click += new System.EventHandler(this.tsmiTypeAdd_Click);
            // 
            // tsmiTypeChange
            // 
            this.tsmiTypeChange.Name = "tsmiTypeChange";
            this.tsmiTypeChange.Size = new System.Drawing.Size(124, 22);
            this.tsmiTypeChange.Text = "修改类型";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 25);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(230, 458);
            this.treeView1.TabIndex = 6;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // listView2
            // 
            this.listView2.ContextMenuStrip = this.cmstExinfo;
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(230, 140);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(950, 343);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // cmstExinfo
            // 
            this.cmstExinfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExinfoMapShow,
            this.tsmiExinfoAdd,
            this.tsmiExinfoChange});
            this.cmstExinfo.Name = "cmstExinfo";
            this.cmstExinfo.Size = new System.Drawing.Size(125, 70);
            // 
            // tsmiExinfoAdd
            // 
            this.tsmiExinfoAdd.Name = "tsmiExinfoAdd";
            this.tsmiExinfoAdd.Size = new System.Drawing.Size(124, 22);
            this.tsmiExinfoAdd.Text = "增加";
            // 
            // tsmiExinfoChange
            // 
            this.tsmiExinfoChange.Name = "tsmiExinfoChange";
            this.tsmiExinfoChange.Size = new System.Drawing.Size(124, 22);
            this.tsmiExinfoChange.Text = "修改";
            // 
            // tsmiExinfoMapShow
            // 
            this.tsmiExinfoMapShow.Name = "tsmiExinfoMapShow";
            this.tsmiExinfoMapShow.Size = new System.Drawing.Size(124, 22);
            this.tsmiExinfoMapShow.Text = "地图查看";
            // 
            // cmstUserdel
            // 
            this.cmstUserdel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUserAdd});
            this.cmstUserdel.Name = "cmsUser";
            this.cmstUserdel.Size = new System.Drawing.Size(125, 26);
            // 
            // tsmiUserAdd
            // 
            this.tsmiUserAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiUserAdd.Name = "tsmiUserAdd";
            this.tsmiUserAdd.Size = new System.Drawing.Size(124, 22);
            this.tsmiUserAdd.Text = "添加用户";
            this.tsmiUserAdd.Click += new System.EventHandler(this.tsmtUserCreate_Click);
            // 
            // mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 483);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "mainfrm";
            this.Text = "mainfrm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.cmsUser.ResumeLayout(false);
            this.cmstProject.ResumeLayout(false);
            this.cmstType.ResumeLayout(false);
            this.cmstExinfo.ResumeLayout(false);
            this.cmstUserdel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnUsermanager;
        private System.Windows.Forms.ToolStripButton btnProjectManager;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ContextMenuStrip cmsUser;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem tsmtUserCreate;
        private System.Windows.Forms.ToolStripMenuItem tsmtUserChange;
        private System.Windows.Forms.ToolStripMenuItem tsmtUserDel;
        private System.Windows.Forms.ContextMenuStrip cmstProject;
        private System.Windows.Forms.ToolStripMenuItem tsmiProAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiChange;
        private System.Windows.Forms.ContextMenuStrip cmstType;
        private System.Windows.Forms.ToolStripMenuItem tsmiTypeAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiTypeChange;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ContextMenuStrip cmstExinfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiExinfoMapShow;
        private System.Windows.Forms.ToolStripMenuItem tsmiExinfoAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiExinfoChange;
        private System.Windows.Forms.ContextMenuStrip cmstUserdel;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserAdd;
    }
}