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
	partial class HA_InterfaceDAL
	{
		public int AddNew(HA_Interface model)
		{
			string sqlStr = "insert into HA_Interface(intf_name,intf_code,intf_namespace,intf_version,intf_auth,intf_dbconn,intf_note,proj_code) output inserted.intf_id values(@intf_name,@intf_code,@intf_namespace,@intf_version,@intf_auth,@intf_dbconn,@intf_note,@proj_code)";
			int id = (int)SQLHelper.ExecuteScalar(sqlStr
			, new SqlParameter("intf_name", model.intf_name)
			, new SqlParameter("intf_code", model.intf_code)
			, new SqlParameter("intf_namespace", model.intf_namespace)
			, new SqlParameter("intf_version", model.intf_version)
			, new SqlParameter("intf_auth", model.intf_auth)
			, new SqlParameter("intf_dbconn", model.intf_dbconn)
			, new SqlParameter("intf_note", model.intf_note)
			, new SqlParameter("proj_code", model.proj_code)
			);
			return id;
		}

		public bool Update(HA_Interface model)
		{
			string sqlStr = "update HA_Interface set intf_name=@intf_name,intf_code=@intf_code," +
                "intf_namespace=@intf_namespace,intf_version=@intf_version,intf_auth=@intf_auth," +
                "intf_dbconn=@intf_dbconn,intf_note=@intf_note,proj_code=@proj_code " +
                "where intf_code=@intf_code";
			int rows = SQLHelper.ExecuteNonQuery(sqlStr
			, new SqlParameter("intf_name", model.intf_name)
			, new SqlParameter("intf_code", model.intf_code)
			, new SqlParameter("intf_namespace", model.intf_namespace)
			, new SqlParameter("intf_version", model.intf_version)
			, new SqlParameter("intf_auth", model.intf_auth)
			, new SqlParameter("intf_dbconn", model.intf_dbconn)
			, new SqlParameter("intf_note", model.intf_note)
			, new SqlParameter("proj_code", model.proj_code)
			);
			return rows > 0;
		}

		public bool Delete(string id)
		{
			string sqlStr = "delete from HA_Interface where intf_code=@id";
			int rows = SQLHelper.ExecuteNonQuery(sqlStr, new SqlParameter("id", id));
			return rows > 0;
		}

		private static HA_Interface ToModel(DataRow row)
		{
			HA_Interface model = new HA_Interface();
			model.intf_name = row.IsNull("intf_name") ? null : (String)row["intf_name"];
			model.intf_code = row.IsNull("intf_code") ? null : (String)row["intf_code"];
			model.intf_namespace = row.IsNull("intf_namespace") ? null : (String)row["intf_namespace"];
			model.intf_version = row.IsNull("intf_version") ? null : (String)row["intf_version"];
			model.intf_auth = row.IsNull("intf_auth") ? null : (String)row["intf_auth"];
			model.intf_dbconn = row.IsNull("intf_dbconn") ? null : (String)row["intf_dbconn"];
			model.intf_note = row.IsNull("intf_note") ? null : (String)row["intf_note"];
			model.proj_code = row.IsNull("proj_code") ? null : (String)row["proj_code"];
			return model;
		}

		public HA_Interface GetModelById(string id)
		{
			string sqlStr = "select * from HA_Interface where intf_code=@id";
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
			HA_Interface model = ToModel(row);
			return model;
		}

		public IEnumerable<HA_Interface> ListAll()
		{
			List<HA_Interface> list = new List<HA_Interface>();
			string sqlStr = "select * from HA_Interface";
			DataTable dt = SQLHelper.ExecuteDataTable(sqlStr);
			foreach (DataRow row in dt.Rows)
			{
				list.Add(ToModel(row));
			}
			return list;
		}
	}
}
