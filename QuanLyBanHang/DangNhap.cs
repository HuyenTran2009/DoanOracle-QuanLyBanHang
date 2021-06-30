using QuanLyBanHang.BLL;
using System;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class DangNhap : Form
    {
        public BaseForm from;
        public BaseForm From { get { return from; } set { from = value; } }

        private UserBLL User;

        private static DangNhap instance;

        public static DangNhap Instance
        {
            get
            {
                if (instance == null) instance = new DangNhap();
                return instance;
            }
            private set { instance = value; }
        }
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            KiemTraDangNhap();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                KiemTraDangNhap();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KiemTraDangNhap();
            }
        }

        public void KiemTraDangNhap(UserBLL userBLL = null)
        {
            User = userBLL ?? new UserBLL(this.username.Text.Trim(), this.password.Text.Trim());

            if (!User.KiemTraDangNhap())
            {
                MessageBox.Show("Thất bại!");
            }
            else
            {
                From.HienThiThongTinDangNhap();
                this.Hide();
            }
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Instance = null;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy.Instance.Show();
        }
    }
}
