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
 * * 说明：FrmBbx.cs
 * *
********************************************************************/

using System;
using System.Data;
using System.Windows.Forms;
using HYD.Hds.Servcie;
using System.Collections;
using ILAK.API.Model;
using ILAK.API.DAL;

namespace ILAK.API
{
    public partial class FrmAGPara : Form
    {
        private DbService db = null;
        public FrmAGPara() {
            InitializeComponent();
            SetStyles();
        }
        #region 减少闪烁
        //减少闪烁
        private void SetStyles() {
            base.SetStyle(
              ControlStyles.UserPaint |
              ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.ResizeRedraw |
              ControlStyles.DoubleBuffer, true);
            base.UpdateStyles();
            base.AutoScaleMode = AutoScaleMode.None;
        }
        #endregion

        private void FrmProject_Load(object sender, EventArgs e)
        {
            Controller c = new Controller();
            db = DB.GetMainDb();
            DataSet ags = db.ExecuteSqlID("GetAGs", null);
            DataTable AGs = null;
            if (ags != null && ags.Tables.Count > 0)
            {
                AGs = ags.Tables[0];
                c.ShowDataTableInListView(AGs, listVAGs);
            }
            DataSet paras = db.ExecuteSqlID("GetParas", null);
            DataTable Paras = null;
            if (paras != null && paras.Tables.Count > 0)
            {
                Paras = paras.Tables[0];

                c.ShowDataTableInListView(Paras, skinLVParas);
            }
        }

