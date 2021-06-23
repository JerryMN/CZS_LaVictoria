using CZS_ERP_Library.DataAccess;

namespace CZS_ERP_Library
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
