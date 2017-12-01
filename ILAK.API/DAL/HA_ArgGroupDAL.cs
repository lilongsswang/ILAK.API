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
	partial class HA_ArgGroupDAL
	{
		public int AddNew(HA_ArgGroup model)
		{
			string sqlStr = "insert into HA_ArgGroup(ag_name,ag_code,ag_paras,ag_note) output inserted.ag_id values(@ag_name,@ag_code,@ag_paras,@ag_note)";
			int id = (int)SQLHelper.ExecuteScalar(sqlStr
			, new SqlParameter("ag_name", model.ag_name)
			, new SqlParameter("ag_code", model.ag_code)
			, new SqlParameter("ag_paras", model.ag_paras)
			, new SqlParameter("ag_note", model.ag_note)
			);
			return id;
		}

		public bool Update(HA_ArgGroup model)
		{
			string sqlStr = "update HA_ArgGroup set ag_name=@ag_name,ag_code=@ag_code,ag_paras=@ag_paras,ag_note=@ag_note where ag_code=@ag_code";
			int rows = SQLHelper.ExecuteNonQuery(sqlStr
			, new SqlParameter("ag_name", model.ag_name)
			, new SqlParameter("ag_code", model.ag_code)
			, new SqlParameter("ag_paras", model.ag_paras)
			, new SqlParameter("ag_note", model.ag_note)
			);
			return rows > 0;
		}

		public bool Delete(string id)
		{
			string sqlStr = "delete from HA_ArgGroup where ag_code=@id";
			int rows = SQLHelper.ExecuteNonQuery(sqlStr, new SqlParameter("id", id));
			return rows > 0;
		}

		private static HA_ArgGroup ToModel(DataRow row)
		{
			HA_ArgGroup model = new HA_ArgGroup();
			model.ag_name = row.IsNull("ag_name") ? null : (String)row["ag_name"];
			model.ag_code = row.IsNull("ag_code") ? null : (String)row["ag_code"];
			model.ag_paras = row.IsNull("ag_paras") ? null : (String)row["ag_paras"];
			model.ag_note = row.IsNull("ag_note") ? null : (String)row["ag_note"];
			return model;
		}

		public HA_ArgGroup GetModelById(string id)
		{
			string sqlStr = "select * from HA_ArgGroup where ag_code=@id";
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
			HA_ArgGroup model = ToModel(row);
			return model;
		}

		public IEnumerable<HA_ArgGroup> ListAll()
		{
			List<HA_ArgGroup> list = new List<HA_ArgGroup>();
			string sqlStr = "select * from HA_ArgGroup";
			DataTable dt = SQLHelper.ExecuteDataTable(sqlStr);
			foreach (DataRow row in dt.Rows)
			{
				list.Add(ToModel(row));
			}
			return list;
		}
	}
}
