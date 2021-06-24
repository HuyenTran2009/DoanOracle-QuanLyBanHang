using Oracle.ManagedDataAccess.Client;
using QuanLyBanHang.BLL;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyBanHang.DAL
{

    public class GioHangDAL: BaseDAL
    {
        public GioHangBLL gH = new GioHangBLL();

        public void GhiGioHang(GioHangBLL gh)
        {
            List<ProductBLL> lp = new List<ProductBLL>();
            int total = 0;
            foreach (var el in gh.IdSL)
            {
                var product = new ProductBLL(el.Key);
                total += Convert.ToInt32(product.pBLL.pDAL.PCost) * el.Value;
            }

            OracleConnection con = ConnectionManager.Connect();
            con.Open();
            int maxId = 0;
            // Execute a SQL SELECT
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = $"SELECT MAX(MaHD) from {this.prefix}HOA_DON";
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dr);
                foreach (DataRow row in data.Rows)
                {
                    maxId = Convert.ToInt32(row[0].ToString());
                }
            }
            string cmdText = $"INSERT INTO {this.prefix}HOA_DON VALUES(" + (maxId + 1).ToString() + ",TO_DATE(SYSDATE, 'MM-DD-YYYY'," + "1,1,1," + total.ToString() + ",Dang giao)";
            cmd.CommandText = cmdText;
            dr = cmd.ExecuteReader();
            // Clean up
            dr.Dispose();
            cmd.Dispose();
            ConnectionManager.Disconnect();
        }
    }
}
