using ILAK.API.DAL;
using ILAK.API.Model;
using System;
using System.Windows.Forms;

namespace ILAK.API
{
    public partial class FrmManageAG : Form
    {
        private HA_ArgGroup agobj = null;
        
        public FrmManageAG(HA_ArgGroup ha_ag)
        {
            agobj = ha_ag;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HA_ArgGroupDAL dal = new HA_ArgGroupDAL();
                if (string.IsNullOrEmpty(txtAGCode.Text))
                {
                    MessageBox.Show("请输入代码");
                    return;
                }
                if (agobj == null)
                {
                    int ret = dal.AddNew(new HA_ArgGroup
                    {
                        ag_code = txtAGCode.Text,
                        ag_name = txtAGName.Text,
                        ag_paras = txtParas.Text,
                        ag_note = txtAGNote.Text
                    });

                    if (ret < 0)
                    {
                        MessageBox.Show("保存失败 : " + ret);
                    }
                }
                else
                {
                    //UpdateProject
                    bool ret = dal.Update(new HA_ArgGroup
                    {
                        ag_code = txtAGCode.Text,
                        ag_name = txtAGName.Text,
                        ag_paras = txtParas.Text,
                        ag_note = txtAGNote.Text
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
            if (agobj != null)
            {
                txtAGCode.ReadOnly = true;
                txtAGCode.Text = agobj.ag_code;
                txtAGName.Text = agobj.ag_name;
                txtAGNote.Text = agobj.ag_note;
                txtParas.Text = agobj.ag_paras;
            }


        }
    }
}
