namespace ILAK.API
{
    partial class FrmManageIntf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageIntf));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIntfName = new System.Windows.Forms.TextBox();
            this.txtIntfCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIntfNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelProjCode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboServIP = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 289);
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
            this.label1.Location = new System.Drawing.Point(37, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "接口名称";
            // 
            // txtIntfName
            // 
            this.txtIntfName.Location = new System.Drawing.Point(143, 13);
            this.txtIntfName.MaxLength = 255;
            this.txtIntfName.Name = "txtIntfName";
            this.txtIntfName.Size = new System.Drawing.Size(236, 21);
            this.txtIntfName.TabIndex = 2;
            // 
            // txtIntfCode
            // 
            this.txtIntfCode.Location = new System.Drawing.Point(143, 52);
            this.txtIntfCode.MaxLength = 255;
            this.txtIntfCode.Name = "txtIntfCode";
            this.txtIntfCode.Size = new System.Drawing.Size(236, 21);
            this.txtIntfCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "接口代码";
            // 
            // txtIntfNote
            // 
            this.txtIntfNote.Location = new System.Drawing.Point(143, 246);
            this.txtIntfNote.MaxLength = 255;
            this.txtIntfNote.Name = "txtIntfNote";
            this.txtIntfNote.Size = new System.Drawing.Size(236, 21);
            this.txtIntfNote.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "备注";
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(143, 94);
            this.txtNameSpace.MaxLength = 255;
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(236, 21);
            this.txtNameSpace.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "命名空间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "数据库连接";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(143, 193);
            this.txtVersion.MaxLength = 50;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(236, 21);
            this.txtVersion.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "版本";
            // 
            // labelProjCode
            // 
            this.labelProjCode.AutoSize = true;
            this.labelProjCode.Location = new System.Drawing.Point(141, 297);
            this.labelProjCode.Name = "labelProjCode";
            this.labelProjCode.Size = new System.Drawing.Size(11, 12);
            this.labelProjCode.TabIndex = 15;
            this.labelProjCode.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "项目代码";
            // 
            // comboServIP
            // 
            this.comboServIP.FormattingEnabled = true;
            this.comboServIP.Location = new System.Drawing.Point(143, 141);
            this.comboServIP.Name = "comboServIP";
            this.comboServIP.Size = new System.Drawing.Size(236, 20);
            this.comboServIP.TabIndex = 17;
            // 
            // FrmManageIntf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 331);
            this.Controls.Add(this.comboServIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelProjCode);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNameSpace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIntfNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIntfCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIntfName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 370);
            this.Name = "FrmManageIntf";
            this.Text = "接口管理";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAddProj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIntfName;
        private System.Windows.Forms.TextBox txtIntfCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIntfNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelProjCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboServIP;
    }
}