

namespace ILAK.API
{
    partial class FrmProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProject));
            this.skinLVInterfaces = new CCWin.SkinControl.SkinListView();
            this.skinPanelProj = new CCWin.SkinControl.SkinPanel();
            this.sTK = new CCWin.SkinControl.SkinToolStrip();
            this.tBtnAddProj = new System.Windows.Forms.ToolStripButton();
            this.tBtnModiProj = new System.Windows.Forms.ToolStripButton();
            this.tBtnDelProj = new System.Windows.Forms.ToolStripButton();
            this.tBtnAddIntf = new System.Windows.Forms.ToolStripButton();
            this.tBtnEditIntf = new System.Windows.Forms.ToolStripButton();
            this.tBtnDelIntf = new System.Windows.Forms.ToolStripButton();
            this.tBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.listVProjects = new CCWin.SkinControl.SkinListView();
            this.skinPanelProj.SuspendLayout();
            this.sTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinLVInterfaces
            // 
            this.skinLVInterfaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinLVInterfaces.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.skinLVInterfaces.Dock = System.Windows.Forms.DockStyle.Right;
            this.skinLVInterfaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.skinLVInterfaces.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.skinLVInterfaces.Location = new System.Drawing.Point(249, 31);
            this.skinLVInterfaces.Margin = new System.Windows.Forms.Padding(0);
            this.skinLVInterfaces.MultiSelect = false;
            this.skinLVInterfaces.Name = "skinLVInterfaces";
            this.skinLVInterfaces.OwnerDraw = true;
            this.skinLVInterfaces.RowBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.skinLVInterfaces.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.skinLVInterfaces.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinLVInterfaces.Size = new System.Drawing.Size(806, 619);
            this.skinLVInterfaces.TabIndex = 13;
            this.skinLVInterfaces.UseCompatibleStateImageBehavior = false;
            this.skinLVInterfaces.DoubleClick += new System.EventHandler(this.skinLVInterfaces_DoubleClick);
            // 
            // skinPanelProj
            // 
            this.skinPanelProj.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinPanelProj.Controls.Add(this.sTK);
            this.skinPanelProj.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanelProj.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanelProj.DownBack = null;
            this.skinPanelProj.Location = new System.Drawing.Point(0, 0);
            this.skinPanelProj.Margin = new System.Windows.Forms.Padding(0);
            this.skinPanelProj.MouseBack = null;
            this.skinPanelProj.Name = "skinPanelProj";
            this.skinPanelProj.NormlBack = null;
            this.skinPanelProj.Size = new System.Drawing.Size(1055, 31);
            this.skinPanelProj.TabIndex = 11;
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
            this.tBtnRefresh});
            this.sTK.Location = new System.Drawing.Point(6, 3);
            this.sTK.Name = "sTK";
            this.sTK.Padding = new System.Windows.Forms.Padding(0);
            this.sTK.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.sTK.Size = new System.Drawing.Size(457, 25);
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
            this.tBtnAddProj.Text = "新增项目";
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
            this.tBtnModiProj.Text = "修改项目";
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
            this.tBtnDelProj.Text = "删除项目";
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
            this.tBtnAddIntf.Text = "新增接口";
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
            this.tBtnEditIntf.Text = "编辑接口";
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
            this.tBtnDelIntf.Text = "删除接口";
            this.tBtnDelIntf.Click += new System.EventHandler(this.tBtnDelIntf_Click);
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
            this.listVProjects.TabIndex = 14;
            this.listVProjects.UseCompatibleStateImageBehavior = false;
            this.listVProjects.View = System.Windows.Forms.View.List;
            this.listVProjects.SelectedIndexChanged += new System.EventHandler(this.listVProjects_SelectedIndexChanged);
            this.listVProjects.DoubleClick += new System.EventHandler(this.listVProjects_DoubleClick);
            // 
            // FrmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1055, 650);
            this.Controls.Add(this.listVProjects);
            this.Controls.Add(this.skinLVInterfaces);
            this.Controls.Add(this.skinPanelProj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(620, 379);
            this.Name = "FrmProject";
            this.Text = "FrmProject";
            this.Load += new System.EventHandler(this.FrmProject_Load);
            this.skinPanelProj.ResumeLayout(false);
            this.skinPanelProj.PerformLayout();
            this.sTK.ResumeLayout(false);
            this.sTK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinListView skinLVInterfaces;
        private CCWin.SkinControl.SkinPanel skinPanelProj;
        private CCWin.SkinControl.SkinToolStrip sTK;
        private System.Windows.Forms.ToolStripButton tBtnAddProj;
        private System.Windows.Forms.ToolStripButton tBtnModiProj;
        private System.Windows.Forms.ToolStripButton tBtnDelProj;
        private System.Windows.Forms.ToolStripButton tBtnAddIntf;
        private System.Windows.Forms.ToolStripButton tBtnDelIntf;
        private CCWin.SkinControl.SkinListView listVProjects;
        private System.Windows.Forms.ToolStripButton tBtnEditIntf;
        private System.Windows.Forms.ToolStripButton tBtnRefresh;
    }
}