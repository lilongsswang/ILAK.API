using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ILAK.API.Model
{
	public partial class HA_Connection
	{
		public Int32? conn_id { get; set; }
		public String conn_name { get; set; }
		public String conn_IP { get; set; }
		public String conn_Account { get; set; }
		public String conn_Password { get; set; }
		public String conn_DBType { get; set; }
		public String conn_Alias { get; set; }
		public String conn_CType { get; set; }
		public String conn_String { get; set; }
		public String conn_note { get; set; }
	}
}
