using CZS_LaVictoria_Library.DataAccess;

namespace CZS_LaVictoria_Library
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeSql()
        {
            var sql = new SqlConnector();
            Connection = sql;
        }
    }
}
