using ILAK.API.DAL;
using ILAK.API.Model;
using HYD.Hds.Servcie;
using System;
using System.Windows.Forms;

namespace ILAK.API
{
    public partial class FrmManageProj : Form
    {
        private HA_Project projobj = null;
        public FrmManageProj(HA_Project ha_project)
        {
            projobj = ha_project;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtProjCode.Text))
                {
                    MessageBox.Show("请输入代码");
                    return;
                }
                //db = DB.GetMainDb();
                //Hashtable htPara = new Hashtable();
                //htPara.Add("proj_name", txtProjName.Text);
                //htPara.Add("proj_code", txtProjCode.Text);
                //htPara.Add("proj_note", txtProjNote.Text);
                HA_ProjectDAL dal = new HA_ProjectDAL();
                if (projobj == null)
                {
                    int ret = dal.AddNew(new HA_Project
                    {
                        proj_code = txtProjCode.Text,
                        proj_name = txtProjName.Text,
                        proj_note = txtProjNote.Text,
                        proj_port = Convert.ToInt32(txtPort.Text)
                    });
                    //int ret = db.ExecuteNonQueryID("InsertProject", htPara);
                }
                else
                {
                    //UpdateProject
                    bool ret = dal.Update(new HA_Project
                    {
                        proj_code = txtProjCode.Text,
                        proj_name = txtProjName.Text,
                        proj_note = txtProjNote.Text,
                        proj_port = Convert.ToInt32(txtPort.Text)
                    });
                    //int ret = db.ExecuteNonQueryID("UpdateProject", htPara);

                    if (ret == false)
                    {
                        MessageBox.Show("修改失败 : " + ret);
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
            if (projobj != null)
            {
                txtProjCode.Enabled = false;
                txtProjCode.Text = projobj.proj_code;
                txtProjName.Text = projobj.proj_name;
                txtProjNote.Text = projobj.proj_note;
                txtPort.Text = projobj.proj_port.ToString();
            }
        }
    }
}
