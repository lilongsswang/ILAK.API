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
	partial class HA_RetValObjectDAL
	{
		public int AddNew(HA_RetValObject model)
		{
			string sqlStr = "insert into HA_RetValObject(rv_name,rv_JSON,rv_exttype,rv_note) output inserted.rv_id values(@rv_name,@rv_JSON,@rv_exttype,@rv_note)";
			int id = (int)SQLHelper.ExecuteScalar(sqlStr
			, new SqlParameter("rv_name", model.rv_name)
			, new SqlParameter("rv_JSON", model.rv_JSON)
			, new SqlParameter("rv_exttype", model.rv_exttype)
			, new SqlParameter("rv_note", model.rv_note)
			);
			return id;
		}

		public bool Update(HA_RetValObject model)
		{
			string sqlStr = "update HA_RetValObject set rv_name=@rv_name,rv_JSON=@rv_JSON,rv_exttype=@rv_exttype,rv_note=@rv_note where rv_name=@rv_name";
			int rows = SQLHelper.ExecuteNonQuery(sqlStr
			, new SqlParameter("rv_name", model.rv_name)
			, new SqlParameter("rv_JSON", model.rv_JSON)
			, new SqlParameter("rv_exttype", model.rv_exttype)
			, new SqlParameter("rv_note", model.rv_note)
			);
			return rows > 0;
		}

		public bool Delete(string id)
		{
			string sqlStr = "delete from HA_RetValObject where rv_name=@id";
			int rows = SQLHelper.ExecuteNonQuery(sqlStr, new SqlParameter("id", id));
			return rows > 0;
		}

		private static HA_RetValObject ToModel(DataRow row)
		{
			HA_RetValObject model = new HA_RetValObject();
			model.rv_name = row.IsNull("rv_name") ? null : (String)row["rv_name"];
			model.rv_JSON = row.IsNull("rv_JSON") ? null : (String)row["rv_JSON"];
			model.rv_exttype = row.IsNull("rv_exttype") ? null : (String)row["rv_exttype"];
			model.rv_note = row.IsNull("rv_note") ? null : (String)row["rv_note"];
			return model;
		}

		public HA_RetValObject GetModelById(string id)
		{
            string sqlStr = "select * from HA_RetValObject where rv_name=@id";
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
			HA_RetValObject model = ToModel(row);
			return model;
		}

		public IEnumerable<HA_RetValObject> ListAll()
		{
			List<HA_RetValObject> list = new List<HA_RetValObject>();
			string sqlStr = "select * from HA_RetValObject";
			DataTable dt = SQLHelper.ExecuteDataTable(sqlStr);
			foreach (DataRow row in dt.Rows)
			{
				list.Add(ToModel(row));
			}
			return list;
		}
	}
}
