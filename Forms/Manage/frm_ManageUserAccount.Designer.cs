namespace FruitApp
{
    partial class frm_ManageUserAccount
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
            this.pnl_KhachHang = new System.Windows.Forms.Panel();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.clm_MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_MaSoThue = new System.Windows.Forms.TextBox();
            this.tb_NgaySinh = new System.Windows.Forms.TextBox();
            this.tb_TenKhachHang = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_MaKhachHang = new System.Windows.Forms.TextBox();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_SoDienThoai = new System.Windows.Forms.Label();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.lb_MaKH = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_KhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_KhachHang
            // 
            this.pnl_KhachHang.Controls.Add(this.button1);
            this.pnl_KhachHang.Location = new System.Drawing.Point(0, 0);
            this.pnl_KhachHang.Name = "pnl_KhachHang";
            this.pnl_KhachHang.Size = new System.Drawing.Size(760, 213);
            this.pnl_KhachHang.TabIndex = 2;
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_MaKH,
            this.clm_TenKH});
            this.dgv_KhachHang.Location = new System.Drawing.Point(0, 219);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.RowTemplate.Height = 24;
            this.dgv_KhachHang.Size = new System.Drawing.Size(760, 650);
            this.dgv_KhachHang.TabIndex = 3;
            this.dgv_KhachHang.TabStop = false;
            // 
            // clm_MaKH
            // 
            this.clm_MaKH.HeaderText = "Mã Khách Hàng";
            this.clm_MaKH.MinimumWidth = 125;
            this.clm_MaKH.Name = "clm_MaKH";
            this.clm_MaKH.ReadOnly = true;
            this.clm_MaKH.Width = 175;
            // 
            // clm_TenKH
            // 
            this.clm_TenKH.HeaderText = "Tên Khách Hàng";
            this.clm_TenKH.MinimumWidth = 175;
            this.clm_TenKH.Name = "clm_TenKH";
            this.clm_TenKH.ReadOnly = true;
            this.clm_TenKH.Width = 350;
            // 
            // tb_MaSoThue
            // 
            this.tb_MaSoThue.Enabled = false;
            this.tb_MaSoThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaSoThue.Location = new System.Drawing.Point(1368, 514);
            this.tb_MaSoThue.Name = "tb_MaSoThue";
            this.tb_MaSoThue.Size = new System.Drawing.Size(185, 30);
            this.tb_MaSoThue.TabIndex = 36;
            // 
            // tb_NgaySinh
            // 
            this.tb_NgaySinh.Enabled = false;
            this.tb_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NgaySinh.Location = new System.Drawing.Point(1368, 392);
            this.tb_NgaySinh.Name = "tb_NgaySinh";
            this.tb_NgaySinh.Size = new System.Drawing.Size(185, 30);
            this.tb_NgaySinh.TabIndex = 35;
            // 
            // tb_TenKhachHang
            // 
            this.tb_TenKhachHang.Enabled = false;
            this.tb_TenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenKhachHang.Location = new System.Drawing.Point(1224, 265);
            this.tb_TenKhachHang.Name = "tb_TenKhachHang";
            this.tb_TenKhachHang.Size = new System.Drawing.Size(329, 30);
            this.tb_TenKhachHang.TabIndex = 34;
            // 
            // tb_Email
            // 
            this.tb_Email.Enabled = false;
            this.tb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(977, 392);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(318, 30);
            this.tb_Email.TabIndex = 33;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Enabled = false;
            this.tb_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DiaChi.Location = new System.Drawing.Point(977, 514);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(318, 30);
            this.tb_DiaChi.TabIndex = 32;
            // 
            // tb_MaKhachHang
            // 
            this.tb_MaKhachHang.Enabled = false;
            this.tb_MaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaKhachHang.Location = new System.Drawing.Point(977, 265);
            this.tb_MaKhachHang.Name = "tb_MaKhachHang";
            this.tb_MaKhachHang.Size = new System.Drawing.Size(167, 30);
            this.tb_MaKhachHang.TabIndex = 31;
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgaySinh.Location = new System.Drawing.Point(1363, 353);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(103, 25);
            this.lb_NgaySinh.TabIndex = 30;
            this.lb_NgaySinh.Text = "Ngày Sinh";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiaChi.Location = new System.Drawing.Point(972, 472);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(76, 25);
            this.lb_DiaChi.TabIndex = 29;
            this.lb_DiaChi.Text = "Địa Chỉ";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(972, 353);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(60, 25);
            this.lb_Email.TabIndex = 28;
            this.lb_Email.Text = "Email";
            // 
            // lb_SoDienThoai
            // 
            this.lb_SoDienThoai.AutoSize = true;
            this.lb_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoDienThoai.Location = new System.Drawing.Point(1364, 472);
            this.lb_SoDienThoai.Name = "lb_SoDienThoai";
            this.lb_SoDienThoai.Size = new System.Drawing.Size(137, 25);
            this.lb_SoDienThoai.TabIndex = 27;
            this.lb_SoDienThoai.Text = "Số Điện Thoại";
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenKH.Location = new System.Drawing.Point(1220, 226);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(161, 25);
            this.lb_TenKH.TabIndex = 26;
            this.lb_TenKH.Text = "Tên Khách Hàng";
            // 
            // lb_MaKH
            // 
            this.lb_MaKH.AutoSize = true;
            this.lb_MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaKH.Location = new System.Drawing.Point(972, 226);
            this.lb_MaKH.Name = "lb_MaKH";
            this.lb_MaKH.Size = new System.Drawing.Size(154, 25);
            this.lb_MaKH.TabIndex = 25;
            this.lb_MaKH.Text = "Mã Khách Hàng";
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(1295, 578);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(141, 37);
            this.btn_Huy.TabIndex = 38;
            this.btn_Huy.Text = "Hủy Bỏ";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Visible = false;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(1107, 578);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(141, 37);
            this.btn_Luu.TabIndex = 37;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(276, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 37);
            this.button1.TabIndex = 38;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frm_ManageUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.tb_MaSoThue);
            this.Controls.Add(this.tb_NgaySinh);
            this.Controls.Add(this.tb_TenKhachHang);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.tb_MaKhachHang);
            this.Controls.Add(this.lb_NgaySinh);
            this.Controls.Add(this.lb_DiaChi);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_SoDienThoai);
            this.Controls.Add(this.lb_TenKH);
            this.Controls.Add(this.lb_MaKH);
            this.Controls.Add(this.dgv_KhachHang);
            this.Controls.Add(this.pnl_KhachHang);
            this.Name = "frm_ManageUserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Khách Hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_ManageUserAccount_FormClosed);
            this.pnl_KhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_KhachHang;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_TenKH;
        private System.Windows.Forms.TextBox tb_MaSoThue;
        private System.Windows.Forms.TextBox tb_NgaySinh;
        private System.Windows.Forms.TextBox tb_TenKhachHang;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_MaKhachHang;
        private System.Windows.Forms.Label lb_NgaySinh;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_SoDienThoai;
        private System.Windows.Forms.Label lb_TenKH;
        private System.Windows.Forms.Label lb_MaKH;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button button1;
    }
}