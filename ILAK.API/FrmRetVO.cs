using ILAK.API.DAL;
using ILAK.API.Model;
using HYD.Hds.Servcie;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace ILAK.API
{
    public partial class FrmRetVO : Form
    {
        DbService db = null;
        public FrmRetVO()
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

        //private void tBtnAddConn_Click(object sender, EventArgs e)
        //{
        //    HA_RetValObjectDAL dal = new HA_RetValObjectDAL();
        //    FrmManageRetVO methodForm = new FrmManageRetVO(null, "");
        //    methodForm.ShowDialog();
        //    ReloadRetVO();
        //}
        private void ReloadRetVO()
        {
            try
            {
                Controller c = new Controller();
                db = DB.GetMainDb();
                c.RefreshListViewFromSqlIDWithOutParas(null, skinLVRetVO, "GetRetVOs");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tBtnModiConn_Click(object sender, EventArgs e)
        {
            if (skinLVRetVO.SelectedItems.Count > 0)
            {
                var a = skinLVRetVO.SelectedItems[0];
                HA_RetValObject ha_conn = new HA_RetValObject
                {
                    rv_name = a.SubItems[0].Text,
                    rv_JSON = a.SubItems[1].Text,
                    rv_exttype = a.SubItems[2].Text,
                    rv_note = a.SubItems[3].Text
                };

                FrmManageRetVO connForm = new FrmManageRetVO(ha_conn, a.SubItems[0].Text);
                connForm.ShowDialog();
                ReloadRetVO();
            }
        }

        private void tBtnDelConn_Click(object sender, EventArgs e)
        {
            if (skinLVRetVO.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("是否要删除该返回类,先确认方法已删除", "类删除提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var a = skinLVRetVO.SelectedItems[0];
                    DbService db = null;
                    db = DB.GetMainDb();
                    Hashtable htPara = new Hashtable();
                    htPara.Add("rv_name", a.SubItems[0].Text);

                    int count = (int)db.ExecuteScalarID("GetMethodUsedRetVOsNumber", htPara);
                    if (count > 0)
                    {
                        MessageBox.Show("还有" + count.ToString() + "个方法在使用该类,避免出错，请先检查接口");
                        return;
                    }
                    HA_RetValObjectDAL dal = new HA_RetValObjectDAL();
                    if (dal.Delete(a.SubItems[0].Text))
                    {
                        ReloadRetVO();
                    }
                }
            }
        }

        private void FrmConnection_Load(object sender, EventArgs e)
        {
            Controller c = new Controller();
            DbService db = null;
            db = DB.GetMainDb();
            DataSet retvos = db.ExecuteSqlID("GetRetVOs", null);
            DataTable RetVOs = null;
            if (retvos != null && retvos.Tables.Count > 0)
            {
                RetVOs = retvos.Tables[0];
                c.ShowDataTableInListView(RetVOs, skinLVRetVO);
            }
        }

        private void skinLVRetVO_DoubleClick(object sender, EventArgs e)
        {
            if (skinLVRetVO.SelectedItems.Count > 0)
            {
                var a = skinLVRetVO.SelectedItems[0];
                HA_RetValObject ha_conn = new HA_RetValObject
                {
                    rv_name = a.SubItems[0].Text,
                    rv_JSON = a.SubItems[1].Text,
                    rv_exttype = a.SubItems[2].Text,
                    rv_note = a.SubItems[3].Text
                };

                FrmManageRetVO connForm = new FrmManageRetVO(ha_conn, a.SubItems[0].Text);
                connForm.ShowDialog();
                ReloadRetVO();
            }
        }

        private void tBtnRefresh_Click(object sender, EventArgs e)
        {
            ReloadRetVO();
        }
    }

}