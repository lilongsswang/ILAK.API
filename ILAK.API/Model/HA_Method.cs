using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ILAK.API.Model
{
	public partial class HA_Method
	{
		public String intf_code { get; set; }
		public Int32? m_id { get; set; }
		public String m_name { get; set; }
		public String m_code { get; set; }
		public String m_desc { get; set; }
		public String m_reqtype { get; set; }
		public Int32? m_template { get; set; }
		public String m_version { get; set; }
		public String m_funcode { get; set; }
		public Boolean? m_isencrypted { get; set; }
		public String m_arggrpcode { get; set; }
		public String m_rtnvaluecode { get; set; }
        public int m_pagesize { get; set; }
	}
}
