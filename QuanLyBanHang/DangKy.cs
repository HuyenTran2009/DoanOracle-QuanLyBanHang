using QuanLyBanHang.BLL;
using System;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class DangKy : Form
    {
        public static string Username { get; set; }
        private UserBLL User;

        private static DangKy instance;

        public static DangKy Instance
        {
            get
            {
                if (instance == null) instance = new DangKy();
                return instance;
            }
            private set { instance = value; }
        }
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            ThucHienDangKy();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void ThucHienDangKy()
        {
            if (string.IsNullOrEmpty(this.username.Text.Trim())||
                string.IsNullOrEmpty(this.password.Text.Trim())  ||
                string.IsNullOrEmpty(this.txtTenHienThi.Text.Trim()) 
            )
            {
                MessageBox.Show("Thiếu thông tin!");
            }
            else {
                User = new UserBLL(this.username.Text.Trim(), this.password.Text.Trim(), this.txtTenHienThi.Text);
                if (User.DangKy())
                {
                    MessageBox.Show("Thành công!");
                    DangNhap.Instance.KiemTraDangNhap(User);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thất bại!");
                } 
            }
        }

        private void DangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Instance = null;
        }
    }
}
