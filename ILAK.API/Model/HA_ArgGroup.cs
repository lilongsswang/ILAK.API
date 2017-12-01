using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ILAK.API.Model
{
	public partial class HA_ArgGroup
	{
		public Int32? ag_id { get; set; }
		public String ag_name { get; set; }
		public String ag_code { get; set; }
		public String ag_paras { get; set; }
		public String ag_note { get; set; }
	}
}
