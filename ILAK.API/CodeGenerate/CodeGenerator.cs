using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ILAK.API.CodeGenerate.Templates;
using HYD.Hds.Servcie;
using System.Collections;
using System.Data;
using Microsoft.VisualStudio.TextTemplating;
using System.IO;
using System.Configuration;
using System.Diagnostics;
using ILAK.API.Helpers;

namespace ILAK.API
{
    public class CodeGenerator
    {
        private static ProjGenOptions projOption { get; set; }
        public static bool InitProjGenOptions(string projcode)
        {
            bool ret = false;
            projOption = new ProjGenOptions();
            try
            {
                DbService db = null;
                db = DB.GetMainDb();
                Hashtable htPara = new Hashtable();
                htPara.Add("AntiSqlInject", "0");
                htPara.Add("proj_code", projcode);
                //初始化Project
                DataSet projects = db.ExecuteSqlID("GetProject", htPara);
                if (projects != null && projects.Tables.Count > 0)
                {
                    using (DataTable dt = projects.Tables[0])
                    {
                        projOption.ProjCode = dt.Rows[0]["proj_code"].ToString();
                        projOption.ProjName = dt.Rows[0]["proj_name"].ToString();
                        projOption.ProjPort = dt.Rows[0]["proj_port"].ToString();
                        projOption.Interfaces = new List<IntfGenOptions>();
                    }
                    //初始化接口
                    htPara = new Hashtable();
                    htPara.Add("AntiSqlInject", "0");
                    htPara.Add("proj_code", projcode);
                    DataSet interfaces = db.ExecuteSqlID("GetInterfaceGen", htPara);
                    if (interfaces != null && interfaces.Tables.Count > 0)
                    {
                        using (DataTable idt = interfaces.Tables[0])
                        {
                            foreach (DataRow iRow in idt.Rows)
                            {
                                IntfGenOptions igo = new IntfGenOptions
                                {
                                    IntfCode = iRow["intf_code"].ToString(),
                                    IntfName = iRow["intf_name"].ToString(),
                                    Methods = new List<MethodOptions>()
                                };

                                string conn = iRow["intf_dbconn"].ToString();
                                htPara = new Hashtable();
                                htPara.Add("AntiSqlInject", "0");
                                htPara.Add("conn_name", iRow["intf_dbconn"].ToString());
                                DataSet connections = db.ExecuteSqlID("GetConnection", htPara);
                                if (connections != null && connections.Tables.Count > 0)
                                {
                                    using (DataTable cdt = connections.Tables[0])
                                    {
                                        //初始化连接 目前 一个接口只会有一个数据库连接,所以这里直接取第一条记录
                                        ConnStrOption connOption = new ConnStrOption
                                        {
                                            Account = cdt.Rows[0]["conn_Account"].ToString(),
                                            DBName = cdt.Rows[0]["conn_Alias"].ToString(),
                                            DbType = cdt.Rows[0]["conn_DBType"].ToString(),
                                            Password = cdt.Rows[0]["conn_Password"].ToString(),
                                            ConnString = cdt.Rows[0]["conn_String"].ToString(),
                                            Host = cdt.Rows[0]["conn_IP"].ToString()
                                        };
                                        igo.ConnOption = connOption;

                                        //初始化方法
                                        Hashtable htParaM = new Hashtable();
                                        htParaM.Add("AntiSqlInject", "0");
                                        htParaM.Add("intf_code", iRow["intf_code"].ToString());
                                        DataSet methods = db.ExecuteSqlID("GetMethodGen", htParaM);
                                        if (methods != null && methods.Tables.Count > 0)
                                        {
                                            using (DataTable mdt = methods.Tables[0])
                                            {
                                                foreach (DataRow mRow in mdt.Rows)
                                                {
                                                    MethodOptions mOption = new MethodOptions
                                                    {
                                                        MCode = mRow["m_code"].ToString(),
                                                        MSqlStmt = mRow["m_funcode"].ToString(),
                                                        MTemplate = mRow["m_template"].ToString(),
                                                        pagesize = Convert.ToInt32(mRow["m_pagesize"].ToString())
                                                    };

                                                    htPara = new Hashtable();
                                                    htPara.Add("AntiSqlInject", "0");
                                                    htPara.Add("ag_code", mRow["m_arggrpcode"].ToString());
                                                    DataSet ag = db.ExecuteSqlID("GetAG", htPara);
                                                    if (ag != null && ag.Tables.Count > 0)
                                                    {
                                                        using (DataTable agdt = ag.Tables[0])
                                                        {
                                                            //一个method只有一组参数,所以这里也只取第一条记录
                                                            //初始化参数组 
                                                            AGGroupOption agOption = new AGGroupOption
                                                            {
                                                                AgCode = agdt.Rows[0]["ag_code"].ToString(),
                                                                Paras = new List<ParameterOption>()
                                                            };

                                                            // 初始化参数
                                                            htPara = new Hashtable();
                                                            htPara.Add("AntiSqlInject", "0");
                                                            htPara.Add("ag_code", mRow["m_arggrpcode"].ToString());
                                                            DataSet paras = db.ExecuteSqlID("GetParasWithAgCodeGen", htPara);
                                                            if (paras != null && paras.Tables.Count > 0)
                                                            {
                                                                using (DataTable pdt = paras.Tables[0])
                                                                {
                                                                    foreach (DataRow pitem in pdt.Rows)
                                                                    {
                                                                        ParameterOption paraOption = new ParameterOption
                                                                        {
                                                                            DataType = pitem["para_datatype"].ToString(),
                                                                            MaxLength = pitem["para_length"].ToString(),
                                                                            ParaCode = pitem["para_code"].ToString(),
                                                                            ParaName = pitem["para_name"].ToString()
                                                                        };
                                                                        agOption.Paras.Add(paraOption);
                                                                    }
                                                                }
                                                            }
                                                            mOption.MAgOption = agOption;
                                                        }
                                                    }
                                                    igo.Methods.Add(mOption);
                                                }
                                            }
                                        }
                                    }
                                    projOption.Interfaces.Add(igo);
                                }
                                else
                                {
                                    throw new Exception("没有配置连接信息");
                                }
                            }
                            ret = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }
        /// <summary>
        /// .sln 和 .csproj
        /// </summary>
        /// <returns></returns>
        public static string GenSolutionFile(string GUIDString)
        {
            string ret = "";
            SolutionTemplate t = new SolutionTemplate();
            t.Session = new TextTemplatingSession();
            t.Session["GUIDString"] = GUIDString;
            t.Initialize();
            ret = t.TransformText();
            return ret;
        }

        public static string GenProjectFile(string GUIDString)
        {
            string ret = "";
            ProjectFileTemplate t = new ProjectFileTemplate();
            t.Session = new TextTemplatingSession();
            t.Session["GUIDString"] = GUIDString;
            t.Session["ProjCode"] = projOption.ProjCode;
            t.Initialize();
            ret = t.TransformText();
            return ret;
        }

        /// <summary>
        /// 接口定义 Proj    /Interfaces
        /// </summary>
        /// <returns></returns>
        public static string GenInterface()
        {
            string ret = "";
            try
            {
                ListOfIntfGenOption lIntfOption = new ListOfIntfGenOption();
                lIntfOption.Interfaces = projOption.Interfaces;

                Interfaces t = new Interfaces();
                t.Session = new TextTemplatingSession();

                t.Session["IntfOptions"] = lIntfOption;
                t.Initialize();
                ret = t.TransformText();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        /// <summary>
        /// Service  继承 接口; /Services
        /// </summary>
        /// <returns></returns>
        public static string GenService()
        {
            string ret = "";
            try
            {
                ListOfIntfGenOption lIntfOption = new ListOfIntfGenOption();
                lIntfOption.Interfaces = projOption.Interfaces;

                Services t = new Services();
                t.Session = new TextTemplatingSession();

                t.Session["IntfOptions"] = lIntfOption;
                t.Initialize();
                ret = t.TransformText();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ret;
        }

        /// <summary>
        ///                /Controllers
        /// </summary>
        /// <returns></returns>
        public static string GenController()
        {
            string ret = "";
            try
            {
                ListOfIntfGenOption lIntfOption = new ListOfIntfGenOption();
                lIntfOption.Interfaces = projOption.Interfaces;

                Controllers t = new Controllers();
                t.Session = new TextTemplatingSession();

                t.Session["IntfOptions"] = lIntfOption;
                t.Initialize();
                ret = t.TransformText();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ret;
        }

        /// <summary>
        /// 参数          /Messages
        /// 手动去重
        /// </summary>
        /// <returns></returns>
        public static string GenAG()
        {
            string ret = "";
            try
            {
                List<string> existParaName = new List<string>();
                ListAGGroupOptions listAgOption = new ListAGGroupOptions();
                listAgOption.listAGOptions = new List<AGGroupOption>();
                foreach (var intfitem in projOption.Interfaces)
                {
                    foreach (var mitem in intfitem.Methods)
                    {
                        if (existParaName.Contains(mitem.MAgOption.AgCode)) continue;
                        existParaName.Add(mitem.MAgOption.AgCode);
                        listAgOption.listAGOptions.Add(mitem.MAgOption);
                    }
                }
                Messages t = new Messages();
                t.Session = new TextTemplatingSession();

                t.Session["MAgOptions"] = listAgOption;
                t.Initialize();

                // tt 模版设置了hostspecific="true" 后,下面这2行生效, 可控制IDE
                //EnvDTE.DTE dte = (EnvDTE.DTE)((IServiceProvider)t.Host).GetService(typeof(EnvDTE.DTE));
                ret = t.TransformText();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        public static string GenAppConfig()
        {
            string ret = "";
            try
            {
                AppConfigTemplate t = new AppConfigTemplate();
                t.Session = new TextTemplatingSession();
                t.Session["ProjOption"] = projOption;
                t.Session["HYDAPIConnString"] = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                t.Initialize();
                ret = t.TransformText();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        public static string GenProjServiceCS()
        {
            string ret = "";
            ProjServiceTemplate t = new ProjServiceTemplate();
            t.Session = new TextTemplatingSession();
            t.Session["ProjOption"] = projOption;
            t.Session["ProjCode"] = projOption.ProjCode;
            t.Initialize();
            ret = t.TransformText();
            return ret;
        }

        public static string GenProjServiceDesigner()
        {
            string ret = "";
            ProjServiceDesignerTemplate t = new ProjServiceDesignerTemplate();
            t.Session = new TextTemplatingSession();
            t.Session["ProjCode"] = projOption.ProjCode;
            t.Initialize();
            ret = t.TransformText();
            return ret;
        }

        public static string GenProjectInstaller()
        {
            string ret = "";
            ProjectInstallerTemplate t = new ProjectInstallerTemplate();
            t.Session = new TextTemplatingSession();
            t.Session["ProjCode"] = projOption.ProjCode;
            t.Initialize();
            ret = t.TransformText();
            return ret;
        }

        public static string GenProgram()
        {
            string ret = "";
            ProgramTemplate t = new ProgramTemplate();
            t.Session = new TextTemplatingSession();
            t.Session["ProjCode"] = projOption.ProjCode;
            t.Initialize();
            ret = t.TransformText();
            return ret;
        }

        public static string GenAssembly(string GUIDString)
        {
            string ret = "";
            AssemblyTemplate t = new AssemblyTemplate();
            t.Session = new TextTemplatingSession();
            t.Session["GUIDString"] = GUIDString;
            t.Initialize();
            ret = t.TransformText();
            return ret;
        }
        #region 拷贝生成的工程文件
        /// <summary>
        /// 拷贝到目标文件夹
        /// </summary>
        /// <returns></returns>
        public static bool CopyCodes()
        {
            bool ret = false;
            try
            {
                string currentFolder = Directory.GetCurrentDirectory();
                string templatePrefix = @"\Templates\";
                string generatePrefix = @"\GenerateSolution\";
                string fromPath = currentFolder + templatePrefix;
                string toPath = currentFolder + generatePrefix;
                //拷贝 Dll
                CopyDirectory(fromPath, toPath);
                ret = true;
            }
            catch (Exception)
            {

                throw;
            }
            return ret;
        }
        #endregion
        #region 编译解决方案
        public static string CompileSolution()
        {
            string ret = "";
            try
            {
                string currentFolder = Directory.GetCurrentDirectory();
                string generatePrefix = @"\GenerateSolution\";

                string workingDirectory = currentFolder + generatePrefix;

                string commandExe = @"c:\windows\Microsoft.NET\Framework\v4.0.30319\MSBuild ";

                string solutionName = @"ProjService.sln";
                string commandStr = solutionName + " /p:configuration=Release";
                string command = commandExe + commandStr;
                CmdHelper.RunCmd(workingDirectory, command, out ret);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }
        #endregion
        #region 拷贝编译结果
        public static string CopyServiceFiles(string DestPath)
        {
            string ret = "";
            try
            {
                string currentFolder = Directory.GetCurrentDirectory();
                string generatePrefix = @"\Deployments\Project" + projOption.ProjCode + @"\";

                string sourceDir = currentFolder + generatePrefix;
                CopyDirectory(sourceDir, DestPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }
        #endregion
        #region 生成帮助文档
        public static string GenHelpDoc()
        {
            string ret = "";
            try
            {
                HelpDocTemplate t = new HelpDocTemplate();
                t.Session = new TextTemplatingSession();
                t.Session["ProjOption"] = projOption;
                t.Initialize();
                ret = t.TransformText();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        #endregion
        #region 拷贝文件夹所有文件到目标文件夹
        public static void CopyDirectory(string srcPath, string destPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(srcPath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //获取目录下（不包含子目录）的文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)     //判断是否文件夹
                    {
                        if (!Directory.Exists(destPath + "\\" + i.Name))
                        {
                            Directory.CreateDirectory(destPath + "\\" + i.Name);   //目标目录下不存在此文件夹即创建子文件夹
                        }
                        CopyDirectory(i.FullName, destPath + "\\" + i.Name);    //递归方式调用复制子文件夹
                    }
                    else
                    {
                        if (!Directory.Exists(destPath))
                        {
                            Directory.CreateDirectory(destPath);
                        }
                        File.Copy(i.FullName, destPath + "\\" + i.Name, true);      //复制文件，true表示可以覆盖同名文件
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region 将现有文件的内容复制到新文件中
        /// <summary>
        /// 将源文件的内容复制到目标文件中
        /// </summary>
        /// <param name="sourceFilePath">源文件的绝对路径</param>
        /// <param name="destFilePath">目标文件的绝对路径</param>
        public static void CopyTo(string sourceFilePath, string destFilePath)
        {
            //有效性检测
            if (!File.Exists(sourceFilePath))
            {
                return;
            }
            try
            {
                //检测目标文件的目录是否存在，不存在则创建
                string destDirectoryPath = GetDirectoryFromFilePath(destFilePath);
                Directory.CreateDirectory(destDirectoryPath);
                //复制文件
                FileInfo file = new FileInfo(sourceFilePath);
                file.CopyTo(destFilePath, true);
            }
            catch
            {
            }
        }
        #endregion
        #region 从文件绝对路径中获取目录路径
        /// <summary>
        /// 从文件绝对路径中获取目录路径
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>
        public static string GetDirectoryFromFilePath(string filePath)
        {
            //实例化文件
            FileInfo file = new FileInfo(filePath);
            //获取目录信息
            DirectoryInfo directory = file.Directory;
            //返回目录路径
            return directory.FullName;
        }
        #endregion
        #region 保存指定文件
        /// <summary>
        /// filename 是 绝对路径
        /// </summary>
        /// <param name="filename">绝对路径</param>
        /// <returns></returns>
        public static bool SaveFileToFolder(string filename, string fileContent)
        {
            bool ret = false;
            try
            {
                FileInfo oFile = new FileInfo(filename);
                if (!oFile.Directory.Exists)
                    oFile.Directory.Create();
                if (!oFile.Exists)
                    oFile.Create().Close();
                StreamWriter oWrite = new StreamWriter(filename, false, Encoding.UTF8);
                oWrite.Write(fileContent);
                oWrite.Flush();
                oWrite.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }
        #endregion
        #region 删除指定文件
        /// <summary>
        /// 删除指定文件
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>
        public static void DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
        #endregion
        #region 删除指定目录
        /// <summary>
        /// 删除指定目录及其所有子目录
        /// </summary>
        /// <param name="directoryPath">指定目录的绝对路径</param>
        public static void DeleteDirectory(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                Directory.Delete(directoryPath, true);
            }
        }
        #endregion
        #region 清空指定目录
        /// <summary>
        /// 清空指定目录下所有文件及子目录,但该目录依然保存.
        /// </summary>
        /// <param name="directoryPath">指定目录的绝对路径</param>
        public static void ClearDirectory(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                //删除目录中所有的文件
                string[] fileNames = GetFileNames(directoryPath);
                for (int i = 0; i < fileNames.Length; i++)
                {
                    DeleteFile(fileNames[i]);
                }
                //删除目录中所有的子目录
                string[] directoryNames = GetDirectories(directoryPath);
                for (int i = 0; i < directoryNames.Length; i++)
                {
                    DeleteDirectory(directoryNames[i]);
                }
            }
        }
        #endregion
        #region 获取指定目录中的文件列表
        /// <summary>
        /// 获取指定目录中所有文件列表
        /// </summary>
        /// <param name="directoryPath">指定目录的绝对路径</param>        
        public static string[] GetFileNames(string directoryPath)
        {
            //如果目录不存在，则抛出异常
            if (!Directory.Exists(directoryPath))
            {
                throw new FileNotFoundException();
            }
            //获取文件列表
            return Directory.GetFiles(directoryPath);
        }
        /// <summary>
        /// 获取指定目录及子目录中所有文件列表
        /// </summary>
        /// <param name="directoryPath">指定目录的绝对路径</param>
        /// <param name="searchPattern">模式字符串，"*"代表0或N个字符，"?"代表1个字符。
        /// 范例："Log*.xml"表示搜索所有以Log开头的Xml文件。</param>
        /// <param name="isSearchChild">是否搜索子目录</param>
        public static string[] GetFileNames(string directoryPath, string searchPattern, bool isSearchChild)
        {
            //如果目录不存在，则抛出异常
            if (!Directory.Exists(directoryPath))
            {
                throw new FileNotFoundException();
            }
            try
            {
                if (isSearchChild)
                {
                    return Directory.GetFiles(directoryPath, searchPattern, SearchOption.AllDirectories);
                }
                else
                {
                    return Directory.GetFiles(directoryPath, searchPattern, SearchOption.TopDirectoryOnly);
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }
        #endregion
        #region 获取指定目录中的子目录列表
        /// <summary>
        /// 获取指定目录中所有子目录列表,若要搜索嵌套的子目录列表,请使用重载方法.
        /// </summary>
        /// <param name="directoryPath">指定目录的绝对路径</param>        
        public static string[] GetDirectories(string directoryPath)
        {
            try
            {
                return Directory.GetDirectories(directoryPath);
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取指定目录及子目录中所有子目录列表
        /// </summary>
        /// <param name="directoryPath">指定目录的绝对路径</param>
        /// <param name="searchPattern">模式字符串，"*"代表0或N个字符，"?"代表1个字符。
        /// 范例："Log*.xml"表示搜索所有以Log开头的Xml文件。</param>
        /// <param name="isSearchChild">是否搜索子目录</param>
        public static string[] GetDirectories(string directoryPath, string searchPattern, bool isSearchChild)
        {
            try
            {
                if (isSearchChild)
                {
                    return Directory.GetDirectories(directoryPath, searchPattern, SearchOption.AllDirectories);
                }
                else
                {
                    return Directory.GetDirectories(directoryPath, searchPattern, SearchOption.TopDirectoryOnly);
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}