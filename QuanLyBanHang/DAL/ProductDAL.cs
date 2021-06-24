using Oracle.ManagedDataAccess.Client;
using QuanLyBanHang.DTO;
using System.Data;

namespace QuanLyBanHang.DAL
{
    public class ProductDAL: BaseDAL
    {
        public Product pDAL = new Product();

        public ProductDAL(int i)
        {
            OracleConnection con = ConnectionManager.Connect();

            // Execute a SQL SELECT
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {this.prefix}SAN_PHAM WHERE MaSP =" + (i).ToString();
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dr);
                foreach (DataRow row in data.Rows)
                {
                    this.pDAL.PID = row[0].ToString();
                    this.pDAL.PName = row[1].ToString();
                    this.pDAL.PCategory = row[2].ToString();
                    this.pDAL.PCost = row[3].ToString();
                    this.pDAL.PQty = row[4].ToString();
                    this.pDAL.PImgUrl = row[5].ToString();
                    this.pDAL.PDetail = row[6].ToString();
                }
            }

            // Clean up
            dr.Dispose();
            cmd.Dispose();
            ConnectionManager.Disconnect();
        }
    }
}
