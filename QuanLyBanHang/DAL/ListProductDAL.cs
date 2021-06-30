using System.Collections.Generic;
using QuanLyBanHang.DTO;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System;

namespace QuanLyBanHang.DAL
{
    public class ListProductDAL: BaseDAL
    {
        public List<Product> lDAL;
        public int TongSo { get; set; } = -1;
        public ListProductDAL(string searchtext = "", int skip = 0, int take = 6)
        {
            this.lDAL = new List<Product>();
            OracleConnection con = ConnectionManager.Connect();
            // Execute a SQL SELECT
            OracleCommand cmd = con.CreateCommand();
            var query = $"SELECT * FROM {this.prefix}SAN_PHAM ";
            if (!string.IsNullOrEmpty(searchtext))
            {
                query += $" WHERE TenSP LIKE '%{searchtext}%' ";
            }

            query += $"OFFSET {skip} ROWS " +
                     $"FETCH NEXT {take} ROWS ONLY";
            
            cmd.CommandText = query;
            //                  
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dr);
                foreach (DataRow row in data.Rows)
                {
                    Product temp = new Product();
                    temp.PID = row[0].ToString();
                    temp.PName = row[1].ToString();
                    temp.PCategory = row[2].ToString();
                    temp.PCost = row[3].ToString();
                    temp.PQty = row[4].ToString();
                    temp.PImgUrl = row[5].ToString();
                    temp.PDetail = row[6].ToString();
                    this.lDAL.Add(temp);
                }
            }

            if(TongSo == -1)
            {
                LayTongSo(con);
            }
            // Clean up
            dr.Dispose();
            cmd.Dispose();
            ConnectionManager.Disconnect();
        }

        private void LayTongSo(OracleConnection con)
        {
            try
            {
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = $"SELECT COUNT(*) FROM {this.prefix}SAN_PHAM";
                var dr = cmd.ExecuteScalar();
                TongSo = int.Parse(dr.ToString());
                cmd.Dispose();
            }
            catch (Exception)
            {
                TongSo = -1;
            }
        }
    }
}
