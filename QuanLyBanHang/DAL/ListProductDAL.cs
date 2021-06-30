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
        public ListProductDAL(string searchtext = "", int skip = 0, int take = 6, string loadSp = "")
        {
            XyLyNgoaiLe(() => Load(searchtext, skip, take, loadSp));
        }

        private void Load(string searchtext = "", int skip = 0, int take = 6, string loaiSp = "")
        {
            this.lDAL = new List<Product>();
            // Execute a SQL SELECT
            OracleCommand cmd = con.CreateCustomCommand();
            var mainQuery = $"{this.prefix}SAN_PHAM ";
            if (!string.IsNullOrEmpty(searchtext))
            {
                mainQuery += $" WHERE TenSP LIKE '%{searchtext}%' ";
            }

            if (!string.IsNullOrEmpty(loaiSp))
            {
                mainQuery += $" WHERE LoaiSp = '{loaiSp}' ";
            }

            var query = $"SELECT * FROM  {mainQuery}";

            if (take != 0)
            {
                query += $"OFFSET {skip} ROWS " +
                         $"FETCH NEXT {take} ROWS ONLY";
            }

            cmd.CommandText = query;
            
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

            if (TongSo == -1)
            {
                LayTongSo(mainQuery);
            }
            // Clean up
            dr.Dispose();
            cmd.Dispose();
        }

        private void LayTongSo(string mainQuery)
        {
            try
            {
                OracleCommand cmd = con.CreateCustomCommand();
                cmd.CommandText = $"SELECT COUNT(*) FROM {mainQuery}";
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
