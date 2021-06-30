namespace QuanLyBanHang
{
    partial class ChiTietSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietSanPham));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductDetail = new System.Windows.Forms.TextBox();
            this.decreaseButton = new System.Windows.Forms.Button();
            this.increase = new System.Windows.Forms.Button();
            this.BuyQty = new System.Windows.Forms.TextBox();
            this.ProductCost = new System.Windows.Forms.Label();
            this.BuyNow = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.Label();
            this.ProductPic = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.UserCartB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.UserCartCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserCart = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserCart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.ProductDetail);
            this.panel2.Controls.Add(this.decreaseButton);
            this.panel2.Controls.Add(this.increase);
            this.panel2.Controls.Add(this.BuyQty);
            this.panel2.Controls.Add(this.ProductCost);
            this.panel2.Controls.Add(this.BuyNow);
            this.panel2.Controls.Add(this.ProductName);
            this.panel2.Controls.Add(this.ProductPic);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(13, 160);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1689, 889);
            this.panel2.TabIndex = 5;
            // 
            // ProductDetail
            // 
            this.ProductDetail.BackColor = System.Drawing.Color.LightCyan;
            this.ProductDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDetail.Location = new System.Drawing.Point(535, 81);
            this.ProductDetail.Margin = new System.Windows.Forms.Padding(4);
            this.ProductDetail.Multiline = true;
            this.ProductDetail.Name = "ProductDetail";
            this.ProductDetail.Size = new System.Drawing.Size(712, 239);
            this.ProductDetail.TabIndex = 12;
            this.ProductDetail.Text = "Chi tiet san pham";
            // 
            // decreaseButton
            // 
            this.decreaseButton.BackColor = System.Drawing.Color.Linen;
            this.decreaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decreaseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.decreaseButton.Location = new System.Drawing.Point(535, 402);
            this.decreaseButton.Margin = new System.Windows.Forms.Padding(4);
            this.decreaseButton.Name = "decreaseButton";
            this.decreaseButton.Size = new System.Drawing.Size(57, 55);
            this.decreaseButton.TabIndex = 11;
            this.decreaseButton.Text = "−";
            this.decreaseButton.UseVisualStyleBackColor = false;
            this.decreaseButton.Click += new System.EventHandler(this.decreaseButton_Click);
            // 
            // increase
            // 
            this.increase.BackColor = System.Drawing.Color.Linen;
            this.increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increase.Location = new System.Drawing.Point(661, 402);
            this.increase.Margin = new System.Windows.Forms.Padding(4);
            this.increase.Name = "increase";
            this.increase.Size = new System.Drawing.Size(57, 55);
            this.increase.TabIndex = 10;
            this.increase.Text = "+";
            this.increase.UseVisualStyleBackColor = false;
            this.increase.Click += new System.EventHandler(this.increase_Click);
            // 
            // BuyQty
            // 
            this.BuyQty.Enabled = false;
            this.BuyQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyQty.Location = new System.Drawing.Point(592, 402);
            this.BuyQty.Margin = new System.Windows.Forms.Padding(4);
            this.BuyQty.Name = "BuyQty";
            this.BuyQty.Size = new System.Drawing.Size(68, 55);
            this.BuyQty.TabIndex = 9;
            this.BuyQty.Text = "1";
            this.BuyQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProductCost
            // 
            this.ProductCost.AutoSize = true;
            this.ProductCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCost.ForeColor = System.Drawing.Color.Red;
            this.ProductCost.Location = new System.Drawing.Point(703, 324);
            this.ProductCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductCost.Name = "ProductCost";
            this.ProductCost.Size = new System.Drawing.Size(346, 58);
            this.ProductCost.TabIndex = 8;
            this.ProductCost.Text = "Gia chua load";
            // 
            // BuyNow
            // 
            this.BuyNow.BackColor = System.Drawing.Color.DarkRed;
            this.BuyNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyNow.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BuyNow.Location = new System.Drawing.Point(753, 394);
            this.BuyNow.Margin = new System.Windows.Forms.Padding(4);
            this.BuyNow.Name = "BuyNow";
            this.BuyNow.Size = new System.Drawing.Size(493, 75);
            this.BuyNow.TabIndex = 7;
            this.BuyNow.Text = "MUA NGAY";
            this.BuyNow.UseVisualStyleBackColor = false;
            this.BuyNow.Click += new System.EventHandler(this.BuyNow_Click);
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.ForeColor = System.Drawing.Color.DarkOrange;
            this.ProductName.Location = new System.Drawing.Point(528, 27);
            this.ProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(529, 44);
            this.ProductName.TabIndex = 6;
            this.ProductName.Text = "Chua load product name ne";
            this.ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductPic
            // 
            this.ProductPic.Location = new System.Drawing.Point(27, 32);
            this.ProductPic.Margin = new System.Windows.Forms.Padding(4);
            this.ProductPic.Name = "ProductPic";
            this.ProductPic.Size = new System.Drawing.Size(453, 418);
            this.ProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPic.TabIndex = 4;
            this.ProductPic.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Moccasin;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.OrangeRed;
            this.button3.Location = new System.Drawing.Point(796, 821);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(604, 53);
            this.button3.TabIndex = 3;
            this.button3.Text = "Bình luận";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(27, 761);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1656, 52);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(27, 480);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1656, 268);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Góp ý của khách hàng";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 71);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1169, 215);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(180, 821);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(604, 53);
            this.button2.TabIndex = 0;
            this.button2.Text = "Quay lại";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Back_Load);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(1463, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(233, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Giỏ hàng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.GioHang_Click);
            // 
            // UserCartCount
            // 
            this.UserCartCount.AutoSize = true;
            this.UserCartCount.BackColor = System.Drawing.Color.DarkOrange;
            this.UserCartCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCartCount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UserCartCount.Location = new System.Drawing.Point(2164, 73);
            this.UserCartCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserCartCount.Name = "UserCartCount";
            this.UserCartCount.Size = new System.Drawing.Size(32, 36);
            this.UserCartCount.TabIndex = 5;
            this.UserCartCount.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.UserCartCount);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.UserCart);
            this.panel1.Controls.Add(this.UserCartB);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1720, 148);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuanLyBanHang.Properties.Resources.geometric_animals_drawing_clipart_images_gallery_for_free_download_geometric_animal_png_670_473;
            this.pictureBox3.Location = new System.Drawing.Point(1205, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(259, 148);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Wheat;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::QuanLyBanHang.Properties.Resources.cart1;
            this.pictureBox2.Location = new System.Drawing.Point(1472, 60);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.GioHang_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.LogoShop;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserCart
            // 
            this.UserCart.BackColor = System.Drawing.Color.Wheat;
            this.UserCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserCart.Image = global::QuanLyBanHang.Properties.Resources.cart1;
            this.UserCart.Location = new System.Drawing.Point(1975, 66);
            this.UserCart.Margin = new System.Windows.Forms.Padding(4);
            this.UserCart.Name = "UserCart";
            this.UserCart.Size = new System.Drawing.Size(57, 49);
            this.UserCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserCart.TabIndex = 3;
            this.UserCart.TabStop = false;
            // 
            // ChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1712, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChiTietSanPham";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiet San Pham";
            this.Load += new System.EventHandler(this.ChiTietSanPham_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ProductCost;
        private System.Windows.Forms.Button BuyNow;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.PictureBox ProductPic;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button increase;
        private System.Windows.Forms.TextBox BuyQty;
        private System.Windows.Forms.TextBox ProductDetail;
        private System.Windows.Forms.Button UserCartB;
        private System.Windows.Forms.PictureBox UserCart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label UserCartCount;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button decreaseButton;
    }
}