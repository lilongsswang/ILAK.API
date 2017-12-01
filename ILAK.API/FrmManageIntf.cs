using ILAK.API.DAL;
using ILAK.API.Model;
using HYD.Hds.Servcie;
using System;
using System.Data;
using System.Windows.Forms;

namespace ILAK.API
{
    public partial class FrmManageIntf : Form
    {
        private HA_Interface intfobj = null;
        
        public FrmManageIntf(HA_Interface ha_intf, string proj_code)
        {
            intfobj = ha_intf;
            InitializeComponent();
            labelProjCode.Text = proj_code;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIntfCode.Text))
                {
                    MessageBox.Show("请输入代码");
                    return;
                }
                HA_InterfaceDAL dal = new HA_InterfaceDAL();

                if (intfobj == null)
                {
                    int ret = dal.AddNew(new HA_Interface
                    {
                        intf_code = txtIntfCode.Text,
                        intf_name = txtIntfName.Text,
                        intf_namespace = txtNameSpace.Text,
                        intf_dbconn = comboServIP.Text,
                        intf_version = txtVersion.Text,
                        intf_auth = "HydAdmin",
                        intf_note = txtIntfNote.Text,
                        proj_code = labelProjCode.Text
                    });

                    if (ret < 0)
                    {
                        MessageBox.Show("保存失败 : " + ret);
                    }
                }
                else
                {
                    //UpdateProject
                    bool ret = dal.Update(new HA_Interface
                    {
                        intf_code = txtIntfCode.Text,
                        intf_name = txtIntfName.Text,
                        intf_namespace = txtNameSpace.Text,
                        intf_dbconn = comboServIP.Text,
                        intf_version = txtVersion.Text,
                        intf_auth = "HydAdmin",
                        intf_note = txtIntfNote.Text,
                        proj_code = labelProjCode.Text
                    });

                    if (ret == false)
                    {
                        MessageBox.Show("保存失败 : " + ret);
                    }
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败 : "+ex.Message);
            }
        }

        private void FrmAddProj_Load(object sender, EventArgs e)
        {
            try
            {
                DbService db = DB.GetMainDb();
                DataSet s = db.ExecuteSqlID("GetSimpleConns", null);
                DataTable S = null;
                if (s != null && s.Tables.Count > 0)
                {
                    S = s.Tables[0];
                    comboServIP.DisplayMember = "ConnName";
                    comboServIP.ValueMember = "ConnName";
                    comboServIP.DataSource = S;
                }
                //comboServIP.DataSource
                if (intfobj != null)
                {
                    txtIntfCode.Enabled = false;
                    txtIntfCode.Text = intfobj.intf_code;
                    txtIntfName.Text = intfobj.intf_name;
                    txtIntfNote.Text = intfobj.intf_note;
                    txtNameSpace.Text = intfobj.intf_name;
                    comboServIP.Text = intfobj.intf_dbconn;
                    txtVersion.Text = intfobj.intf_version;
                }
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }
        }
    }
}
