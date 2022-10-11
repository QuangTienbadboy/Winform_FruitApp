namespace FruitApp
{
    partial class frm_ManageOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Order = new System.Windows.Forms.DataGridView();
            this.grb_Status = new System.Windows.Forms.GroupBox();
            this.cbx_DaHuy = new System.Windows.Forms.CheckBox();
            this.cbx_HoanThanh = new System.Windows.Forms.CheckBox();
            this.cbx_DangGiaoHang = new System.Windows.Forms.CheckBox();
            this.cbx_DaXacNhan = new System.Windows.Forms.CheckBox();
            this.cbx_ChuaXacNhan = new System.Windows.Forms.CheckBox();
            this.grb_SoLuongDonHang = new System.Windows.Forms.GroupBox();
            this.lb_DaHuy = new System.Windows.Forms.Label();
            this.lb_HoanThanh = new System.Windows.Forms.Label();
            this.lb_DangGiaoHang = new System.Windows.Forms.Label();
            this.lb_DaXacNhan = new System.Windows.Forms.Label();
            this.lb_ChoXacNhan = new System.Windows.Forms.Label();
            this.dtpck_NgayOrder = new System.Windows.Forms.DateTimePicker();
            this.tb_MaDonHang = new System.Windows.Forms.TextBox();
            this.lb_MaDonHang = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.clm_MDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_NguoiDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DiaChiGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).BeginInit();
            this.grb_Status.SuspendLayout();
            this.grb_SoLuongDonHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Order
            // 
            this.dgv_Order.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_MDH,
            this.clm_NguoiDat,
            this.clm_ChiTiet,
            this.clm_NgayDat,
            this.clm_DiaChiGiao,
            this.clm_TrangThai});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Order.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Order.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Order.Location = new System.Drawing.Point(0, 261);
            this.dgv_Order.Name = "dgv_Order";
            this.dgv_Order.RowHeadersWidth = 51;
            this.dgv_Order.RowTemplate.Height = 24;
            this.dgv_Order.Size = new System.Drawing.Size(1924, 600);
            this.dgv_Order.TabIndex = 0;
            this.dgv_Order.TabStop = false;
            // 
            // grb_Status
            // 
            this.grb_Status.Controls.Add(this.cbx_DaHuy);
            this.grb_Status.Controls.Add(this.cbx_HoanThanh);
            this.grb_Status.Controls.Add(this.cbx_DangGiaoHang);
            this.grb_Status.Controls.Add(this.cbx_DaXacNhan);
            this.grb_Status.Controls.Add(this.cbx_ChuaXacNhan);
            this.grb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Status.Location = new System.Drawing.Point(73, 12);
            this.grb_Status.Name = "grb_Status";
            this.grb_Status.Size = new System.Drawing.Size(224, 204);
            this.grb_Status.TabIndex = 1;
            this.grb_Status.TabStop = false;
            this.grb_Status.Text = "Trạng Thái";
            // 
            // cbx_DaHuy
            // 
            this.cbx_DaHuy.AutoSize = true;
            this.cbx_DaHuy.Location = new System.Drawing.Point(25, 169);
            this.cbx_DaHuy.Name = "cbx_DaHuy";
            this.cbx_DaHuy.Size = new System.Drawing.Size(99, 29);
            this.cbx_DaHuy.TabIndex = 4;
            this.cbx_DaHuy.Text = "Đã Hủy";
            this.cbx_DaHuy.UseVisualStyleBackColor = true;
            // 
            // cbx_HoanThanh
            // 
            this.cbx_HoanThanh.AutoSize = true;
            this.cbx_HoanThanh.Location = new System.Drawing.Point(25, 134);
            this.cbx_HoanThanh.Name = "cbx_HoanThanh";
            this.cbx_HoanThanh.Size = new System.Drawing.Size(143, 29);
            this.cbx_HoanThanh.TabIndex = 3;
            this.cbx_HoanThanh.Text = "Hoàn Thành";
            this.cbx_HoanThanh.UseVisualStyleBackColor = true;
            // 
            // cbx_DangGiaoHang
            // 
            this.cbx_DangGiaoHang.AutoSize = true;
            this.cbx_DangGiaoHang.Location = new System.Drawing.Point(25, 99);
            this.cbx_DangGiaoHang.Name = "cbx_DangGiaoHang";
            this.cbx_DangGiaoHang.Size = new System.Drawing.Size(179, 29);
            this.cbx_DangGiaoHang.TabIndex = 2;
            this.cbx_DangGiaoHang.Text = "Đang Giao Hàng";
            this.cbx_DangGiaoHang.UseVisualStyleBackColor = true;
            // 
            // cbx_DaXacNhan
            // 
            this.cbx_DaXacNhan.AutoSize = true;
            this.cbx_DaXacNhan.Location = new System.Drawing.Point(25, 64);
            this.cbx_DaXacNhan.Name = "cbx_DaXacNhan";
            this.cbx_DaXacNhan.Size = new System.Drawing.Size(151, 29);
            this.cbx_DaXacNhan.TabIndex = 1;
            this.cbx_DaXacNhan.Text = "Đã Xác Nhận";
            this.cbx_DaXacNhan.UseVisualStyleBackColor = true;
            // 
            // cbx_ChuaXacNhan
            // 
            this.cbx_ChuaXacNhan.AutoSize = true;
            this.cbx_ChuaXacNhan.Location = new System.Drawing.Point(25, 29);
            this.cbx_ChuaXacNhan.Name = "cbx_ChuaXacNhan";
            this.cbx_ChuaXacNhan.Size = new System.Drawing.Size(163, 29);
            this.cbx_ChuaXacNhan.TabIndex = 0;
            this.cbx_ChuaXacNhan.Text = "Chờ Xác Nhận";
            this.cbx_ChuaXacNhan.UseVisualStyleBackColor = true;
            // 
            // grb_SoLuongDonHang
            // 
            this.grb_SoLuongDonHang.Controls.Add(this.lb_DaHuy);
            this.grb_SoLuongDonHang.Controls.Add(this.lb_HoanThanh);
            this.grb_SoLuongDonHang.Controls.Add(this.lb_DangGiaoHang);
            this.grb_SoLuongDonHang.Controls.Add(this.lb_DaXacNhan);
            this.grb_SoLuongDonHang.Controls.Add(this.lb_ChoXacNhan);
            this.grb_SoLuongDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_SoLuongDonHang.Location = new System.Drawing.Point(1633, 19);
            this.grb_SoLuongDonHang.Name = "grb_SoLuongDonHang";
            this.grb_SoLuongDonHang.Size = new System.Drawing.Size(253, 204);
            this.grb_SoLuongDonHang.TabIndex = 2;
            this.grb_SoLuongDonHang.TabStop = false;
            this.grb_SoLuongDonHang.Text = "Các Đơn Trong Ngày";
            // 
            // lb_DaHuy
            // 
            this.lb_DaHuy.AutoSize = true;
            this.lb_DaHuy.Location = new System.Drawing.Point(86, 170);
            this.lb_DaHuy.Name = "lb_DaHuy";
            this.lb_DaHuy.Size = new System.Drawing.Size(83, 25);
            this.lb_DaHuy.TabIndex = 4;
            this.lb_DaHuy.Text = "Đã Hủy:";
            // 
            // lb_HoanThanh
            // 
            this.lb_HoanThanh.AutoSize = true;
            this.lb_HoanThanh.Location = new System.Drawing.Point(42, 134);
            this.lb_HoanThanh.Name = "lb_HoanThanh";
            this.lb_HoanThanh.Size = new System.Drawing.Size(127, 25);
            this.lb_HoanThanh.TabIndex = 3;
            this.lb_HoanThanh.Text = "Hoàn Thành:";
            // 
            // lb_DangGiaoHang
            // 
            this.lb_DangGiaoHang.AutoSize = true;
            this.lb_DangGiaoHang.Location = new System.Drawing.Point(6, 99);
            this.lb_DangGiaoHang.Name = "lb_DangGiaoHang";
            this.lb_DangGiaoHang.Size = new System.Drawing.Size(163, 25);
            this.lb_DangGiaoHang.TabIndex = 2;
            this.lb_DangGiaoHang.Text = "Đang Giao Hàng:";
            // 
            // lb_DaXacNhan
            // 
            this.lb_DaXacNhan.AutoSize = true;
            this.lb_DaXacNhan.Location = new System.Drawing.Point(34, 64);
            this.lb_DaXacNhan.Name = "lb_DaXacNhan";
            this.lb_DaXacNhan.Size = new System.Drawing.Size(135, 25);
            this.lb_DaXacNhan.TabIndex = 1;
            this.lb_DaXacNhan.Text = "Đã Xác Nhận:";
            // 
            // lb_ChoXacNhan
            // 
            this.lb_ChoXacNhan.AutoSize = true;
            this.lb_ChoXacNhan.Location = new System.Drawing.Point(22, 30);
            this.lb_ChoXacNhan.Name = "lb_ChoXacNhan";
            this.lb_ChoXacNhan.Size = new System.Drawing.Size(147, 25);
            this.lb_ChoXacNhan.TabIndex = 0;
            this.lb_ChoXacNhan.Text = "Chờ Xác Nhận:";
            // 
            // dtpck_NgayOrder
            // 
            this.dtpck_NgayOrder.CustomFormat = "dd/MM/yyyy";
            this.dtpck_NgayOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpck_NgayOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpck_NgayOrder.Location = new System.Drawing.Point(880, 117);
            this.dtpck_NgayOrder.Name = "dtpck_NgayOrder";
            this.dtpck_NgayOrder.Size = new System.Drawing.Size(156, 30);
            this.dtpck_NgayOrder.TabIndex = 3;
            // 
            // tb_MaDonHang
            // 
            this.tb_MaDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaDonHang.Location = new System.Drawing.Point(985, 49);
            this.tb_MaDonHang.Name = "tb_MaDonHang";
            this.tb_MaDonHang.Size = new System.Drawing.Size(162, 30);
            this.tb_MaDonHang.TabIndex = 4;
            // 
            // lb_MaDonHang
            // 
            this.lb_MaDonHang.AutoSize = true;
            this.lb_MaDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaDonHang.Location = new System.Drawing.Point(770, 55);
            this.lb_MaDonHang.Name = "lb_MaDonHang";
            this.lb_MaDonHang.Size = new System.Drawing.Size(191, 25);
            this.lb_MaDonHang.TabIndex = 5;
            this.lb_MaDonHang.Text = "Nhập Mã Đơn Hàng:";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.Location = new System.Drawing.Point(899, 181);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(119, 43);
            this.btn_Confirm.TabIndex = 6;
            this.btn_Confirm.Text = "Xác Nhận";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            // 
            // clm_MDH
            // 
            this.clm_MDH.HeaderText = "Mã Đơn Hàng";
            this.clm_MDH.MinimumWidth = 125;
            this.clm_MDH.Name = "clm_MDH";
            this.clm_MDH.ReadOnly = true;
            this.clm_MDH.Width = 125;
            // 
            // clm_NguoiDat
            // 
            this.clm_NguoiDat.HeaderText = "Người Đặt";
            this.clm_NguoiDat.MinimumWidth = 125;
            this.clm_NguoiDat.Name = "clm_NguoiDat";
            this.clm_NguoiDat.ReadOnly = true;
            this.clm_NguoiDat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clm_NguoiDat.Width = 125;
            // 
            // clm_ChiTiet
            // 
            this.clm_ChiTiet.HeaderText = "Chi Tiết Đơn Hàng";
            this.clm_ChiTiet.MinimumWidth = 250;
            this.clm_ChiTiet.Name = "clm_ChiTiet";
            this.clm_ChiTiet.ReadOnly = true;
            this.clm_ChiTiet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clm_ChiTiet.Width = 750;
            // 
            // clm_NgayDat
            // 
            this.clm_NgayDat.HeaderText = "Ngày Đặt Hàng";
            this.clm_NgayDat.MinimumWidth = 125;
            this.clm_NgayDat.Name = "clm_NgayDat";
            this.clm_NgayDat.ReadOnly = true;
            this.clm_NgayDat.Width = 150;
            // 
            // clm_DiaChiGiao
            // 
            this.clm_DiaChiGiao.HeaderText = "Địa Chỉ Giao";
            this.clm_DiaChiGiao.MinimumWidth = 125;
            this.clm_DiaChiGiao.Name = "clm_DiaChiGiao";
            this.clm_DiaChiGiao.ReadOnly = true;
            this.clm_DiaChiGiao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clm_DiaChiGiao.Width = 200;
            // 
            // clm_TrangThai
            // 
            this.clm_TrangThai.HeaderText = "Trạng Thái";
            this.clm_TrangThai.MinimumWidth = 125;
            this.clm_TrangThai.Name = "clm_TrangThai";
            this.clm_TrangThai.ReadOnly = true;
            this.clm_TrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clm_TrangThai.Width = 125;
            // 
            // frm_ManageOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 861);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lb_MaDonHang);
            this.Controls.Add(this.tb_MaDonHang);
            this.Controls.Add(this.dtpck_NgayOrder);
            this.Controls.Add(this.grb_SoLuongDonHang);
            this.Controls.Add(this.grb_Status);
            this.Controls.Add(this.dgv_Order);
            this.Name = "frm_ManageOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Đơn Hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_ManageOrder_FormClosed);
            this.Load += new System.EventHandler(this.frm_ManageOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).EndInit();
            this.grb_Status.ResumeLayout(false);
            this.grb_Status.PerformLayout();
            this.grb_SoLuongDonHang.ResumeLayout(false);
            this.grb_SoLuongDonHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Order;
        private System.Windows.Forms.GroupBox grb_Status;
        private System.Windows.Forms.CheckBox cbx_DaHuy;
        private System.Windows.Forms.CheckBox cbx_HoanThanh;
        private System.Windows.Forms.CheckBox cbx_DangGiaoHang;
        private System.Windows.Forms.CheckBox cbx_DaXacNhan;
        private System.Windows.Forms.CheckBox cbx_ChuaXacNhan;
        private System.Windows.Forms.GroupBox grb_SoLuongDonHang;
        private System.Windows.Forms.Label lb_DaHuy;
        private System.Windows.Forms.Label lb_HoanThanh;
        private System.Windows.Forms.Label lb_DangGiaoHang;
        private System.Windows.Forms.Label lb_DaXacNhan;
        private System.Windows.Forms.Label lb_ChoXacNhan;
        private System.Windows.Forms.DateTimePicker dtpck_NgayOrder;
        private System.Windows.Forms.TextBox tb_MaDonHang;
        private System.Windows.Forms.Label lb_MaDonHang;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_MDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_NguoiDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DiaChiGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_TrangThai;
    }
}