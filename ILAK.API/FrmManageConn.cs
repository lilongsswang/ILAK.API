using ILAK.API.DAL;
using ILAK.API.Model;
using System;
using System.Windows.Forms;

namespace ILAK.API
{
    public partial class FrmManageConn : Form
    {
        private HA_Connection cobj = null;

        public FrmManageConn(HA_Connection ha_c,string connName)
        {
            cobj = ha_c;
            InitializeComponent();
            txtConnName.Text = connName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HA_ConnectionDAL dal = new HA_ConnectionDAL();
                if (string.IsNullOrEmpty(txtConnName.Text))
                {
                    MessageBox.Show("请输入连接名称");
                    return;
                }
                if (cobj == null)
                {
                    int ret = dal.AddNew(new HA_Connection
                    {
                        conn_name = txtConnName.Text,
                        conn_IP = txtConnIP.Text,
                        conn_DBType = comboDBType.Text,
                        conn_CType = txtCType.Text,
                        conn_Account = txtConnAccount.Text,
                        conn_note = txtConnNote.Text,
                        conn_Alias = txtDBName.Text,
                        conn_Password = txtPassword.Text,
                        conn_String = ""
                    });

                    if (ret < 0)
                    {
                        MessageBox.Show("保存失败 : " + ret);
                    }
                }
                else
                {
                    //UpdateProject
                    bool ret = dal.Update(new HA_Connection
                    {
                        conn_name = txtConnName.Text,
                        conn_IP = txtConnIP.Text,
                        conn_DBType = comboDBType.Text,
                        conn_CType = txtCType.Text,
                        conn_Account = txtConnAccount.Text,
                        conn_note = txtConnNote.Text,
                        conn_Alias = txtDBName.Text,
                        conn_Password = txtPassword.Text,
                        conn_String = txtConnStr.Text
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
                txtConnName.ReadOnly = true;
                txtConnIP.Text = cobj.conn_IP;
                txtConnName.Text = cobj.conn_name;
                txtConnNote.Text = cobj.conn_note;
                comboDBType.Text = cobj.conn_DBType;
                txtCType.Text = cobj.conn_CType;
                txtConnAccount.Text = cobj.conn_Account;
                txtPassword.Text = cobj.conn_Password;
                txtConnStr.Text = cobj.conn_String;
                txtDBName.Text = cobj.conn_Alias;
            }


        }
    }
}
