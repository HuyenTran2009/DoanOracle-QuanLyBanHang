using QuanLyBanHang.BLL;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public class BaseForm: Form
    {
        public BaseForm()
        {
            this.WindowState = FormWindowState.Maximized;
        }

        public virtual void DangNhapThanhCong(UserBLL user)
        {

        }
    }
}
