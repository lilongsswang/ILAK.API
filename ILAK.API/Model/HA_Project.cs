using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ILAK.API.Model
{
	public partial class HA_Project
	{
		public Int32? proj_id { get; set; }
		public String proj_name { get; set; }
		public String proj_code { get; set; }
		public String proj_note { get; set; }
        public Int32 proj_port { get; set; }

    }
}
