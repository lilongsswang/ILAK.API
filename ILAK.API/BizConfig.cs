using HYD.Hds.Servcie;
using System;
using System.Data;
using System.Windows.Forms;

namespace ILAK.API
{
    /// <summary>
    /// 引自HDSAPI
    /// </summary>
    public class BizConfig
    {
        public DbService db = null;
        public static DataTable Projects = null;
        public static DataTable Interfaces = null;

        public BizConfig()
        {
            InitSystem();
        }

        public DbService MainDb {
            get
            {
                return DB.GetMainDb();
            }
        }

        private void InitSystem()
        {
            try
            {
                db = DB.GetMainDb();
                if (Projects != null) Projects.Dispose();
                if (Interfaces != null) Interfaces.Dispose();

                DataSet projects = db.ExecuteSqlID("GetProjects", null);

                if (projects != null && projects.Tables.Count > 0) Projects = projects.Tables[0];

                DataSet interfaces = db.ExecuteSqlID("GetInterfaces", null);

                if (interfaces != null && interfaces.Tables.Count > 0) Interfaces = interfaces.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }
        }
    }
}
