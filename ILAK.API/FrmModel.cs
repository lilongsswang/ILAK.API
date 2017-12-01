using Microsoft.CSharp;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace ILAK.API.FrmModel
{
    public class BaseObject
    {

    }

    public enum TempType
    {
        Query = 1,
        CDUA,
        SP
    }

    public class TestReq
    {
        public string Cd { get; set; }
        public string DD { get; set; }

    }
    public class TestClassUtil
    {
        public string GetClassJSONString(object classObj, Dictionary<string, string> colums)
        {
            string resultJSON = JsonConvert.SerializeObject(classObj);
            return resultJSON;
            //return  ""Welcome "" + strName + "", Check in at "" + System.DateTime.Now.ToString();
        }
    }

    public class DynamicParasFactory
    {
        #region 废弃
        /// <summary>
        /// 暂时只支持string类型
        /// </summary>
        /// <param name="typeBuilder"></param>
        /// <param name="FieldName"></param>
        /// <param name="PropName"></param>
        /// <param name="JSONName"></param>
        /// <param name="Desc"></param>
        /// <returns></returns>
        private static TypeBuilder Constructor(TypeBuilder typeBuilder, string FieldName, string PropName, string JSONName, string Desc)
        {
            var fieldobj = typeBuilder.DefineField(FieldName, typeof(string), FieldAttributes.Private);
            var methodGet = typeBuilder.DefineMethod("Get" + PropName, MethodAttributes.Public, typeof(string), null);
            var methodSet = typeBuilder.DefineMethod("Set" + PropName, MethodAttributes.Public, null, new Type[] { typeof(string) });
            var ilGet = methodGet.GetILGenerator();
            ilGet.Emit(OpCodes.Ldarg_0);//this 入栈
            ilGet.Emit(OpCodes.Ldfld, fieldobj);
            ilGet.Emit(OpCodes.Ret);
            var ilSet = methodSet.GetILGenerator();
            ilSet.Emit(OpCodes.Ldarg_0);//this 入栈
            ilSet.Emit(OpCodes.Ldarg_1);//参数 入栈
            ilSet.Emit(OpCodes.Stfld, fieldobj);
            ilSet.Emit(OpCodes.Ret);
            var propertyObj = typeBuilder.DefineProperty(PropName, System.Reflection.PropertyAttributes.None, typeof(string), null);
            CustomAttributeBuilder customAttributeBuilder = new CustomAttributeBuilder(typeof(DescriptionAttribute).GetConstructor(new Type[] { typeof(string) }), new object[] { Desc });
            CustomAttributeBuilder customAttributeBuilder2 = new CustomAttributeBuilder(typeof(JsonPropertyAttribute).GetConstructor(new Type[] { typeof(string) }), new object[] { FieldName });
            propertyObj.SetCustomAttribute(customAttributeBuilder);//字段描述 
            propertyObj.SetCustomAttribute(customAttributeBuilder2);//JsonProperty 
            propertyObj.SetGetMethod(methodGet);
            propertyObj.SetSetMethod(methodSet);
            return typeBuilder;
        }

        private static object ConstructRequestObject(DataTable dt)
        {
            string timelyAssemblName = "HydDynamicProxy";
            var assemblyName = new AssemblyName(timelyAssemblName);


            var assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName,
                AssemblyBuilderAccess.RunAndSave);
            var moduleBuilder = assemblyBuilder.DefineDynamicModule("MainModule", "HydDynamicProxy.dll");
            //定义公开,继承Object,无接口的类
            var typeBuilder = moduleBuilder.DefineType("RequestObject", TypeAttributes.Public | TypeAttributes.Serializable, typeof(BaseObject), new Type[0]);
            int columnNumber = dt.Columns.Count;
            int rowNumber = dt.Rows.Count;
            //HardCode部分 指定了para_code和default的取值字段
            for (int j = 0; j < rowNumber; j++)
            {
                string FieldName = "", PropName = "", Desc = "";

                for (int i = 0; i < columnNumber; i++)
                {
                    if (dt.Columns[i].ColumnName == "para_code")
                    {
                        FieldName = dt.Rows[j].ItemArray[i].ToString();
                        PropName = GetFirstUpperStr(FieldName);
                    }
                    if (dt.Columns[i].ColumnName == "para_default")
                    {
                        Desc = dt.Rows[j].ItemArray[i].ToString();
                    }
                }
                typeBuilder = Constructor(typeBuilder, FieldName, PropName, FieldName, Desc);
            }

            var dynamicType = typeBuilder.CreateType();
            assemblyBuilder.Save(timelyAssemblName + ".dll");

            var instance = Activator.CreateInstance(dynamicType);

            return instance;
        }
        #endregion

        private static string GetFirstUpperStr(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                if (s.Length > 1)
                {
                    return char.ToUpper(s[0]) + s.Substring(1);
                }
                return char.ToUpper(s[0]).ToString();
            }
            return null;
        }

        /// <summary>
        /// 用hardcode的方式来生成RequestObject 分为两步: 第一步拼接Runtime Code, 第二步 调用本函数
        /// </summary>
        /// <param name="codeString"></param>
        /// <returns></returns>
        public static string TranslateObjectInCodeToJSON(string codeString)
        {
            // 1.新建CodeProvider
            CSharpCodeProvider objCSharpCodePrivoder = new CSharpCodeProvider();

            // 2.设置编译参数
            CompilerParameters objCompilerParameters = new CompilerParameters();
            objCompilerParameters.ReferencedAssemblies.Add("System.dll");
            objCompilerParameters.ReferencedAssemblies.Add("Newtonsoft.Json.dll");
            //objCompilerParameters.ReferencedAssemblies.Add("HydDynamicProxy.dll");
            objCompilerParameters.GenerateInMemory = true;

            // 3.得到编译结果
            CompilerResults cr = objCSharpCodePrivoder.CompileAssemblyFromSource(objCompilerParameters, codeString);

            if (cr.Errors.HasErrors)
            {
                string strErrorMsg = cr.Errors.Count.ToString() + " 错误:";

                for (int x = 0; x < cr.Errors.Count; x++)
                {
                    strErrorMsg = strErrorMsg + "/r/n行: " +
                                 cr.Errors[x].Line.ToString() + " - " +
                                 cr.Errors[x].ErrorText;
                }

                MessageBox.Show("出现编译错误" + strErrorMsg + ",请修改代码", "编译错误");
                return "";
            }

            // 4. 反射方式调用
            Assembly objAssembly = cr.CompiledAssembly;

            object objClass = objAssembly.CreateInstance("Hyd.Dynamic.ClassUtil");

            if (objClass == null)
            {
                MessageBox.Show("错误: " + "不能新建类ClassUtil.");
                return "";
            }
            object reqClass = objAssembly.CreateInstance("Hyd.Dynamic.RequestObject");
            if (reqClass == null)
            {
                MessageBox.Show("错误: " + "不能新建类RequestObject.");
                return "";
            }
            object[] objCodeParms = new object[1];
            objCodeParms[0] = reqClass;

            string strResult = (string)objClass.GetType().InvokeMember(
                       "GetClassJSONString", BindingFlags.InvokeMethod, null, objClass, objCodeParms);
            return strResult;
        }

        public static string CodeBuilder(DataTable dt)
        {
            int colNumber = dt.Columns.Count;
            int rowNumber = dt.Rows.Count;
            string fullCode = "";
            string frontCode = @"
                using System;
                using Newtonsoft.Json;
                using System.ComponentModel;

                namespace Hyd.Dynamic
                {";
            string classCode = @"
                    public class RequestObject{
                   
                    ";
            for (int j = 0; j < rowNumber; j++)
            {
                string FieldName = "", PropName = "", Desc = "";
                string DataType = "";
                for (int i = 0; i < colNumber; i++)
                {
                    if (dt.Columns[i].ColumnName == "para_name")
                    {
                        FieldName = dt.Rows[j].ItemArray[i].ToString();
                        PropName = GetFirstUpperStr(FieldName);
                    }
                    if (dt.Columns[i].ColumnName == "para_default")
                    {
                        Desc = dt.Rows[j].ItemArray[i].ToString();
                    }
                    if (dt.Columns[i].ColumnName == "para_datatype")
                    {
                        DataType = dt.Rows[j].ItemArray[i].ToString();
                    }
                }

                //[JsonProperty(""cd""), Description(""desc"")] public string Cd { get; set; }
                classCode += @"[JsonProperty(""" + FieldName + @"""), Description(""" + Desc + @""")] public " +
                             DataType + " " + PropName + @" {get; set;} ";
            }
            classCode = classCode + "}\n";
            string dynamicCode = @"public class ClassUtil
                    {
                        public string GetClassJSONString(object classObj)
                        {";

            for (int j = 0; j < rowNumber; j++)
            {
                string paraName = "";
                object tempDefaultValue = null;
                string DataType = "";

                for (int i = 0; i < colNumber; i++)
                {
                    //需要para_name先于para_default得到值
                    if (dt.Columns[i].ColumnName == "para_name")
                    {
                        paraName = dt.Rows[j].ItemArray[i].ToString();
                    }
                    if (dt.Columns[i].ColumnName == "para_default")
                    {
                        tempDefaultValue = dt.Rows[j].ItemArray[i];

                        dynamicCode += ("(classObj as RequestObject)." + GetFirstUpperStr(paraName) +
                            " = ");
                        //    + dt.Rows[j].ItemArray[i].ToString() + ";");
                        //dynamicCode += ("(classObj as RequestObject)." + GetFirstUpperStr(paraName) +
                        //    " = "
                        //    + @"""" + dt.Rows[j].ItemArray[i].ToString() + @""";");
                    }
                    if (dt.Columns[i].ColumnName == "para_datatype")
                    {
                        DataType = dt.Rows[j].ItemArray[i].ToString();
                        switch (DataType)
                        {
                            case "string":
                                dynamicCode += @"""" + tempDefaultValue.ToString() + @""";";
                                break;
                            case "bool":
                                dynamicCode += " " + tempDefaultValue.ToString() + ";";
                                break;
                            case "int":
                                dynamicCode += " " + Convert.ToInt32(tempDefaultValue) + ";";
                                break;
                            case "float":
                                dynamicCode += " " + Convert.ToSingle(tempDefaultValue) + "F;";
                                break;
                            case "double":
                                dynamicCode += " " + Convert.ToDouble(tempDefaultValue) + ";";
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            string endCode = @"
                            string resultJSON = JsonConvert.SerializeObject(classObj);
                            return resultJSON;
                        }
                    }
                }";

            fullCode = frontCode + classCode + dynamicCode + endCode;

            return fullCode;
        }
    }
}