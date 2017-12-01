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
    partial class FrmRetVO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRetVO));
            this.skinPanel4 = new CCWin.SkinControl.SkinPanel();
            this.skinToolStrip3 = new CCWin.SkinControl.SkinToolStrip();
            this.tBtnModiClass = new System.Windows.Forms.ToolStripButton();
            this.tBtnDelClass = new System.Windows.Forms.ToolStripButton();
            this.tBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.txtConnStrGen = new System.Windows.Forms.TextBox();
            this.skinLVRetVO = new CCWin.SkinControl.SkinListView();
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
            this.tBtnModiClass,
            this.tBtnDelClass,
            this.tBtnRefresh});
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
            // tBtnModiClass
            // 
            this.tBtnModiClass.AutoSize = false;
            this.tBtnModiClass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnModiClass.ForeColor = System.Drawing.Color.White;
            this.tBtnModiClass.Image = ((System.Drawing.Image)(resources.GetObject("tBtnModiClass.Image")));
            this.tBtnModiClass.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnModiClass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnModiClass.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnModiClass.Name = "tBtnModiClass";
            this.tBtnModiClass.Size = new System.Drawing.Size(60, 23);
            this.tBtnModiClass.Text = "修改类";
            this.tBtnModiClass.Click += new System.EventHandler(this.tBtnModiConn_Click);
            // 
            // tBtnDelClass
            // 
            this.tBtnDelClass.AutoSize = false;
            this.tBtnDelClass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBtnDelClass.ForeColor = System.Drawing.Color.White;
            this.tBtnDelClass.Image = ((System.Drawing.Image)(resources.GetObject("tBtnDelClass.Image")));
            this.tBtnDelClass.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tBtnDelClass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnDelClass.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tBtnDelClass.Name = "tBtnDelClass";
            this.tBtnDelClass.Size = new System.Drawing.Size(60, 23);
            this.tBtnDelClass.Text = "删除类";
            this.tBtnDelClass.Click += new System.EventHandler(this.tBtnDelConn_Click);
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
            // txtConnStrGen
            // 
            this.txtConnStrGen.Font = new System.Drawing.Font("宋体", 12F);
            this.txtConnStrGen.Location = new System.Drawing.Point(0, 478);
            this.txtConnStrGen.Multiline = true;
            this.txtConnStrGen.Name = "txtConnStrGen";
            this.txtConnStrGen.ReadOnly = true;
            this.txtConnStrGen.Size = new System.Drawing.Size(973, 116);
            this.txtConnStrGen.TabIndex = 53;
            // 
            // skinLVRetVO
            // 
            this.skinLVRetVO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLVRetVO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinLVRetVO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.skinLVRetVO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinLVRetVO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.skinLVRetVO.GridLines = true;
            this.skinLVRetVO.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.skinLVRetVO.Location = new System.Drawing.Point(0, 31);
            this.skinLVRetVO.Margin = new System.Windows.Forms.Padding(0);
            this.skinLVRetVO.MultiSelect = false;
            this.skinLVRetVO.Name = "skinLVRetVO";
            this.skinLVRetVO.OwnerDraw = true;
            this.skinLVRetVO.RowBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.skinLVRetVO.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.skinLVRetVO.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinLVRetVO.Size = new System.Drawing.Size(973, 435);
            this.skinLVRetVO.TabIndex = 54;
            this.skinLVRetVO.UseCompatibleStateImageBehavior = false;
            this.skinLVRetVO.DoubleClick += new System.EventHandler(this.skinLVRetVO_DoubleClick);
            // 
            // FrmRetVO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(985, 650);
            this.Controls.Add(this.skinLVRetVO);
            this.Controls.Add(this.txtConnStrGen);
            this.Controls.Add(this.skinPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(620, 379);
            this.Name = "FrmRetVO";
            this.Text = "FrmMethod";
            this.Load += new System.EventHandler(this.FrmConnection_Load);
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
        private System.Windows.Forms.ToolStripButton tBtnModiClass;
        private System.Windows.Forms.ToolStripButton tBtnDelClass;
        private System.Windows.Forms.TextBox txtConnStrGen;
        private CCWin.SkinControl.SkinListView skinLVRetVO;
        private System.Windows.Forms.ToolStripButton tBtnRefresh;
    }
}