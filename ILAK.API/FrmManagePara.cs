using ILAK.API.DAL;
using ILAK.API.Model;
using System;
using System.Windows.Forms;

namespace ILAK.API
{
    public partial class FrmManagePara : Form
    {
        private HA_Parameter paraobj = null;
        
        public FrmManagePara(HA_Parameter ha_para)
        {
            paraobj = ha_para;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HA_ParameterDAL dal = new HA_ParameterDAL();
                if(string.IsNullOrEmpty(txtParaCode.Text))
                {
                    MessageBox.Show("请输入参数代码");
                    return;
                }
                else if(txtParaCode.Text.Contains(","))
                {
                    MessageBox.Show("请不要输入 , (逗号)");
                    return;
                }
                if (paraobj == null)
                {
                    int ret = dal.AddNew(new HA_Parameter
                    {
                        para_name = txtParaName.Text,
                        para_code = txtParaCode.Text,
                        para_length = txtLength.Text,
                        para_note = txtConnNote.Text,
                        para_required = false,
                        para_datatype = comboDataType.Text,
                        para_default = txtDefaultValue.Text
                    });

                    if (ret < 0)
                    {
                        MessageBox.Show("保存失败 : " + ret);
                    }
                }
                else
                {
                    //UpdateProject
                    bool ret = dal.Update(new HA_Parameter
                    {
                        para_name = txtParaName.Text,
                        para_code = txtParaCode.Text,
                        para_length = txtLength.Text,
                        para_note = txtConnNote.Text,
                        para_required = false,
                        para_datatype = comboDataType.Text,
                        para_default = txtDefaultValue.Text
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
            if (paraobj != null)
            {
                txtParaCode.Text = paraobj.para_code;
                txtParaName.Text = paraobj.para_name;
                txtConnNote.Text = paraobj.para_note;
                comboDataType.Text = paraobj.para_datatype;
                txtLength.Text = paraobj.para_length;
                txtDefaultValue.Text = paraobj.para_default;
            }


        }
    }
}