        private void ReloadAGs()
        {
            try
            {
                Controller c = new Controller();
                c.RefreshListViewFromSqlIDWithOutParas(null, listVAGs, "GetAGs");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ReloadParameter(string agcode)
        {
            try
            {
                Controller c = new Controller();
                Hashtable htPara = new Hashtable();
                htPara.Add("ag_code", agcode);
                c.RefreshListViewFromSqlIDWithParas(null, skinLVParas, "GetParasWithAgCode", htPara);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void listVProjects_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void tBtnAddProj_Click(object sender, EventArgs e)
        {
            FrmManageAG addprojForm = new FrmManageAG(null);
            addprojForm.ShowDialog();
            ReloadAGs();
        }

        private void tBtnModiProj_Click(object sender, EventArgs e)
        {
            if (listVAGs.SelectedItems.Count > 0)
            {
                var a = listVAGs.SelectedItems[0];
                HA_ArgGroup ha_ag = new HA_ArgGroup
                {
                    ag_code = a.SubItems[0].Text,
                    ag_name = a.SubItems[1].Text,
                    ag_paras = a.SubItems[2].Text,
                    ag_note = a.SubItems[3].Text
                };

                FrmManageAG agForm = new FrmManageAG(ha_ag);
                agForm.ShowDialog();
                ReloadAGs();
            }
        }

        private void tBtnDelProj_Click(object sender, EventArgs e)
        {
            if (listVAGs.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("是否要删除该参数组?", "参数组删除提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var a = listVAGs.SelectedItems[0];
                    DbService db = null;
                    db = DB.GetMainDb();
                    Hashtable htPara = new Hashtable();
                    htPara.Add("ag_code", a.SubItems[0].Text);

                    int count = (int)db.ExecuteScalarID("CountAGNumbers", htPara);
                    if (count > 0)
                    {
                        MessageBox.Show("还有" + count.ToString() + "个方法在使用该参数组,避免出错，请先检查方法");
                        return;
                    }
                    HA_ArgGroupDAL dal = new HA_ArgGroupDAL();
                    if (dal.Delete(a.SubItems[0].Text))
                        ReloadAGs();
                }
            }
        }

        private void tBtnAddIntf_Click(object sender, EventArgs e)
        {
            FrmManagePara manageIntfFomr = new FrmManagePara(null);
            manageIntfFomr.ShowDialog();
            ShowAllParameters();
        }

        private void tBtnEditIntf_Click(object sender, EventArgs e)
        {
            if (skinLVParas.SelectedItems.Count > 0)
            {
                var a = skinLVParas.SelectedItems[0];
                
                HA_Parameter ha_para = new HA_Parameter
                {
                     para_code = a.SubItems[0].Text,
                    para_name = a.SubItems[1].Text,
                    para_datatype = a.SubItems[2].Text,
                    para_length = a.SubItems[3].Text,
                    para_default = a.SubItems[4].Text,
                    para_note = a.SubItems[5].Text,
                    para_required = false
                };

                FrmManagePara manageIntfFomr = new FrmManagePara(ha_para);
                manageIntfFomr.ShowDialog();
                ShowAllParameters();
            }
        }

        private void tBtnDelIntf_Click(object sender, EventArgs e)
        {
            if (skinLVParas.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("是否要删除该参数?", "参数删除提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //listVAGs.SelectedItems.Count > 0
                    //var proj = listVAGs.SelectedItems[0];
                    var a = skinLVParas.SelectedItems[0];

                    DbService db = null;
                    db = DB.GetMainDb();
                    Hashtable htPara = new Hashtable();
                    htPara.Add("para_code", a.SubItems[0].Text);

                    int count = (int)db.ExecuteScalarID("CountParaNumbers", htPara);
                    if (count > 0)
                    {
                        MessageBox.Show("还有"+count.ToString()+"个参数组在使用该参数,避免出错，请先检查参数组");
                        return;
                    }

                    HA_ParameterDAL dal = new HA_ParameterDAL();
                    if (dal.Delete(a.SubItems[0].Text))
                    {
                        ShowAllParameters();// ReloadParameter(proj.SubItems[0].Text);
                    }
                }
            }
        }

        private void tBtnShowAllParas_Click(object sender, EventArgs e)
        {
            ShowAllParameters();
        }

        private void ShowAllParameters()
        {
            Controller c = new Controller();
            DataSet paras = db.ExecuteSqlID("GetParas", null);
            DataTable Paras = null;
            if (paras != null && paras.Tables.Count > 0)
            {
                Paras = paras.Tables[0];
                c.ShowDataTableInListView(Paras, skinLVParas);
            }
        }

        private void listVAGs_DoubleClick(object sender, EventArgs e)
        {
            if (listVAGs.SelectedItems.Count > 0)
            {
                var a = listVAGs.SelectedItems[0];
                HA_ArgGroup ha_ag = new HA_ArgGroup
                {
                    ag_code = a.SubItems[0].Text,
                    ag_name = a.SubItems[1].Text,
                    ag_paras = a.SubItems[2].Text,
                    ag_note = a.SubItems[3].Text
                };

                FrmManageAG agForm = new FrmManageAG(ha_ag);
                agForm.ShowDialog();
                ReloadAGs();
            }
        }

        private void skinLVParas_DoubleClick(object sender, EventArgs e)
        {
            if (skinLVParas.SelectedItems.Count > 0)
            {
                var a = skinLVParas.SelectedItems[0];

                HA_Parameter ha_para = new HA_Parameter
                {
                    para_code = a.SubItems[0].Text,
                    para_name = a.SubItems[1].Text,
                    para_datatype = a.SubItems[2].Text,
                    para_length = a.SubItems[3].Text,
                    para_default = a.SubItems[4].Text,
                    para_note = a.SubItems[5].Text,
                    para_required = false
                };

                FrmManagePara manageIntfFomr = new FrmManagePara(ha_para);
                manageIntfFomr.ShowDialog();
                ShowAllParameters();
            }
        }

        private void sBtnDisplayParas_Click(object sender, EventArgs e)
        {
            if (listVAGs.SelectedItems.Count > 0)
            {
                var a = listVAGs.SelectedItems[0];
                string agcode = a.Text;
                DbService db = null;
                db = DB.GetMainDb();
                try
                {
                    Hashtable htPara = new Hashtable();
                    htPara.Add("AntiSqlInject", "0");
                    htPara.Add("ag_code", agcode);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    db.Close();
                }
                ReloadParameter(agcode);
            }
        }
    }
}
