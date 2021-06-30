using QuanLyBanHang.BLL;
using QuanLyBanHang.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class ManHinhChinh : BaseHienThiSanPham
    {
        private int TrangHienTai = 1;
        private int TongSoTrang = -1;
        private int TrangHienThi = 6;

        private static ManHinhChinh instance;
        public static ManHinhChinh Instance
        {
            get
            {
                if (instance == null) instance = new ManHinhChinh();
                return instance;
            }
        }

        public static int Flat { get => flat; set => flat = value; }

        private static int flat = 0;

        private readonly string _Search = "Search...";
        private List<string> IgnoreSearch
        {
            get
            {
                return new List<string>
                {
                    _Search,
                    "Tìm kiếm"
                };
            }
        }
        public ManHinhChinh()
        {
            ManHinhChinh.Flat = 1;
            InitializeComponent();
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            LoadData();
            SetInsanceDanhMucSanPham(DanhMucSanPham);
            LoadDanhMucSanPham();
        }

        private void UserSearchTB_Leave(object sender, EventArgs e)
        {
            if (UserSearchTB.Text.Length == 0)
            {
                UserSearchTB.Text = _Search;
                UserSearchTB.ForeColor = SystemColors.GrayText;
            }
        }

        private void UserSearchTB_Enter(object sender, EventArgs e)
        {
            if (UserSearchTB.Text == _Search)
            {
                UserSearchTB.Text = "";
                UserSearchTB.ForeColor = SystemColors.WindowText;
            }
        }
        private void UserSearchTB_Validated(object sender, EventArgs e)
        {
            if (UserSearchTB.Text.Length == 0)
            {
                UserSearchTB.Text = _Search;
                UserSearchTB.ForeColor = SystemColors.GrayText;
            }
        }

        private void UserSearchB_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void TimKiem()
        {
            ManHinhTimKiem sear1 = ManHinhTimKiem.Instance;
            sear1.SearchString = (IgnoreSearch.Contains(this.UserSearchTB.Text) ? string.Empty : this.UserSearchTB.Text);
            sear1.Show();
            ManHinhChinh.Flat = 2;
            this.Visible = false;
        }

        private void LoadProductPanel(ListProductBLL list)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Hide();

            foreach (var el in list.lBLL.lDAL)
            {
                var panel = ProductExtensions.TaoProductPanel(el);
                flowLayoutPanel1.Controls.Add(panel);
            }

            flowLayoutPanel1.Show();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (MessageBox.Show("Bạn Có chắc muốn thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void GioHang_Click(object sender, EventArgs e)
        {
            GioHang.Instance.Show();
            GioHang.Flat = 1;
            this.Visible = false;
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            if (UserExtensions.LoggedInUser == null)
            {
                DangNhap.Instance.Show();
                DangNhap.Instance.From = this;

            }
        }

        private void BtnLui_Click(object sender, EventArgs e)
        {
            if (TrangHienTai == 1)
                return;
            TrangHienTai--;
            LoadData();
        }

        private void BtnToi_Click(object sender, EventArgs e)
        {
            if (TrangHienTai == TongSoTrang)
                return;
            TrangHienTai++;
            LoadData();
        }

        private void CapNhat()
        {
            this.lblHienTai.Text = TrangHienTai.ToString();
            this.lblTong.Text = this.TongSoTrang.ToString();
        }

        private void LoadData()
        {
            ListProductBLL manHinhChinhListProduct = 
                new ListProductBLL(
                    IgnoreSearch.Contains(this.UserSearchTB.Text) ? string.Empty : this.UserSearchTB.Text, 
                    (this.TrangHienTai - 1) * this.TrangHienThi,
                    this.TrangHienThi,
                    selectedLoaiSpId
                );

            TongSoTrang = (manHinhChinhListProduct.lBLL.TongSo / this.TrangHienThi) +
               (manHinhChinhListProduct.lBLL.TongSo % this.TrangHienThi > 0 ? 1 : 0 );
            this.LoadProductPanel(manHinhChinhListProduct);
            this.CapNhat();
        }

        public override void HienThiThongTinDangNhap()
        {
            this.usernameLbl.Text = UserExtensions.LoggedInUser.DisplayUsername;
            this.usernameLbl.Show();
            this.loginB.Hide();
        }

        private void usernameLbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameLbl_Click(object sender, EventArgs e)
        {

        }

        private void UserSearchTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UserSearchTB_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TimKiem();
            }
        }

        protected override void LoadSPTheoLoai() => LoadData();

        public void TryHide()
        {
            if(instance != null)
                instance.Visible = false;
        }

        public void TryShow()
        {
            if (instance != null)
                instance.Visible = true;
        }
    }
}
