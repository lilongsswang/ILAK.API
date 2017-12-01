namespace ILAK.API
{
    partial class FrmManageProj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageProj));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjName = new System.Windows.Forms.TextBox();
            this.txtProjCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 171);
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
            this.label1.Text = "项目名称";
            // 
            // txtProjName
            // 
            this.txtProjName.Location = new System.Drawing.Point(143, 13);
            this.txtProjName.MaxLength = 255;
            this.txtProjName.Name = "txtProjName";
            this.txtProjName.Size = new System.Drawing.Size(236, 21);
            this.txtProjName.TabIndex = 2;
            // 
            // txtProjCode
            // 
            this.txtProjCode.Location = new System.Drawing.Point(143, 52);
            this.txtProjCode.MaxLength = 255;
            this.txtProjCode.Name = "txtProjCode";
            this.txtProjCode.Size = new System.Drawing.Size(236, 21);
            this.txtProjCode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "项目代码";
            // 
            // txtProjNote
            // 
            this.txtProjNote.Location = new System.Drawing.Point(143, 140);
            this.txtProjNote.MaxLength = 255;
            this.txtProjNote.Name = "txtProjNote";
            this.txtProjNote.Size = new System.Drawing.Size(236, 21);
            this.txtProjNote.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "备注";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(143, 96);
            this.txtPort.MaxLength = 255;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(236, 21);
            this.txtPort.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "部署端口";
            // 
            // FrmManageProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 211);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProjNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProjCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProjName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 250);
            this.Name = "FrmManageProj";
            this.Text = "项目管理";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAddProj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProjName;
        private System.Windows.Forms.TextBox txtProjCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProjNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label4;
    }
}