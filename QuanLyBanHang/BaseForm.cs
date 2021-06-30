using QuanLyBanHang.BLL;
using QuanLyBanHang.Extensions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public class BaseForm: Form
    {
        protected readonly int PagingProducts = 12;
        public BaseForm()
        {
            InitData();
        }

        private void InitData()
        {
            this.WindowState = FormWindowState.Maximized;
            if (UserExtensions.LoggedInUser != null)
            {
                HienThiThongTinDangNhap();
            }
        }

        public virtual void HienThiThongTinDangNhap(){}
    }
}
