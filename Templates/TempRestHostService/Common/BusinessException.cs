using Hyd.Frame.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempRestHostService
{
    public class BusinessException : Exception
    {
        public string OperatorName { get; set; }
        public string MethodName { get; set; }
        public DateTime HappenTime { get; set; }
        public BusinessException(string message, string operatorName, string methodName) : base(message)
        {
            OperatorName = operatorName ?? string.Empty;
            MethodName = methodName ?? string.Empty;
            HappenTime = DateTime.Now;
        }

        public string GetDescription()
        {
            StringBuilder result = new StringBuilder();
            if (!string.IsNullOrEmpty(OperatorName))
            {
                result.Append("操作员[{0}] ".FormatWith(OperatorName));
            }
            result.Append("时间[{0:yyyyMMdd HH:mm:ss}] \r\n".FormatWith(HappenTime));
            result.Append("消息:{0} \r\n".FormatWith(this.Message));
            if (!string.IsNullOrEmpty(MethodName))
            {
                result.Append("发生源:[{0}] ".FormatWith(MethodName));
            }
            return result.ToString();
        }
    }
}
