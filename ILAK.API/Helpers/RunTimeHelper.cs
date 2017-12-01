using ILAK.API.JsonClassGenerator;
using ILAK.API.JsonClassGenerator.CodeWriters;
using System;
using System.Windows.Forms;

namespace ILAK.API.Helpers
{
    public class RunTimeHelper
    {
        public static bool GenClassStringByJSON(string JSONString, string NameSpace, string SecondaryNameSpace, string TargetFolder, string MainClass)
        {
            try
            {
                var gen = new JsonClassGenerator.JsonClassGenerator()
                {
                    Example = JSONString,
                    InternalVisibility = false,
                    CodeWriter = new CSharpCodeWriter(),
                    ExplicitDeserialization = false,
                    Namespace = NameSpace,
                    NoHelperClass = true,
                    SecondaryNamespace = SecondaryNameSpace,
                    TargetFolder = TargetFolder,
                    UseProperties = true,
                    MainClass = MainClass,
                    SortMemberFields = true,
                    UsePascalCase = true,
                    UseNestedClasses = false,
                    ApplyObfuscationAttributes = false,
                    SingleFile = true,
                    ExamplesInDocumentation = true
                };
                if (gen == null) return false;
                try
                {
                    //需要升为.net framework 4.6才能打开这段注释
                    //gen.GenerateClasses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("无法生成代码: " + ex.Message, "错误", MessageBoxButtons.OK);
                    throw ex;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }


    }
}
