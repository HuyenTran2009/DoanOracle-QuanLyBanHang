using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.BLL;
//using QuanLyBanHangQuaMang.DTO;

namespace QuanLyBanHang
{
    public partial class ManHinhChinh : BaseForm
    {
        private static ManHinhChinh instance;
        
        public static ManHinhChinh Instance
        {
            get
            {
                if (instance == null) instance = new ManHinhChinh();
                return ManHinhChinh.instance;
            }
            private set { ManHinhChinh.instance = value; }
        }

        public static int Flat { get => flat; set => flat = value; }

        private static int flat = 0;

        private readonly string _Search = "Search...";
        private List<string> IgnoreSearch;
        public ManHinhChinh()
        {

            if (!string.IsNullOrEmpty(DangNhap.Username))
            {
                DangNhapThanhCong(new UserBLL { DisplayUsername = DangNhap.Username });
            }
            InitializeComponent();
            IgnoreSearch = new List<string>
            {
                _Search,
                "Tìm kiếm"
            };
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            LoadData();
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
            ManHinhTimKiem sear1 = new ManHinhTimKiem(IgnoreSearch.Contains(this.UserSearchTB.Text) ? string.Empty : this.UserSearchTB.Text);
            sear1.Show();
            ManHinhChinh.Flat = 2;
            this.Visible = false;
        }

        private void productShow1_Click(object sender, EventArgs e)
        {
            //ChiTietSanPham pro1 = new ChiTietSanPham(1);
            //pro1.Show();
            ChiTietSanPham.resetId(1);
            ChiTietSanPham.Instance.Show();
            ManHinhChinh.Flat = 1;
            this.Visible = false;
              
        }

        private void productShow2_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(2);
            ChiTietSanPham.Instance.Show();
            ManHinhChinh.Flat = 1;
            this.Visible = false;
        }

        private void productShow3_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(3);
            ChiTietSanPham.Instance.Show();
            ManHinhChinh.Flat = 1;
            this.Visible = false;
        }

        private void productShow4_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(4);
            ChiTietSanPham.Instance.Show();
            ManHinhChinh.Flat = 1;
            this.Visible = false;
        }

        private void productShow5_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(5);
            ChiTietSanPham.Instance.Show();
            ManHinhChinh.Flat = 1;
            this.Visible = false;
        }

        private void productShow6_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(6);
            ChiTietSanPham.Instance.Show();
            ManHinhChinh.Flat = 1;
            this.Visible = false;
        }

        private void loadProductPanel(ListProductBLL list)
        {
            for (int i = 1; i <= list.lBLL.lDAL.Count(); i++)
            {
                var el = list.lBLL.lDAL[i -1];
                HienThiSanPham(el, i);
            }

            if (list.lBLL.lDAL.Count() < TrangHienThi)
            {
                for (int i = list.lBLL.lDAL.Count() + 1; i <= TrangHienThi; i++)
                {
                    An(i);
                }
            }
        }

        private void An(int i)
        {
            var productName = this.Controls.Find("ProductName" + i, true).FirstOrDefault() as Label;
            productName.Visible = false;

            var productCost = this.Controls.Find("ProductCost" + i, true).FirstOrDefault() as Label;
            productCost.Visible = false;

            var productPic = this.Controls.Find("ProductPic" + i, true).FirstOrDefault() as PictureBox;
            productPic.Visible = false;
        }

        private void HienThiSanPham(DTO.Product el, int i)
        {
            var productName = this.Controls.Find("ProductName" + i, true).FirstOrDefault() as Label;
            productName.Text = el.PName;
            productName.Visible = true;

            var productCost = this.Controls.Find("ProductCost" + i, true).FirstOrDefault() as Label;
            productCost.Text = el.PCost + ".000đ";
            productCost.Visible = true;

            var productPic = this.Controls.Find("ProductPic" + i, true).FirstOrDefault() as PictureBox;
            productPic.Visible = true;

            var request = WebRequest.Create(el.PImgUrl);
            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    productPic.Image = Bitmap.FromStream(stream);
                }
            }
        }

        private void DanhMucSanPham_AfterSelect(object sender, TreeViewEventArgs e)
        {

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
            if (string.IsNullOrEmpty(DangNhap.Username))
            {
                DangNhap.Instance.Show();
                DangNhap.Instance.From = this;

            }
        }

        private int TrangHienTai = 1;
        private int TongSoTrang = -1;
        private int TrangHienThi = 6;
        private void btnLui_Click(object sender, EventArgs e)
        {
            if (TrangHienTai == 1)
                return;
            TrangHienTai--;
            LoadData();
        }

        private void btnToi_Click(object sender, EventArgs e)
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
                    this.TrangHienThi
                );

            TongSoTrang = (manHinhChinhListProduct.lBLL.TongSo / this.TrangHienThi) +
               (manHinhChinhListProduct.lBLL.TongSo % this.TrangHienThi > 0 ? 1 : 0 );
            this.loadProductPanel(manHinhChinhListProduct);
            this.CapNhat();
        }

        public override void DangNhapThanhCong(UserBLL user)
        {
            this.usernameLbl.Text = user.DisplayUsername;
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
    }
}
