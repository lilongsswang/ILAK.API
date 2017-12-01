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
	partial class HA_ProjectDAL
	{
		public int AddNew(HA_Project model)
		{
			string sqlStr = "insert into HA_Project(proj_name,proj_code,proj_note,proj_port) output inserted.proj_id values" +
                "(@proj_name,@proj_code,@proj_note,@proj_port)";
            
			int id = (int)SQLHelper.ExecuteScalar(sqlStr
			, new SqlParameter("proj_name", model.proj_name)
			, new SqlParameter("proj_code", model.proj_code)
			, new SqlParameter("proj_note", model.proj_note)
            , new SqlParameter("proj_port", model.proj_port)
            );
			return id;
		}

		public bool Update(HA_Project model)
		{
			string sqlStr = "update HA_Project set proj_name=@proj_name,proj_code=@proj_code," +
                "proj_note=@proj_note,proj_port=@proj_port where proj_code=@proj_code";
			int rows = SQLHelper.ExecuteNonQuery(sqlStr
			, new SqlParameter("proj_name", model.proj_name)
			, new SqlParameter("proj_code", model.proj_code)
			, new SqlParameter("proj_note", model.proj_note)
            , new SqlParameter("proj_port", model.proj_port)
            );
			return rows > 0;
		}

		public bool Delete(string id)
		{
			string sqlStr = "delete from HA_Project where proj_code=@proj_code";
			int rows = SQLHelper.ExecuteNonQuery(sqlStr, new SqlParameter("proj_code", id));
			return rows > 0;
		}

		private static HA_Project ToModel(DataRow row)
		{
			HA_Project model = new HA_Project();
			model.proj_name = row.IsNull("proj_name") ? null : (String)row["proj_name"];
			model.proj_code = row.IsNull("proj_code") ? null : (String)row["proj_code"];
			model.proj_note = row.IsNull("proj_note") ? null : (String)row["proj_note"];
            model.proj_port = (Int32)row["proj_port"];
            return model;
		}

		public HA_Project GetModelById(string id)
		{
			string sqlStr = "select * from HA_Project where proj_code=@proj_code";
			DataTable dt = SQLHelper.ExecuteDataTable(sqlStr, new SqlParameter("proj_code", id));
			if (dt.Rows.Count > 1)
			{
				throw new Exception("more than 1 row was found");
			}
			if (dt.Rows.Count <= 0)
			{
				return null;
			}
			DataRow row = dt.Rows[0];
			HA_Project model = ToModel(row);
			return model;
		}

		public IEnumerable<HA_Project> ListAll()
		{
			List<HA_Project> list = new List<HA_Project>();
			string sqlStr = "select * from HA_Project";
			DataTable dt = SQLHelper.ExecuteDataTable(sqlStr);
			foreach (DataRow row in dt.Rows)
			{
				list.Add(ToModel(row));
			}
			return list;
		}
	}
}
