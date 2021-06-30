using Oracle.ManagedDataAccess.Client;
using QuanLyBanHang.BLL;
using System;
using System.Data;

namespace QuanLyBanHang.DAL
{
    public class UserDAL: BaseDAL
    {
        public bool DangNhap(UserBLL user)
        {
            return XyLyNgoaiLe<bool>(() =>
            {
                OracleCommand cmd = con.CreateCustomCommand();
                cmd.CommandText = $"SELECT MATK, TenHienThi FROM {this.prefix}TAI_KHOAN " +
                    $"WHERE TENTK = '{user.Username}' " +
                    $"AND MATKHAU = '{user.Password}'";
                var dr = cmd.ExecuteReader();
                bool thanhCong = false;

                if (dr.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(dr);
                    var row = data.Rows[0];
                    user.MaTK = Convert.ToInt32(row[0].ToString());
                    user.DisplayUsername = row[1].ToString();
                    thanhCong = true;
                }

                cmd.Dispose();
                return thanhCong;
            });
        }

        public bool DangKy(UserBLL user)
        {
            return XyLyNgoaiLe<bool>(() =>
            {
                var stt = GetLast();
                OracleCommand cmd = con.CreateCustomCommand();
                cmd.CommandText = $"Insert into {this.prefix}TAI_KHOAN (MATK,TENTK, MATKHAU, TenHienThi) values ({stt},'{user.Username}','{user.Password}', '{user.DisplayUsername}')";
                var dr = cmd.ExecuteNonQuery();
                cmd.Dispose();
                user.MaTK = stt;
                return dr > 0;
            });
        }

        private int GetLast()
        {
            int stt = 0;
            OracleConnection con1 = ConnectionManager.Connect();
            OracleCommand cmd = con1.CreateCustomCommand();
            cmd.CommandText = $"Select max(MaTK) from {this.prefix}TAI_KHOAN";
            var dem = cmd.ExecuteScalar();
            if (dem != null)
            {
                stt = Convert.ToInt32(dem.ToString());
            }
            cmd.Dispose();
            return stt + 1;
        }
    }
}
