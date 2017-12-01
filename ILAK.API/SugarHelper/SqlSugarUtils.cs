using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;

namespace ILAK.API
{
    public static class SqlSugarUtils
    {
        public static bool Initialated { get; set; }
        public static SqlSugarClient GetDb(string connStr, SqlSugar.DbType dbType)
        {
            SqlSugarClient db = new SqlSugarClient(
                new ConnectionConfig
                {
                    ConnectionString = connStr,
                    DbType = SqlSugar.DbType.SqlServer,
                    IsAutoCloseConnection = true,
                    InitKeyType = InitKeyType.Attribute
                });

            return db;
        }
        public static DataTable GetQueryDataTableResult(string connStr, string sqlStmt, List<SugarParameter> paras)
        {
            DataTable result = null;
            try
            {
                SqlSugarClient db = GetDb(connStr, SqlSugar.DbType.SqlServer);
                result = db.Ado.GetDataTable(sqlStmt, paras);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static string GetSingleJSONResult(string connStr, SqlSugar.DbType dbType, string sqlStmt, List<SugarParameter> paras)
        {
            string result = "";
            try
            {
                SqlSugarClient db = GetDb(connStr, dbType);

                if (Initialated==false)
                {
                    //string currentDirectory = Directory.GetCurrentDirectory();
                    //db.DbFirst.CreateClassFile(currentDirectory + @"\ClassFile\", "ILAK.API.Models");
                    //Initialated = true;
                }
                ////db.Ado.SqlQueryDynamic(sqlStmt,)

                //var sret = db.Queryable("ha_interface", "t")
                //    .Where("t.proj_code like @proj_code")
                //    .AddParameters(new { proj_code = "%1" })
                //    .Select("t.*").ToSql();
                using (DataTable tmp = db.Ado.GetDataTable(sqlStmt, paras))
                {
                    result = JsonTool.SerializeToJson(tmp);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static string GetQueryJSONResult(string connStr, string sqlStmt, List<SugarParameter> paras)
        {
            string result = "";
            try
            {
                SqlSugarClient db = GetDb(connStr, SqlSugar.DbType.SqlServer);
                using (DataTable tmp = db.Ado.GetDataTable(sqlStmt, paras))
                {
                    result = JsonConvert.SerializeObject(tmp, new DataTableConverter());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static int GetPageSize(string para)
        {
            //获取pagesize参数的defaultvalue
            return 1;
        }
        /// <summary>
        /// 测试方法
        /// </summary>
        /// <returns></returns>
        public static string TestGetDbAndOperate()
        {
            string JSONResult = "";
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlSugarClient db = GetDb(connStr, SqlSugar.DbType.SqlServer);
            var testresult = db.Ado.GetDataTable("SELECT * from dbo.ha_project");

            JSONResult = JsonConvert.SerializeObject(testresult, new DataTableConverter());
            return JSONResult;
            //List<T> list = db.SqlQuery<T>("select * from T where id=@id", new { id = 1 });
            //转成dynamic
            //dynamic list = db.Ado.SqlQueryDynamic("select * from student");
            //转成json
            //string list = db.Ado.SqlQueryJson("select * from student");
            //using (var db = new SqlSugarClient(ConnectionString))
            //{

            //    List<T> list = db.Queryable<T>().OrderBy(it => it.id, OrderByType.desc).ToPageList(pageIndex, pageSize);
            //}
        }
    }
}
