using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hyd.API.JSONTbl.CodeGenerate.Templates;

namespace Hyd.API.JSONTbl
{
    public class CodeGenerator
    {
        public static ProjGenOptions InitProjGenOptions(string proj_code)
        {
            ProjGenOptions ret = new ProjGenOptions();

            return ret;
        }
        /// <summary>
        /// .sln 和 .csproj
        /// </summary>
        /// <returns></returns>
        public static bool GenSolution(ProjGenOptions projoption)
        {
            bool ret = false;
            return ret;
        }

        /// <summary>
        /// 接口定义 Proj    /Interfaces
        /// </summary>
        /// <returns></returns>
        public static bool GenInterface(ProjGenOptions projoption)
        {
            bool ret = false;
            return ret;
        }

        /// <summary>
        /// Service  继承 接口; /Services
        /// </summary>
        /// <returns></returns>
        public static bool GenService(ProjGenOptions projoption)
        {
            bool ret = false;
            return ret;
        }

        /// <summary>
        ///                /Controllers
        /// </summary>
        /// <returns></returns>
        public static bool GenController(ProjGenOptions projoption)
        {
            bool ret = false;
            return ret;
        }

        /// <summary>
        /// 参数          /Messages
        /// </summary>
        /// <returns></returns>
        public static bool GenAG(ProjGenOptions projoption)
        {
            bool ret = false;
            Messages t = new Messages();
            t.Session = new Microsoft.VisualStudio.TextTemplating.TextTemplatingSession();
            AGGroupOption agoption = new AGGroupOption {
                 Paras = new List<ParameterOption>()
            };
            
            //agoption.Paras.Add();
            //t.Session[""]
            return ret;
        }
    }
}
