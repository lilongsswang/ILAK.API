using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TempRestHostService
{
    [DataContract]
    public class RetBase<T>
    {

        [DataMember]
        public string code { get; set; }

        [DataMember]
        public string msg { get; set; }

        [DataMember]
        public T data { get; set; }
        //[DataMember]
        //public Pager pager { get; set; }
        public Stream ToStream()
        {
            string jsonResult = Hyd.Frame.Extension.JsonHelper.GetJsonString(this);
            byte[] resbyte = System.Text.Encoding.UTF8.GetBytes(jsonResult);
            System.IO.MemoryStream memo = new System.IO.MemoryStream(resbyte);
            memo.Seek(0, System.IO.SeekOrigin.Begin);
            return memo;
        }
    }
}
