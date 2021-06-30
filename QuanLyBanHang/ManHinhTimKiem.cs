using QuanLyBanHang.BLL;
using QuanLyBanHang.Extensions;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class ManHinhTimKiem : BaseHienThiSanPham
    {
        private static ManHinhTimKiem instance;

        public static ManHinhTimKiem Instance
        {
            get
            {
                if (instance == null) instance = new ManHinhTimKiem();
                return instance;
            }
        }
        public string _username;
        public string Username { 
            get { 
                return _username; }
            set {
                _username = value;
            } 
        }
        public string SearchString { get => searchString; set => searchString = value; }

        private string searchString;
        public ManHinhTimKiem()
        {
            InitializeComponent();
            SearchString = searchString;
            SearchInfo.Text = searchString;
        }

        private void ManHinhTimKiem_Load(object sender, EventArgs e)
        {
            LoadData();
            SetInsanceDanhMucSanPham(DanhMucSanPham);
            LoadDanhMucSanPham();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
            ManHinhChinh.Instance.Visible = true;
        }

        private void GioHang_Click(object sender, EventArgs e)
        {
            GioHang.Instance.Show();
            GioHang.Flat = 2;
            Visible = false;
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            if (UserExtensions.LoggedInUser != null)
            {
                DangNhap.Instance.Show();
                DangNhap.Instance.From = this;
            }
        }

        public override void HienThiThongTinDangNhap()
        {
            usernameLbl.Text = UserExtensions.LoggedInUser.DisplayUsername;
            usernameLbl.Show();
            loginB.Hide();
        }

        protected override void LoadSPTheoLoai() => LoadData();

        private void LoadData()
        {
            flowLayoutPanel1.Controls.Clear();
            ListProductBLL manHinhTimKiemListProduct = new ListProductBLL(SearchString, 0, PagingProducts, selectedLoaiSpId);
            flowLayoutPanel1.Hide();
            foreach (var el in manHinhTimKiemListProduct.lBLL.lDAL)
            {
                var panel = ProductExtensions.TaoProductPanel(el);
                flowLayoutPanel1.Controls.Add(panel);
            }
            flowLayoutPanel1.Show();
        }

        public void TryHide()
        {
            if(instance != null)
                instance.Visible = false;
        }

        public void TryShow()
        {
            if(instance != null)
                instance.Visible = true;
        }
    }
}
