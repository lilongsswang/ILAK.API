using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ILAK.API.Model
{
	public partial class HA_RetValObject
	{
		public Int32? rv_id { get; set; }
		public String rv_name { get; set; }
		public String rv_JSON { get; set; }
		public String rv_exttype { get; set; }
		public String rv_note { get; set; }
	}
}
