using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
namespace QuanLyBanHang.Extensions
{
    public class ProductExtensions
    {
        private static readonly string sanPham_Text = "san_pham";
        private static readonly Control _control = new Control();
        private static readonly Font fontTenSP = new Font(_control.Font.FontFamily, 15, FontStyle.Regular, GraphicsUnit.Pixel);
        private static readonly Font fontTien = new Font(_control.Font.FontFamily, 20, FontStyle.Bold, GraphicsUnit.Pixel);

        private static Dictionary<string, Image> _imagesMapping = new Dictionary<string, Image>();
        public static Dictionary<string, Product> _productsMapping = new Dictionary<string, Product>();

        public static Panel TaoProductPanel(DTO.Product el)
        {
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
            pictureBox.Image = TryCacheImage(el.PImgUrl);
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

            return panel;
        }

        private static void PictureBox_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32((sender as PictureBox).Name.Replace(sanPham_Text, string.Empty));
            ChiTietSanPham.resetId(id);
            ChiTietSanPham.Instance.Show();

            ManHinhChinh.Instance.TryHide();
            ManHinhTimKiem.Instance.TryHide();
        }

        public static Image TryCacheImage(string url)
        {
            if (_imagesMapping.ContainsKey(url))
            {
                return _imagesMapping[url];
            }

            var request = WebRequest.Create(url);
            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    var image = Bitmap.FromStream(stream); ;
                    _imagesMapping[url] = image;
                    return image;
                }
            }
        }
    }
}
