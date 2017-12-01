namespace ILAK.API
{
    partial class FrmManageRetVO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageRetVO));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtExtType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRetJSON = new System.Windows.Forms.TextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 364);
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
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "类名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(143, 16);
            this.txtName.MaxLength = 255;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(289, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtExtType
            // 
            this.txtExtType.Location = new System.Drawing.Point(143, 58);
            this.txtExtType.MaxLength = 255;
            this.txtExtType.Name = "txtExtType";
            this.txtExtType.Size = new System.Drawing.Size(289, 21);
            this.txtExtType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "继承类型";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(143, 337);
            this.txtNote.MaxLength = 255;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(289, 21);
            this.txtNote.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "备注";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "返回JSON示例";
            // 
            // txtRetJSON
            // 
            this.txtRetJSON.Location = new System.Drawing.Point(39, 132);
            this.txtRetJSON.MaxLength = 9999;
            this.txtRetJSON.Multiline = true;
            this.txtRetJSON.Name = "txtRetJSON";
            this.txtRetJSON.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRetJSON.Size = new System.Drawing.Size(393, 184);
            this.txtRetJSON.TabIndex = 8;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.Green;
            this.skinLabel1.Location = new System.Drawing.Point(13, 402);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(164, 17);
            this.skinLabel1.TabIndex = 20;
            this.skinLabel1.Text = "手工修改某方法的返回值类型";
            // 
            // FrmManageRetVO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 431);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.txtRetJSON);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExtType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 470);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 470);
            this.Name = "FrmManageRetVO";
            this.Text = "返回值类型";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAddProj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtExtType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRetJSON;
        private CCWin.SkinControl.SkinLabel skinLabel1;
    }
}