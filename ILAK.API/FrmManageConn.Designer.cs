namespace ILAK.API
{
    partial class FrmManageConn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageConn));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnName = new System.Windows.Forms.TextBox();
            this.txtConnIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConnNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConnAccount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConnStr = new System.Windows.Forms.TextBox();
            this.comboDBType = new System.Windows.Forms.ComboBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "连接名称";
            // 
            // txtConnName
            // 
            this.txtConnName.Location = new System.Drawing.Point(143, 16);
            this.txtConnName.MaxLength = 255;
            this.txtConnName.Name = "txtConnName";
            this.txtConnName.Size = new System.Drawing.Size(236, 21);
            this.txtConnName.TabIndex = 1;
            // 
            // txtConnIP
            // 
            this.txtConnIP.Location = new System.Drawing.Point(143, 55);
            this.txtConnIP.MaxLength = 255;
            this.txtConnIP.Name = "txtConnIP";
            this.txtConnIP.Size = new System.Drawing.Size(236, 21);
            this.txtConnIP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP地址";
            // 
            // txtConnNote
            // 
            this.txtConnNote.Location = new System.Drawing.Point(143, 364);
            this.txtConnNote.MaxLength = 255;
            this.txtConnNote.Name = "txtConnNote";
            this.txtConnNote.Size = new System.Drawing.Size(236, 21);
            this.txtConnNote.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "备注";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据库类型";
            // 
            // txtCType
            // 
            this.txtCType.Location = new System.Drawing.Point(143, 138);
            this.txtCType.MaxLength = 255;
            this.txtCType.Name = "txtCType";
            this.txtCType.ReadOnly = true;
            this.txtCType.Size = new System.Drawing.Size(236, 21);
            this.txtCType.TabIndex = 5;
            this.txtCType.Text = "Default";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "连接类型";
            // 
            // txtConnAccount
            // 
            this.txtConnAccount.Location = new System.Drawing.Point(143, 179);
            this.txtConnAccount.MaxLength = 255;
            this.txtConnAccount.Name = "txtConnAccount";
            this.txtConnAccount.Size = new System.Drawing.Size(236, 21);
            this.txtConnAccount.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "账号";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(143, 222);
            this.txtPassword.MaxLength = 255;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(236, 21);
            this.txtPassword.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "连接字符串";
            // 
            // txtConnStr
            // 
            this.txtConnStr.Location = new System.Drawing.Point(143, 294);
            this.txtConnStr.MaxLength = 500;
            this.txtConnStr.Multiline = true;
            this.txtConnStr.Name = "txtConnStr";
            this.txtConnStr.Size = new System.Drawing.Size(236, 58);
            this.txtConnStr.TabIndex = 8;
            // 
            // comboDBType
            // 
            this.comboDBType.FormattingEnabled = true;
            this.comboDBType.Items.AddRange(new object[] {
            "MSSql",
            "Cache*",
            "Oracle*"});
            this.comboDBType.Location = new System.Drawing.Point(143, 97);
            this.comboDBType.Name = "comboDBType";
            this.comboDBType.Size = new System.Drawing.Size(236, 20);
            this.comboDBType.TabIndex = 20;
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(143, 261);
            this.txtDBName.MaxLength = 255;
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(236, 21);
            this.txtDBName.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "DB名";
            // 
            // FrmManageConn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 431);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboDBType);
            this.Controls.Add(this.txtConnStr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtConnAccount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConnNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConnIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConnName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 470);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 470);
            this.Name = "FrmManageConn";
            this.Text = "连接管理";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAddProj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnName;
        private System.Windows.Forms.TextBox txtConnIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConnNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConnAccount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConnStr;
        private System.Windows.Forms.ComboBox comboDBType;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Label label9;
    }
}