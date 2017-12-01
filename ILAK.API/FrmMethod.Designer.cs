/********************************************************************
 * *
 * * 使本项目源码或本项目生成的DLL前请仔细阅读以下协议内容，如果你同意以下协议才能使用本项目所有的功能，
 * * 否则如果你违反了以下协议，有可能陷入法律纠纷和赔偿，作者保留追究法律责任的权利。
 * *
 * * 1、你可以在开发的软件产品中使用和修改本项目的源码和DLL，但是请保留所有相关的版权信息。
 * * 2、不能将本项目源码与作者的其他项目整合作为一个单独的软件售卖给他人使用。
 * * 3、不能传播本项目的源码和DLL，包括上传到网上、拷贝给他人等方式。
 * * 4、以上协议暂时定制，由于还不完善，作者保留以后修改协议的权利。
 * *
 * * Copyright (C) 2013-? cskin Corporation All rights reserved.
 * * 网站：CSkin界面库 http://www.cskin.net 论坛 http://bbs.cskin.net
 * * 作者： 乔克斯 QQ：345015918 .Net项目技术组群：306485590
 * * 请保留以上版权信息，否则作者将保留追究法律责任。
 * *
 * * 创建时间：2014-08-26
 * * 说明：FrmBbx.Designer.cs
 * *
********************************************************************/

