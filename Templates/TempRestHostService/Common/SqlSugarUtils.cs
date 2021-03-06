﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace TempRestHostService
{
    public class SqlSugarUtils
    {
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
                using (DataTable tmp = db.Ado.GetDataTable(sqlStmt, paras))
                {
                    //result = JsonConvert.SerializeObject(tmp, new DataTableConverter());
                    result = JsonTool.SerializeToJson(tmp);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static string GetQueryJSONResult(string connStr, SqlSugar.DbType dbType, string sqlStmt, List<SugarParameter> paras)
        {
            string result = "";
            try
            {
                SqlSugarClient db = GetDb(connStr, dbType);
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

        public static dynamic QueryData(string connStr, SqlSugar.DbType dbType, string sqlStmt, List<SugarParameter> paras)
        {
            dynamic ret = null;
            try
            {
                SqlSugarClient db = GetDb(connStr, dbType);
                ret = db.Ado.SqlQueryDynamic(sqlStmt, paras);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }
        public static int GetPageSize(string para)
        {
            //获取pagesize参数的defaultvalue
            return 1;
        }
        public static bool LogExecute(string connStr, string intfcode)
        {
            bool ret = false;
            try
            {
                SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = connStr, //必填
                    DbType = SqlSugar.DbType.SqlServer, //必填
                    IsAutoCloseConnection = true, //默认false
                    InitKeyType = InitKeyType.SystemTable
                });

                if (!db.DbMaintenance.IsAnyTable("dbo.HA_Execlog"))
                {
                    #region 建日志表SQL
                    db.Ado.ExecuteCommand(@"CREATE TABLE [dbo].[HA_ExecLog] (
                    [log_id] int NOT NULL IDENTITY(1,1) ,
                    [log_intfcode] varchar(255) NULL ,
                    [log_intfver] varchar(255) NULL ,
                    [log_reqjson] varchar(MAX) NULL ,
                    [log_requestStmt] varchar(MAX) NULL ,
                    [log_datetime] datetime NULL ,
                    [log_executor] varchar(255) NULL ,
                    [log_mcode] varchar(255) NULL ,
                    [log_projcode] varchar(255) NULL ,
                    [log_action] varchar(50) NULL DEFAULT ('Query') 
                    )


                    GO
                    DBCC CHECKIDENT(N'[dbo].[HA_ExecLog]', RESEED, 2)
                    GO
                    IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
                    'SCHEMA', N'dbo', 
                    'TABLE', N'HA_ExecLog', 
                    'COLUMN', N'log_id')) > 0) 
                    EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'log自增id'
                    , @level0type = 'SCHEMA', @level0name = N'dbo'
                    , @level1type = 'TABLE', @level1name = N'HA_ExecLog'
                    , @level2type = 'COLUMN', @level2name = N'log_id'
                    ELSE
                    EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'log自增id'
                    , @level0type = 'SCHEMA', @level0name = N'dbo'
                    , @level1type = 'TABLE', @level1name = N'HA_ExecLog'
                    , @level2type = 'COLUMN', @level2name = N'log_id'
                    GO
                    IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
                    'SCHEMA', N'dbo', 
                    'TABLE', N'HA_ExecLog', 
                    'COLUMN', N'log_intfcode')) > 0) 
                    EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'接口代码'
                    , @level0type = 'SCHEMA', @level0name = N'dbo'
                    , @level1type = 'TABLE', @level1name = N'HA_ExecLog'
                    , @level2type = 'COLUMN', @level2name = N'log_intfcode'
                    ELSE
                    EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'接口代码'
                    , @level0type = 'SCHEMA', @level0name = N'dbo'
                    , @level1type = 'TABLE', @level1name = N'HA_ExecLog'
                    , @level2type = 'COLUMN', @level2name = N'log_intfcode'
                    GO
                    IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
                    'SCHEMA', N'dbo', 
                    'TABLE', N'HA_ExecLog', 
                    'COLUMN', N'log_intfver')) > 0) 
                    EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'接口版本'
                    , @level0type = 'SCHEMA', @level0name = N'dbo'
                    , @level1type = 'TABLE', @level1name = N'HA_ExecLog'
                    , @level2type = 'COLUMN', @level2name = N'log_intfver'
                    ELSE
                    EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'接口版本'
                    , @level0type = 'SCHEMA', @level0name = N'dbo'
                    , @level1type = 'TABLE', @level1name = N'HA_ExecLog'
                    , @level2type = 'COLUMN', @level2name = N'log_intfver'
                    GO
                    IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
                    'SCHEMA', N'dbo', 
                    'TABLE', N'HA_ExecLog', 
                    'COLUMN', N'log_reqjson')) > 0) 
                    EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'请求json'
                    , @level0type = 'SCHEMA', @level0name = N'dbo'
                    , @level1type = 'TABLE', @level1name = N'HA_ExecLog'
                    , @level2type = 'COLUMN', @level2name = N'log_reqjson'
                    ELSE
                    EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'请求json'
                    , @level0type = 'SCHEMA', @level0name = N'dbo'
                    , @level1type = 'TABLE', @level1name = N'HA_ExecLog'
                    , @level2type = 'COLUMN', @level2name = N'log_reqjson'
                    GO
                    IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
                    'SCHEMA', N'dbo', 
                    'TABLE', N'HA_ExecLog', 
                    'COLUMN', N'log_requestStmt')) > 0) 
                    EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'返回json'
                    , @level0type = 'SCHEMA', @level0name = N'dbo'
                    , @level1type = 'TABLE', @level1name = N'HA_ExecLog'
                    , @level2type = 'COLUMN', @level2name = N'log_requestStmt'
                    ELSE
                    EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'返回json'
                    , @level0type = 'SCHEMA', @level0name = N'dbo'
                    , @level1type = 'TABLE', @level1name = N'HA_ExecLog'
                    , @level2type = 'COLUMN', @level2name = N'log_requestStmt'
                    GO
                    IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
                    'SCHEMA', N'dbo', 
                    'TABLE', N'HA_ExecLog', 
                    'COLUMN', N'log_datetime')) > 0) 
                    EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'执行日期时间'
                    , @level0type = 'SCHEMA', @level0name = N'dbo'
                    , @level1type = 'TABLE', @level1name = N'HA_ExecLog'
                    , @level2type = 'COLUMN', @level2name = N'log_datetime'
                    ELSE
                    EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'执行日期时间'
                    , @level0type = 'SCHEMA', @level0name = N'dbo'
                    , @level1type = 'TABLE', @level1name = N'HA_ExecLog'
                    , @level2type = 'COLUMN', @level2name = N'log_datetime'
                    GO
                    IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
                    'SCHEMA', N'dbo', 
                    'TABLE', N'HA_ExecLog', 
                    'COLUMN', N'log_executor')) > 0) 
                    EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'执行人'
                    , @level0type = 'SCHEMA', @level0name = N'dbo'
                    , @level1type = 'TABLE', @level1name = N'HA_ExecLog'
                    , @level2type = 'COLUMN', @level2name = N'log_executor'
                    ELSE
                    EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'执行人'
                    , @level0type = 'SCHEMA', @level0name = N'dbo'
                    , @level1type = 'TABLE', @level1name = N'HA_ExecLog'
                    , @level2type = 'COLUMN', @level2name = N'log_executor'
                    GO

                    -- ----------------------------
                    -- Indexes structure for table HA_ExecLog
                    -- ----------------------------
                    CREATE INDEX [logdatetimeIdx] ON [dbo].[HA_ExecLog]
                    ([log_datetime] ASC) 
                    INCLUDE ([log_intfcode]) 
                    GO
                    CREATE INDEX [ActionIndex] ON [dbo].[HA_ExecLog]
                    ([log_action] ASC) 
                    INCLUDE ([log_datetime], [log_mcode]) 
                    GO
                    ", new object());
                    #endregion
                }
                #region 记录日志

                #endregion

                ret = true;
            }
            catch (Exception)
            {

                throw;
            }
            return ret;
        }
    }
}
