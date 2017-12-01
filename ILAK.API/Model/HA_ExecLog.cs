using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ILAK.API.Model
{
	public partial class HA_ExecLog
	{
		public Int32? log_id { get; set; }
		public String log_intfcode { get; set; }
		public String log_intfver { get; set; }
		public String log_reqjson { get; set; }
		public String log_retjson { get; set; }
		public DateTime? log_datetime { get; set; }
		public String log_executor { get; set; }
        public String log_mcode { get; set; }
        public String log_projcode { get; set; }

    }
}
