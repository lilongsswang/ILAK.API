namespace ILAK.API
{
    partial class FrmManageAG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageAG));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAGName = new System.Windows.Forms.TextBox();
            this.txtAGCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAGNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 181);
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
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "组名称";
            // 
            // txtAGName
            // 
            this.txtAGName.Location = new System.Drawing.Point(143, 13);
            this.txtAGName.MaxLength = 255;
            this.txtAGName.Name = "txtAGName";
            this.txtAGName.Size = new System.Drawing.Size(236, 21);
            this.txtAGName.TabIndex = 2;
            // 
            // txtAGCode
            // 
            this.txtAGCode.Location = new System.Drawing.Point(143, 52);
            this.txtAGCode.MaxLength = 255;
            this.txtAGCode.Name = "txtAGCode";
            this.txtAGCode.Size = new System.Drawing.Size(236, 21);
            this.txtAGCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "组代码";
            // 
            // txtAGNote
            // 
            this.txtAGNote.Location = new System.Drawing.Point(143, 142);
            this.txtAGNote.MaxLength = 255;
            this.txtAGNote.Name = "txtAGNote";
            this.txtAGNote.Size = new System.Drawing.Size(236, 21);
            this.txtAGNote.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "备注";
            // 
            // txtParas
            // 
            this.txtParas.Location = new System.Drawing.Point(143, 94);
            this.txtParas.MaxLength = 255;
            this.txtParas.Name = "txtParas";
            this.txtParas.Size = new System.Drawing.Size(236, 21);
            this.txtParas.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "参数集合(,)";
            // 
            // FrmManageAG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 221);
            this.Controls.Add(this.txtParas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAGNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAGCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAGName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 260);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 260);
            this.Name = "FrmManageAG";
            this.Text = "参数组管理";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAddProj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAGName;
        private System.Windows.Forms.TextBox txtAGCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAGNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParas;
        private System.Windows.Forms.Label label4;
    }
}