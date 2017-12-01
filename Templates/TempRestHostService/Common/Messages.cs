using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempRestHostService
{
    public class SysSetting
    {
        public const int Finance_AGO_DAY = -7;
        public const int PERIOD_AGO_DAY = -30;
        public const int TODAY = 1;
        public const int DEFAULT_TOTALCOUNT = 0;
        public const int DEFAULT_CURRENT_PAGE = 1;
        public const int DEFAULT_COUNT_OF_PER_PAGE = 10;
        public const int DEFAULT_FEATURE_DAY = 13;
    }
    public class Messages
    {
        public const string REST_CONTEXTTYPE = "application/json";
        public const string REST_ENCODE = "UTF-8";
        public const string REST_POST = "POST";
        public const string PARAM_NOT_ALLOW_EMPTY = "入参不能为空";
        public const string RESTFUL_OUTPUT_CONTENTTYPE = "application/json; charset=utf-8";
    }
}
