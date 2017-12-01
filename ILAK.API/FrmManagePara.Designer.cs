namespace ILAK.API
{
    partial class FrmManagePara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManagePara));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParaName = new System.Windows.Forms.TextBox();
            this.txtParaCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConnNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDefaultValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboDataType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 281);
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
            this.label1.Text = "参数名称";
            // 
            // txtParaName
            // 
            this.txtParaName.Location = new System.Drawing.Point(143, 16);
            this.txtParaName.MaxLength = 255;
            this.txtParaName.Name = "txtParaName";
            this.txtParaName.Size = new System.Drawing.Size(236, 21);
            this.txtParaName.TabIndex = 1;
            // 
            // txtParaCode
            // 
            this.txtParaCode.Location = new System.Drawing.Point(143, 55);
            this.txtParaCode.MaxLength = 255;
            this.txtParaCode.Name = "txtParaCode";
            this.txtParaCode.Size = new System.Drawing.Size(236, 21);
            this.txtParaCode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "参数代码";
            // 
            // txtConnNote
            // 
            this.txtConnNote.Location = new System.Drawing.Point(143, 240);
            this.txtConnNote.MaxLength = 255;
            this.txtConnNote.Name = "txtConnNote";
            this.txtConnNote.Size = new System.Drawing.Size(236, 21);
            this.txtConnNote.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "备注";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(143, 143);
            this.txtLength.MaxLength = 255;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(236, 21);
            this.txtLength.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "最大长度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "默认值";
            // 
            // txtDefaultValue
            // 
            this.txtDefaultValue.Location = new System.Drawing.Point(143, 190);
            this.txtDefaultValue.MaxLength = 255;
            this.txtDefaultValue.Name = "txtDefaultValue";
            this.txtDefaultValue.Size = new System.Drawing.Size(236, 21);
            this.txtDefaultValue.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "参数数据类型";
            // 
            // comboDataType
            // 
            this.comboDataType.FormattingEnabled = true;
            this.comboDataType.Items.AddRange(new object[] {
            "string",
            "decimal",
            "bool",
            "int",
            "datetime",
            "*JSONObj"});
            this.comboDataType.Location = new System.Drawing.Point(143, 97);
            this.comboDataType.Name = "comboDataType";
            this.comboDataType.Size = new System.Drawing.Size(236, 20);
            this.comboDataType.TabIndex = 20;
            // 
            // FrmManagePara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 321);
            this.Controls.Add(this.comboDataType);
            this.Controls.Add(this.txtDefaultValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConnNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParaCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParaName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 360);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 360);
            this.Name = "FrmManagePara";
            this.Text = "参数管理";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAddProj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParaName;
        private System.Windows.Forms.TextBox txtParaCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConnNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDefaultValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboDataType;
    }
}