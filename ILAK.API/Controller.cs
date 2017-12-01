using CCWin.SkinControl;
using HYD.Hds.Servcie;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace ILAK.API
{
    public class Controller
    {
        private DbService db = null;
        public bool RefreshListViewFromSqlIDWithOutParas(DataTable dt, SkinListView lv, string sqlid)
        {
            bool ret = false;
            db = DB.GetMainDb();
            try
            {
                if (dt != null) dt.Dispose();

                DataSet tempds = db.ExecuteSqlID(sqlid, null);
                if (dt == null) dt = new DataTable();
                if (tempds != null && tempds.Tables.Count > 0) dt = tempds.Tables[0];
                ShowDataTableInListView(dt, lv);
                ret = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }
            return ret;
        }

        public bool RefreshListViewFromSqlIDWithParas(DataTable dt, SkinListView lv, string sqlid, Hashtable htPara)
        {
            bool ret = false;
            db = DB.GetMainDb();
            try
            {
                if (dt != null) dt.Dispose();

                DataSet tempds = db.ExecuteSqlID(sqlid, htPara);
                if (dt == null) dt = new DataTable();
                if (tempds != null && tempds.Tables.Count > 0) dt = tempds.Tables[0];
                ShowDataTableInListView(dt, lv);
                ret = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }
            return ret;
        }

        public void ShowDataTableInListView(DataTable dt, SkinListView lv)
        {
            lv.Clear();
            lv.AllowColumnReorder = true;//用户可以调整列的位置
            lv.GridLines = true;//显示行与行之间的分隔线    
            lv.FullRowSelect = true;//要选择就是一行    
            lv.View = View.Details;//定义列表显示的方式   
            lv.Scrollable = true;//需要时候显示滚动条   
            lv.MultiSelect = false; // 不可以多行选择    
            lv.HeaderStyle = ColumnHeaderStyle.Clickable;
            lv.View = View.Details;
            int RowCount, ColumnCount;
            DataRow dr = null;
            if (dt == null) return;
            RowCount = dt.Rows.Count;
            ColumnCount = dt.Columns.Count;
            //添加列标题名
            for (int i = 0; i < ColumnCount; i++)
            {
                lv.Columns.Add(dt.Columns[i].Caption.Trim(), lv.Width / ColumnCount);
            }
            if (RowCount == 0) return;
            for (int i = 0; i < RowCount; i++)
            {
                dr = dt.Rows[i];
                lv.Items.Add(dr[0].ToString());
                for (int j = 1; j < ColumnCount; j++)
                {
                    lv.Items[i].SubItems.Add(dr[j].ToString());
                }
            }
        }

    }
}
