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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.picShowresult = new System.Windows.Forms.PictureBox();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.pnlTurnPage = new System.Windows.Forms.Panel();
            this.btnfwPage = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnBackPage = new System.Windows.Forms.Button();
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
            this.axMapControl1.Size = new System.Drawing.Size(739, 444);
            this.axMapControl1.TabIndex = 9;
            // 
            // pnlTitle
            // 
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
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnResultArr);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(225, 444);
            this.flowLayoutPanel1.TabIndex = 12;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnResultArr
            // 
            this.btnResultArr.Location = new System.Drawing.Point(0, 2);
            this.btnResultArr.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnResultArr.Name = "btnResultArr";
            this.btnResultArr.Size = new System.Drawing.Size(206, 62);
            this.btnResultArr.TabIndex = 4;
            this.btnResultArr.Text = "ID：12，xxx异常名称\r\n标签：XXX项目，XX用户\r\n异常信息：TLW-11-1，地图异常类型\r\n问题描述：xxxxxxxxxxxxxxx";
            this.btnResultArr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResultArr.UseVisualStyleBackColor = true;
            this.btnResultArr.Click += new System.EventHandler(this.btnResultArr_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "ID：12，xxx异常名称\r\n标签：XXX项目，XX用户\r\n异常信息：TLW-11-1，地图异常类型\r\n问题描述：xxxxxxxxxxxxxxx";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnResultArr_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 134);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 62);
            this.button3.TabIndex = 4;
            this.button3.Text = "ID：12，xxx异常名称\r\n标签：XXX项目，XX用户\r\n异常信息：TLW-11-1，地图异常类型\r\n问题描述：xxxxxxxxxxxxxxx";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnResultArr_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 200);
            this.button5.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(206, 62);
            this.button5.TabIndex = 4;
            this.button5.Text = "ID：12，xxx异常名称\r\n标签：XXX项目，XX用户\r\n异常信息：TLW-11-1，地图异常类型\r\n问题描述：xxxxxxxxxxxxxxx";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnResultArr_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 266);
            this.button6.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(206, 62);
            this.button6.TabIndex = 4;
            this.button6.Text = "ID：12，xxx异常名称\r\n标签：XXX项目，XX用户\r\n异常信息：TLW-11-1，地图异常类型\r\n问题描述：xxxxxxxxxxxxxxx";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnResultArr_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 332);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 62);
            this.button4.TabIndex = 4;
            this.button4.Text = "ID：12，xxx异常名称\r\n标签：XXX项目，XX用户\r\n异常信息：TLW-11-1，地图异常类型\r\n问题描述：xxxxxxxxxxxxxxx";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnResultArr_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 398);
            this.button7.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(206, 62);
            this.button7.TabIndex = 4;
            this.button7.Text = "ID：12，xxx异常名称\r\n标签：XXX项目，XX用户\r\n异常信息：TLW-11-1，地图异常类型\r\n问题描述：xxxxxxxxxxxxxxx";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnResultArr_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 464);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "ID：12，xxx异常名称\r\n标签：XXX项目，XX用户\r\n异常信息：TLW-11-1，地图异常类型\r\n问题描述：xxxxxxxxxxxxxxx";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnResultArr_Click);
            // 
            // pnlMap
            // 
            this.pnlMap.Controls.Add(this.picShowresult);
            this.pnlMap.Controls.Add(this.axMapControl1);
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(225, 41);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(739, 444);
            this.pnlMap.TabIndex = 13;
            // 
            // picShowresult
            // 
            this.picShowresult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picShowresult.Image = ((System.Drawing.Image)(resources.GetObject("picShowresult.Image")));
            this.picShowresult.Location = new System.Drawing.Point(1, 178);
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
            this.pnlResult.Size = new System.Drawing.Size(225, 444);
            this.pnlResult.TabIndex = 13;
            // 
            // pnlTurnPage
            // 
            this.pnlTurnPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTurnPage.Controls.Add(this.btnfwPage);
            this.pnlTurnPage.Controls.Add(this.button13);
            this.pnlTurnPage.Controls.Add(this.button12);
            this.pnlTurnPage.Controls.Add(this.button11);
            this.pnlTurnPage.Controls.Add(this.button10);
            this.pnlTurnPage.Controls.Add(this.btnBackPage);
            this.pnlTurnPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTurnPage.Location = new System.Drawing.Point(225, 457);
            this.pnlTurnPage.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTurnPage.Name = "pnlTurnPage";
            this.pnlTurnPage.Size = new System.Drawing.Size(739, 28);
            this.pnlTurnPage.TabIndex = 15;
            // 
            // btnfwPage
            // 
            this.btnfwPage.Location = new System.Drawing.Point(160, 1);
            this.btnfwPage.Name = "btnfwPage";
            this.btnfwPage.Size = new System.Drawing.Size(37, 23);
            this.btnfwPage.TabIndex = 0;
            this.btnfwPage.Text = "->";
            this.btnfwPage.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(130, 1);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(22, 23);
            this.button13.TabIndex = 0;
            this.button13.Text = "4";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(102, 1);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(22, 23);
            this.button12.TabIndex = 0;
            this.button12.Text = "3";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(74, 1);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(22, 23);
            this.button11.TabIndex = 0;
            this.button11.Text = "2";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(46, 1);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(22, 23);
            this.button10.TabIndex = 0;
            this.button10.Text = "1";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // btnBackPage
            // 
            this.btnBackPage.Location = new System.Drawing.Point(2, 1);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(38, 23);
            this.btnBackPage.TabIndex = 0;
            this.btnBackPage.Text = "<-";
            this.btnBackPage.UseVisualStyleBackColor = true;
            // 
            // mapShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 485);
            this.Controls.Add(this.pnlTurnPage);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.axLicenseControl1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel pnlTurnPage;
        private System.Windows.Forms.Button btnfwPage;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnBackPage;
    }
}