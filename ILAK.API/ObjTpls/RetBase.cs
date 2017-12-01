using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ILAK.API.ObjTpls
{
    [DataContract]
    public class RetBase<T>
    {
        public RetBase()
        { 
            define = new TableDefine();
        }

        [DataMember]
        public string code { get; set; }

        [DataMember]
        public string msg { get; set; }

        [DataMember]
        public T data { get; set; }
        [DataMember]
        public Pager pager { get; set; }
        [DataMember]
        public TableDefine define { get; set; }

        public Stream ToStream()
        {
            string jsonResult = JsonTool.ObjectToJson(this);
            byte[] resbyte = System.Text.Encoding.UTF8.GetBytes(jsonResult);
            System.IO.MemoryStream memo = new System.IO.MemoryStream(resbyte);
            memo.Seek(0, System.IO.SeekOrigin.Begin); 
            return memo;
        }
    }
    [DataContract]
    public class TableDefine
    {
        public TableDefine()
        {
            Items = new List<TableDefineItem>();
        }
        [DataMember]
        public string Cd { get; set; }
        [DataMember]
        public string CnNam { get; set; }
        [DataMember]
        public string Nam { get; set; }

        [DataMember]
        public List<TableDefineItem> Items { get; set; }
         [DataMember]
        public string ItemsCfg { get; set; }
    }
    [DataContract]
    public class TableDefineItem
    {
        [DataMember]
        public string CnNam { get; set; }
        [DataMember]
        public string Nam { get; set; }

        /// <summary>
        /// 字段状态：0 不显示不编辑 1 列表显示 2 编辑，编辑时候需要将1和2的都选择出来进行编辑。
        /// </summary>
        [DataMember]
        public string IsShown { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [DataMember]
        public string DataType { get; set; }
    }
}