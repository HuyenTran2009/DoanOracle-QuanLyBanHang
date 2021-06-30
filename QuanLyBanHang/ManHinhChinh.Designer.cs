using System.Drawing;
using System.Net;

namespace QuanLyBanHang
{
    partial class ManHinhChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("DANH MỤC SẢN PHẨM");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManHinhChinh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.loginB = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.UserCart = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UserCartB = new System.Windows.Forms.Button();
            this.UserSearchB = new System.Windows.Forms.Button();
            this.UserSearchTB = new System.Windows.Forms.TextBox();
            this.LogoShop = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLui = new System.Windows.Forms.Button();
            this.lblHienTai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.btnToi = new System.Windows.Forms.Button();
            this.DanhMucSanPham = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoShop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.usernameLbl);
            this.panel1.Controls.Add(this.loginB);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.UserCart);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.UserCartB);
            this.panel1.Controls.Add(this.UserSearchB);
            this.panel1.Controls.Add(this.UserSearchTB);
            this.panel1.Controls.Add(this.LogoShop);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1889, 148);
            this.panel1.TabIndex = 1;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(1706, 24);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(0, 25);
            this.usernameLbl.TabIndex = 18;
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameLbl.TextChanged += new System.EventHandler(this.usernameLbl_TextChanged);
            this.usernameLbl.Click += new System.EventHandler(this.usernameLbl_Click);
            // 
            // loginB
            // 
            this.loginB.BackColor = System.Drawing.Color.Bisque;
            this.loginB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginB.ForeColor = System.Drawing.Color.Firebrick;
            this.loginB.Location = new System.Drawing.Point(1543, 15);
            this.loginB.Margin = new System.Windows.Forms.Padding(4);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(156, 37);
            this.loginB.TabIndex = 12;
            this.loginB.Text = "Đăng nhập";
            this.loginB.UseVisualStyleBackColor = false;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Wheat;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1551, 75);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.GioHang_Click);
            // 
            // UserCart
            // 
            this.UserCart.BackColor = System.Drawing.Color.Wheat;
            this.UserCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserCart.Location = new System.Drawing.Point(1975, 66);
            this.UserCart.Margin = new System.Windows.Forms.Padding(4);
            this.UserCart.Name = "UserCart";
            this.UserCart.Size = new System.Drawing.Size(57, 49);
            this.UserCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserCart.TabIndex = 3;
            this.UserCart.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(1543, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(233, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Giỏ hàng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.GioHang_Click);
            // 
            // UserCartB
            // 
            this.UserCartB.BackColor = System.Drawing.Color.Wheat;
            this.UserCartB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCartB.ForeColor = System.Drawing.Color.DarkOrange;
            this.UserCartB.Location = new System.Drawing.Point(1969, 58);
            this.UserCartB.Margin = new System.Windows.Forms.Padding(4);
            this.UserCartB.Name = "UserCartB";
            this.UserCartB.Size = new System.Drawing.Size(244, 65);
            this.UserCartB.TabIndex = 4;
            this.UserCartB.Text = "Giỏ hàng";
            this.UserCartB.UseVisualStyleBackColor = false;
            // 
            // UserSearchB
            // 
            this.UserSearchB.BackColor = System.Drawing.Color.SlateBlue;
            this.UserSearchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSearchB.ForeColor = System.Drawing.Color.SeaShell;
            this.UserSearchB.Location = new System.Drawing.Point(1133, 54);
            this.UserSearchB.Margin = new System.Windows.Forms.Padding(0);
            this.UserSearchB.Name = "UserSearchB";
            this.UserSearchB.Size = new System.Drawing.Size(205, 47);
            this.UserSearchB.TabIndex = 2;
            this.UserSearchB.Text = "Tìm kiếm";
            this.UserSearchB.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.UserSearchB.UseVisualStyleBackColor = false;
            this.UserSearchB.Click += new System.EventHandler(this.UserSearchB_Click);
            // 
            // UserSearchTB
            // 
            this.UserSearchTB.CausesValidation = false;
            this.UserSearchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSearchTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UserSearchTB.Location = new System.Drawing.Point(357, 54);
            this.UserSearchTB.Margin = new System.Windows.Forms.Padding(4);
            this.UserSearchTB.MaxLength = 100;
            this.UserSearchTB.Name = "UserSearchTB";
            this.UserSearchTB.Size = new System.Drawing.Size(752, 45);
            this.UserSearchTB.TabIndex = 1;
            this.UserSearchTB.TextChanged += new System.EventHandler(this.UserSearchTB_TextChanged);
            this.UserSearchTB.Enter += new System.EventHandler(this.UserSearchTB_Enter);
            this.UserSearchTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserSearchTB_KeyDown);
            this.UserSearchTB.Leave += new System.EventHandler(this.UserSearchTB_Leave);
            this.UserSearchTB.Validated += new System.EventHandler(this.UserSearchTB_Validated);
            // 
            // LogoShop
            // 
            this.LogoShop.BackColor = System.Drawing.Color.Transparent;
            this.LogoShop.Image = global::QuanLyBanHang.Properties.Resources.ShopLogo;
            this.LogoShop.Location = new System.Drawing.Point(0, 0);
            this.LogoShop.Margin = new System.Windows.Forms.Padding(4);
            this.LogoShop.Name = "LogoShop";
            this.LogoShop.Size = new System.Drawing.Size(288, 148);
            this.LogoShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoShop.TabIndex = 0;
            this.LogoShop.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(410, 158);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(11);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1479, 816);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnLui
            // 
            this.btnLui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLui.Location = new System.Drawing.Point(981, 979);
            this.btnLui.Name = "btnLui";
            this.btnLui.Size = new System.Drawing.Size(127, 42);
            this.btnLui.TabIndex = 7;
            this.btnLui.Text = "Lùi";
            this.btnLui.UseVisualStyleBackColor = true;
            this.btnLui.Click += new System.EventHandler(this.BtnLui_Click);
            // 
            // lblHienTai
            // 
            this.lblHienTai.AutoSize = true;
            this.lblHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienTai.Location = new System.Drawing.Point(1115, 988);
            this.lblHienTai.Name = "lblHienTai";
            this.lblHienTai.Size = new System.Drawing.Size(23, 25);
            this.lblHienTai.TabIndex = 10;
            this.lblHienTai.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1144, 988);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "/";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.Location = new System.Drawing.Point(1168, 988);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(23, 25);
            this.lblTong.TabIndex = 12;
            this.lblTong.Text = "1";
            // 
            // btnToi
            // 
            this.btnToi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToi.Location = new System.Drawing.Point(1196, 979);
            this.btnToi.Name = "btnToi";
            this.btnToi.Size = new System.Drawing.Size(127, 42);
            this.btnToi.TabIndex = 9;
            this.btnToi.Text = "Tới";
            this.btnToi.UseVisualStyleBackColor = true;
            this.btnToi.Click += new System.EventHandler(this.BtnToi_Click);
            // 
            // DanhMucSanPham
            // 
            this.DanhMucSanPham.BackColor = System.Drawing.Color.LightCyan;
            this.DanhMucSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhMucSanPham.ItemHeight = 35;
            this.DanhMucSanPham.Location = new System.Drawing.Point(-7, 182);
            this.DanhMucSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.DanhMucSanPham.Name = "DanhMucSanPham";
            treeNode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            treeNode1.ForeColor = System.Drawing.Color.Black;
            treeNode1.Name = "DanhMuc";
            treeNode1.Text = "DANH MỤC SẢN PHẨM";
            this.DanhMucSanPham.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.DanhMucSanPham.ShowLines = false;
            this.DanhMucSanPham.Size = new System.Drawing.Size(399, 842);
            this.DanhMucSanPham.TabIndex = 5;
            // 
            // ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.DanhMucSanPham);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnToi);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLui);
            this.Controls.Add(this.lblHienTai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MuaSamOnline";
            this.Load += new System.EventHandler(this.ManHinhChinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoShop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoShop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox UserSearchTB;
        private System.Windows.Forms.Button UserSearchB;
        private System.Windows.Forms.PictureBox UserCart;
        private System.Windows.Forms.Button UserCartB;
        private System.Windows.Forms.Label UserCartCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button loginB;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Button btnLui;
        private System.Windows.Forms.Label lblHienTai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Button btnToi;
        private System.Windows.Forms.TreeView DanhMucSanPham;
    }
}