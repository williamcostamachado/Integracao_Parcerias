using System.Configuration;
using System.Data.OleDb;

namespace Integracao_Parceria.Connection
{
    public static class DataBaseConnection
    {
        public static OleDbConnection Open()
        {
            var sql = ConfigurationManager.ConnectionStrings["AccessConnectionString"].ToString();
            var oleDbConnection = new OleDbConnection(sql);
            oleDbConnection.Open();

            return oleDbConnection;
        }
    }
}