namespace ILAK.API
{
    partial class FrmMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMethod));
            this.skinLVMethods = new CCWin.SkinControl.SkinListView();
            this.skinPanel4 = new CCWin.SkinControl.SkinPanel();
            this.skinToolStrip3 = new CCWin.SkinControl.SkinToolStrip();
            this.tBtnAddMethod = new System.Windows.Forms.ToolStripButton();
            this.tBtnModiMethod = new System.Windows.Forms.ToolStripButton();
            this.tBtnDelMethod = new System.Windows.Forms.ToolStripButton();
            this.tBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.lblPosition = new System.Windows.Forms.Label();
            this.edtJson = new EasyScintilla.SimpleEditor();
            this.btnSaveRetVal = new System.Windows.Forms.Button();
            this.btnPreviewReq = new System.Windows.Forms.Button();
            this.skinLVProjects = new CCWin.SkinControl.SkinListView();
            this.skinLVInterfaces = new CCWin.SkinControl.SkinListView();
            this.label1 = new System.Windows.Forms.Label();
            this.skinPanel4.SuspendLayout();
            this.skinToolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinLVMethods
            // 
            this.skinLVMethods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinLVMethods.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.skinLVMethods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.skinLVMethods.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.skinLVMethods.Location = new System.Drawing.Point(238, 39);
            this.skinLVMethods.Margin = new System.Windows.Forms.Padding(0);
            this.skinLVMethods.MultiSelect = false;
            this.skinLVMethods.Name = "skinLVMethods";
            this.skinLVMethods.OwnerDraw = true;
            this.skinLVMethods.RowBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.skinLVMethods.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.skinLVMethods.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinLVMethods.Size = new System.Drawing.Size(740, 245);
            this.skinLVMethods.TabIndex = 13;
            this.skinLVMethods.UseCompatibleStateImageBehavior = false;
            this.skinLVMethods.DoubleClick += new System.EventHandler(this.skinLVMethods_DoubleClick);
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
            this.tBtnAddMethod,
            this.tBtnModiMethod,
            this.tBtnDelMethod,
            this.tBtnRefresh});
            this.skinToolStrip3.Location = new System.Drawing.Point(6, 3);
            this.skinToolStrip3.Name = "skinToolStrip3";
            this.skinToolStrip3.Padding = new System.Windows.Forms.Padding(0);
            this.skinToolStrip3.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip3.Size = new System.Drawing.Size(262, 25);
            this.skinToolStrip3.SkinAllColor = true;
            this.skinToolStrip3.TabIndex = 125;
            this.skinToolStrip3.Text = "skinToolStrip3";
            this.skinToolStrip3.TitleAnamorphosis = false;
            this.skinToolStrip3.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip3.TitleRadius = 4;
            this.skinToolStrip3.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // tBtnAddMethod
            // 
            this.tBtnAddMethod.AutoSize = false;
            this.tBtnAddMethod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnAddMethod.ForeColor = System.Drawing.Color.Black;
            this.tBtnAddMethod.Image = ((System.Drawing.Image)(resources.GetObject("tBtnAddMethod.Image")));
            this.tBtnAddMethod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnAddMethod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnAddMethod.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnAddMethod.Name = "tBtnAddMethod";
            this.tBtnAddMethod.Size = new System.Drawing.Size(60, 23);
            this.tBtnAddMethod.Text = "新增方法";
            this.tBtnAddMethod.Click += new System.EventHandler(this.tBtnAddMethod_Click);
            // 
            // tBtnModiMethod
            // 
            this.tBtnModiMethod.AutoSize = false;
            this.tBtnModiMethod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnModiMethod.ForeColor = System.Drawing.Color.White;
            this.tBtnModiMethod.Image = ((System.Drawing.Image)(resources.GetObject("tBtnModiMethod.Image")));
            this.tBtnModiMethod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnModiMethod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnModiMethod.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnModiMethod.Name = "tBtnModiMethod";
            this.tBtnModiMethod.Size = new System.Drawing.Size(60, 23);
            this.tBtnModiMethod.Text = "修改方法";
            this.tBtnModiMethod.Click += new System.EventHandler(this.tBtnModiMethod_Click);
            // 
            // tBtnDelMethod
            // 
            this.tBtnDelMethod.AutoSize = false;
            this.tBtnDelMethod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnDelMethod.ForeColor = System.Drawing.Color.White;
            this.tBtnDelMethod.Image = ((System.Drawing.Image)(resources.GetObject("tBtnDelMethod.Image")));
            this.tBtnDelMethod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnDelMethod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnDelMethod.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnDelMethod.Name = "tBtnDelMethod";
            this.tBtnDelMethod.Size = new System.Drawing.Size(60, 23);
            this.tBtnDelMethod.Text = "删除方法";
            this.tBtnDelMethod.Click += new System.EventHandler(this.tBtnDelMethod_Click);
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
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPosition.Location = new System.Drawing.Point(256, 603);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(48, 16);
            this.lblPosition.TabIndex = 51;
            this.lblPosition.Text = "0 / 0";
            // 
            // edtJson
            // 
            this.edtJson.IndentationGuides = ScintillaNET.IndentView.LookBoth;
            this.edtJson.Location = new System.Drawing.Point(238, 324);
            this.edtJson.Name = "edtJson";
            this.edtJson.Size = new System.Drawing.Size(739, 277);
            this.edtJson.Styler = null;
            this.edtJson.TabIndex = 50;
            this.edtJson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtJson_KeyDown);
            this.edtJson.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EditorPositionChanged);
            this.edtJson.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditorPositionChanged);
            // 
            // btnSaveRetVal
            // 
            this.btnSaveRetVal.Location = new System.Drawing.Point(433, 289);
            this.btnSaveRetVal.Name = "btnSaveRetVal";
            this.btnSaveRetVal.Size = new System.Drawing.Size(155, 30);
            this.btnSaveRetVal.TabIndex = 52;
            this.btnSaveRetVal.Text = "测试SQL并保存返回类";
            this.btnSaveRetVal.UseVisualStyleBackColor = true;
            this.btnSaveRetVal.Click += new System.EventHandler(this.btnSaveRetVal_Click);
            // 
            // btnPreviewReq
            // 
            this.btnPreviewReq.Location = new System.Drawing.Point(259, 290);
            this.btnPreviewReq.Name = "btnPreviewReq";
            this.btnPreviewReq.Size = new System.Drawing.Size(155, 30);
            this.btnPreviewReq.TabIndex = 53;
            this.btnPreviewReq.Text = "预览请求JSON格式";
            this.btnPreviewReq.UseVisualStyleBackColor = true;
            this.btnPreviewReq.Click += new System.EventHandler(this.btnPreviewReq_Click);
            // 
            // skinLVProjects
            // 
            this.skinLVProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinLVProjects.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.skinLVProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.skinLVProjects.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.skinLVProjects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.skinLVProjects.Location = new System.Drawing.Point(6, 39);
            this.skinLVProjects.Margin = new System.Windows.Forms.Padding(0);
            this.skinLVProjects.MultiSelect = false;
            this.skinLVProjects.Name = "skinLVProjects";
            this.skinLVProjects.OwnerDraw = true;
            this.skinLVProjects.RowBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.skinLVProjects.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.skinLVProjects.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinLVProjects.Size = new System.Drawing.Size(217, 245);
            this.skinLVProjects.TabIndex = 55;
            this.skinLVProjects.UseCompatibleStateImageBehavior = false;
            this.skinLVProjects.SelectedIndexChanged += new System.EventHandler(this.skinLVProjects_SelectedIndexChanged);
            // 
            // skinLVInterfaces
            // 
            this.skinLVInterfaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinLVInterfaces.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.skinLVInterfaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.skinLVInterfaces.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.skinLVInterfaces.Location = new System.Drawing.Point(6, 298);
            this.skinLVInterfaces.Margin = new System.Windows.Forms.Padding(0);
            this.skinLVInterfaces.MultiSelect = false;
            this.skinLVInterfaces.Name = "skinLVInterfaces";
            this.skinLVInterfaces.OwnerDraw = true;
            this.skinLVInterfaces.RowBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.skinLVInterfaces.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.skinLVInterfaces.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinLVInterfaces.Size = new System.Drawing.Size(217, 303);
            this.skinLVInterfaces.TabIndex = 56;
            this.skinLVInterfaces.UseCompatibleStateImageBehavior = false;
            this.skinLVInterfaces.SelectedIndexChanged += new System.EventHandler(this.skinLVInterfaces_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(932, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 57;
            this.label1.Text = "可编辑";
            // 
            // FrmMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(985, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skinLVInterfaces);
            this.Controls.Add(this.skinLVProjects);
            this.Controls.Add(this.btnPreviewReq);
            this.Controls.Add(this.btnSaveRetVal);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.edtJson);
            this.Controls.Add(this.skinLVMethods);
            this.Controls.Add(this.skinPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(620, 379);
            this.Name = "FrmMethod";
            this.Text = "FrmMethod";
            this.Load += new System.EventHandler(this.FrmMethod_Load);
            this.skinPanel4.ResumeLayout(false);
            this.skinPanel4.PerformLayout();
            this.skinToolStrip3.ResumeLayout(false);
            this.skinToolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinListView skinLVMethods;
        private CCWin.SkinControl.SkinPanel skinPanel4;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip3;
        private System.Windows.Forms.ToolStripButton tBtnAddMethod;
        private System.Windows.Forms.ToolStripButton tBtnModiMethod;
        private System.Windows.Forms.ToolStripButton tBtnDelMethod;
        private System.Windows.Forms.Label lblPosition;
        private EasyScintilla.SimpleEditor edtJson;
        private System.Windows.Forms.Button btnSaveRetVal;
        private System.Windows.Forms.Button btnPreviewReq;
        private CCWin.SkinControl.SkinListView skinLVProjects;
        private CCWin.SkinControl.SkinListView skinLVInterfaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tBtnRefresh;
    }
}