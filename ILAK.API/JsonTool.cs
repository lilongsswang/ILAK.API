using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using System.Text.RegularExpressions;

namespace ILAK.API
{
    public class JsonTool
    {
        public string ConvertJsonString(string str)
        {
            //格式化json字符串
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(str);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return str;
            }
        }
        // 从一个对象信息生成Json串  
        public static string ObjectToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
        // 从一个Json串生成对象信息  
        public static object JsonToObject(string jsonString, object obj)
        {
            return JsonConvert.DeserializeObject(jsonString, obj.GetType());
        }
        /// <summary>
        /// 从json串生成动态对象
        /// </summary>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        public static object JsonToDynObj(string jsonString)
        {
            return JsonConvert.DeserializeObject<dynamic>(jsonString);
        }
        public static List<T> GetCollection<T>(string jsonString)
        {
            List<T> result = default(List<T>);
            //JObject configJson = JObject.Parse(jsonString);
            //JArray configJsonArray = JArray.Parse(jsonString);
            result = JsonConvert.DeserializeObject<List<T>>(jsonString);
            return result;
        }
        public static T GetResult<T>(string jsonString)
        {
            T result = default(T);
            //JObject configJson = JObject.Parse(jsonString);
            result = JsonConvert.DeserializeObject<T>(jsonString);
            return result;
        }
        #region 日期转换
        /// <summary>
        /// 得到json格式
        /// </summary>
        /// <param name="reJson"></param>
        /// <returns></returns>
        public static string GetDateTimeString(string reJson)
        {

            reJson = Regex.Replace(reJson, @"\\/Date\((\d+)\)\\/", match =>
            {
                DateTime datetime = new DateTime(1970, 1, 1);
                datetime = datetime.AddMilliseconds(long.Parse(match.Groups[1].Value));
                datetime = datetime.ToLocalTime();
                return datetime.ToString("yyyy-MM-dd");
            });
            return reJson;
        }
        /// <summary>
        /// 有时区偏差，用来确定时间格式的变量足够了
        /// </summary>
        /// <param name="datetimestring"></param>
        /// <returns></returns>
        public static string GetJsonDateTimeString(DateTime datetimestring)
        {
            string ret = "";
            try
            {
                JavaScriptDateTimeConverter convert = new JavaScriptDateTimeConverter();
                
                ret = JsonConvert.SerializeObject(datetimestring, Formatting.None, convert);
                ret = "/" + ret.Remove(0,4) + "/";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }
        #endregion

        public static string SerializeToJson(DataTable dt)
        {
            ITraceWriter traceWriter = new MemoryTraceWriter();
            try
            {
                var options = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    TraceWriter = traceWriter,

                }.AddSqlConverters();
                var json = JsonConvert.SerializeObject(dt, options);
                return json;
            }
            catch (Exception ex)
            {
                Console.WriteLine(traceWriter);
                Console.WriteLine(ex);

            }

            return "";
        }
    }
    #region SqlPrimitiveConverters
    public static class SqlPrimitiveConverters
    {
        public static JsonSerializerSettings AddSqlConverters(this JsonSerializerSettings settings)
        {
            foreach (var converter in converters)
                settings.Converters.Add(converter);
            return settings;
        }

        static readonly JsonConverter[] converters = new JsonConverter[]
        {
            new SqlBinaryConverter(),
            new SqlBooleanConverter(),
            new SqlByteConverter(),
            new SqlDateTimeConverter(),
            new SqlDecimalConverter(),
            new SqlDoubleConverter(),
            new SqlGuidConverter(),
            new SqlInt16Converter(),
            new SqlInt32Converter(),
            new SqlInt64Converter(),
            new SqlMoneyConverter(),
            new SqlSingleConverter(),
            new SqlStringConverter(),
            // TODO: converters for primitives from System.Data.SqlTypes that are classes not structs:
            // SqlBytes, SqlChars, SqlXml
            // Maybe SqlFileStream
		};
    }

    abstract class SqlPrimitiveConverterBase<T> : JsonConverter where T : struct, INullable, IComparable
    {
        protected abstract object GetValue(T sqlValue);

        public override bool CanConvert(Type objectType)
        {
            return typeof(T) == objectType;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            T sqlValue = (T)value;
            if (sqlValue.IsNull)
                writer.WriteNull();
            else
            {
                serializer.Serialize(writer, GetValue(sqlValue));
            }
        }
    }

    class SqlBinaryConverter : SqlPrimitiveConverterBase<SqlBinary>
    {
        protected override object GetValue(SqlBinary sqlValue) { return sqlValue.Value; }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlBinary.Null;
            return (SqlBinary)serializer.Deserialize<byte[]>(reader);
        }
    }

    class SqlBooleanConverter : SqlPrimitiveConverterBase<SqlBoolean>
    {
        protected override object GetValue(SqlBoolean sqlValue) { return sqlValue.Value; }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlBoolean.Null;
            return (SqlBoolean)serializer.Deserialize<bool>(reader);
        }
    }

    class SqlByteConverter : SqlPrimitiveConverterBase<SqlByte>
    {
        protected override object GetValue(SqlByte sqlValue) { return sqlValue.Value; }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlByte.Null;
            return (SqlByte)serializer.Deserialize<byte>(reader);
        }
    }

    class SqlDateTimeConverter : SqlPrimitiveConverterBase<SqlDateTime>
    {
        protected override object GetValue(SqlDateTime sqlValue) { return sqlValue.Value; }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlDateTime.Null;
            return (SqlDateTime)serializer.Deserialize<DateTime>(reader);
        }
    }

    class SqlDecimalConverter : SqlPrimitiveConverterBase<SqlDecimal>
    {
        protected override object GetValue(SqlDecimal sqlValue) { return sqlValue.Value; }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlDecimal.Null;
            return (SqlDecimal)serializer.Deserialize<decimal>(reader);
        }
    }

    class SqlDoubleConverter : SqlPrimitiveConverterBase<SqlDouble>
    {
        protected override object GetValue(SqlDouble sqlValue) { return sqlValue.Value; }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlDouble.Null;
            return (SqlDouble)serializer.Deserialize<double>(reader);
        }
    }

    class SqlGuidConverter : SqlPrimitiveConverterBase<SqlGuid>
    {
        protected override object GetValue(SqlGuid sqlValue) { return sqlValue.Value; }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlGuid.Null;
            return (SqlGuid)serializer.Deserialize<Guid>(reader);
        }
    }

    class SqlInt16Converter : SqlPrimitiveConverterBase<SqlInt16>
    {
        protected override object GetValue(SqlInt16 sqlValue) { return sqlValue.Value; }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlInt16.Null;
            return (SqlInt16)serializer.Deserialize<short>(reader);
        }
    }

    class SqlInt32Converter : SqlPrimitiveConverterBase<SqlInt32>
    {
        protected override object GetValue(SqlInt32 sqlValue) { return sqlValue.Value; }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlInt32.Null;
            return (SqlInt32)serializer.Deserialize<int>(reader);
        }
    }

    class SqlInt64Converter : SqlPrimitiveConverterBase<SqlInt64>
    {
        protected override object GetValue(SqlInt64 sqlValue) { return sqlValue.Value; }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlInt64.Null;
            return (SqlInt64)serializer.Deserialize<long>(reader);
        }
    }

    class SqlMoneyConverter : SqlPrimitiveConverterBase<SqlMoney>
    {
        protected override object GetValue(SqlMoney sqlValue) { return sqlValue.Value; }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlMoney.Null;
            return (SqlMoney)serializer.Deserialize<decimal>(reader);
        }
    }

    class SqlSingleConverter : SqlPrimitiveConverterBase<SqlSingle>
    {
        protected override object GetValue(SqlSingle sqlValue) { return sqlValue.Value; }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlSingle.Null;
            return (SqlSingle)serializer.Deserialize<float>(reader);
        }
    }

    class SqlStringConverter : SqlPrimitiveConverterBase<SqlString>
    {
        protected override object GetValue(SqlString sqlValue) { return sqlValue.Value; }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlString.Null;
            return (SqlString)serializer.Deserialize<string>(reader);
        }
    }
    #endregion
}
