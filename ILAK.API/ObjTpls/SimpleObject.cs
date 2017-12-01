using System.Runtime.Serialization;

namespace ILAK.API.ObjTpls
{
    [DataContract]
    public class SimpleObject
    {
        [DataMember]
        public string code { get; set; }
        [DataMember]
        public string msg { get; set; }
        [DataMember]
        public string data { get; set; }
    }

}
