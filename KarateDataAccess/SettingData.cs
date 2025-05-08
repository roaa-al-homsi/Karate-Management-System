using System.Configuration;

namespace KarateDataAccess
{
    public static class SettingData
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    }
}
