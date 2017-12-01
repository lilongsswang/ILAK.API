using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ILAK.API.Model
{
	public partial class HA_Interface
	{
		public Int32? intf_id { get; set; }
		public String intf_name { get; set; }
		public String intf_code { get; set; }
		public String intf_namespace { get; set; }
		public String intf_version { get; set; }
		public String intf_auth { get; set; }
		public String intf_dbconn { get; set; }
		public String intf_note { get; set; }
		public String proj_code { get; set; }
	}
}
