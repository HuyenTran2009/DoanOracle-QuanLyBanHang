using Oracle.ManagedDataAccess.Client;
using QuanLyBanHang.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyBanHang.DAL
{
    public class ListDanhMucSanPhamDAL: BaseDAL
    {
        public List<LoaiSP> lspDAL = new List<LoaiSP>();

        public ListDanhMucSanPhamDAL()
        {
            XyLyNgoaiLe(() => LoadDanhMucSanPham());
        }

        private void LoadDanhMucSanPham()
        {
            // Execute a SQL SELECT
            OracleCommand cmd = con.CreateCustomCommand();
            cmd.CommandText = $"SELECT * FROM {this.prefix}LOAI_SP";
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dr);
                foreach (DataRow row in data.Rows)
                {
                    var loaiSP = new LoaiSP
                    {
                        Id = row[0].ToString(),
                        Name = row[1].ToString()
                    };

                    lspDAL.Add(loaiSP);
                }
            }

            dr.Dispose();
            cmd.Dispose();
        }
    }
}
