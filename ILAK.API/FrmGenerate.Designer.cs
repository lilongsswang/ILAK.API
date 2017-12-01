
namespace ILAK.API
{
    partial class FrmGenerate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerate));
            this.skinPanel4 = new CCWin.SkinControl.SkinPanel();
            this.skinToolStrip3 = new CCWin.SkinControl.SkinToolStrip();
            this.tBtnGenerate = new System.Windows.Forms.ToolStripButton();
            this.tBtnOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.tBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.lblDestFolder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.T_Helper = new System.Windows.Forms.TextBox();
            this.listVProjects = new CCWin.SkinControl.SkinListView();
            this.txtCompileResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestPath = new System.Windows.Forms.TextBox();
            this.skinPanel4.SuspendLayout();
            this.skinToolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel4
            // 
            this.skinPanel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinPanel4.Controls.Add(this.skinToolStrip3);
            this.skinPanel4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel4.DownBack = null;
            this.skinPanel4.Location = new System.Drawing.Point(0, 0);
            this.skinPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.skinPanel4.MouseBack = null;
            this.skinPanel4.Name = "skinPanel4";
            this.skinPanel4.NormlBack = null;
            this.skinPanel4.Size = new System.Drawing.Size(985, 31);
            this.skinPanel4.TabIndex = 11;
            // 
            // skinToolStrip3
            // 
            this.skinToolStrip3.Arrow = System.Drawing.Color.White;
            this.skinToolStrip3.Back = System.Drawing.Color.White;
            this.skinToolStrip3.BackColor = System.Drawing.Color.Transparent;
            this.skinToolStrip3.BackRadius = 4;
            this.skinToolStrip3.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinToolStrip3.Base = System.Drawing.Color.Transparent;
            this.skinToolStrip3.BaseFore = System.Drawing.Color.Black;
            this.skinToolStrip3.BaseForeAnamorphosis = false;
            this.skinToolStrip3.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip3.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinToolStrip3.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skinToolStrip3.BaseHoverFore = System.Drawing.Color.Black;
            this.skinToolStrip3.BaseItemAnamorphosis = true;
            this.skinToolStrip3.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.skinToolStrip3.BaseItemBorderShow = true;
            this.skinToolStrip3.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip3.BaseItemDown")));
            this.skinToolStrip3.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinToolStrip3.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip3.BaseItemMouse")));
            this.skinToolStrip3.BaseItemNorml = ((System.Drawing.Image)(resources.GetObject("skinToolStrip3.BaseItemNorml")));
            this.skinToolStrip3.BaseItemPressed = System.Drawing.Color.Transparent;
            this.skinToolStrip3.BaseItemRadius = 2;
            this.skinToolStrip3.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip3.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.skinToolStrip3.BindTabControl = null;
            this.skinToolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.skinToolStrip3.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip3.Fore = System.Drawing.Color.Black;
            this.skinToolStrip3.GripMargin = new System.Windows.Forms.Padding(0);
            this.skinToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.skinToolStrip3.HoverFore = System.Drawing.Color.White;
            this.skinToolStrip3.ItemAnamorphosis = false;
            this.skinToolStrip3.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip3.ItemBorderShow = false;
            this.skinToolStrip3.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip3.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip3.ItemRadius = 1;
            this.skinToolStrip3.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tBtnRefresh,
            this.tBtnGenerate,
            this.tBtnOpenFolder});
            this.skinToolStrip3.Location = new System.Drawing.Point(6, 3);
            this.skinToolStrip3.Name = "skinToolStrip3";
            this.skinToolStrip3.Padding = new System.Windows.Forms.Padding(0);
            this.skinToolStrip3.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip3.Size = new System.Drawing.Size(197, 25);
            this.skinToolStrip3.SkinAllColor = true;
            this.skinToolStrip3.TabIndex = 125;
            this.skinToolStrip3.Text = "skinToolStrip3";
            this.skinToolStrip3.TitleAnamorphosis = false;
            this.skinToolStrip3.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip3.TitleRadius = 4;
            this.skinToolStrip3.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // tBtnGenerate
            // 
            this.tBtnGenerate.AutoSize = false;
            this.tBtnGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnGenerate.ForeColor = System.Drawing.Color.Black;
            this.tBtnGenerate.Image = ((System.Drawing.Image)(resources.GetObject("tBtnGenerate.Image")));
            this.tBtnGenerate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnGenerate.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnGenerate.Name = "tBtnGenerate";
            this.tBtnGenerate.Size = new System.Drawing.Size(60, 23);
            this.tBtnGenerate.Text = "生成项目";
            this.tBtnGenerate.Click += new System.EventHandler(this.tBtnGenerate_Click);
            // 
            // tBtnOpenFolder
            // 
            this.tBtnOpenFolder.AutoSize = false;
            this.tBtnOpenFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnOpenFolder.ForeColor = System.Drawing.Color.White;
            this.tBtnOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("tBtnOpenFolder.Image")));
            this.tBtnOpenFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnOpenFolder.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnOpenFolder.Name = "tBtnOpenFolder";
            this.tBtnOpenFolder.Size = new System.Drawing.Size(60, 23);
            this.tBtnOpenFolder.Text = "拷贝结果";
            this.tBtnOpenFolder.Click += new System.EventHandler(this.tBtnOpenFolder_Click);
            // 
            // tBtnRefresh
            // 
            this.tBtnRefresh.AutoSize = false;
            this.tBtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnRefresh.ForeColor = System.Drawing.Color.White;
            this.tBtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tBtnRefresh.Image")));
            this.tBtnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnRefresh.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnRefresh.Name = "tBtnRefresh";
            this.tBtnRefresh.Size = new System.Drawing.Size(60, 23);
            this.tBtnRefresh.Text = "刷新";
            this.tBtnRefresh.Click += new System.EventHandler(this.tBtnRefresh_Click);
            // 
            // lblDestFolder
            // 
            this.lblDestFolder.AutoSize = true;
            this.lblDestFolder.Font = new System.Drawing.Font("宋体", 12F);
            this.lblDestFolder.Location = new System.Drawing.Point(249, 41);
            this.lblDestFolder.Name = "lblDestFolder";
            this.lblDestFolder.Size = new System.Drawing.Size(80, 16);
            this.lblDestFolder.TabIndex = 51;
            this.lblDestFolder.Text = "生成目录:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(403, -35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "请求参数设置";
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Font = new System.Drawing.Font("宋体", 11F);
            this.txtDirectoryPath.Location = new System.Drawing.Point(335, 37);
            this.txtDirectoryPath.MaxLength = 0;
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.Size = new System.Drawing.Size(638, 24);
            this.txtDirectoryPath.TabIndex = 45;
            // 
            // T_Helper
            // 
            this.T_Helper.Location = new System.Drawing.Point(251, 497);
            this.T_Helper.Multiline = true;
            this.T_Helper.Name = "T_Helper";
            this.T_Helper.ReadOnly = true;
            this.T_Helper.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.T_Helper.Size = new System.Drawing.Size(734, 141);
            this.T_Helper.TabIndex = 47;
            // 
            // listVProjects
            // 
            this.listVProjects.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.listVProjects.Dock = System.Windows.Forms.DockStyle.Left;
            this.listVProjects.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.listVProjects.Location = new System.Drawing.Point(0, 31);
            this.listVProjects.MultiSelect = false;
            this.listVProjects.Name = "listVProjects";
            this.listVProjects.OwnerDraw = true;
            this.listVProjects.RowBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.listVProjects.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.listVProjects.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listVProjects.Size = new System.Drawing.Size(235, 619);
            this.listVProjects.TabIndex = 48;
            this.listVProjects.UseCompatibleStateImageBehavior = false;
            this.listVProjects.View = System.Windows.Forms.View.List;
            // 
            // txtCompileResult
            // 
            this.txtCompileResult.Location = new System.Drawing.Point(251, 109);
            this.txtCompileResult.MaxLength = 0;
            this.txtCompileResult.Multiline = true;
            this.txtCompileResult.Name = "txtCompileResult";
            this.txtCompileResult.ReadOnly = true;
            this.txtCompileResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCompileResult.Size = new System.Drawing.Size(734, 382);
            this.txtCompileResult.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(249, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "目标目录:";
            // 
            // txtDestPath
            // 
            this.txtDestPath.Font = new System.Drawing.Font("宋体", 11F);
            this.txtDestPath.Location = new System.Drawing.Point(335, 67);
            this.txtDestPath.MaxLength = 0;
            this.txtDestPath.Name = "txtDestPath";
            this.txtDestPath.Size = new System.Drawing.Size(638, 24);
            this.txtDestPath.TabIndex = 52;
            // 
            // FrmGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(985, 650);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestPath);
            this.Controls.Add(this.lblDestFolder);
            this.Controls.Add(this.txtCompileResult);
            this.Controls.Add(this.listVProjects);
            this.Controls.Add(this.T_Helper);
            this.Controls.Add(this.txtDirectoryPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skinPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(620, 379);
            this.Name = "FrmGenerate";
            this.Text = "FrmGenerate";
            this.Load += new System.EventHandler(this.FrmGenerate_Load);
            this.skinPanel4.ResumeLayout(false);
            this.skinPanel4.PerformLayout();
            this.skinToolStrip3.ResumeLayout(false);
            this.skinToolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinPanel skinPanel4;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip3;
        private System.Windows.Forms.ToolStripButton tBtnGenerate;
        private System.Windows.Forms.ToolStripButton tBtnOpenFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDestFolder;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.TextBox T_Helper;
        private CCWin.SkinControl.SkinListView listVProjects;
        private System.Windows.Forms.ToolStripButton tBtnRefresh;
        private System.Windows.Forms.TextBox txtCompileResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestPath;
    }
}