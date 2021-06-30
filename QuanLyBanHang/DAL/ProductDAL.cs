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
            XyLyNgoaiLe(() => LoadDanhSachSanPham(i));
        }

        private void LoadDanhSachSanPham(int i)
        {
            // Execute a SQL SELECT
            OracleCommand cmd = con.CreateCustomCommand();
            cmd.CommandText = $"SELECT * FROM {this.prefix}SAN_PHAM WHERE MaSP =" + (i).ToString();
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dr);
                var row = data.Rows[0];
                this.pDAL.PID = row[0].ToString();
                this.pDAL.PName = row[1].ToString();
                this.pDAL.PCategory = row[2].ToString();
                this.pDAL.PCost = row[3].ToString();
                this.pDAL.PQty = row[4].ToString();
                this.pDAL.PImgUrl = row[5].ToString();
                this.pDAL.PDetail = row[6].ToString();
            }

            dr.Dispose();
            cmd.Dispose();
        }
    }
}
