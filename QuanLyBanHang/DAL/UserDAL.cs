using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;
using QuanLyBanHang.DTO;
using QuanLyBanHang.BLL;

namespace QuanLyBanHang.DAL
{

    public class UserDAL: BaseDAL
    {
        public bool DangNhap(UserBLL user)
        {
            OracleConnection con = ConnectionManager.Connect();

            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = $"SELECT TenHienThi FROM {this.prefix}TAI_KHOAN " +
                $"WHERE TENTK = '{user.Username}' " +
                $"AND MATKHAU = '{user.Password}'";
            var dr = cmd.ExecuteScalar();
            bool thanhCong = false;

            if (dr != null)
            {
                thanhCong = true;
                user.DisplayUsername = dr.ToString();
            }

            // Clean up

            cmd.Dispose();
            ConnectionManager.Disconnect();

            return thanhCong; 
        }

        public bool DangKy(UserBLL user)
        {
            var stt = GetLast();
            OracleConnection con = ConnectionManager.Connect();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = $"Insert into {this.prefix}TAI_KHOAN (MATK,TENTK, MATKHAU, TenHienThi) values ({stt},'{user.Username}','{user.Password}', '{user.DisplayUsername}')";
            var dr = cmd.ExecuteNonQuery();
            cmd.Dispose();
            ConnectionManager.Disconnect();
            return dr > 0;
        }

        private int GetLast()
        {
            OracleConnection con = ConnectionManager.Connect();
            int stt = 0;
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = $"Select max(MaTK) from {this.prefix}TAI_KHOAN";
            var dem = cmd.ExecuteScalar();
            if (dem != null)
            {
                stt = Convert.ToInt32(dem.ToString());
            }
            cmd.Dispose();
            ConnectionManager.Disconnect();
            return stt + 1;
        }
    }
}
