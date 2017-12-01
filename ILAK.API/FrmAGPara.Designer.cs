

namespace ILAK.API
{
    partial class FrmAGPara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAGPara));
            this.skinLVParas = new CCWin.SkinControl.SkinListView();
            this.skinPanel = new CCWin.SkinControl.SkinPanel();
            this.sTK = new CCWin.SkinControl.SkinToolStrip();
            this.tBtnAddProj = new System.Windows.Forms.ToolStripButton();
            this.tBtnModiProj = new System.Windows.Forms.ToolStripButton();
            this.tBtnDelProj = new System.Windows.Forms.ToolStripButton();
            this.tBtnAddIntf = new System.Windows.Forms.ToolStripButton();
            this.tBtnEditIntf = new System.Windows.Forms.ToolStripButton();
            this.tBtnDelIntf = new System.Windows.Forms.ToolStripButton();
            this.tBtnShowAllParas = new System.Windows.Forms.ToolStripButton();
            this.listVAGs = new CCWin.SkinControl.SkinListView();
            this.sBtnDisplayParas = new CCWin.SkinControl.SkinButton();
            this.skinPanel.SuspendLayout();
            this.sTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinLVParas
            // 
            this.skinLVParas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinLVParas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.skinLVParas.Dock = System.Windows.Forms.DockStyle.Right;
            this.skinLVParas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.skinLVParas.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.skinLVParas.Location = new System.Drawing.Point(322, 31);
            this.skinLVParas.Margin = new System.Windows.Forms.Padding(0);
            this.skinLVParas.MultiSelect = false;
            this.skinLVParas.Name = "skinLVParas";
            this.skinLVParas.OwnerDraw = true;
            this.skinLVParas.RowBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.skinLVParas.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.skinLVParas.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinLVParas.Size = new System.Drawing.Size(733, 619);
            this.skinLVParas.TabIndex = 13;
            this.skinLVParas.UseCompatibleStateImageBehavior = false;
            this.skinLVParas.DoubleClick += new System.EventHandler(this.skinLVParas_DoubleClick);
            // 
            // skinPanel
            // 
            this.skinPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinPanel.Controls.Add(this.sTK);
            this.skinPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel.DownBack = null;
            this.skinPanel.Location = new System.Drawing.Point(0, 0);
            this.skinPanel.Margin = new System.Windows.Forms.Padding(0);
            this.skinPanel.MouseBack = null;
            this.skinPanel.Name = "skinPanel";
            this.skinPanel.NormlBack = null;
            this.skinPanel.Size = new System.Drawing.Size(1055, 31);
            this.skinPanel.TabIndex = 11;
            // 
            // sTK
            // 
            this.sTK.Arrow = System.Drawing.Color.White;
            this.sTK.Back = System.Drawing.Color.White;
            this.sTK.BackColor = System.Drawing.Color.Transparent;
            this.sTK.BackRadius = 4;
            this.sTK.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.sTK.Base = System.Drawing.Color.Transparent;
            this.sTK.BaseFore = System.Drawing.Color.Black;
            this.sTK.BaseForeAnamorphosis = false;
            this.sTK.BaseForeAnamorphosisBorder = 4;
            this.sTK.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.sTK.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.sTK.BaseHoverFore = System.Drawing.Color.Black;
            this.sTK.BaseItemAnamorphosis = true;
            this.sTK.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.sTK.BaseItemBorderShow = true;
            this.sTK.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("sTK.BaseItemDown")));
            this.sTK.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sTK.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("sTK.BaseItemMouse")));
            this.sTK.BaseItemNorml = ((System.Drawing.Image)(resources.GetObject("sTK.BaseItemNorml")));
            this.sTK.BaseItemPressed = System.Drawing.Color.Transparent;
            this.sTK.BaseItemRadius = 2;
            this.sTK.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.sTK.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.sTK.BindTabControl = null;
            this.sTK.Dock = System.Windows.Forms.DockStyle.None;
            this.sTK.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.sTK.Fore = System.Drawing.Color.Black;
            this.sTK.GripMargin = new System.Windows.Forms.Padding(0);
            this.sTK.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.sTK.HoverFore = System.Drawing.Color.White;
            this.sTK.ItemAnamorphosis = false;
            this.sTK.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.sTK.ItemBorderShow = false;
            this.sTK.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.sTK.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.sTK.ItemRadius = 1;
            this.sTK.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.sTK.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tBtnAddProj,
            this.tBtnModiProj,
            this.tBtnDelProj,
            this.tBtnAddIntf,
            this.tBtnEditIntf,
            this.tBtnDelIntf,
            this.tBtnShowAllParas});
            this.sTK.Location = new System.Drawing.Point(6, 3);
            this.sTK.Name = "sTK";
            this.sTK.Padding = new System.Windows.Forms.Padding(0);
            this.sTK.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.sTK.Size = new System.Drawing.Size(476, 25);
            this.sTK.SkinAllColor = true;
            this.sTK.TabIndex = 125;
            this.sTK.Text = "skinToolStrip3";
            this.sTK.TitleAnamorphosis = false;
            this.sTK.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.sTK.TitleRadius = 4;
            this.sTK.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // tBtnAddProj
            // 
            this.tBtnAddProj.AutoSize = false;
            this.tBtnAddProj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnAddProj.ForeColor = System.Drawing.Color.Black;
            this.tBtnAddProj.Image = ((System.Drawing.Image)(resources.GetObject("tBtnAddProj.Image")));
            this.tBtnAddProj.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnAddProj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnAddProj.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnAddProj.Name = "tBtnAddProj";
            this.tBtnAddProj.Size = new System.Drawing.Size(60, 23);
            this.tBtnAddProj.Text = "+参数组";
            this.tBtnAddProj.Click += new System.EventHandler(this.tBtnAddProj_Click);
            // 
            // tBtnModiProj
            // 
            this.tBtnModiProj.AutoSize = false;
            this.tBtnModiProj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnModiProj.ForeColor = System.Drawing.Color.White;
            this.tBtnModiProj.Image = ((System.Drawing.Image)(resources.GetObject("tBtnModiProj.Image")));
            this.tBtnModiProj.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnModiProj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnModiProj.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnModiProj.Name = "tBtnModiProj";
            this.tBtnModiProj.Size = new System.Drawing.Size(60, 23);
            this.tBtnModiProj.Text = "*参数组";
            this.tBtnModiProj.Click += new System.EventHandler(this.tBtnModiProj_Click);
            // 
            // tBtnDelProj
            // 
            this.tBtnDelProj.AutoSize = false;
            this.tBtnDelProj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnDelProj.ForeColor = System.Drawing.Color.White;
            this.tBtnDelProj.Image = ((System.Drawing.Image)(resources.GetObject("tBtnDelProj.Image")));
            this.tBtnDelProj.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnDelProj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnDelProj.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnDelProj.Name = "tBtnDelProj";
            this.tBtnDelProj.Size = new System.Drawing.Size(60, 23);
            this.tBtnDelProj.Text = "-参数组";
            this.tBtnDelProj.Click += new System.EventHandler(this.tBtnDelProj_Click);
            // 
            // tBtnAddIntf
            // 
            this.tBtnAddIntf.AutoSize = false;
            this.tBtnAddIntf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnAddIntf.ForeColor = System.Drawing.Color.White;
            this.tBtnAddIntf.Image = ((System.Drawing.Image)(resources.GetObject("tBtnAddIntf.Image")));
            this.tBtnAddIntf.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnAddIntf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnAddIntf.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnAddIntf.Name = "tBtnAddIntf";
            this.tBtnAddIntf.Size = new System.Drawing.Size(60, 23);
            this.tBtnAddIntf.Text = "新增参数";
            this.tBtnAddIntf.Click += new System.EventHandler(this.tBtnAddIntf_Click);
            // 
            // tBtnEditIntf
            // 
            this.tBtnEditIntf.AutoSize = false;
            this.tBtnEditIntf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnEditIntf.ForeColor = System.Drawing.Color.White;
            this.tBtnEditIntf.Image = ((System.Drawing.Image)(resources.GetObject("tBtnEditIntf.Image")));
            this.tBtnEditIntf.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnEditIntf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnEditIntf.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnEditIntf.Name = "tBtnEditIntf";
            this.tBtnEditIntf.Size = new System.Drawing.Size(60, 23);
            this.tBtnEditIntf.Text = "编辑参数";
            this.tBtnEditIntf.Click += new System.EventHandler(this.tBtnEditIntf_Click);
            // 
            // tBtnDelIntf
            // 
            this.tBtnDelIntf.AutoSize = false;
            this.tBtnDelIntf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnDelIntf.ForeColor = System.Drawing.Color.White;
            this.tBtnDelIntf.Image = ((System.Drawing.Image)(resources.GetObject("tBtnDelIntf.Image")));
            this.tBtnDelIntf.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnDelIntf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnDelIntf.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnDelIntf.Name = "tBtnDelIntf";
            this.tBtnDelIntf.Size = new System.Drawing.Size(60, 23);
            this.tBtnDelIntf.Text = "删除参数";
            this.tBtnDelIntf.Click += new System.EventHandler(this.tBtnDelIntf_Click);
            // 
            // tBtnShowAllParas
            // 
            this.tBtnShowAllParas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnShowAllParas.Image = ((System.Drawing.Image)(resources.GetObject("tBtnShowAllParas.Image")));
            this.tBtnShowAllParas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnShowAllParas.Name = "tBtnShowAllParas";
            this.tBtnShowAllParas.Size = new System.Drawing.Size(84, 22);
            this.tBtnShowAllParas.Text = "显示所有参数";
            this.tBtnShowAllParas.Click += new System.EventHandler(this.tBtnShowAllParas_Click);
            // 
            // listVAGs
            // 
            this.listVAGs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.listVAGs.Dock = System.Windows.Forms.DockStyle.Left;
            this.listVAGs.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.listVAGs.Location = new System.Drawing.Point(0, 31);
            this.listVAGs.MultiSelect = false;
            this.listVAGs.Name = "listVAGs";
            this.listVAGs.OwnerDraw = true;
            this.listVAGs.RowBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.listVAGs.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.listVAGs.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listVAGs.Size = new System.Drawing.Size(258, 619);
            this.listVAGs.TabIndex = 14;
            this.listVAGs.UseCompatibleStateImageBehavior = false;
            this.listVAGs.View = System.Windows.Forms.View.List;
            this.listVAGs.DoubleClick += new System.EventHandler(this.listVAGs_DoubleClick);
            // 
            // sBtnDisplayParas
            // 
            this.sBtnDisplayParas.BackColor = System.Drawing.Color.Transparent;
            this.sBtnDisplayParas.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sBtnDisplayParas.DownBack = null;
            this.sBtnDisplayParas.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sBtnDisplayParas.Location = new System.Drawing.Point(264, 224);
            this.sBtnDisplayParas.MouseBack = null;
            this.sBtnDisplayParas.Name = "sBtnDisplayParas";
            this.sBtnDisplayParas.NormlBack = null;
            this.sBtnDisplayParas.Size = new System.Drawing.Size(39, 28);
            this.sBtnDisplayParas.TabIndex = 15;
            this.sBtnDisplayParas.Text = "→";
            this.sBtnDisplayParas.UseVisualStyleBackColor = false;
            this.sBtnDisplayParas.Click += new System.EventHandler(this.sBtnDisplayParas_Click);
            // 
            // FrmAGPara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1055, 650);
            this.Controls.Add(this.sBtnDisplayParas);
            this.Controls.Add(this.listVAGs);
            this.Controls.Add(this.skinLVParas);
            this.Controls.Add(this.skinPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(620, 379);
            this.Name = "FrmAGPara";
            this.Text = "FrmProject";
            this.Load += new System.EventHandler(this.FrmProject_Load);
            this.skinPanel.ResumeLayout(false);
            this.skinPanel.PerformLayout();
            this.sTK.ResumeLayout(false);
            this.sTK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinListView skinLVParas;
        private CCWin.SkinControl.SkinPanel skinPanel;
        private CCWin.SkinControl.SkinToolStrip sTK;
        private System.Windows.Forms.ToolStripButton tBtnAddProj;
        private System.Windows.Forms.ToolStripButton tBtnModiProj;
        private System.Windows.Forms.ToolStripButton tBtnDelProj;
        private System.Windows.Forms.ToolStripButton tBtnAddIntf;
        private System.Windows.Forms.ToolStripButton tBtnDelIntf;
        private CCWin.SkinControl.SkinListView listVAGs;
        private System.Windows.Forms.ToolStripButton tBtnEditIntf;
        private System.Windows.Forms.ToolStripButton tBtnShowAllParas;
        private CCWin.SkinControl.SkinButton sBtnDisplayParas;
    }
}