using QuanLyBanHang.BLL;
using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class ManHinhTimKiem : BaseForm
    {
        private static ManHinhTimKiem instance;

        public static ManHinhTimKiem Instance
        {
            get
            {
                if (instance == null) instance = new ManHinhTimKiem(SearchString);
                return ManHinhTimKiem.instance;
            }
            private set { ManHinhTimKiem.instance = value; }
        }
        public string _username;
        public string Username { 
            get { 
                return _username; }
            set {
                _username = value;
            } 
        }
        public static string SearchString { get => searchString; set => searchString = value; }

        private static string searchString = SearchString;
        public ManHinhTimKiem(String searchString)
        {
            ManHinhTimKiem.searchString = searchString;
            if (!string.IsNullOrEmpty(DangNhap.Username))
            {
                DangNhapThanhCong(new UserBLL { DisplayUsername = DangNhap.Username });
            }
            InitializeComponent();
            this.SearchInfo.Text = searchString;

        }

        private readonly string sanPham_Text = "san_pham";
        private void ManHinhTimKiem_Load(object sender, EventArgs e)
        {
            var fontTenSP = new Font(Font.FontFamily, 15, FontStyle.Regular, GraphicsUnit.Pixel);
            var fontTien = new Font(Font.FontFamily, 20, FontStyle.Bold, GraphicsUnit.Pixel);

            ListProductBLL manHinhTimKiemListProduct = new ListProductBLL(ManHinhTimKiem.searchString, 0, 12);
            if (manHinhTimKiemListProduct.lBLL.lDAL.Count() < 12)
            {
                for (int i = 0; i < manHinhTimKiemListProduct.lBLL.lDAL.Count(); i++)
                {
                    var el = manHinhTimKiemListProduct.lBLL.lDAL[i];
                    Panel panel = new Panel
                    {
                        Size = new Size { Width = 350, Height = 381 },
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    var pictureBox = new PictureBox
                    {
                        Size = new Size { Width = 315, Height = 287 },
                        BorderStyle = BorderStyle.FixedSingle,
                        Left = 13
                    };
                    var request = WebRequest.Create(el.PImgUrl);
                    using (var response = request.GetResponse())
                    {
                        using (var stream = response.GetResponseStream())
                        {
                            pictureBox.Image = Bitmap.FromStream(stream);
                        }
                    }
                    pictureBox.Name = $"{sanPham_Text}{Convert.ToInt32(el.PID)}";
                    pictureBox.Click += PictureBox_Click;
                    panel.Controls.Add(pictureBox);

                    var productName = new Label
                    {
                        Text = el.PName,
                        Top = pictureBox.Top + pictureBox.Height + 10,
                        Left = 50,
                        AutoSize = true,
                        Font = fontTenSP
                    };
                    panel.Controls.Add(productName);
                    var productCost = new Label
                    {
                        Text = el.PCost + ".000đ",
                        Top = productName.Top + productName.Height + 10,
                        Left = 50,
                        AutoSize = true,
                        Font = fontTien
                    };

                    panel.Controls.Add(productCost);
                    flowLayoutPanel1.Controls.Add(panel);
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32((sender as PictureBox).Name.Replace(sanPham_Text, string.Empty));
            ChiTietSanPham.resetId(id);
            ChiTietSanPham.Instance.Show();
            this.Visible = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            ManHinhChinh.Instance.Visible = true;
        }

        private void GioHang_Click(object sender, EventArgs e)
        {
            GioHang.Instance.Show();
            GioHang.Flat = 2;
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

        public override void DangNhapThanhCong(UserBLL user)
        {
            this.usernameLbl.Text = user.DisplayUsername;
            this.usernameLbl.Show();
            this.loginB.Hide();
        }
    }
}
