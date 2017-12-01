using System;
using System.Windows.Forms;
using HYD.Hds.Servcie;
using System.Collections;
using ILAK.API.Model;
using ILAK.API.DAL;

namespace ILAK.API
{
    public partial class FrmProject : Form
    {
        private BizConfig bc = new BizConfig();
        public FrmProject()
        {
            InitializeComponent();
            SetStyles();
        }
        #region 减少闪烁
        //减少闪烁
        private void SetStyles()
        {
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
            c.ShowDataTableInListView(BizConfig.Projects, listVProjects);
            c.ShowDataTableInListView(BizConfig.Interfaces, skinLVInterfaces);
        }

        private void ReloadProjects()
        {
            try
            {
                Controller c = new Controller();
                c.RefreshListViewFromSqlIDWithOutParas(BizConfig.Projects, listVProjects, "GetProjects");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ReloadInterface(string projcode)
        {
            try
            {
                Controller c = new Controller();
                Hashtable htPara = new Hashtable();
                htPara.Add("proj_code", projcode);
                c.RefreshListViewFromSqlIDWithParas(BizConfig.Interfaces, skinLVInterfaces, "GetInterface", htPara);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listVProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVProjects.SelectedItems.Count > 0)
            {
                var a = listVProjects.SelectedItems[0];
                string projcode = a.Text;
                DbService db = null;
                db = DB.GetMainDb();
                try
                {
                    Hashtable htPara = new Hashtable();
                    htPara.Add("AntiSqlInject", "0");
                    htPara.Add("proj_code", projcode);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    db.Close();
                }
                ReloadInterface(projcode);
            }
        }

        private void tBtnAddProj_Click(object sender, EventArgs e)
        {
            FrmManageProj addprojForm = new FrmManageProj(null);
            addprojForm.ShowDialog();
            ReloadProjects();
        }

        private void tBtnModiProj_Click(object sender, EventArgs e)
        {
            if (listVProjects.SelectedItems.Count > 0)
            {
                var a = listVProjects.SelectedItems[0];
                HA_Project ha_project = new HA_Project
                {
                    proj_code = a.SubItems[0].Text,
                    proj_name = a.SubItems[1].Text,
                    proj_port = Convert.ToInt32(a.SubItems[2].Text),
                    proj_note = a.SubItems[3].Text
                };

                FrmManageProj addprojForm = new FrmManageProj(ha_project);
                addprojForm.ShowDialog();
                ReloadProjects();
            }
        }

        private void tBtnDelProj_Click(object sender, EventArgs e)
        {
            if (listVProjects.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("是否要删除该项目?", "项目删除提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var a = listVProjects.SelectedItems[0];

                    DbService db = null;
                    db = DB.GetMainDb();
                    Hashtable htPara = new Hashtable();
                    htPara.Add("proj_code", a.SubItems[0].Text);

                    int count = (int)db.ExecuteScalarID("CountIntfNumbers", htPara);
                    if (count > 0)
                    {
                        MessageBox.Show("项目下还存在接口的定义，请先删除项目下的接口");
                        return;
                    }

                    HA_ProjectDAL dal = new HA_ProjectDAL();
                    if (dal.Delete(a.SubItems[0].Text))
                        ReloadProjects();
                }
            }
        }

        private void tBtnAddIntf_Click(object sender, EventArgs e)
        {
            if (listVProjects.SelectedItems.Count > 0)
            {
                var a = listVProjects.SelectedItems[0];
                FrmManageIntf manageIntfFomr = new FrmManageIntf(null, a.SubItems[0].Text);
                manageIntfFomr.ShowDialog();
                ReloadInterface(a.SubItems[0].Text);
            }
        }

        private void tBtnEditIntf_Click(object sender, EventArgs e)
        {
            if (listVProjects.SelectedItems.Count > 0 && skinLVInterfaces.SelectedItems.Count > 0)
            {
                var proj = listVProjects.SelectedItems[0];
                var a = skinLVInterfaces.SelectedItems[0];

                HA_Interface ha_intf = new HA_Interface
                {
                    proj_code = proj.SubItems[0].Text,
                    intf_name = a.SubItems[2].Text,
                    intf_code = a.SubItems[3].Text,
                    intf_namespace = a.SubItems[4].Text,
                    intf_version = a.SubItems[5].Text,
                    intf_auth = a.SubItems[6].Text,
                    intf_dbconn = a.SubItems[7].Text,
                    intf_note = a.SubItems[8].Text
                };

                FrmManageIntf manageIntfFomr = new FrmManageIntf(ha_intf, proj.SubItems[0].Text);
                manageIntfFomr.ShowDialog();
                ReloadInterface(proj.SubItems[0].Text);
            }
        }

        private void tBtnDelIntf_Click(object sender, EventArgs e)
        {
            if (listVProjects.SelectedItems.Count > 0 && skinLVInterfaces.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("是否要删除该接口?", "接口删除提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var proj = listVProjects.SelectedItems[0];
                    var a = skinLVInterfaces.SelectedItems[0];


                    DbService db = null;
                    db = DB.GetMainDb();
                    Hashtable htPara = new Hashtable();
                    htPara.Add("intf_code", a.SubItems[3].Text);

                    int count = (int)db.ExecuteScalarID("CountMethodNumbers", htPara);
                    if (count > 0)
                    {
                        MessageBox.Show("接口下还存在方法的定义，请先删除接口下的方法");
                        return;
                    }

                    HA_InterfaceDAL dal = new HA_InterfaceDAL();
                    if (dal.Delete(a.SubItems[3].Text))
                    {
                        ReloadInterface(proj.SubItems[0].Text);
                    }
                }
            }
        }

        private void listVProjects_DoubleClick(object sender, EventArgs e)
        {
            if (listVProjects.SelectedItems.Count > 0)
            {
                var a = listVProjects.SelectedItems[0];
                HA_Project ha_project = new HA_Project
                {
                    proj_code = a.SubItems[0].Text,
                    proj_name = a.SubItems[1].Text,
                    proj_port = Convert.ToInt32(a.SubItems[2].Text),
                    proj_note = a.SubItems[3].Text
                };

                FrmManageProj addprojForm = new FrmManageProj(ha_project);
                addprojForm.ShowDialog();
                ReloadProjects();
            }
        }

        private void skinLVInterfaces_DoubleClick(object sender, EventArgs e)
        {
            if (listVProjects.SelectedItems.Count > 0 && skinLVInterfaces.SelectedItems.Count > 0)
            {
                var proj = listVProjects.SelectedItems[0];
                var a = skinLVInterfaces.SelectedItems[0];

                HA_Interface ha_intf = new HA_Interface
                {
                    proj_code = proj.SubItems[0].Text,
                    intf_name = a.SubItems[2].Text,
                    intf_code = a.SubItems[3].Text,
                    intf_namespace = a.SubItems[4].Text,
                    intf_version = a.SubItems[5].Text,
                    intf_auth = a.SubItems[6].Text,
                    intf_dbconn = a.SubItems[7].Text,
                    intf_note = a.SubItems[8].Text
                };

                FrmManageIntf manageIntfFomr = new FrmManageIntf(ha_intf, proj.SubItems[0].Text);
                manageIntfFomr.ShowDialog();
                ReloadInterface(proj.SubItems[0].Text);
            }
        }

        private void tBtnRefresh_Click(object sender, EventArgs e)
        {
            ReloadProjects();
        }
    }
}
