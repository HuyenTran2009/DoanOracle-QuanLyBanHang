using QuanLyBanHang.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace QuanLyBanHang
{
    public partial class GioHang : BaseForm
    {
        private static int stt=0;
        private static int flat;
        private static GioHang instance;
        readonly string nameButtonDelPrefix = "DelButton_id_";
        readonly string namePanelPrefix = "ChiTietGH_id_";

        public static GioHang Instance
        {
            get
            {
                if (instance == null) instance = new GioHang();
                instance.Reload();
                return GioHang.instance;
            }
        }

        public static int Flat { get => flat; set => flat = value; }

        public GioHang()
        {
            InitializeComponent();
        }

        private void TenSP_Click(object sender, EventArgs e)
        {
            
        }

        public void ThemChiTietGH(int sl, int id)
        {
            ProductBLL newPro = new ProductBLL(id);
            Panel returnPanel = new Panel();
            GioHang.stt++;

            //Qty
            TextBox QtyPro = new TextBox();
            QtyPro.BackColor = Color.Lavender;
            QtyPro.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            QtyPro.Location = new Point(374, 0);
            QtyPro.Name = "sl1";
            QtyPro.Text = sl.ToString();
            QtyPro.Size = new Size(123, 30);
            QtyPro.Enabled = false;
            QtyPro.TabIndex = 3;
            QtyPro.TextAlign = HorizontalAlignment.Center;
            // Name
            TextBox NamePro = new TextBox();
            NamePro.BackColor = Color.Lavender;
            NamePro.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            NamePro.Location = new Point(0, 1);
            NamePro.Name = "sp1";
            NamePro.Size = new Size(306, 30);
            NamePro.TabIndex = 2;
            NamePro.Enabled = false;
            NamePro.Text = newPro.pBLL.pDAL.PName;
            NamePro.TextAlign = HorizontalAlignment.Center;
            // tt1
            TextBox TotalPro = new TextBox();
            TotalPro.BackColor = Color.Lavender;
            TotalPro.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            TotalPro.Location = new Point(885, 0);
            TotalPro.Name = "tt1";
            TotalPro.Text = (Convert.ToInt32(newPro.pBLL.pDAL.PCost) * sl).ToString()+".000đ";
            TotalPro.Enabled = false;
            TotalPro.Size = new Size(156, 30);
            TotalPro.TabIndex = 5;
            TotalPro.TextAlign = HorizontalAlignment.Center;
            // dg1
            TextBox CostPro = new TextBox();
            CostPro.BackColor = Color.Lavender;
            CostPro.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            CostPro.Location = new Point(621, 0);
            CostPro.Name = "dg1";
            CostPro.Text = newPro.pBLL.pDAL.PCost + ".000đ";
            CostPro.TextAlign = HorizontalAlignment.Center;
            CostPro.Enabled = false;
            CostPro.Size = new Size(141, 30);
            CostPro.TabIndex = 4;
            //delButton
            Button delPro = new Button();
            delPro.BackColor = Color.Wheat;
            delPro.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            delPro.ForeColor = Color.Red;
            delPro.Location = new Point(1106, 1);
            delPro.Name = $"{nameButtonDelPrefix}{id}";
            delPro.Size = new Size(148, 30);
            delPro.TabIndex = 6;
            delPro.Text = "Xóa";
            delPro.Click += new EventHandler(this.del_Click1);

            returnPanel.Controls.Add(delPro);
            returnPanel.Controls.Add(CostPro);
            returnPanel.Controls.Add(TotalPro);
            returnPanel.Controls.Add(NamePro);
            returnPanel.Controls.Add(QtyPro);
            returnPanel.Name = $"{namePanelPrefix}{id}";
            returnPanel.Size = new Size(1257, 31);
            returnPanel.TabIndex = 1;
            this.flowLayoutPanel1.Controls.Add(returnPanel);
            this.flowLayoutPanel1.Controls.SetChildIndex(returnPanel, GioHang.stt);
        }

        private void del_Click1(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            var idString = temp.Name.Replace(nameButtonDelPrefix, "");
            if(int.TryParse(idString, out int id))
            {
                var controls = flowLayoutPanel1.Controls.Find($"{namePanelPrefix}{id}", true);
                if(controls.Length == 1)
                {
                    Panel pnl = controls.First() as Panel;
                    this.flowLayoutPanel1.Controls.Remove(pnl);
                    GioHangBLL.Instance.IdSL.Remove(id);
                }
            }
        }

        public void Reload()
        {
            this.flowLayoutPanel1.Controls.Clear();
            foreach (var el in GioHangBLL.Instance.IdSL)
            {
                ThemChiTietGH(el.Value, el.Key);
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (GioHang.flat == 1)
                ManHinhChinh.Instance.Visible = true;
            else if (GioHang.flat == 2)
                ManHinhTimKiem.Instance.Visible = true;
            else if (GioHang.flat == 3)
                ChiTietSanPham.Instance.Visible = true;
        }

        private void ThanhToan_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MHThanhToan.Instance.Show();
        }
    }
}
