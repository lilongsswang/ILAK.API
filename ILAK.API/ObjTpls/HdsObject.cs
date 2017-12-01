using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Newtonsoft.Json;

namespace ILAK.API.ObjTpls
{
    [DataContract]
    public class HdsObject
    { 

    }

    [DataContract]
    public class ParaHdsObject : ParaBase
    {
        [DataMember]
        public string ObjectNam { get; set; }
    }

    [DataContract]
    public class SqlContainer
    {
        [DataMember]
        public string MainSql { get; set; }
        [DataMember]
        public string CountSql { get; set; }

        [DataMember]
        public string TableSchema { get; set; }

        [DataMember]
        public TableDefine TableDefine { get; set; }
    } 
}