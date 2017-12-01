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
    partial class FrmConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConnection));
            this.skinPanel = new CCWin.SkinControl.SkinPanel();
            this.skinToolStrip3 = new CCWin.SkinControl.SkinToolStrip();
            this.tBtnAddConn = new System.Windows.Forms.ToolStripButton();
            this.tBtnModiConn = new System.Windows.Forms.ToolStripButton();
            this.tBtnDelConn = new System.Windows.Forms.ToolStripButton();
            this.tBtnGenConnStr = new System.Windows.Forms.ToolStripButton();
            this.tBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnSaveBackToConn = new System.Windows.Forms.Button();
            this.txtConnStrGen = new System.Windows.Forms.TextBox();
            this.skinLVConns = new CCWin.SkinControl.SkinListView();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.labelConnStatus = new System.Windows.Forms.Label();
            this.skinPanel.SuspendLayout();
            this.skinToolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel
            // 
            this.skinPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinPanel.Controls.Add(this.skinToolStrip3);
            this.skinPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel.DownBack = null;
            this.skinPanel.Location = new System.Drawing.Point(0, 0);
            this.skinPanel.Margin = new System.Windows.Forms.Padding(0);
            this.skinPanel.MouseBack = null;
            this.skinPanel.Name = "skinPanel";
            this.skinPanel.NormlBack = null;
            this.skinPanel.Size = new System.Drawing.Size(985, 31);
            this.skinPanel.TabIndex = 11;
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
            this.tBtnAddConn,
            this.tBtnModiConn,
            this.tBtnDelConn,
            this.tBtnGenConnStr,
            this.tBtnRefresh});
            this.skinToolStrip3.Location = new System.Drawing.Point(6, 3);
            this.skinToolStrip3.Name = "skinToolStrip3";
            this.skinToolStrip3.Padding = new System.Windows.Forms.Padding(0);
            this.skinToolStrip3.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip3.Size = new System.Drawing.Size(407, 25);
            this.skinToolStrip3.SkinAllColor = true;
            this.skinToolStrip3.TabIndex = 125;
            this.skinToolStrip3.Text = "skinToolStrip3";
            this.skinToolStrip3.TitleAnamorphosis = false;
            this.skinToolStrip3.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip3.TitleRadius = 4;
            this.skinToolStrip3.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // tBtnAddConn
            // 
            this.tBtnAddConn.AutoSize = false;
            this.tBtnAddConn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnAddConn.ForeColor = System.Drawing.Color.Black;
            this.tBtnAddConn.Image = ((System.Drawing.Image)(resources.GetObject("tBtnAddConn.Image")));
            this.tBtnAddConn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnAddConn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnAddConn.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnAddConn.Name = "tBtnAddConn";
            this.tBtnAddConn.Size = new System.Drawing.Size(60, 23);
            this.tBtnAddConn.Text = "新增连接";
            this.tBtnAddConn.Click += new System.EventHandler(this.tBtnAddConn_Click);
            // 
            // tBtnModiConn
            // 
            this.tBtnModiConn.AutoSize = false;
            this.tBtnModiConn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnModiConn.ForeColor = System.Drawing.Color.White;
            this.tBtnModiConn.Image = ((System.Drawing.Image)(resources.GetObject("tBtnModiConn.Image")));
            this.tBtnModiConn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnModiConn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnModiConn.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnModiConn.Name = "tBtnModiConn";
            this.tBtnModiConn.Size = new System.Drawing.Size(60, 23);
            this.tBtnModiConn.Text = "修改连接";
            this.tBtnModiConn.Click += new System.EventHandler(this.tBtnModiConn_Click);
            // 
            // tBtnDelConn
            // 
            this.tBtnDelConn.AutoSize = false;
            this.tBtnDelConn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnDelConn.ForeColor = System.Drawing.Color.White;
            this.tBtnDelConn.Image = ((System.Drawing.Image)(resources.GetObject("tBtnDelConn.Image")));
            this.tBtnDelConn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnDelConn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnDelConn.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnDelConn.Name = "tBtnDelConn";
            this.tBtnDelConn.Size = new System.Drawing.Size(60, 23);
            this.tBtnDelConn.Text = "删除连接";
            this.tBtnDelConn.Click += new System.EventHandler(this.tBtnDelConn_Click);
            // 
            // tBtnGenConnStr
            // 
            this.tBtnGenConnStr.AutoSize = false;
            this.tBtnGenConnStr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnGenConnStr.ForeColor = System.Drawing.Color.White;
            this.tBtnGenConnStr.Image = ((System.Drawing.Image)(resources.GetObject("tBtnGenConnStr.Image")));
            this.tBtnGenConnStr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnGenConnStr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnGenConnStr.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnGenConnStr.Name = "tBtnGenConnStr";
            this.tBtnGenConnStr.Size = new System.Drawing.Size(100, 23);
            this.tBtnGenConnStr.Text = "生成连接字符串↓";
            this.tBtnGenConnStr.Click += new System.EventHandler(this.tBtnGenConnStr_Click);
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
            this.tBtnRefresh.Size = new System.Drawing.Size(100, 23);
            this.tBtnRefresh.Text = "刷新显示";
            this.tBtnRefresh.Click += new System.EventHandler(this.tBtnRefresh_Click);
            // 
            // btnSaveBackToConn
            // 
            this.btnSaveBackToConn.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSaveBackToConn.Location = new System.Drawing.Point(820, 572);
            this.btnSaveBackToConn.Name = "btnSaveBackToConn";
            this.btnSaveBackToConn.Size = new System.Drawing.Size(153, 31);
            this.btnSaveBackToConn.TabIndex = 52;
            this.btnSaveBackToConn.Text = "保存到选中的连接";
            this.btnSaveBackToConn.UseVisualStyleBackColor = true;
            this.btnSaveBackToConn.Click += new System.EventHandler(this.btnSaveBackToConn_Click);
            // 
            // txtConnStrGen
            // 
            this.txtConnStrGen.Font = new System.Drawing.Font("宋体", 12F);
            this.txtConnStrGen.Location = new System.Drawing.Point(0, 478);
            this.txtConnStrGen.Multiline = true;
            this.txtConnStrGen.Name = "txtConnStrGen";
            this.txtConnStrGen.ReadOnly = true;
            this.txtConnStrGen.Size = new System.Drawing.Size(973, 78);
            this.txtConnStrGen.TabIndex = 53;
            // 
            // skinLVConns
            // 
            this.skinLVConns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLVConns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinLVConns.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.skinLVConns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.skinLVConns.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.skinLVConns.Location = new System.Drawing.Point(0, 31);
            this.skinLVConns.Margin = new System.Windows.Forms.Padding(0);
            this.skinLVConns.MultiSelect = false;
            this.skinLVConns.Name = "skinLVConns";
            this.skinLVConns.OwnerDraw = true;
            this.skinLVConns.RowBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.skinLVConns.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.skinLVConns.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinLVConns.Size = new System.Drawing.Size(973, 435);
            this.skinLVConns.TabIndex = 54;
            this.skinLVConns.UseCompatibleStateImageBehavior = false;
            this.skinLVConns.SelectedIndexChanged += new System.EventHandler(this.skinLVConns_SelectedIndexChanged);
            this.skinLVConns.DoubleClick += new System.EventHandler(this.skinLVConns_DoubleClick);
            // 
            // btnTestConn
            // 
            this.btnTestConn.Font = new System.Drawing.Font("宋体", 12F);
            this.btnTestConn.Location = new System.Drawing.Point(661, 572);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(153, 31);
            this.btnTestConn.TabIndex = 55;
            this.btnTestConn.Text = "测试连接";
            this.btnTestConn.UseVisualStyleBackColor = true;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // labelConnStatus
            // 
            this.labelConnStatus.AutoSize = true;
            this.labelConnStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelConnStatus.ForeColor = System.Drawing.Color.Black;
            this.labelConnStatus.Location = new System.Drawing.Point(13, 572);
            this.labelConnStatus.Name = "labelConnStatus";
            this.labelConnStatus.Size = new System.Drawing.Size(16, 16);
            this.labelConnStatus.TabIndex = 56;
            this.labelConnStatus.Text = " ";
            // 
            // FrmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(985, 650);
            this.Controls.Add(this.labelConnStatus);
            this.Controls.Add(this.btnTestConn);
            this.Controls.Add(this.skinLVConns);
            this.Controls.Add(this.txtConnStrGen);
            this.Controls.Add(this.btnSaveBackToConn);
            this.Controls.Add(this.skinPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(620, 379);
            this.Name = "FrmConnection";
            this.Text = "FrmMethod";
            this.Load += new System.EventHandler(this.FrmConnection_Load);
            this.skinPanel.ResumeLayout(false);
            this.skinPanel.PerformLayout();
            this.skinToolStrip3.ResumeLayout(false);
            this.skinToolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinPanel skinPanel;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip3;
        private System.Windows.Forms.ToolStripButton tBtnAddConn;
        private System.Windows.Forms.ToolStripButton tBtnModiConn;
        private System.Windows.Forms.ToolStripButton tBtnDelConn;
        private System.Windows.Forms.ToolStripButton tBtnGenConnStr;
        private System.Windows.Forms.Button btnSaveBackToConn;
        private System.Windows.Forms.TextBox txtConnStrGen;
        private CCWin.SkinControl.SkinListView skinLVConns;
        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.ToolStripButton tBtnRefresh;
        private System.Windows.Forms.Label labelConnStatus;
    }
}