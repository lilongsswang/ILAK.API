using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TempRestHostService
{
    /// <summary>
    /// 参数基础对象，包含Pager分页对象
    /// </summary>
    [DataContract]
    public class ParaBase : ParaRoot
    {
        [DataMember]
        public Pager Pager { get; set; }

        /// <summary>
        /// 获取或者设置过滤器数据，过滤器为一个字符串，拼接规则：字段名:字段值^字段名:字段值^...
        /// </summary>
        [DataMember]
        public string Filter { get; set; }
    }

    /// <summary>
    /// 参数根对象，空结构
    /// </summary>
    [DataContract]
    public class ParaRoot
    {

    }

    /// <summary>
    /// 分页对象
    /// </summary>
    [DataContract]
    public class Pager
    {
        [DataMember]
        public int Page { get; set; }
        [DataMember]
        public int PageSize { get; set; }
        [DataMember]
        public int Total { get; set; }

        public static Pager Default()
        {
            Pager pager = new Pager();
            pager.Page = 1;
            pager.PageSize = 10;
            return pager;
        }
    }
}
