namespace ExceptionsCollectionSystem
{
    partial class mapShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mapShow));
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbo = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtKeywork = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnResultArr = new System.Windows.Forms.Button();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.picShowresult = new System.Windows.Forms.PictureBox();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.pnlTurnPage = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.turnPaper1 = new ExceptionsCollectionSystem.Component.turnPaper();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowresult)).BeginInit();
            this.pnlResult.SuspendLayout();
            this.pnlTurnPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(352, 194);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 8;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(0, 0);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(739, 416);
            this.axMapControl1.TabIndex = 9;
            // 
            // pnlTitle
            // 
            this.pnlTitle.AutoScroll = true;
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.cmbo);
            this.pnlTitle.Controls.Add(this.btnQuery);
            this.pnlTitle.Controls.Add(this.txtKeywork);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(964, 41);
            this.pnlTitle.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(164, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "查找类型:";
            // 
            // cmbo
            // 
            this.cmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo.Font = new System.Drawing.Font("宋体", 13F);
            this.cmbo.FormattingEnabled = true;
            this.cmbo.Items.AddRange(new object[] {
            "ID",
            "用户名",
            "项目名称",
            "异常类型",
            "异常ID",
            "异常名称"});
            this.cmbo.Location = new System.Drawing.Point(250, 8);
            this.cmbo.Name = "cmbo";
            this.cmbo.Size = new System.Drawing.Size(121, 25);
            this.cmbo.TabIndex = 4;
            this.cmbo.TextChanged += new System.EventHandler(this.cmbo_TextChanged);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnQuery.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(834, 6);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 29);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtKeywork
            // 
            this.txtKeywork.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtKeywork.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKeywork.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKeywork.Location = new System.Drawing.Point(426, 6);
            this.txtKeywork.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txtKeywork.Name = "txtKeywork";
            this.txtKeywork.Size = new System.Drawing.Size(402, 30);
            this.txtKeywork.TabIndex = 2;
            this.txtKeywork.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeywork_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnResultArr);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(225, 416);
            this.flowLayoutPanel1.TabIndex = 12;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnResultArr
            // 
            this.btnResultArr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResultArr.FlatAppearance.BorderSize = 0;
            this.btnResultArr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultArr.Location = new System.Drawing.Point(0, 2);
            this.btnResultArr.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnResultArr.Name = "btnResultArr";
            this.btnResultArr.Size = new System.Drawing.Size(207, 62);
            this.btnResultArr.TabIndex = 4;
            this.btnResultArr.Text = "ID：12，xxx异常名称\r\n标签：XXX项目，XX用户\r\n异常信息：TLW-11-1，地图异常类型\r\n问题描述：xxxxxxxxxxxxxxx";
            this.btnResultArr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResultArr.UseVisualStyleBackColor = true;
            this.btnResultArr.Click += new System.EventHandler(this.btnResultArr_Click);
            // 
            // pnlMap
            // 
            this.pnlMap.Controls.Add(this.picShowresult);
            this.pnlMap.Controls.Add(this.axMapControl1);
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(225, 41);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(739, 416);
            this.pnlMap.TabIndex = 13;
            // 
            // picShowresult
            // 
            this.picShowresult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picShowresult.Image = ((System.Drawing.Image)(resources.GetObject("picShowresult.Image")));
            this.picShowresult.Location = new System.Drawing.Point(1, 164);
            this.picShowresult.Name = "picShowresult";
            this.picShowresult.Size = new System.Drawing.Size(14, 46);
            this.picShowresult.TabIndex = 12;
            this.picShowresult.TabStop = false;
            this.picShowresult.Click += new System.EventHandler(this.picShowresult_Click);
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.flowLayoutPanel1);
            this.pnlResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlResult.Location = new System.Drawing.Point(0, 41);
            this.pnlResult.Margin = new System.Windows.Forms.Padding(0);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(225, 416);
            this.pnlResult.TabIndex = 13;
            // 
            // pnlTurnPage
            // 
            this.pnlTurnPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTurnPage.Controls.Add(this.turnPaper1);
            this.pnlTurnPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTurnPage.Location = new System.Drawing.Point(0, 457);
            this.pnlTurnPage.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTurnPage.Name = "pnlTurnPage";
            this.pnlTurnPage.Size = new System.Drawing.Size(964, 28);
            this.pnlTurnPage.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "ID：12，xxx异常名称\r\n标签：XXX项目，XX用户\r\n异常信息：TLW-11-1，地图异常类型\r\n问题描述：xxxxxxxxxxxxxxx";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 134);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 62);
            this.button2.TabIndex = 6;
            this.button2.Text = "ID：12，xxx异常名称\r\n标签：XXX项目，XX用户\r\n异常信息：TLW-11-1，地图异常类型\r\n问题描述：xxxxxxxxxxxxxxx";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 200);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 62);
            this.button3.TabIndex = 7;
            this.button3.Text = "ID：12，xxx异常名称\r\n标签：XXX项目，XX用户\r\n异常信息：TLW-11-1，地图异常类型\r\n问题描述：xxxxxxxxxxxxxxx";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 266);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 62);
            this.button4.TabIndex = 8;
            this.button4.Text = "ID：12，xxx异常名称\r\n标签：XXX项目，XX用户\r\n异常信息：TLW-11-1，地图异常类型\r\n问题描述：xxxxxxxxxxxxxxx";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(0, 332);
            this.button5.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 62);
            this.button5.TabIndex = 9;
            this.button5.Text = "ID：12，xxx异常名称\r\n标签：XXX项目，XX用户\r\n异常信息：TLW-11-1，地图异常类型\r\n问题描述：xxxxxxxxxxxxxxx";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(0, 398);
            this.button6.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(207, 62);
            this.button6.TabIndex = 10;
            this.button6.Text = "ID：12，xxx异常名称\r\n标签：XXX项目，XX用户\r\n异常信息：TLW-11-1，地图异常类型\r\n问题描述：xxxxxxxxxxxxxxx";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(0, 464);
            this.button7.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(207, 62);
            this.button7.TabIndex = 11;
            this.button7.Text = "ID：12，xxx异常名称\r\n标签：XXX项目，XX用户\r\n异常信息：TLW-11-1，地图异常类型\r\n问题描述：xxxxxxxxxxxxxxx";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(0, 530);
            this.button8.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(207, 62);
            this.button8.TabIndex = 12;
            this.button8.Text = "ID：12，xxx异常名称\r\n标签：XXX项目，XX用户\r\n异常信息：TLW-11-1，地图异常类型\r\n问题描述：xxxxxxxxxxxxxxx";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // turnPaper1
            // 
            this.turnPaper1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.turnPaper1.Location = new System.Drawing.Point(0, 0);
            this.turnPaper1.Name = "turnPaper1";
            this.turnPaper1.Size = new System.Drawing.Size(962, 26);
            this.turnPaper1.TabIndex = 0;
            // 
            // mapShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 485);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.pnlTurnPage);
            this.Name = "mapShow";
            this.Text = "地图查询";
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShowresult)).EndInit();
            this.pnlResult.ResumeLayout(false);
            this.pnlTurnPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtKeywork;
        private System.Windows.Forms.PictureBox picShowresult;
        private System.Windows.Forms.ComboBox cmbo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResultArr;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Panel pnlTurnPage;
        private Component.turnPaper turnPaper1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}