using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILAK.API.Helpers
{
    public class SQLHelper
    {
        public static readonly string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        public static int ExecuteNonQuery(string sqlStr, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sqlStr;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string sqlStr, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sqlStr;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static DataTable ExecuteDataTable(string sqlStr, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sqlStr;
                    cmd.Parameters.AddRange(parameters);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static SqlDataReader ExecuteDataReader(string sqlStr, params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = sqlStr;
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }

        /// <summary>
        /// 简单的连接字符串生成方法
        /// </summary>
        /// <param name="conn_DBType"></param>
        /// <param name="IP"></param>
        /// <param name="Namespace"></param>
        /// <param name="user"></param>
        /// <param name="pwd"></param>
        /// <param name="port"></param>
        /// <returns></returns>
        public static string GetConnStr(string conn_DBType, string IP, string Namespace, string user, string pwd, int port)
        {
            string retConnStr = "";
            
            switch (conn_DBType)
            {
                case "MSSql":
                    //Server=172.18.107.250;Database=HDSAPI;User Id=sa;Password=Passw0rd;
                    retConnStr = "Server=" + IP + ";Database=" + Namespace + ";User Id=" + user + ";Password=" + pwd+";";
                    break;
                case "Cache*":

                    break;
                case "Oracle*":

                    break;
                default:
                    break;
            }
            return retConnStr;
        }
    }
}
