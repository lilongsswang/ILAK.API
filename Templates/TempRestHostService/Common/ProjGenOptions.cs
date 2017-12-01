using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempRestHostService
{
    public class ProjGenOptions
    {
        public string ProjName { get; set; }
        public string ProjCode { get; set; }
        public string ProjPort { get; set; }

        public List<IntfGenOptions> Interfaces { get; set; }
    }

    public class IntfGenOptions
    {
        public string IntfName { get; set; }
        public string IntfCode { get; set; }
        public ConnStrOption IntfConnStr { get; set; }

        public MethodOptions Methods { get; set; }
    }

    public class MethodOptions
    {
        public string MCode { get; set; }
        public string MTemplate { get; set; }
        public string MSqlStmt { get; set; }
        public AGGroupOption MAgOption { get; set; }
        public int pagesize { get; set; }
    }

    public class AGGroupOption
    {
        public List<ParameterOption> Paras { get; set; }
    }

    public class ParameterOption
    {
        public string ParaName { get; set; }
        public string ParaCode { get; set; }
        public string DataType { get; set; }
        public string MaxLength { get; set; }
    }

    public class ConnStrOption
    {
        public string ConnString { get; set; }
        public string Host { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string DBName { get; set; }

        public string DbType { get; set; }
    }
}
