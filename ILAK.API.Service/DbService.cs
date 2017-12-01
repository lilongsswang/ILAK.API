using Boco.Config;
using Boco.SC.DataAccess;

namespace HYD.Hds.Servcie
{
    /// <summary>
    /// 小林哥提供 : ILAK 2017-11-14
    /// </summary>
    public class DbService : DataBase
    {
        public DbService(string cfg)
            : base(cfg)
        {
        }

        /// <summary>
        /// 根据KeyConfig配置获取DbService
        /// </summary>
        /// <param name="keyConfig"></param>
        /// <returns></returns>
        public static DbService GetService(string keyConfig)
        {
            return new DbService(Configer.GetConfig(keyConfig));
        }

        public static string GetConfig(string key)
        {
            return Configer.Keys[key];
        }
    }
}