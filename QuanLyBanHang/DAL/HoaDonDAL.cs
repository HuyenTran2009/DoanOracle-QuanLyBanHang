using Oracle.ManagedDataAccess.Client;
using QuanLyBanHang.BLL;
using System;

namespace QuanLyBanHang.DAL
{
    public class HoaDonDAL: BaseDAL
    {
        public HoaDonDAL()
        {
        }

        public bool TaoMoiHoaDon(GioHangBLL gh)
        {
            if (gh.HasHoaDonId)
            {
                return false;
            }

            var isInserted = XyLyNgoaiLe(() => Insert()) > 0;
            if (isInserted)
            {
                gh.HoaDonId = XyLyNgoaiLe(() => GetLastId());
            }

            return isInserted;
        }

        private int Insert()
        {
            string cmdText = $"INSERT INTO {this.prefix}HOA_DON(NgayMuaHang, MaKH, CachThanhToan, MaNV, ThanhTien, TinhTrangHoaDon) " +
                   $"VALUES(SYSDATE, 1, 1, 1, 0, 'Dang cho')";
            OracleCommand cmd = con.CreateCustomCommand();
            cmd.CommandText = cmdText;
            var result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return result;
        }

        private int GetLastId()
        {
            int id = -1;
            string cmdText = $"SELECT MAX(MaHD) FROM {this.prefix}HOA_DON";
            OracleCommand cmd = con.CreateCustomCommand();
            cmd.CommandText = cmdText;

            var dr = cmd.ExecuteScalar();
            if (dr != null)
            {
                id = Convert.ToInt32(dr.ToString());
            }
            cmd.Dispose();
            return id;
        }

        public bool ThanhToanHoaDon(GioHangBLL gh)
        {
            if (!gh.HasHoaDonId)
            {
                return false;
            }

            string cmdText = $"UPDATE {this.prefix}HOA_DON SET TinhTrangHoaDon = 'Da Thanh Tan'" +
                $"WHERE MAHD = {gh.HoaDonId}";

            return XyLyNgoaiLe(() => {
                OracleCommand cmd = con.CreateCustomCommand();
                cmd.CommandText = cmdText;
                var result = cmd.ExecuteNonQuery();
                return result == 1;
            });
        }
    }
}
