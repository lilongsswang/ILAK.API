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
	partial class HA_ParameterDAL
	{
		public int AddNew(HA_Parameter model)
		{
			string sqlStr = "insert into HA_Parameter(para_name,para_code,para_datatype,para_length," +
                "para_required,para_default,para_note) output inserted.para_id " +
                " values(@para_name,@para_code,@para_datatype,@para_length," +
                "@para_required,@para_default,@para_note)";
			int id = (int)SQLHelper.ExecuteScalar(sqlStr
			, new SqlParameter("para_name", model.para_name)
			, new SqlParameter("para_code", model.para_code)
			, new SqlParameter("para_datatype", model.para_datatype)
			, new SqlParameter("para_length", model.para_length)
			, new SqlParameter("para_required", model.para_required)
			, new SqlParameter("para_default", model.para_default)
			, new SqlParameter("para_note", model.para_note)
			);
			return id;
		}

		public bool Update(HA_Parameter model)
		{
			string sqlStr = "update HA_Parameter set para_name=@para_name,para_code=@para_code,para_datatype=@para_datatype,para_length=@para_length,para_required=@para_required,para_default=@para_default,para_note=@para_note where para_code=@para_code";
			int rows = SQLHelper.ExecuteNonQuery(sqlStr
			, new SqlParameter("para_name", model.para_name)
			, new SqlParameter("para_code", model.para_code)
			, new SqlParameter("para_datatype", model.para_datatype)
			, new SqlParameter("para_length", model.para_length)
			, new SqlParameter("para_required", model.para_required)
			, new SqlParameter("para_default", model.para_default)
			, new SqlParameter("para_note", model.para_note)
			);
			return rows > 0;
		}

		public bool Delete(string id)
		{
			string sqlStr = "delete from HA_Parameter where para_code=@id";
			int rows = SQLHelper.ExecuteNonQuery(sqlStr, new SqlParameter("id", id));
			return rows > 0;
		}

		private static HA_Parameter ToModel(DataRow row)
		{
			HA_Parameter model = new HA_Parameter();
			model.para_name = row.IsNull("para_name") ? null : (String)row["para_name"];
			model.para_code = row.IsNull("para_code") ? null : (String)row["para_code"];
			model.para_datatype = row.IsNull("para_datatype") ? null : (String)row["para_datatype"];
			model.para_length = row.IsNull("para_length") ? null : (String)row["para_length"];
			model.para_required = row.IsNull("para_required") ? null : (Boolean?)row["para_required"];
			model.para_default = row.IsNull("para_default") ? null : (String)row["para_default"];
			model.para_note = row.IsNull("para_note") ? null : (String)row["para_note"];
            return model;
		}

		public HA_Parameter GetModelById(string id)
		{
			string sqlStr = "select * from HA_Parameter where para_code=@id";
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
			HA_Parameter model = ToModel(row);
			return model;
		}

		public IEnumerable<HA_Parameter> ListAll()
		{
			List<HA_Parameter> list = new List<HA_Parameter>();
			string sqlStr = "select * from HA_Parameter";
			DataTable dt = SQLHelper.ExecuteDataTable(sqlStr);
			foreach (DataRow row in dt.Rows)
			{
				list.Add(ToModel(row));
			}
			return list;
		}
	}
}
