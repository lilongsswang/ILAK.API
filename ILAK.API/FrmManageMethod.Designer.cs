namespace ILAK.API
{
    partial class FrmManageMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageMethod));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReqType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFunCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelIntfCode = new System.Windows.Forms.Label();
            this.comboAGGCode = new System.Windows.Forms.ComboBox();
            this.txtRetVO = new System.Windows.Forms.TextBox();
            this.comboTemplate = new System.Windows.Forms.ComboBox();
            this.txtPageSize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 9;
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
            this.label1.Text = "代码";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(72, 16);
            this.txtCode.MaxLength = 255;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(236, 21);
            this.txtCode.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(396, 16);
            this.txtName.MaxLength = 255;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 21);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "返回值类";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(71, 61);
            this.txtDesc.MaxLength = 50;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(236, 21);
            this.txtDesc.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "描述";
            // 
            // txtReqType
            // 
            this.txtReqType.Location = new System.Drawing.Point(396, 61);
            this.txtReqType.MaxLength = 255;
            this.txtReqType.Name = "txtReqType";
            this.txtReqType.ReadOnly = true;
            this.txtReqType.Size = new System.Drawing.Size(236, 21);
            this.txtReqType.TabIndex = 4;
            this.txtReqType.Text = "POST";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "请求类型";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "模版类型";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "参数组代码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "查询SQL";
            // 
            // txtFunCode
            // 
            this.txtFunCode.Location = new System.Drawing.Point(72, 197);
            this.txtFunCode.MaxLength = 65535;
            this.txtFunCode.Multiline = true;
            this.txtFunCode.Name = "txtFunCode";
            this.txtFunCode.Size = new System.Drawing.Size(560, 167);
            this.txtFunCode.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "接口代码";
            // 
            // labelIntfCode
            // 
            this.labelIntfCode.AutoSize = true;
            this.labelIntfCode.Location = new System.Drawing.Point(143, 391);
            this.labelIntfCode.Name = "labelIntfCode";
            this.labelIntfCode.Size = new System.Drawing.Size(0, 12);
            this.labelIntfCode.TabIndex = 21;
            // 
            // comboAGGCode
            // 
            this.comboAGGCode.FormattingEnabled = true;
            this.comboAGGCode.Location = new System.Drawing.Point(396, 104);
            this.comboAGGCode.Name = "comboAGGCode";
            this.comboAGGCode.Size = new System.Drawing.Size(236, 20);
            this.comboAGGCode.TabIndex = 6;
            // 
            // txtRetVO
            // 
            this.txtRetVO.Location = new System.Drawing.Point(396, 147);
            this.txtRetVO.MaxLength = 255;
            this.txtRetVO.Name = "txtRetVO";
            this.txtRetVO.ReadOnly = true;
            this.txtRetVO.Size = new System.Drawing.Size(236, 21);
            this.txtRetVO.TabIndex = 24;
            // 
            // comboTemplate
            // 
            this.comboTemplate.FormattingEnabled = true;
            this.comboTemplate.Items.AddRange(new object[] {
            "查询",
            "增删改",
            "存储过程"});
            this.comboTemplate.Location = new System.Drawing.Point(72, 104);
            this.comboTemplate.Name = "comboTemplate";
            this.comboTemplate.Size = new System.Drawing.Size(236, 20);
            this.comboTemplate.TabIndex = 5;
            // 
            // txtPageSize
            // 
            this.txtPageSize.Location = new System.Drawing.Point(72, 147);
            this.txtPageSize.MaxLength = 50;
            this.txtPageSize.Name = "txtPageSize";
            this.txtPageSize.Size = new System.Drawing.Size(236, 21);
            this.txtPageSize.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "每页条数";
            // 
            // FrmManageMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 431);
            this.Controls.Add(this.txtPageSize);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboTemplate);
            this.Controls.Add(this.txtRetVO);
            this.Controls.Add(this.comboAGGCode);
            this.Controls.Add(this.labelIntfCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFunCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReqType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 470);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 470);
            this.Name = "FrmManageMethod";
            this.Text = "方法管理";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAddProj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReqType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFunCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelIntfCode;
        private System.Windows.Forms.ComboBox comboAGGCode;
        private System.Windows.Forms.TextBox txtRetVO;
        private System.Windows.Forms.ComboBox comboTemplate;
        private System.Windows.Forms.TextBox txtPageSize;
        private System.Windows.Forms.Label label10;
    }
}