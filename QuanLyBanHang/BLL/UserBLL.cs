using QuanLyBanHang.DAL;
using QuanLyBanHang.Extensions;

namespace QuanLyBanHang.BLL
{
    public class UserBLL
    {
        public UserBLL()
        {
                
        }
        public UserBLL(string username, string password, string tenHienThi = null)
        {
            this.Username = username;
            this.Password = password;
            this.DisplayUsername = tenHienThi;
            _instance = this;
        }

        private UserBLL _instance;
        public int MaTK { get; set; }
        public string DisplayUsername { get; set; }
        public string Username { get; private set; }
        public string Password { get; private set; }

        public bool KiemTraDangNhap()
        {
            UserDAL userDAL = new UserDAL();
            if (userDAL.DangNhap(_instance))
            {
                UserExtensions.LoggedInUser = _instance;
                return true;
            }
            return false;
        }

        public bool DangKy()
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.DangKy(_instance);
        }
    }
}
