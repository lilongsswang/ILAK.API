
using ILAK.API.DAL;
using ILAK.API.Model;
using ILAK.API.UI.Helpers;
using HYD.Hds.Servcie;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SqlSugar;
using System.IO;
using System.Configuration;
using ILAK.API.FrmModel;
using ILAK.API.Helpers;

namespace ILAK.API
{
    public partial class FrmMethod : Form
    {
        public FrmMethod()
        {
            InitializeComponent();
            SetStyles();
            InitialiseSyntaxHighlightingEditor();
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

        private void InitialiseSyntaxHighlightingEditor()
        {
            edtJson.Styler = new JsonStyler();              // The thing that sets Json syntax highlighting
            edtJson.Text = string.Empty;                    // Clear any developer entered dummy data
            edtJson.SetSavePoint();                         // Show the buffer has not been changed.
        }
        private void edtJson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                edtJson.SelectionStart = 0;
                edtJson.SelectionEnd = edtJson.TextLength;
                e.Handled = true;
            }
        }

        private void EditorPositionChanged(object sender, EventArgs e) { UpdateCursorPosition(); }

        private void UpdateCursorPosition()
        {
            lblPosition.Text = $"{edtJson.CurrentLine + 1}/{edtJson.GetColumn(edtJson.CurrentPosition) + 1}";
        }

        private void tBtnAddMethod_Click(object sender, EventArgs e)
        {
            if (skinLVInterfaces.SelectedItems.Count > 0)
            {
                var a = skinLVInterfaces.SelectedItems[0];
                HA_MethodDAL dal = new HA_MethodDAL();
                FrmManageMethod methodForm = new FrmManageMethod(null, a.Text);
                methodForm.ShowDialog();
                if (a == null) return;
                ReloadMethod(a.Text);
            }
            else
            {
                MessageBox.Show("请选择需要添加方法的接口");
            }
            //dal.AddNew()
        }

