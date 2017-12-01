using HYD.Hds.Servcie;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ILAK.API
{
    public partial class FrmGenerate : Form
    {
        public FrmGenerate() {
            InitializeComponent();
            SetStyles();
        }
        #region 减少闪烁
        //减少闪烁
        private void SetStyles() {
            base.SetStyle(
              ControlStyles.UserPaint |
              ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.ResizeRedraw |
              ControlStyles.DoubleBuffer, true);
            base.UpdateStyles();
            base.AutoScaleMode = AutoScaleMode.None;
        }

        #endregion

        private void tBtnOpenFolder_Click(object sender, EventArgs e)
        {
            string path = txtDestPath.Text;
            try
            {
                if (string.IsNullOrEmpty(txtDestPath.Text))
                {
                    MessageBox.Show("请填写一个本地目录地址");
                    return;
                }
                if (txtDestPath.Text == txtDirectoryPath.Text)
                {
                    MessageBox.Show("请选择另外一个目录来保存.");
                    return;
                }
                CodeGenerator.CopyServiceFiles(path);
                //完成后 打开拷贝到的目录
                System.Diagnostics.Process.Start("Explorer.exe", path);
                
            }
            catch (Exception)
            {
            }
        }

        private void tBtnGenerate_Click(object sender, EventArgs e)
        {
            if (listVProjects.SelectedItems.Count > 0)
            {
                var a = listVProjects.SelectedItems[0];
                string projcode = a.Text;
                try
                {
                    txtDirectoryPath.Text = "";
                    txtCompileResult.Text = "";
                    T_Helper.Text = "";

                    var initResult = CodeGenerator.InitProjGenOptions(projcode);
                    if (initResult == false)
                    {
                        MessageBox.Show("初始化失败!");
                    }
                    //后期看是否在此处分模版.
                    string GUIDString = Guid.NewGuid().ToString();
                    var projectfileResult = CodeGenerator.GenProjectFile(GUIDString);
                    var solutionfileResult = CodeGenerator.GenSolutionFile(GUIDString);
                    var assemblyResult = CodeGenerator.GenAssembly(GUIDString);
                    var agResult = CodeGenerator.GenAG();
                    var intfResult = CodeGenerator.GenInterface();
                    var servResult = CodeGenerator.GenService();
                    var controllerResult = CodeGenerator.GenController();
                    var appconfigResult = CodeGenerator.GenAppConfig();
                    var projserviceResult = CodeGenerator.GenProjServiceCS();
                    var projservicedesignerResult = CodeGenerator.GenProjServiceDesigner();
                    var projectinstallerResult = CodeGenerator.GenProjectInstaller();
                    var programResult = CodeGenerator.GenProgram();

                    //保存这些生成的文本为文件
                    string currentFolder = Directory.GetCurrentDirectory();
                    string outputPrefix = @"\GenerateSolution\";
                    string projectPrefix = @"TempRestHostService\";
                    string solutionlevel = currentFolder + outputPrefix;
                    string outputFolder = currentFolder + outputPrefix + projectPrefix;
                    //清理生成目录
                    CodeGenerator.ClearDirectory(solutionlevel);
                    //解决方案文件
                    CodeGenerator.SaveFileToFolder(solutionlevel + "ProjService.sln", solutionfileResult);
                    //项目文件
                    CodeGenerator.SaveFileToFolder(outputFolder + "TempRestHostService.csproj", projectfileResult);
                    //assembly文件
                    CodeGenerator.SaveFileToFolder(outputFolder + @"Properties\AssemblyInfo.cs", assemblyResult);
                    //消息
                    CodeGenerator.SaveFileToFolder(outputFolder + @"Messages\TemplateAG.cs", agResult);
                    //接口
                    CodeGenerator.SaveFileToFolder(outputFolder + @"Interfaces\TemplateInterface.cs", intfResult);
                    //服务
                    CodeGenerator.SaveFileToFolder(outputFolder + @"Services\TemplateService.cs", servResult);
                    //控制类
                    CodeGenerator.SaveFileToFolder(outputFolder + @"Controllers\TemplateController.cs", controllerResult);
                    //appconfig
                    CodeGenerator.SaveFileToFolder(outputFolder + "App.config", appconfigResult);
                    //服务安装文件
                    CodeGenerator.SaveFileToFolder(outputFolder + "ProjService.cs", projserviceResult);
                    CodeGenerator.SaveFileToFolder(outputFolder + "ProjService.Designer.cs", projservicedesignerResult);
                    CodeGenerator.SaveFileToFolder(outputFolder + "ProjectInstaller.Designer.cs", projectinstallerResult);
                    //服务程序入口
                    CodeGenerator.SaveFileToFolder(outputFolder + "Program.cs", programResult);

                    if (CodeGenerator.CopyCodes())
                    {
                        txtCompileResult.Text = CodeGenerator.CompileSolution();
                        txtDirectoryPath.Text = currentFolder + @"\Deployments\Project" + projcode + @"\";
                        T_Helper.Text = CodeGenerator.GenHelpDoc();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FrmGenerate_Load(object sender, EventArgs e)
        {
            GetAllProjects();
        }

        private void tBtnRefresh_Click(object sender, EventArgs e)
        {
            GetAllProjects();
        }

        private void GetAllProjects()
        {
            DbService db = DB.GetMainDb();
            Controller c = new Controller();
            DataSet projects = db.ExecuteSqlID("GetProjects", null);
            DataTable Projects = null;
            if (projects != null && projects.Tables.Count > 0) Projects = projects.Tables[0];
            c.ShowDataTableInListView(Projects, listVProjects);
        }

        #region 测试代码
        //private void tBtnGenerate_Click(object sender, EventArgs e)
        //{
        //    #region 动态编译测试old
        //    //if (T_ClassName_Compile.Text.Length == 0 || T_Code.Text.Length == 0 || T_Function_Compile.Text.Length == 0)
        //    //{
        //    //    MessageBox.Show("Pls enter function name and the C# code.");
        //    //    return;
        //    //}
        //    //string codeString = @"
        //    //using System;
        //    //namespace INRuntime  
        //    //{  
        //    //class RunningClass
        //    //{  
        //    //public static string CompileFunc(string sMsg)  
        //    //{  
        //    //    return ""Compile function:"" + sMsg;  
        //    //}
        //    //    }
        //    //}";

        //    //CompilerParameters compilerParams = new CompilerParameters
        //    //{
        //    //    //编译器选项设置
        //    //    CompilerOptions = "/target:library /optimize",
        //    //    //编译时在内存输出
        //    //    GenerateInMemory = true,
        //    //    //生成调试信息
        //    //    IncludeDebugInformation = false
        //    //};

        //    //CodeDomProvider cdp = CodeDomProvider.CreateProvider("C#");

        //    //CompilerParameters cp = new CompilerParameters();

        //    //cp.ReferencedAssemblies.Add("System.dll");
        //    ////cp.ReferencedAssemblies.Add("");
        //    //cp.GenerateExecutable = false;
        //    //cp.GenerateInMemory = true;
        //    //cp.IncludeDebugInformation = false;

        //    //CompilerResults cr = cdp.CompileAssemblyFromSource(cp, codeString); // T_Code.Text);

        //    //if (cr.Errors.HasErrors)
        //    //{
        //    //    StringBuilder sb = new StringBuilder();
        //    //    sb.AppendLine("Compile code error.");
        //    //    foreach (CompilerError error in cr.Errors)
        //    //        sb.AppendLine(error.ErrorText);

        //    //    MessageBox.Show(sb.ToString());
        //    //    return;
        //    //}

        //    //Assembly ass = cr.CompiledAssembly;
        //    //Type type = ass.GetType(T_ClassName_Compile.Text);
        //    //MethodInfo mi = type.GetMethod(T_Function_Compile.Text);

        //    //object[] objParams = null;
        //    //if (T_Param_Compile.Text.Length != 0)
        //    //{
        //    //    objParams = new object[1];
        //    //    objParams[0] = T_Param_Compile.Text;
        //    //}
        //    //T_Result_Compile.Text = (string)mi.Invoke(null, objParams);
        //    #endregion
        //    #region 动态编译测试程序
        //    //获取代码文本
        //    string strSourceCode = @"
        //        using System;

        //        namespace Dynamicly
        //        {
        //            public class HelloWorld
        //            {
        //                public string GetTime(string strName)
        //                {
        //                    return  ""Welcome "" + strName + "", Check in at "" + System.DateTime.Now.ToString();
        //                }
        //            }
        //        }
        //        ";

        //    // 1.新建CodeProvider
        //    CSharpCodeProvider objCSharpCodePrivoder = new CSharpCodeProvider();

        //    // 2.设置编译参数
        //    CompilerParameters objCompilerParameters = new CompilerParameters();
        //    objCompilerParameters.ReferencedAssemblies.Add("System.dll");
        //    objCompilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
        //    objCompilerParameters.GenerateInMemory = true;

        //    // 3.得到编译结果
        //    CompilerResults cr = objCSharpCodePrivoder.CompileAssemblyFromSource(objCompilerParameters, strSourceCode);

        //    if (cr.Errors.HasErrors)
        //    {
        //        string strErrorMsg = cr.Errors.Count.ToString() + " 错误:";

        //        for (int x = 0; x < cr.Errors.Count; x++)
        //        {
        //            strErrorMsg = strErrorMsg + "/r/n行: " +
        //                         cr.Errors[x].Line.ToString() + " - " +
        //                         cr.Errors[x].ErrorText;
        //        }

        //        T_Code.Text = strErrorMsg;
        //        MessageBox.Show("出现编译错误，请修改代码", "编译错误");
        //        return;
        //    }

        //    // 4. 反射方式调用
        //    Assembly objAssembly = cr.CompiledAssembly; 
        //    // 测试命名空间
        //    object objClass = objAssembly.CreateInstance("Dynamicly.HelloWorld");

        //    if (objClass == null)
        //    {
        //        T_Code.Text = "错误: " + "不能新建该类.";
        //        return;
        //    }

        //    object[] objCodeParms = new object[1];
        //    objCodeParms[0] = "ILAK";

        //    string strResult = (string)objClass.GetType().InvokeMember(
        //               "GetTime", BindingFlags.InvokeMethod, null, objClass, objCodeParms);
        //    T_Code.Text = strResult;
        //    #endregion
        //}
        #endregion
    }
}
