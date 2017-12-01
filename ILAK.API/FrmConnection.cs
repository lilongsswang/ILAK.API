
using ILAK.API.DAL;
using ILAK.API.Helpers;
using ILAK.API.Model;
using HYD.Hds.Servcie;
using SqlSugar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ILAK.API
{
    public partial class FrmConnection : Form
    {
        DbService db = null;
        public FrmConnection()
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

        private void btnSaveBackToConn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtConnStrGen.Text))
            {
                try
                {
                    if (skinLVConns.SelectedItems.Count > 0)
                    {
                        labelConnStatus.Text = "";
                        var a = skinLVConns.SelectedItems[0];
                        HA_ConnectionDAL dal = new HA_ConnectionDAL();

                        HA_Connection ha_conn = new HA_Connection
                        {
                            conn_name = a.SubItems[1].Text,
                            conn_IP = a.SubItems[2].Text,
                            conn_Account = a.SubItems[3].Text,
                            conn_Password = a.SubItems[4].Text,
                            conn_DBType = a.SubItems[5].Text,
                            conn_Alias = a.SubItems[6].Text,
                            conn_CType = a.SubItems[7].Text,
                            conn_String = txtConnStrGen.Text,
                            conn_note = a.SubItems[9].Text
                        };
                        bool ret = dal.Update(ha_conn);
                        if (ret)
                        {
                            labelConnStatus.Text = "保存成功!";
                            ReloadConnection();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tBtnGenConnStr_Click(object sender, EventArgs e)
        {
            if (skinLVConns.SelectedItems.Count > 0)
            {
                var a = skinLVConns.SelectedItems[0];
                HA_Connection ha_conn = new HA_Connection
                {
                    conn_name = a.SubItems[1].Text,
                    conn_IP = a.SubItems[2].Text,
                    conn_Account = a.SubItems[3].Text,
                    conn_Password = a.SubItems[4].Text,
                    conn_DBType = a.SubItems[5].Text,
                    conn_CType = a.SubItems[7].Text,
                    //conn_String = a.SubItems[7].Text,
                    conn_note = a.SubItems[9].Text,
                    conn_Alias = a.SubItems[6].Text
                };
                //代码重构点之一
                string connString = SQLHelper.GetConnStr(ha_conn.conn_DBType, ha_conn.conn_IP,
                    ha_conn.conn_Alias, ha_conn.conn_Account,
                    ha_conn.conn_Password, 0);

                txtConnStrGen.Text = connString;
            }
            labelConnStatus.Text = "";
        }

        private void tBtnAddConn_Click(object sender, EventArgs e)
        {
            HA_ConnectionDAL dal = new HA_ConnectionDAL();
            FrmManageConn methodForm = new FrmManageConn(null, "");
            methodForm.ShowDialog();
            ReloadConnection();
        }

        private void ReloadConnection()
        {
            try
            {
                Controller c = new Controller();
                db = DB.GetMainDb();
                c.RefreshListViewFromSqlIDWithOutParas(null, skinLVConns, "GetConnections");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBtnModiConn_Click(object sender, EventArgs e)
        {
            if (skinLVConns.SelectedItems.Count > 0)
            {
                var a = skinLVConns.SelectedItems[0];
                HA_Connection ha_conn = new HA_Connection
                {
                    conn_name = a.SubItems[1].Text,
                    conn_IP = a.SubItems[2].Text,
                    conn_Account = a.SubItems[3].Text,
                    conn_Password = a.SubItems[4].Text,
                    conn_DBType = a.SubItems[5].Text,
                    conn_Alias = a.SubItems[6].Text,
                    conn_CType = a.SubItems[7].Text,
                    conn_String = a.SubItems[8].Text,
                    conn_note = a.SubItems[9].Text
                };

                FrmManageConn connForm = new FrmManageConn(ha_conn, a.SubItems[1].Text);
                connForm.ShowDialog();
                ReloadConnection();
            }
        }

        private void tBtnDelConn_Click(object sender, EventArgs e)
        {
            if (skinLVConns.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("是否要删除该连接?", "连接删除提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var a = skinLVConns.SelectedItems[0];
                    DbService db = null;
                    db = DB.GetMainDb();
                    Hashtable htPara = new Hashtable();
                    htPara.Add("conn_name", a.SubItems[1].Text);

                    int count = (int)db.ExecuteScalarID("GetInterfaceUsedConnectionsNumber", htPara);
                    if (count > 0)
                    {
                        MessageBox.Show("还有" + count.ToString() + "个接口在使用该连接,避免出错，请先检查接口");
                        return;
                    }
                    HA_ConnectionDAL dal = new HA_ConnectionDAL();
                    if (dal.Delete(Convert.ToInt32(a.SubItems[0].Text)))
                    {
                        ReloadConnection();
                    }
                }
            }
        }

        private void FrmConnection_Load(object sender, EventArgs e)
        {
            Controller c = new Controller();
            DbService db = null;
            db = DB.GetMainDb();
            DataSet connections = db.ExecuteSqlID("GetConnections", null);
            DataTable Connections = null;
            if (connections != null && connections.Tables.Count > 0)
            {
                Connections = connections.Tables[0];
                c.ShowDataTableInListView(Connections, skinLVConns);
            }
        }

        private void skinLVConns_DoubleClick(object sender, EventArgs e)
        {
            if (skinLVConns.SelectedItems.Count > 0)
            {
                var a = skinLVConns.SelectedItems[0];
                HA_Connection ha_conn = new HA_Connection
                {
                    conn_name = a.SubItems[1].Text,
                    conn_IP = a.SubItems[2].Text,
                    conn_Account = a.SubItems[3].Text,
                    conn_Password = a.SubItems[4].Text,
                    conn_DBType = a.SubItems[5].Text,
                    conn_Alias = a.SubItems[6].Text,
                    conn_CType = a.SubItems[7].Text,
                    conn_String = a.SubItems[8].Text,
                    conn_note = a.SubItems[9].Text
                };

                FrmManageConn connForm = new FrmManageConn(ha_conn, a.SubItems[1].Text);
                connForm.ShowDialog();
                ReloadConnection();
            }
        }

        private void tBtnRefresh_Click(object sender, EventArgs e)
        {
            ReloadConnection();
        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtConnStrGen.Text))
            {
                try
                {
                    if (skinLVConns.SelectedItems.Count > 0)
                    {
                        labelConnStatus.Text = "";
                        var a = skinLVConns.SelectedItems[0];
                        string testConnStr = txtConnStrGen.Text;
                        string DataBaseType = a.SubItems[5].Text;
                        SqlSugar.DbType sdt = SqlSugar.DbType.SqlServer;
                        switch (DataBaseType)
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
                        using (SqlSugarClient ssc = SqlSugarUtils.GetDb(testConnStr, sdt))
                        {
                            List<DbColumnInfo> columns = new List<DbColumnInfo>();
                            DbColumnInfo column = new DbColumnInfo();
                            column.DataType = "varchar";
                            column.DbColumnName = "testcol";
                            column.Length = 50;
                            columns.Add(column);
                            bool result = ssc.DbMaintenance.CreateTable("HydTestDbTable", columns);
                            if (result)
                            {
                                ssc.DbMaintenance.DropTable("HydTestDbTable");
                                labelConnStatus.Text = "测试成功!";
                            }
                            else
                            {
                                labelConnStatus.Text = "连接失败!";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    labelConnStatus.Text = "连接失败! " + ex.Message;
                }
            }
            else
            {
                MessageBox.Show("请先 生成连接字符串");
            }
        }

        private void skinLVConns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skinLVConns.SelectedItems.Count > 0)
            {
                var a = skinLVConns.SelectedItems[0];
                txtConnStrGen.Text = a.SubItems[8].Text;
            }
        }
    }

}
