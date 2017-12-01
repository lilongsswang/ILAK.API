using HYD.Hds.Servcie;

namespace ILAK.API
{
    public class DB
    {
        public static DbService GetMainDb()
        {
            return DbService.GetService("HDSAPISQL");
        }

        public static DbService GetHDSDb()
        {
            return DbService.GetService("HDSCache");
        }

    }
}