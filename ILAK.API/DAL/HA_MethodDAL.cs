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
	partial class HA_MethodDAL
	{
		public int AddNew(HA_Method model)
		{
			string sqlStr = "insert into HA_Method(intf_code,m_name,m_code,m_desc,m_reqtype,m_template,m_version,m_funcode,m_isencrypted,m_arggrpcode,m_rtnvaluecode,m_pagesize) " +
                "output inserted.m_id values(@intf_code,@m_name,@m_code,@m_desc,@m_reqtype,@m_template,@m_version,@m_funcode,@m_isencrypted,@m_arggrpcode,@m_rtnvaluecode,@m_pagesize)";
			int id = (int)SQLHelper.ExecuteScalar(sqlStr
			, new SqlParameter("intf_code", model.intf_code)
			, new SqlParameter("m_name", model.m_name)
			, new SqlParameter("m_code", model.m_code)
			, new SqlParameter("m_desc", model.m_desc)
			, new SqlParameter("m_reqtype", model.m_reqtype)
			, new SqlParameter("m_template", model.m_template)
			, new SqlParameter("m_version", model.m_version)
			, new SqlParameter("m_funcode", model.m_funcode)
			, new SqlParameter("m_isencrypted", model.m_isencrypted)
			, new SqlParameter("m_arggrpcode", model.m_arggrpcode)
			, new SqlParameter("m_rtnvaluecode", model.m_rtnvaluecode)
            , new SqlParameter("m_pagesize", model.m_pagesize)
            );
			return id;
		}

		public bool Update(HA_Method model)
		{
			string sqlStr = "update HA_Method set intf_code=@intf_code,m_name=@m_name,m_code=@m_code,m_desc=@m_desc,m_reqtype=@m_reqtype," +
                "m_template=@m_template,m_version=@m_version,m_funcode=@m_funcode,m_isencrypted=@m_isencrypted,m_arggrpcode=@m_arggrpcode," +
                "m_rtnvaluecode=@m_rtnvaluecode, m_pagesize=@m_pagesize where m_code=@m_code";
			int rows = SQLHelper.ExecuteNonQuery(sqlStr
			, new SqlParameter("intf_code", model.intf_code)
			, new SqlParameter("m_name", model.m_name)
			, new SqlParameter("m_code", model.m_code)
			, new SqlParameter("m_desc", model.m_desc)
			, new SqlParameter("m_reqtype", model.m_reqtype)
			, new SqlParameter("m_template", model.m_template)
			, new SqlParameter("m_version", model.m_version)
			, new SqlParameter("m_funcode", model.m_funcode)
			, new SqlParameter("m_isencrypted", model.m_isencrypted)
			, new SqlParameter("m_arggrpcode", model.m_arggrpcode)
			, new SqlParameter("m_rtnvaluecode", model.m_rtnvaluecode)
            , new SqlParameter("m_pagesize", model.m_pagesize)
            );
			return rows > 0;
		}

		public bool Delete(string id)
		{
			string sqlStr = "delete from HA_Method where m_code=@id";
			int rows = SQLHelper.ExecuteNonQuery(sqlStr, new SqlParameter("id", id));
			return rows > 0;
		}

		private static HA_Method ToModel(DataRow row)
		{
			HA_Method model = new HA_Method();
			model.intf_code = row.IsNull("intf_code") ? null : (String)row["intf_code"];
			model.m_name = row.IsNull("m_name") ? null : (String)row["m_name"];
			model.m_code = row.IsNull("m_code") ? null : (String)row["m_code"];
			model.m_desc = row.IsNull("m_desc") ? null : (String)row["m_desc"];
			model.m_reqtype = row.IsNull("m_reqtype") ? null : (String)row["m_reqtype"];
			model.m_template = row.IsNull("m_template") ? null : (Int32?)row["m_template"];
			model.m_version = row.IsNull("m_version") ? null : (String)row["m_version"];
			model.m_funcode = row.IsNull("m_funcode") ? null : (String)row["m_funcode"];
			model.m_isencrypted = row.IsNull("m_isencrypted") ? null : (Boolean?)row["m_isencrypted"];
			model.m_arggrpcode = row.IsNull("m_arggrpcode") ? null : (String)row["m_arggrpcode"];
			model.m_rtnvaluecode = row.IsNull("m_rtnvaluecode") ? null : (String)row["m_rtnvaluecode"];
            model.m_pagesize = row.IsNull("m_pagesize") ? 0 : (int)row["m_pagesize"];
            return model;
		}

		public HA_Method GetModelById(string id)
		{
			string sqlStr = "select * from HA_Method where m_code=@id";
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
			HA_Method model = ToModel(row);
			return model;
		}

		public IEnumerable<HA_Method> ListAll()
		{
			List<HA_Method> list = new List<HA_Method>();
			string sqlStr = "select * from HA_Method";
			DataTable dt = SQLHelper.ExecuteDataTable(sqlStr);
			foreach (DataRow row in dt.Rows)
			{
				list.Add(ToModel(row));
			}
			return list;
		}
	}
}
