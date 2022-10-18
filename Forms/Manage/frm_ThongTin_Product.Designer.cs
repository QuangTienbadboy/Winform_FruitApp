namespace FruitApp.Forms.Manage
{
    partial class frm_ThongTin_Product
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
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.cb_LoaiTraiCay = new System.Windows.Forms.ComboBox();
            this.ptr_TraiCay = new System.Windows.Forms.PictureBox();
            this.lb_CapNhat = new System.Windows.Forms.Label();
            this.lb_Them = new System.Windows.Forms.Label();
            this.rtbx_MoTa = new System.Windows.Forms.RichTextBox();
            this.tb_GiaBan = new System.Windows.Forms.TextBox();
            this.tb_DVT = new System.Windows.Forms.TextBox();
            this.tb_TGBQ = new System.Windows.Forms.TextBox();
            this.tb_TenTC = new System.Windows.Forms.TextBox();
            this.tb_MaTC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_GiaMua = new System.Windows.Forms.TextBox();
            this.rbtn_DuaHau = new System.Windows.Forms.RadioButton();
            this.rbtn_DuaLuoi = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_TraiCay)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Huy
            // 
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(872, 505);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(104, 37);
            this.btn_Huy.TabIndex = 49;
            this.btn_Huy.Text = "Hủy Bỏ";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(613, 505);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(104, 37);
            this.btn_Luu.TabIndex = 48;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.Location = new System.Drawing.Point(740, 398);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(106, 33);
            this.btn_Browse.TabIndex = 45;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // cb_LoaiTraiCay
            // 
            this.cb_LoaiTraiCay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LoaiTraiCay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiTraiCay.FormattingEnabled = true;
            this.cb_LoaiTraiCay.Location = new System.Drawing.Point(244, 181);
            this.cb_LoaiTraiCay.Name = "cb_LoaiTraiCay";
            this.cb_LoaiTraiCay.Size = new System.Drawing.Size(323, 33);
            this.cb_LoaiTraiCay.TabIndex = 44;
            this.cb_LoaiTraiCay.SelectedIndexChanged += new System.EventHandler(this.cb_LoaiTraiCay_SelectedIndexChanged);
            // 
            // ptr_TraiCay
            // 
            this.ptr_TraiCay.BackColor = System.Drawing.Color.White;
            this.ptr_TraiCay.Location = new System.Drawing.Point(613, 138);
            this.ptr_TraiCay.Name = "ptr_TraiCay";
            this.ptr_TraiCay.Size = new System.Drawing.Size(363, 254);
            this.ptr_TraiCay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_TraiCay.TabIndex = 43;
            this.ptr_TraiCay.TabStop = false;
            // 
            // lb_CapNhat
            // 
            this.lb_CapNhat.AutoSize = true;
            this.lb_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CapNhat.ForeColor = System.Drawing.Color.Blue;
            this.lb_CapNhat.Location = new System.Drawing.Point(375, 34);
            this.lb_CapNhat.Name = "lb_CapNhat";
            this.lb_CapNhat.Size = new System.Drawing.Size(299, 39);
            this.lb_CapNhat.TabIndex = 42;
            this.lb_CapNhat.Text = "Cập Nhật Trái Cây";
            // 
            // lb_Them
            // 
            this.lb_Them.AutoSize = true;
            this.lb_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Them.ForeColor = System.Drawing.Color.Blue;
            this.lb_Them.Location = new System.Drawing.Point(368, 34);
            this.lb_Them.Name = "lb_Them";
            this.lb_Them.Size = new System.Drawing.Size(306, 39);
            this.lb_Them.TabIndex = 41;
            this.lb_Them.Text = "Thêm Trái Cây Mới";
            // 
            // rtbx_MoTa
            // 
            this.rtbx_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbx_MoTa.Location = new System.Drawing.Point(244, 355);
            this.rtbx_MoTa.MaxLength = 512;
            this.rtbx_MoTa.Name = "rtbx_MoTa";
            this.rtbx_MoTa.Size = new System.Drawing.Size(323, 187);
            this.rtbx_MoTa.TabIndex = 40;
            this.rtbx_MoTa.Text = "";
            // 
            // tb_GiaBan
            // 
            this.tb_GiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GiaBan.Location = new System.Drawing.Point(244, 306);
            this.tb_GiaBan.MaxLength = 10;
            this.tb_GiaBan.Name = "tb_GiaBan";
            this.tb_GiaBan.Size = new System.Drawing.Size(100, 30);
            this.tb_GiaBan.TabIndex = 38;
            // 
            // tb_DVT
            // 
            this.tb_DVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DVT.Location = new System.Drawing.Point(244, 263);
            this.tb_DVT.MaxLength = 30;
            this.tb_DVT.Name = "tb_DVT";
            this.tb_DVT.Size = new System.Drawing.Size(141, 30);
            this.tb_DVT.TabIndex = 37;
            // 
            // tb_TGBQ
            // 
            this.tb_TGBQ.Enabled = false;
            this.tb_TGBQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TGBQ.Location = new System.Drawing.Point(244, 220);
            this.tb_TGBQ.MaxLength = 30;
            this.tb_TGBQ.Name = "tb_TGBQ";
            this.tb_TGBQ.Size = new System.Drawing.Size(141, 30);
            this.tb_TGBQ.TabIndex = 36;
            // 
            // tb_TenTC
            // 
            this.tb_TenTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenTC.Location = new System.Drawing.Point(244, 138);
            this.tb_TenTC.MaxLength = 50;
            this.tb_TenTC.Name = "tb_TenTC";
            this.tb_TenTC.Size = new System.Drawing.Size(323, 30);
            this.tb_TenTC.TabIndex = 35;
            // 
            // tb_MaTC
            // 
            this.tb_MaTC.Enabled = false;
            this.tb_MaTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaTC.Location = new System.Drawing.Point(244, 97);
            this.tb_MaTC.MaxLength = 6;
            this.tb_MaTC.Name = "tb_MaTC";
            this.tb_MaTC.Size = new System.Drawing.Size(100, 30);
            this.tb_MaTC.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(162, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 33;
            this.label9.Text = "Mô Tả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(753, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "Hình Ảnh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(353, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Giá Mua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Thời Gian Bảo Quản";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Giá Bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Đơn Vị Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Loại Trái Cây";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên Trái Cây";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã Trái Cây";
            // 
            // tb_GiaMua
            // 
            this.tb_GiaMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GiaMua.Location = new System.Drawing.Point(445, 309);
            this.tb_GiaMua.MaxLength = 10;
            this.tb_GiaMua.Name = "tb_GiaMua";
            this.tb_GiaMua.Size = new System.Drawing.Size(122, 30);
            this.tb_GiaMua.TabIndex = 50;
            // 
            // rbtn_DuaHau
            // 
            this.rbtn_DuaHau.AutoSize = true;
            this.rbtn_DuaHau.Location = new System.Drawing.Point(391, 225);
            this.rbtn_DuaHau.Name = "rbtn_DuaHau";
            this.rbtn_DuaHau.Size = new System.Drawing.Size(81, 20);
            this.rbtn_DuaHau.TabIndex = 51;
            this.rbtn_DuaHau.TabStop = true;
            this.rbtn_DuaHau.Text = "Dưa Hấu";
            this.rbtn_DuaHau.UseVisualStyleBackColor = true;
            this.rbtn_DuaHau.Visible = false;
            this.rbtn_DuaHau.CheckedChanged += new System.EventHandler(this.cb_LoaiTraiCay_SelectedIndexChanged);
            // 
            // rbtn_DuaLuoi
            // 
            this.rbtn_DuaLuoi.AutoSize = true;
            this.rbtn_DuaLuoi.Location = new System.Drawing.Point(486, 225);
            this.rbtn_DuaLuoi.Name = "rbtn_DuaLuoi";
            this.rbtn_DuaLuoi.Size = new System.Drawing.Size(81, 20);
            this.rbtn_DuaLuoi.TabIndex = 52;
            this.rbtn_DuaLuoi.TabStop = true;
            this.rbtn_DuaLuoi.Text = "Dưa Lưới";
            this.rbtn_DuaLuoi.UseVisualStyleBackColor = true;
            this.rbtn_DuaLuoi.Visible = false;
            this.rbtn_DuaLuoi.CheckedChanged += new System.EventHandler(this.cb_LoaiTraiCay_SelectedIndexChanged);
            // 
            // frm_ThongTin_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1028, 557);
            this.Controls.Add(this.rbtn_DuaLuoi);
            this.Controls.Add(this.rbtn_DuaHau);
            this.Controls.Add(this.tb_GiaMua);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.cb_LoaiTraiCay);
            this.Controls.Add(this.ptr_TraiCay);
            this.Controls.Add(this.lb_CapNhat);
            this.Controls.Add(this.lb_Them);
            this.Controls.Add(this.rtbx_MoTa);
            this.Controls.Add(this.tb_GiaBan);
            this.Controls.Add(this.tb_DVT);
            this.Controls.Add(this.tb_TGBQ);
            this.Controls.Add(this.tb_TenTC);
            this.Controls.Add(this.tb_MaTC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_ThongTin_Product";
            this.Text = "Cập Nhật Thông Tin Trái Cây";
            this.Load += new System.EventHandler(this.frm_ThongTin_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_TraiCay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Browse;
        internal System.Windows.Forms.ComboBox cb_LoaiTraiCay;
        internal System.Windows.Forms.PictureBox ptr_TraiCay;
        internal System.Windows.Forms.Label lb_CapNhat;
        internal System.Windows.Forms.Label lb_Them;
        internal System.Windows.Forms.RichTextBox rtbx_MoTa;
        internal System.Windows.Forms.TextBox tb_GiaBan;
        internal System.Windows.Forms.TextBox tb_DVT;
        internal System.Windows.Forms.TextBox tb_TGBQ;
        internal System.Windows.Forms.TextBox tb_TenTC;
        internal System.Windows.Forms.TextBox tb_MaTC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox tb_GiaMua;
        private System.Windows.Forms.RadioButton rbtn_DuaHau;
        private System.Windows.Forms.RadioButton rbtn_DuaLuoi;
    }
}