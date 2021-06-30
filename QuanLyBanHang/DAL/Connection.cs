using Oracle.ManagedDataAccess.Client;

namespace QuanLyBanHang.DAL
{
    public class ConnectionManager
    {
        private static string constr = @"Data Source=(DESCRIPTION =
            (ADDRESS = (PROTOCOL = TCP)(HOST = Sz19)(PORT = 1521))
            (CONNECT_DATA =
              (SERVER = Sz19)
              (SERVICE_NAME = orcl)
            )
          );User Id=c##scott;Password=tiger";


        private static OracleConnection con;
        public static OracleConnection Connect()
        {
            con = new OracleConnection();
            con.ConnectionString = constr;
            con.Open();
            return con;
        }

        public static void Disconnect()
        {
            con.Dispose();
        }
    }
}
