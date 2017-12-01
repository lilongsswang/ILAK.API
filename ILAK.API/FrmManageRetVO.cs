using ILAK.API.DAL;
using ILAK.API.Model;
using System;
using System.Windows.Forms;

namespace ILAK.API
{
    public partial class FrmManageRetVO : Form
    {
        private HA_RetValObject cobj = null;
        
        public FrmManageRetVO(HA_RetValObject ha_c,string retvname)
        {
            cobj = ha_c;
            InitializeComponent();
            txtName.Text = retvname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("请输入类名");
                    return;
                }

                HA_RetValObjectDAL dal = new HA_RetValObjectDAL();

                if (cobj == null)
                {
                    int ret = dal.AddNew(new HA_RetValObject
                    {
                        rv_name = txtName.Text,
                        rv_exttype = txtExtType.Text,
                        rv_note = txtNote.Text,
                        rv_JSON = txtRetJSON.Text
                    });

                    if (ret < 0)
                    {
                        MessageBox.Show("保存失败 : " + ret);
                    }
                }
                else
                {
                    //UpdateProject
                    bool ret = dal.Update(new HA_RetValObject
                    {
                        rv_name = txtName.Text,
                        rv_exttype = txtExtType.Text,
                        rv_note = txtNote.Text,
                        rv_JSON = txtRetJSON.Text
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
            if (cobj != null)
            {
                txtName.ReadOnly = true;
                txtExtType.Text = cobj.rv_exttype;
                txtName.Text = cobj.rv_name;
                txtNote.Text = cobj.rv_note;
                txtRetJSON.Text = cobj.rv_JSON;
            }


        }
    }
}
