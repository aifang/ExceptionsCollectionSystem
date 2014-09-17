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
            this.btnTypeManager = new System.Windows.Forms.ToolStripButton();
            this.btnExInput = new System.Windows.Forms.ToolStripButton();
            this.btnQueryInfo = new System.Windows.Forms.ToolStripButton();
            this.cmsUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmtUserCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmtUserChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmtUserDel = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cmstProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiProAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProChange = new System.Windows.Forms.ToolStripMenuItem();
            this.cmstType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiTypeAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTypeChange = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmstExinfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiExinfoMapShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExinfoAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExinfoChange = new System.Windows.Forms.ToolStripMenuItem();
            this.cmstUserAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUserAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmstProjectAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmstTypeAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiTypeadd0 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmstExinfoAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiExAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.cmsUser.SuspendLayout();
            this.cmstProject.SuspendLayout();
            this.cmstType.SuspendLayout();
            this.cmstExinfo.SuspendLayout();
            this.cmstUserAdd.SuspendLayout();
            this.cmstProjectAdd.SuspendLayout();
            this.cmstTypeAdd.SuspendLayout();
            this.cmstExinfoAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsermanager,
            this.btnProjectManager,
            this.btnTypeManager,
            this.btnExInput,
            this.btnQueryInfo});
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
            // btnTypeManager
            // 
            this.btnTypeManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTypeManager.Image = ((System.Drawing.Image)(resources.GetObject("btnTypeManager.Image")));
            this.btnTypeManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTypeManager.Name = "btnTypeManager";
            this.btnTypeManager.Size = new System.Drawing.Size(60, 22);
            this.btnTypeManager.Text = "类型管理";
            this.btnTypeManager.Click += new System.EventHandler(this.btnTypeManager_Click);
            // 
            // btnExInput
            // 
            this.btnExInput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExInput.Image = ((System.Drawing.Image)(resources.GetObject("btnExInput.Image")));
            this.btnExInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExInput.Name = "btnExInput";
            this.btnExInput.Size = new System.Drawing.Size(60, 22);
            this.btnExInput.Text = "异常录入";
            this.btnExInput.Click += new System.EventHandler(this.btnExInput_Click);
            // 
            // btnQueryInfo
            // 
            this.btnQueryInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQueryInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnQueryInfo.Image")));
            this.btnQueryInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQueryInfo.Name = "btnQueryInfo";
            this.btnQueryInfo.Size = new System.Drawing.Size(60, 22);
            this.btnQueryInfo.Text = "信息查询";
            this.btnQueryInfo.Click += new System.EventHandler(this.btnQueryInfo_Click);
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
            this.listView1.Location = new System.Drawing.Point(174, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1006, 110);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // cmstProject
            // 
            this.cmstProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProAdd,
            this.tsmiProChange});
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
            // tsmiProChange
            // 
            this.tsmiProChange.Name = "tsmiProChange";
            this.tsmiProChange.Size = new System.Drawing.Size(124, 22);
            this.tsmiProChange.Text = "修改项目";
            this.tsmiProChange.Click += new System.EventHandler(this.tsmiProChange_Click);
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
            this.tsmiTypeAdd.Text = "添加类型";
            this.tsmiTypeAdd.Click += new System.EventHandler(this.tsmiTypeAdd_Click);
            // 
            // tsmiTypeChange
            // 
            this.tsmiTypeChange.Name = "tsmiTypeChange";
            this.tsmiTypeChange.Size = new System.Drawing.Size(124, 22);
            this.tsmiTypeChange.Text = "修改类型";
            this.tsmiTypeChange.Click += new System.EventHandler(this.tsmiTypeChange_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 25);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(174, 458);
            this.treeView1.TabIndex = 6;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(174, 135);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1006, 348);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "用户";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "所属项目";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "异常类型";
            this.columnHeader4.Width = 74;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "异常编号";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "异常名称";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "异常描述";
            this.columnHeader7.Width = 210;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "解决方案";
            this.columnHeader8.Width = 196;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "备注";
            this.columnHeader9.Width = 116;
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
            // tsmiExinfoMapShow
            // 
            this.tsmiExinfoMapShow.Name = "tsmiExinfoMapShow";
            this.tsmiExinfoMapShow.Size = new System.Drawing.Size(124, 22);
            this.tsmiExinfoMapShow.Text = "地图查看";
            this.tsmiExinfoMapShow.Click += new System.EventHandler(this.tsmiExinfoMapShow_Click);
            // 
            // tsmiExinfoAdd
            // 
            this.tsmiExinfoAdd.Name = "tsmiExinfoAdd";
            this.tsmiExinfoAdd.Size = new System.Drawing.Size(124, 22);
            this.tsmiExinfoAdd.Text = "添加";
            this.tsmiExinfoAdd.Click += new System.EventHandler(this.tsmiExinfoAdd_Click);
            // 
            // tsmiExinfoChange
            // 
            this.tsmiExinfoChange.Name = "tsmiExinfoChange";
            this.tsmiExinfoChange.Size = new System.Drawing.Size(124, 22);
            this.tsmiExinfoChange.Text = "修改";
            this.tsmiExinfoChange.Click += new System.EventHandler(this.tsmiExinfoChange_Click);
            // 
            // cmstUserAdd
            // 
            this.cmstUserAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUserAdd});
            this.cmstUserAdd.Name = "cmsUser";
            this.cmstUserAdd.Size = new System.Drawing.Size(125, 26);
            // 
            // tsmiUserAdd
            // 
            this.tsmiUserAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiUserAdd.Name = "tsmiUserAdd";
            this.tsmiUserAdd.Size = new System.Drawing.Size(124, 22);
            this.tsmiUserAdd.Text = "添加用户";
            this.tsmiUserAdd.Click += new System.EventHandler(this.tsmtUserCreate_Click);
            // 
            // cmstProjectAdd
            // 
            this.cmstProjectAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd});
            this.cmstProjectAdd.Name = "cmsUser";
            this.cmstProjectAdd.Size = new System.Drawing.Size(125, 26);
            this.cmstProjectAdd.Click += new System.EventHandler(this.tsmiProAdd_Click);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(124, 22);
            this.tsmiAdd.Text = "添加项目";
            // 
            // cmstTypeAdd
            // 
            this.cmstTypeAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTypeadd0});
            this.cmstTypeAdd.Name = "cmsUser";
            this.cmstTypeAdd.Size = new System.Drawing.Size(125, 26);
            // 
            // tsmiTypeadd0
            // 
            this.tsmiTypeadd0.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiTypeadd0.Name = "tsmiTypeadd0";
            this.tsmiTypeadd0.Size = new System.Drawing.Size(124, 22);
            this.tsmiTypeadd0.Text = "添加类型";
            // 
            // cmstExinfoAdd
            // 
            this.cmstExinfoAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExAdd});
            this.cmstExinfoAdd.Name = "cmstExinfo";
            this.cmstExinfoAdd.Size = new System.Drawing.Size(101, 26);
            // 
            // tsmiExAdd
            // 
            this.tsmiExAdd.Name = "tsmiExAdd";
            this.tsmiExAdd.Size = new System.Drawing.Size(100, 22);
            this.tsmiExAdd.Text = "增加";
            this.tsmiExAdd.Click += new System.EventHandler(this.tsmiExinfoAdd_Click);
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
            this.Text = "异常收集系统";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.cmsUser.ResumeLayout(false);
            this.cmstProject.ResumeLayout(false);
            this.cmstType.ResumeLayout(false);
            this.cmstExinfo.ResumeLayout(false);
            this.cmstUserAdd.ResumeLayout(false);
            this.cmstProjectAdd.ResumeLayout(false);
            this.cmstTypeAdd.ResumeLayout(false);
            this.cmstExinfoAdd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnUsermanager;
        private System.Windows.Forms.ToolStripButton btnProjectManager;
        private System.Windows.Forms.ToolStripButton btnTypeManager;
        private System.Windows.Forms.ToolStripButton btnExInput;
        private System.Windows.Forms.ToolStripButton btnQueryInfo;
        private System.Windows.Forms.ContextMenuStrip cmsUser;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem tsmtUserCreate;
        private System.Windows.Forms.ToolStripMenuItem tsmtUserChange;
        private System.Windows.Forms.ToolStripMenuItem tsmtUserDel;
        private System.Windows.Forms.ContextMenuStrip cmstProject;
        private System.Windows.Forms.ToolStripMenuItem tsmiProAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiProChange;
        private System.Windows.Forms.ContextMenuStrip cmstType;
        private System.Windows.Forms.ToolStripMenuItem tsmiTypeAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiTypeChange;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ContextMenuStrip cmstExinfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiExinfoMapShow;
        private System.Windows.Forms.ToolStripMenuItem tsmiExinfoAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiExinfoChange;
        private System.Windows.Forms.ContextMenuStrip cmstUserAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserAdd;
        private System.Windows.Forms.ContextMenuStrip cmstProjectAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ContextMenuStrip cmstTypeAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiTypeadd0;
        private System.Windows.Forms.ContextMenuStrip cmstExinfoAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiExAdd;
    }
}