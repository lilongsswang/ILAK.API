namespace ILAK.API
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabShow = new CCWin.SkinControl.SkinTabControl();
            this.tabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.tabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.tabPage3 = new CCWin.SkinControl.SkinTabPage();
            this.tabPage4 = new CCWin.SkinControl.SkinTabPage();
            this.tabPage5 = new CCWin.SkinControl.SkinTabPage();
            this.tabPage6 = new CCWin.SkinControl.SkinTabPage();
            this.tabShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabShow
            // 
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.tabShow.Animation = animation1;
            this.tabShow.AnimationStart = false;
            this.tabShow.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tabShow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabShow.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tabShow.Controls.Add(this.tabPage1);
            this.tabShow.Controls.Add(this.tabPage2);
            this.tabShow.Controls.Add(this.tabPage3);
            this.tabShow.Controls.Add(this.tabPage4);
            this.tabShow.Controls.Add(this.tabPage5);
            this.tabShow.Controls.Add(this.tabPage6);
            this.tabShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabShow.DrawType = CCWin.SkinControl.DrawStyle.Draw;
            this.tabShow.HeadBack = null;
            this.tabShow.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tabShow.Interval = 5;
            this.tabShow.ItemSize = new System.Drawing.Size(120, 36);
            this.tabShow.Location = new System.Drawing.Point(0, 0);
            this.tabShow.Name = "tabShow";
            this.tabShow.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tabShow.PageArrowDown")));
            this.tabShow.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tabShow.PageArrowHover")));
            this.tabShow.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tabShow.PageCloseHover")));
            this.tabShow.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tabShow.PageCloseNormal")));
            this.tabShow.PageDown = ((System.Drawing.Image)(resources.GetObject("tabShow.PageDown")));
            this.tabShow.PageHover = ((System.Drawing.Image)(resources.GetObject("tabShow.PageHover")));
            this.tabShow.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tabShow.PageNorml = null;
            this.tabShow.SelectedIndex = 0;
            this.tabShow.ShowToolTips = true;
            this.tabShow.Size = new System.Drawing.Size(1039, 661);
            this.tabShow.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabShow.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(0, 36);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1039, 625);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Tag = "FrmProject";
            this.tabPage1.Text = "1.配置项目和接口";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(0, 36);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1039, 625);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Tag = "FrmMethod";
            this.tabPage2.Text = "2 配置方法和参数";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(0, 36);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1039, 625);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Tag = "FrmGenerate";
            this.tabPage3.Text = "3 生成接口项目";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(0, 36);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1039, 625);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Tag = "FrmConnection";
            this.tabPage4.Text = "* 数据库连接管理";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Location = new System.Drawing.Point(0, 36);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1039, 625);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Tag = "FrmAGPara";
            this.tabPage5.Text = "参数组参数管理";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.Location = new System.Drawing.Point(0, 36);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1039, 625);
            this.tabPage6.TabIndex = 7;
            this.tabPage6.Tag = "FrmRetVO";
            this.tabPage6.Text = "返回值管理";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1039, 661);
            this.Controls.Add(this.tabShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1055, 700);
            this.Name = "Main";
            this.Text = "云动快车_互宜达科技";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinTabControl tabShow;
        private CCWin.SkinControl.SkinTabPage tabPage1;
        private CCWin.SkinControl.SkinTabPage tabPage2;
        private CCWin.SkinControl.SkinTabPage tabPage3;
        private CCWin.SkinControl.SkinTabPage tabPage4;
        private CCWin.SkinControl.SkinTabPage tabPage6;
        private CCWin.SkinControl.SkinTabPage tabPage5;
    }
}

