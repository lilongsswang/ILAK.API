using ILAK.API.DAL;
using ILAK.API.FrmModel;
using ILAK.API.Model;
using HYD.Hds.Servcie;
using System;
using System.Data;
using System.Windows.Forms;

namespace ILAK.API
{
    public partial class FrmManageMethod : Form
    {
        private HA_Method cobj = null;
        private string intfcode = "";
        public FrmManageMethod(HA_Method ha_c,string intf_code)
        {
            cobj = ha_c;
            InitializeComponent();
            labelIntfCode.Text = intf_code;
            intfcode = intf_code;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCode.Text))
                {
                    MessageBox.Show("请输入代码");
                    return;
                }
                HA_MethodDAL dal = new HA_MethodDAL();
                TempType tt = TempType.Query;

                switch (comboTemplate.Text)
                {
                    case "查询":
                        tt = TempType.Query;
                        break;
                    case "增删改":
                        tt = TempType.CDUA;
                        break;
                    case "存储过程":
                        tt = TempType.SP;
                        break;
                    default:
                        break;
                }
                if (cobj == null)
                {
                    int ret = dal.AddNew(new HA_Method
                    {
                        intf_code = intfcode,
                        m_code = txtCode.Text,
                        m_desc = txtDesc.Text,
                        m_reqtype = txtReqType.Text,
                        m_template = (int)tt,
                        m_rtnvaluecode = "ret" + txtCode.Text,
                        m_arggrpcode = comboAGGCode.Text,
                        m_isencrypted = false,
                        m_funcode = txtFunCode.Text,
                        m_name = txtName.Text,
                        m_version = "",
                        m_pagesize = Convert.ToInt32(txtPageSize.Text)
                    });

                    if (ret < 0)
                    {
                        MessageBox.Show("保存失败 : " + ret);
                    }
                    HA_RetValObjectDAL voDAL = new HA_RetValObjectDAL();
                    string exttype = "";
                    switch (tt)
                    {
                        case TempType.Query:
                            exttype = "BaseObj";
                            break;
                        case TempType.CDUA:
                            exttype = "BaseObj";
                            break;
                        case TempType.SP:
                            exttype = "BaseObj";
                            break;
                        default:
                            break;
                    }

                    ret = voDAL.AddNew(new HA_RetValObject
                    {
                        rv_name = "ret"+txtCode.Text,
                        rv_exttype = exttype,
                        rv_note = "Orignal",
                        rv_JSON = ""
                    });

                    if (ret < 0)
                    {
                        MessageBox.Show("保存失败 : " + ret);
                    }

                }
                else
                {
                    //UpdateProject
                    bool ret = dal.Update(new HA_Method
                    {
                        intf_code = intfcode,
                        m_code = txtCode.Text,
                        m_desc = txtDesc.Text,
                        m_reqtype = txtReqType.Text,
                        m_template = (int)tt,
                        m_rtnvaluecode = txtRetVO.Text,
                        m_arggrpcode = comboAGGCode.Text,
                        m_isencrypted = false,
                        m_funcode = txtFunCode.Text,
                        m_name = txtName.Text,
                        m_version = "",
                        m_pagesize = Convert.ToInt32(txtPageSize.Text)
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
            DbService db = DB.GetMainDb();
            DataSet ags = db.ExecuteSqlID("GetSimpleAGs", null);
            DataTable AGs = null;
            if (ags != null && ags.Tables.Count > 0)
            {
                AGs = ags.Tables[0];
                comboAGGCode.DisplayMember = "Index";
                comboAGGCode.ValueMember = "Index";
                comboAGGCode.DataSource = AGs;
            }
            //DataSet rvs = db.ExecuteSqlID("GetSimpleRetVOs", null);
            //DataTable RVs = null;
            //if (rvs != null && rvs.Tables.Count > 0)
            //{
            //    RVs = rvs.Tables[0];
            //    comboRetVO.DisplayMember = "Name";
            //    comboRetVO.ValueMember = "Name";
            //    comboRetVO.DataSource = RVs;
            //}
            if (cobj != null)
            {
                txtName.Text = cobj.m_name;
                txtCode.Text = cobj.m_code;
                txtRetVO.Text = cobj.m_rtnvaluecode;
                txtDesc.Text = cobj.m_desc;
                //txtReqType.Text = cobj.m_reqtype;
                txtPageSize.Text = cobj.m_pagesize.ToString();
                comboTemplate.Enabled = false;
                string preType = "";
                switch (cobj.m_template)
                {
                    case (int)TempType.Query:
                        preType = "查询";
                        break;
                    case (int)TempType.CDUA:
                        preType = "增删改";
                        break;
                    case (int)TempType.SP:
                        preType = "存储过程";
                        break;
                    default:
                        break;
                }

                comboTemplate.Text = preType; // cobj.m_template.ToString();
                comboAGGCode.Text = cobj.m_arggrpcode;
                txtFunCode.Text = cobj.m_funcode;
            }


        }
    }
}
