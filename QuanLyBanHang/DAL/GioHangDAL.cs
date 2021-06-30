using Oracle.ManagedDataAccess.Client;
using QuanLyBanHang.BLL;
using QuanLyBanHang.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QuanLyBanHang.DAL
{

    public class GioHangDAL: BaseDAL
    {

        private Dictionary<string, int> _productCosts;
        public GioHangDAL()
        {
            if (!ProductExtensions._productsMapping.Any())
            {
                ProductExtensions._productsMapping = new ListProductDAL("", 0, 0).lDAL.ToDictionary(d => d.PID);
            }

            _productCosts = ProductExtensions._productsMapping.Select(d => d.Value)
                            .ToDictionary(d => d.PID, d => Convert.ToInt32(d.PCost));
        }

        public bool GhiGioHang(GioHangBLL gh)
        {
            if (!gh.HasHoaDonId)
            {
                var hoaDonDAL = new HoaDonDAL();
                hoaDonDAL.TaoMoiHoaDon(gh);
            }

            XyLyNgoaiLe(() => RemoveAll(gh.HoaDonId));

            foreach (var item in gh.IdSL)
            {
                XyLyNgoaiLe(() => Insert(gh.HoaDonId, item));
            }
            return true;
        }

        private int Insert(int hoaDonId, KeyValuePair<int, int> item)
        {
            int total = _productCosts[item.Key.ToString()] * item.Value;
            string cmdText = $"INSERT INTO {this.prefix}CT_HOA_DON" + //(NgayMuaHang, MaKH, CachThanhToan, MaNV, ThanhTien, TinhTrangHoaDon) " +
                   $" VALUES({hoaDonId}, {item.Key}, {item.Value}, {_productCosts[item.Key.ToString()]}, {total})";
            OracleCommand cmd = con.CreateCustomCommand();
            cmd.CommandText = cmdText;
            var result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return result;
        }

        private void RemoveAll(int hoaDonId)
        {
            string cmdText = $"DELETE {this.prefix}CT_HOA_DON" + 
                   $" WHERE MAHD = {hoaDonId}";
            OracleCommand cmd = con.CreateCustomCommand();
            cmd.CommandText = cmdText;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
    }
}
