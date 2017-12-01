using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ILAK.API.Model
{
	public partial class HA_Parameter
	{
		public Int32? para_id { get; set; }
		public String para_name { get; set; }
		public String para_code { get; set; }
		public String para_datatype { get; set; }
		public String para_length { get; set; }
		public Boolean? para_required { get; set; }
		public String para_default { get; set; }
		public String para_note { get; set; }
	}
}
