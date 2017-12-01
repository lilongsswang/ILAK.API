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
	partial class HA_ConnectionDAL
	{
		public int AddNew(HA_Connection model)
		{
			string sqlStr = "insert into HA_Connection(conn_name,conn_IP,conn_Account,conn_Password,conn_DBType,conn_Alias,conn_CType,conn_String,conn_note) " +
                "output inserted.conn_id values(@conn_name,@conn_IP,@conn_Account,@conn_Password,@conn_DBType,@conn_Alias,@conn_CType,@conn_String,@conn_note)";
			int id = (int)SQLHelper.ExecuteScalar(sqlStr
			, new SqlParameter("conn_name", model.conn_name)
			, new SqlParameter("conn_IP", model.conn_IP)
			, new SqlParameter("conn_Account", model.conn_Account)
			, new SqlParameter("conn_Password", model.conn_Password)
			, new SqlParameter("conn_DBType", model.conn_DBType)
			, new SqlParameter("conn_Alias", model.conn_Alias)
			, new SqlParameter("conn_CType", model.conn_CType)
			, new SqlParameter("conn_String", model.conn_String)
			, new SqlParameter("conn_note", model.conn_note)
			);
			return id;
		}

		public bool Update(HA_Connection model)
		{
			string sqlStr = "update HA_Connection set conn_name=@conn_name,conn_IP=@conn_IP,conn_Account=@conn_Account," +
                "conn_Password=@conn_Password,conn_DBType=@conn_DBType,conn_Alias=@conn_Alias,conn_CType=@conn_CType," +
                "conn_String=@conn_String,conn_note=@conn_note where conn_name=@conn_name";
			int rows = SQLHelper.ExecuteNonQuery(sqlStr
			, new SqlParameter("conn_name", model.conn_name)
			, new SqlParameter("conn_IP", model.conn_IP)
			, new SqlParameter("conn_Account", model.conn_Account)
			, new SqlParameter("conn_Password", model.conn_Password)
			, new SqlParameter("conn_DBType", model.conn_DBType)
			, new SqlParameter("conn_Alias", model.conn_Alias)
			, new SqlParameter("conn_CType", model.conn_CType)
			, new SqlParameter("conn_String", model.conn_String)
			, new SqlParameter("conn_note", model.conn_note)
			);
			return rows > 0;
		}

		public bool Delete(int id)
		{
			string sqlStr = "delete from HA_Connection where conn_id=@id";
			int rows = SQLHelper.ExecuteNonQuery(sqlStr, new SqlParameter("id", id));
			return rows > 0;
		}

		private static HA_Connection ToModel(DataRow row)
		{
			HA_Connection model = new HA_Connection();
			model.conn_id = row.IsNull("conn_id") ? null : (Int32?)row["conn_id"];
			model.conn_name = row.IsNull("conn_name") ? null : (String)row["conn_name"];
			model.conn_IP = row.IsNull("conn_IP") ? null : (String)row["conn_IP"];
			model.conn_Account = row.IsNull("conn_Account") ? null : (String)row["conn_Account"];
			model.conn_Password = row.IsNull("conn_Password") ? null : (String)row["conn_Password"];
			model.conn_DBType = row.IsNull("conn_DBType") ? null : (String)row["conn_DBType"];
			model.conn_Alias = row.IsNull("conn_Alias") ? null : (String)row["conn_Alias"];
			model.conn_CType = row.IsNull("conn_CType") ? null : (String)row["conn_CType"];
			model.conn_String = row.IsNull("conn_String") ? null : (String)row["conn_String"];
			model.conn_note = row.IsNull("conn_note") ? null : (String)row["conn_note"];
			return model;
		}

		public HA_Connection GetModelById(int id)
		{
			string sqlStr = "select * from HA_Connection where conn_id=@id";
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
			HA_Connection model = ToModel(row);
			return model;
		}

		public IEnumerable<HA_Connection> ListAll()
		{
			List<HA_Connection> list = new List<HA_Connection>();
			string sqlStr = "select * from HA_Connection";
			DataTable dt = SQLHelper.ExecuteDataTable(sqlStr);
			foreach (DataRow row in dt.Rows)
			{
				list.Add(ToModel(row));
			}
			return list;
		}
	}
}