        private void FrmMethod_Load(object sender, EventArgs e)
        {
            Controller c = new Controller();
            DbService db = null;
            try
            {
                db = DB.GetMainDb();
                DataSet projects = db.ExecuteSqlID("GetProjectsSimple", null);
                DataTable Projects = null;
                if (projects != null && projects.Tables.Count > 0)
                {
                    Projects = projects.Tables[0];
                    c.ShowDataTableInListView(Projects, skinLVProjects);
                }

                DataSet interfaces = db.ExecuteSqlID("GetInterfacesSimple", null);
                DataTable Interfaces = null;
                if (interfaces != null && interfaces.Tables.Count > 0)
                {
                    Interfaces = interfaces.Tables[0];
                    c.ShowDataTableInListView(Interfaces, skinLVInterfaces);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void skinLVProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skinLVProjects.SelectedItems.Count > 0)
            {
                var a = skinLVProjects.SelectedItems[0];
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

        private void skinLVInterfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skinLVInterfaces.SelectedItems.Count > 0)
            {
                var a = skinLVInterfaces.SelectedItems[0];
                string intfcode = a.Text;
                DbService db = null;
                db = DB.GetMainDb();
                try
                {
                    Hashtable htPara = new Hashtable();
                    htPara.Add("AntiSqlInject", "0");
                    htPara.Add("intf_code", intfcode);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    db.Close();
                }
                ReloadMethod(intfcode);
            }
        }

        private void ReloadInterface(string projcode)
        {
            try
            {
                Controller c = new Controller();
                Hashtable htPara = new Hashtable();
                htPara.Add("proj_code", projcode);
                c.RefreshListViewFromSqlIDWithParas(null, skinLVInterfaces, "GetInterfaceSimple", htPara);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReloadMethod(string intfcode)
        {
            try
            {
                Controller c = new Controller();
                Hashtable htPara = new Hashtable();
                htPara.Add("intf_code", intfcode);
                c.RefreshListViewFromSqlIDWithParas(null, skinLVMethods, "GetMethod", htPara);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBtnModiMethod_Click(object sender, EventArgs e)
        {
            if (skinLVMethods.SelectedItems.Count > 0 && skinLVInterfaces.SelectedItems.Count > 0)
            {
                var a = skinLVMethods.SelectedItems[0];
                var intf = skinLVInterfaces.SelectedItems[0];
                HA_Method ha_method = new HA_Method
                {
                    intf_code = a.SubItems[0].Text,
                    m_name = a.SubItems[1].Text,
                    m_code = a.SubItems[2].Text,
                    m_desc = a.SubItems[3].Text,
                    //m_reqtype = a.SubItems[4].Text,
                    m_template = Convert.ToInt32(a.SubItems[4].Text),
                    m_version = a.SubItems[5].Text,
                    m_funcode = a.SubItems[6].Text,
                    m_isencrypted = false, //a.SubItems[2].Text,
                    m_arggrpcode = a.SubItems[8].Text,
                    m_rtnvaluecode = a.SubItems[9].Text,
                    m_pagesize = Convert.ToInt32(a.SubItems[10].Text)
                };

                FrmManageMethod addprojForm = new FrmManageMethod(ha_method, intf.Text);
                addprojForm.ShowDialog();
                ReloadMethod(intf.Text);
            }
        }

        private void tBtnDelMethod_Click(object sender, EventArgs e)
        {
            if (skinLVMethods.SelectedItems.Count > 0 && skinLVInterfaces.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("是否要删除该方法?", "方法删除提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var a = skinLVMethods.SelectedItems[0];
                    var intf = skinLVInterfaces.SelectedItems[0];

                    HA_MethodDAL dal = new HA_MethodDAL();
                    if (dal.Delete(a.SubItems[2].Text))
                    {
                        ReloadMethod(intf.Text);
                    }
                }
            }
        }

        private void btnPreviewReq_Click(object sender, EventArgs e)
        {
            #region 调用返回json串的操作
            //SqlSugarUtils ssu = new SqlSugarUtils();
            //string resultJSON = ssu.TestGetDbAndOperate();
            //JsonTool jt = new JsonTool();
            //resultJSON = jt.ConvertJsonString(resultJSON);
            //edtJson.Text = resultJSON;
            #endregion
            try
            {
                if (skinLVMethods.SelectedItems.Count > 0)
                {
                    var a = skinLVMethods.SelectedItems[0];

                    HA_Method ha_method = new HA_Method
                    {
                        intf_code = a.SubItems[0].Text,
                        m_name = a.SubItems[1].Text,
                        m_code = a.SubItems[2].Text,
                        m_desc = a.SubItems[3].Text,
                        //m_reqtype = a.SubItems[4].Text,
                        m_template = Convert.ToInt32(a.SubItems[4].Text),
                        m_version = a.SubItems[5].Text,
                        m_funcode = a.SubItems[6].Text,
                        m_isencrypted = false, //a.SubItems[2].Text,
                        m_arggrpcode = a.SubItems[8].Text,
                        m_rtnvaluecode = a.SubItems[9].Text,
                        m_pagesize = Convert.ToInt32(a.SubItems[10].Text)
                    };

                    string m_code = a.SubItems[2].Text;
                    SugarParameter sp = new SugarParameter("m_code", m_code);
                    List<SugarParameter> lsp = new List<SugarParameter>();
                    lsp.Add(sp);
                    string sysConnString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                    //查询所有参数
                    string sqlStmt = @"SELECT
                                    a.[para_name]
                                   ,a.[para_default]
                                   ,a.[para_datatype]
                                   FROM [dbo].[HA_Parameter] a 
                                   left join [dbo].[HA_ArgGroup] b on  a.para_code
                                   in (select col from dbo.split((select i.ag_paras from [dbo].[HA_ArgGroup] i
                                   where i.ag_code=b.ag_code)+',' ,','))
                                   left join [dbo].[HA_Method] c on c.m_arggrpcode = b.ag_code
                                   where c.m_code =@m_code";
                    using (DataTable dt = SqlSugarUtils.GetQueryDataTableResult(sysConnString, sqlStmt, lsp))
                    {
                        int columnNumber = dt.Columns.Count;
                        int rowNumber = dt.Rows.Count;
                        //var obj = DynamicParasFactory.ConstructRequestObject(dt);
                        string codeString = DynamicParasFactory.CodeBuilder(dt);
                        string resultJSON = DynamicParasFactory.TranslateObjectInCodeToJSON(codeString);

                        JsonTool jt = new JsonTool();
                        //美化JSON字符串
                        resultJSON = jt.ConvertJsonString(resultJSON);
                        edtJson.Text = resultJSON;
                        #region 测试完成后屏蔽这段代码
                        //string destFolder = System.AppDomain.CurrentDomain.BaseDirectory;
                        //destFolder += ha_method.intf_code + @"\" + ha_method.m_code + @"\Model";
                        //DirectoryInfo di = new DirectoryInfo(destFolder);
                        //if (di.Exists == false)
                        //{
                        //    Directory.CreateDirectory(destFolder);
                        //}

                        //bool writeClassRet = RunTimeHelper.GenClassStringByJSON(resultJSON, "ILAK.API", "ILAK.API.Model", destFolder, "Req" + ha_method.m_arggrpcode);

                        //if (!writeClassRet)
                        //{
                        //    MessageBox.Show("写文件失败");
                        //}
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void skinLVMethods_DoubleClick(object sender, EventArgs e)
        {
            if (skinLVMethods.SelectedItems.Count > 0 && skinLVInterfaces.SelectedItems.Count > 0)
            {
                var a = skinLVMethods.SelectedItems[0];
                var intf = skinLVInterfaces.SelectedItems[0];
                HA_Method ha_method = new HA_Method
                {
                    intf_code = a.SubItems[0].Text,
                    m_name = a.SubItems[1].Text,
                    m_code = a.SubItems[2].Text,
                    m_desc = a.SubItems[3].Text,
                    //m_reqtype = a.SubItems[4].Text,
                    m_template = Convert.ToInt32(a.SubItems[4].Text),
                    m_version = a.SubItems[5].Text,
                    m_funcode = a.SubItems[6].Text,
                    m_isencrypted = false, //a.SubItems[2].Text,
                    m_arggrpcode = a.SubItems[8].Text,
                    m_rtnvaluecode = a.SubItems[9].Text,
                    m_pagesize = Convert.ToInt32(a.SubItems[10].Text)
                };

                FrmManageMethod addprojForm = new FrmManageMethod(ha_method, intf.Text);
                addprojForm.ShowDialog();
                ReloadMethod(intf.Text);
            }
        }

        private void tBtnRefresh_Click(object sender, EventArgs e)
        {
            FrmMethod_Load(null, null);
        }

        private void btnSaveRetVal_Click(object sender, EventArgs e)
        {

            if (skinLVMethods.SelectedItems.Count > 0 && skinLVInterfaces.SelectedItems.Count > 0)
            {
                try
                {
                    var a = skinLVMethods.SelectedItems[0];
                    var intf = skinLVInterfaces.SelectedItems[0];
                    HA_Method ha_method = new HA_Method
                    {
                        intf_code = a.SubItems[0].Text,
                        m_name = a.SubItems[1].Text,
                        m_code = a.SubItems[2].Text,
                        m_desc = a.SubItems[3].Text,
                        //m_reqtype = a.SubItems[4].Text,
                        m_template = Convert.ToInt32(a.SubItems[4].Text),
                        m_version = a.SubItems[5].Text,
                        m_funcode = a.SubItems[6].Text,
                        m_isencrypted = false, //a.SubItems[2].Text,
                        m_arggrpcode = a.SubItems[8].Text,
                        m_rtnvaluecode = a.SubItems[9].Text,
                        m_pagesize = Convert.ToInt32(a.SubItems[10].Text)
                    };
                    //1.connStr: 通过intf_code得到 interface上的dbConn,取出connStr和DBType
                    string connStr = "";
                    string connName = "";
                    string dbType = "";
                    string intfcode = ha_method.intf_code;
                    DbService db = DB.GetMainDb();
                    Hashtable htPara = new Hashtable();
                    htPara.Add("intf_code", intfcode);
                    DataSet tempds = db.ExecuteSqlID("GetInterface2", htPara);
                    if (tempds != null && tempds.Tables.Count > 0)
                    {
                        if (tempds.Tables[0].Rows.Count > 0)
                        {
                            connName = tempds.Tables[0].Rows[0]["intf_dbconn"].ToString();
                        }
                    }
                    if (string.IsNullOrEmpty(connName))
                    {
                        MessageBox.Show("接口没有配置数据库连接");
                        return;
                    }
                    //2.dt 
                    SqlSugar.DbType sdt = SqlSugar.DbType.SqlServer;
                    Hashtable htParaConn = new Hashtable();
                    htParaConn.Add("conn_name", connName);
                    tempds = db.ExecuteSqlID("GetConnection2", htParaConn);

                    if (tempds != null && tempds.Tables.Count > 0)
                    {
                        if (tempds.Tables[0].Rows.Count > 0)
                        {
                            connStr = tempds.Tables[0].Rows[0]["conn_string"].ToString();
                            dbType = tempds.Tables[0].Rows[0]["conn_dbtype"].ToString();
                        }
                    }
                    if (string.IsNullOrEmpty(connStr))
                    {
                        MessageBox.Show("数据库连接不存在");
                        return;
                    }
                    switch (dbType)
                    {
                        case "MSSql":
                            sdt = SqlSugar.DbType.SqlServer;
                            break;
                        case "Cache*":

                            break;
                        case "Oracle*":
                            sdt = SqlSugar.DbType.Oracle;
                            break;
                        default:
                            break;
                    }
                    //3.sqlStmt
                    string sqlStmt = ha_method.m_funcode;
                    if (string.IsNullOrEmpty(sqlStmt))
                    {
                        MessageBox.Show("没有查询语句");
                        return;
                    }
                    //4.paras 从ag_code里得到 ag组，再去得到所有的参数
                    string ag_code = ha_method.m_arggrpcode;
                    Hashtable htParaAG = new Hashtable();
                    htParaAG.Add("ag_code", ag_code);
                    tempds = db.ExecuteSqlID("GetParas2", htParaAG);
                    List<SugarParameter> sParas = new List<SugarParameter>();

                    if (tempds != null && tempds.Tables.Count > 0)
                    {
                        if (tempds.Tables[0].Rows.Count > 0)
                        {
                            int rowCount = tempds.Tables[0].Rows.Count;

                            for (int i = 0; i < rowCount; i++)
                            {
                                SugarParameter sp = new SugarParameter(tempds.Tables[0].Rows[i]["para_name"].ToString(), tempds.Tables[0].Rows[i]["para_default"].ToString());
                                sParas.Add(sp);
                            }
                        }
                    }
                    if (sParas.Count == 0)
                    {
                        MessageBox.Show("没有配置参数");
                        return;
                    }
                    //5 处理pagesize
                    if (!sqlStmt.ToLower().Contains("top"))
                    {
                        if (ha_method.m_pagesize == 0)
                        {
                            sqlStmt = sqlStmt.ToLower().Replace("select", "select top 1");
                        }
                        else
                        {
                            string topnumber = ha_method.m_pagesize.ToString();
                            if (ha_method.m_pagesize > 5)
                                topnumber = "5";
                            sqlStmt = sqlStmt.ToLower().Replace("select", "select top " + topnumber);
                        }
                    }
                    string resultJSON = SqlSugarUtils.GetSingleJSONResult(connStr, sdt, sqlStmt, sParas);
                    JsonTool jt = new JsonTool();
                    //6 美化JSON字符串
                    resultJSON = jt.ConvertJsonString(resultJSON);
                    edtJson.Text = resultJSON;
                    //7 顺便保存到 RetVO 的 类JSON里去
                    Hashtable htParaRV = new Hashtable();
                    htParaRV.Add("rv_name", "ret" + ha_method.m_code);
                    tempds = db.ExecuteSqlID("GetRetVO2", htParaRV);
                    if (tempds != null && tempds.Tables.Count > 0)
                    {
                        HA_RetValObjectDAL dal = new HA_RetValObjectDAL();
                        HA_RetValObject rvo = new HA_RetValObject
                        {
                            rv_name = "ret" + ha_method.m_code,
                            rv_exttype = tempds.Tables[0].Rows[0]["rv_exttype"].ToString(),
                            rv_note = tempds.Tables[0].Rows[0]["rv_note"].ToString(),
                            rv_JSON = resultJSON
                        };
                        bool ret = dal.Update(rvo);
                        if (ret == false)
                        {
                            MessageBox.Show("保存到RetVO失败 : " + ret);
                        }
                    }
                    //8 顺手将json转换为类文件
                    #region 测试后屏蔽这段代码
                    //string destFolder = System.AppDomain.CurrentDomain.BaseDirectory;
                    //destFolder += ha_method.intf_code + @"\" + ha_method.m_code + @"\Model";
                    //DirectoryInfo di = new DirectoryInfo(destFolder);
                    //if (di.Exists == false)
                    //{
                    //    Directory.CreateDirectory(destFolder);
                    //}

                    //bool writeClassRet = RunTimeHelper.GenClassStringByJSON(resultJSON, "ILAK.API", "ILAK.API.Model", destFolder, "ret" + ha_method.m_code);

                    //if (!writeClassRet)
                    //{
                    //    MessageBox.Show("写文件失败");
                    //}
                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
