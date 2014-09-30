namespace ExceptionsCollectionSystem
{
    partial class ExInfoFrm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.txtDescripe = new System.Windows.Forms.TextBox();
            this.txtExName = new System.Windows.Forms.TextBox();
            this.txtExID = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.cmbPro = new System.Windows.Forms.ComboBox();
            this.cmbExType = new System.Windows.Forms.ComboBox();
            this.btnUseradd = new System.Windows.Forms.Button();
            this.btnTypeadd = new System.Windows.Forms.Button();
            this.btnProadd = new System.Windows.Forms.Button();
            this.lblErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(281, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 31);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(150, 318);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 31);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(97, 277);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(274, 21);
            this.txtRemarks.TabIndex = 6;
            // 
            // txtSolution
            // 
            this.txtSolution.Location = new System.Drawing.Point(97, 246);
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.Size = new System.Drawing.Size(274, 21);
            this.txtSolution.TabIndex = 5;
            // 
            // txtDescripe
            // 
            this.txtDescripe.Location = new System.Drawing.Point(97, 215);
            this.txtDescripe.Name = "txtDescripe";
            this.txtDescripe.Size = new System.Drawing.Size(274, 21);
            this.txtDescripe.TabIndex = 4;
            // 
            // txtExName
            // 
            this.txtExName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtExName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtExName.Location = new System.Drawing.Point(97, 184);
            this.txtExName.Name = "txtExName";
            this.txtExName.Size = new System.Drawing.Size(274, 21);
            this.txtExName.TabIndex = 3;
            // 
            // txtExID
            // 
            this.txtExID.Location = new System.Drawing.Point(97, 153);
            this.txtExID.Name = "txtExID";
            this.txtExID.ReadOnly = true;
            this.txtExID.Size = new System.Drawing.Size(274, 21);
            this.txtExID.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(97, 29);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(274, 21);
            this.txtID.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "备注";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "解决方案";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "异常描述";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "异常名称*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "异常编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "异常类型*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "所属项目*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "用户*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(97, 61);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(274, 20);
            this.cmbUser.TabIndex = 0;
            // 
            // cmbPro
            // 
            this.cmbPro.FormattingEnabled = true;
            this.cmbPro.Location = new System.Drawing.Point(97, 91);
            this.cmbPro.Name = "cmbPro";
            this.cmbPro.Size = new System.Drawing.Size(274, 20);
            this.cmbPro.TabIndex = 1;
            // 
            // cmbExType
            // 
            this.cmbExType.Location = new System.Drawing.Point(97, 122);
            this.cmbExType.Name = "cmbExType";
            this.cmbExType.Size = new System.Drawing.Size(274, 20);
            this.cmbExType.TabIndex = 2;
            this.cmbExType.TextUpdate += new System.EventHandler(this.cmbExType_TextUpdate);
            this.cmbExType.TextChanged += new System.EventHandler(this.cmbExType_TextChanged);
            // 
            // btnUseradd
            // 
            this.btnUseradd.BackgroundImage = global::ExceptionsCollectionSystem.Properties.Resources.加号1;
            this.btnUseradd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUseradd.Location = new System.Drawing.Point(377, 58);
            this.btnUseradd.Name = "btnUseradd";
            this.btnUseradd.Size = new System.Drawing.Size(23, 23);
            this.btnUseradd.TabIndex = 11;
            this.btnUseradd.UseVisualStyleBackColor = true;
            this.btnUseradd.Click += new System.EventHandler(this.btnUseradd_Click);
            // 
            // btnTypeadd
            // 
            this.btnTypeadd.BackgroundImage = global::ExceptionsCollectionSystem.Properties.Resources.加号1;
            this.btnTypeadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTypeadd.Location = new System.Drawing.Point(377, 120);
            this.btnTypeadd.Name = "btnTypeadd";
            this.btnTypeadd.Size = new System.Drawing.Size(23, 23);
            this.btnTypeadd.TabIndex = 13;
            this.btnTypeadd.UseVisualStyleBackColor = true;
            this.btnTypeadd.Click += new System.EventHandler(this.btnTypeadd_Click);
            // 
            // btnProadd
            // 
            this.btnProadd.BackgroundImage = global::ExceptionsCollectionSystem.Properties.Resources.加号1;
            this.btnProadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProadd.Location = new System.Drawing.Point(377, 89);
            this.btnProadd.Name = "btnProadd";
            this.btnProadd.Size = new System.Drawing.Size(23, 23);
            this.btnProadd.TabIndex = 12;
            this.btnProadd.UseVisualStyleBackColor = true;
            this.btnProadd.Click += new System.EventHandler(this.btnProadd_Click);
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErr.ForeColor = System.Drawing.Color.Red;
            this.lblErr.Location = new System.Drawing.Point(0, 375);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(0, 12);
            this.lblErr.TabIndex = 6;
            this.lblErr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 387);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.btnTypeadd);
            this.Controls.Add(this.btnProadd);
            this.Controls.Add(this.btnUseradd);
            this.Controls.Add(this.cmbExType);
            this.Controls.Add(this.cmbPro);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDescripe);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSolution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label9);
            this.Name = "ExInfoFrm";
            this.Text = "添加异常信息";
            this.Load += new System.EventHandler(this.EXInfoFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtSolution;
        private System.Windows.Forms.TextBox txtDescripe;
        private System.Windows.Forms.TextBox txtExName;
        private System.Windows.Forms.TextBox txtExID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.ComboBox cmbPro;
        private System.Windows.Forms.ComboBox cmbExType;
        private System.Windows.Forms.Button btnUseradd;
        private System.Windows.Forms.Button btnTypeadd;
        private System.Windows.Forms.Button btnProadd;
        private System.Windows.Forms.Label lblErr;
    }
}