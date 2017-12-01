using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ILAK.API.Model;
using ILAK.API.Helpers;

namespace ILAK.API.DAL
{
	partial class HA_ExecLogDAL
	{
		public int AddNew(HA_ExecLog model)
		{
			string sqlStr = "insert into HA_ExecLog(log_id,log_intfcode,log_intfver,log_reqjson,log_retjson,log_datetime,log_executor,log_mcode,log_projcode)" +
                "  values(@log_intfcode,@log_intfver,@log_reqjson,@log_retjson,@log_datetime,@log_executor,@log_mcode,@log_projcode)";
			int id = (int)SQLHelper.ExecuteScalar(sqlStr
			, new SqlParameter("log_intfcode", model.log_intfcode)
			, new SqlParameter("log_intfver", model.log_intfver)
			, new SqlParameter("log_reqjson", model.log_reqjson)
			, new SqlParameter("log_retjson", model.log_retjson)
			, new SqlParameter("log_datetime", model.log_datetime)
			, new SqlParameter("log_executor", model.log_executor)
            , new SqlParameter("log_mcode", model.log_mcode)
            , new SqlParameter("log_projcode", model.log_projcode)
            );
			return id;
		}
        /// <summary>
        /// 基本不用
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
		public bool Update(HA_ExecLog model)
		{
			string sqlStr = "update HA_ExecLog set log_intfcode=@log_intfcode,log_intfver=@log_intfver," +
                "log_reqjson=@log_reqjson,log_retjson=@log_retjson,log_datetime=@log_datetime," +
                "log_executor=@log_executor, log_mcode=@log_mcode, log_projcode=@log_projcode " +
                "where log_mcode=@log_mcode and log_datetime=@log_datetime";
			int rows = SQLHelper.ExecuteNonQuery(sqlStr
			, new SqlParameter("log_intfcode", model.log_intfcode)
			, new SqlParameter("log_intfver", model.log_intfver)
			, new SqlParameter("log_reqjson", model.log_reqjson)
			, new SqlParameter("log_retjson", model.log_retjson)
			, new SqlParameter("log_datetime", model.log_datetime)
			, new SqlParameter("log_executor", model.log_executor)
            , new SqlParameter("log_mcode", model.log_mcode)
            , new SqlParameter("log_projcode",model.log_projcode)
            );
			return rows > 0;
		}

		public bool Delete(string code,string dtValue)
		{
			string sqlStr = "delete from HA_ExecLog " +
                "where log_datetime=@log_datetime and log_mcode=@log_mcode";
			int rows = SQLHelper.ExecuteNonQuery(sqlStr
                , new SqlParameter("log_mcode", code),
                new SqlParameter("log_datetime", dtValue));
			return rows > 0;
		}

		private static HA_ExecLog ToModel(DataRow row)
		{
			HA_ExecLog model = new HA_ExecLog();
			model.log_intfcode = row.IsNull("log_intfcode") ? null : (String)row["log_intfcode"];
			model.log_intfver = row.IsNull("log_intfver") ? null : (String)row["log_intfver"];
			model.log_reqjson = row.IsNull("log_reqjson") ? null : (String)row["log_reqjson"];
			model.log_retjson = row.IsNull("log_retjson") ? null : (String)row["log_retjson"];
			model.log_datetime = row.IsNull("log_datetime") ? null : (DateTime?)row["log_datetime"];
			model.log_executor = row.IsNull("log_executor") ? null : (String)row["log_executor"];
            model.log_mcode = row.IsNull("log_mcode") ? null : (String)row["log_mcode"];
            model.log_mcode = row.IsNull("log_projcode") ? null : (String)row["log_projcode"];
            return model;
		}

		public HA_ExecLog GetModelById(int id)
		{
			string sqlStr = "select * from HA_ExecLog where id=@id";
			DataTable dt = SQLHelper.ExecuteDataTable(sqlStr, new SqlParameter("id", id));
			if (dt.Rows.Count > 1)
			{
				throw new Exception("more than 1 row was found");
			}
			if (dt.Rows.Count <= 0)
			{
				return null;
			}
			DataRow row = dt.Rows[0];
			HA_ExecLog model = ToModel(row);
			return model;
		}

		public IEnumerable<HA_ExecLog> ListAll()
		{
			List<HA_ExecLog> list = new List<HA_ExecLog>();
			string sqlStr = "select * from HA_ExecLog";
			DataTable dt = SQLHelper.ExecuteDataTable(sqlStr);
			foreach (DataRow row in dt.Rows)
			{
				list.Add(ToModel(row));
			}
			return list;
		}
	}
}
