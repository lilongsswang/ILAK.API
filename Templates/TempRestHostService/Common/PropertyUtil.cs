using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TempRestHostService
{
    public class PropertyUtil
    {
        /// <summary>
        /// 获取某个对象的[公有属性]的名称,类型,值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetPropertyValue<T>(T obj, bool onlyGetNull = false)
        {
            //if (obj == null)
            //{
            //    return "null";
            //}
            //Type t = obj.GetType();//获得该类的Type
            ////再用Type.GetProperties获得PropertyInfo[],然后就可以用foreach 遍历了
            //var sb = new StringBuilder();
            //sb.AppendFormat("类型{0} [公有属性]的名称,类型,值{1}\r\n", t.FullName, onlyGetNull ? "只显示空值的" : "");
            //var i = 0;
            //foreach (PropertyInfo pi in t.GetProperties())
            //{
            //    var name = pi.Name;//获得属性的名字,后面就可以根据名字判断来进行些自己想要的操作
            //    var value = pi.GetValue(obj, null);//用pi.GetValue获得值
            //    var type = value?.GetType() ?? typeof(object);//获得属性的类型
            //    if (onlyGetNull && value != null) continue;
            //    i++;
            //    sb.AppendFormat("{3}  {0} {1}={2}\r\n", type, name, value?.ToString() ?? "null", i.ToString().PadLeft(2, '0'));
            //    // sb.Append("类型：" + pi.PropertyType.FullName + " 属性名：" + pi.Name + " 值：" + pi.GetValue(obj, null) + "");
            //}
            //return sb.ToString();
			return "";
        }

        /// <summary>
        /// 获取某个对象的[公有属性]的名称 不要null值属性
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Dictionary<string, object> GetPropertyName<T>(T obj)
        {
            Dictionary<string, object> ret = new Dictionary<string, object>();
            if (obj == null)
            {
                return null;
            }
            Type t = obj.GetType();//获得该类的Type
            //再用Type.GetProperties获得PropertyInfo[],然后就可以用foreach 遍历了
            foreach (PropertyInfo pi in t.GetProperties())
            {
                var name = pi.Name;//获得属性的名字,后面就可以根据名字判断来进行些自己想要的操作
                var value = pi.GetValue(obj, null);//用pi.GetValue获得值
                if (value == null) continue;
                //var type = value?.GetType() ?? typeof(object);//获得属性的类型
                ret.Add(name, value);
            }
            return ret;
        }
    }
}
