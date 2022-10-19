namespace FruitApp.Forms.Manage
{
    partial class frm_ManageEmployee
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
            this.pnl_QLNV = new System.Windows.Forms.Panel();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.cb_CVNV = new System.Windows.Forms.ComboBox();
            this.lb_CV = new System.Windows.Forms.Label();
            this.tb_TNV = new System.Windows.Forms.TextBox();
            this.tb_MNV = new System.Windows.Forms.TextBox();
            this.lb_TNV = new System.Windows.Forms.Label();
            this.lb_MNV = new System.Windows.Forms.Label();
            this.pnl_TTNV = new System.Windows.Forms.Panel();
            this.lb_NgayVaoLam = new System.Windows.Forms.Label();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.lb_DienThoai = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_ChucVu = new System.Windows.Forms.Label();
            this.lb_MaNV = new System.Windows.Forms.Label();
            this.lb_TenNV = new System.Windows.Forms.Label();
            this.ptr_NV = new System.Windows.Forms.PictureBox();
            this.dgv_NV = new System.Windows.Forms.DataGridView();
            this.clm_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.pnl_QLNV.SuspendLayout();
            this.pnl_TTNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_NV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_QLNV
            // 
            this.pnl_QLNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnl_QLNV.Controls.Add(this.btn_Xoa);
            this.pnl_QLNV.Controls.Add(this.btn_Them);
            this.pnl_QLNV.Controls.Add(this.btn_Sua);
            this.pnl_QLNV.Controls.Add(this.cb_CVNV);
            this.pnl_QLNV.Controls.Add(this.lb_CV);
            this.pnl_QLNV.Controls.Add(this.tb_TNV);
            this.pnl_QLNV.Controls.Add(this.tb_MNV);
            this.pnl_QLNV.Controls.Add(this.lb_TNV);
            this.pnl_QLNV.Controls.Add(this.lb_MNV);
            this.pnl_QLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_QLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_QLNV.Location = new System.Drawing.Point(0, 0);
            this.pnl_QLNV.Name = "pnl_QLNV";
            this.pnl_QLNV.Size = new System.Drawing.Size(1924, 175);
            this.pnl_QLNV.TabIndex = 0;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(871, 82);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(180, 37);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm Nhân Viên";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Enabled = false;
            this.btn_Sua.Location = new System.Drawing.Point(1074, 82);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(164, 37);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa Thông Tin";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // cb_CVNV
            // 
            this.cb_CVNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CVNV.FormattingEnabled = true;
            this.cb_CVNV.Location = new System.Drawing.Point(570, 86);
            this.cb_CVNV.Name = "cb_CVNV";
            this.cb_CVNV.Size = new System.Drawing.Size(262, 33);
            this.cb_CVNV.TabIndex = 5;
            this.cb_CVNV.SelectedIndexChanged += new System.EventHandler(this.cb_CVNV_SelectedIndexChanged);
            // 
            // lb_CV
            // 
            this.lb_CV.AutoSize = true;
            this.lb_CV.Location = new System.Drawing.Point(659, 43);
            this.lb_CV.Name = "lb_CV";
            this.lb_CV.Size = new System.Drawing.Size(95, 25);
            this.lb_CV.TabIndex = 4;
            this.lb_CV.Text = "Chức Vụ:";
            // 
            // tb_TNV
            // 
            this.tb_TNV.Location = new System.Drawing.Point(251, 89);
            this.tb_TNV.MaxLength = 40;
            this.tb_TNV.Name = "tb_TNV";
            this.tb_TNV.Size = new System.Drawing.Size(273, 30);
            this.tb_TNV.TabIndex = 3;
            this.tb_TNV.TextChanged += new System.EventHandler(this.tb_TNV_TextChanged);
            // 
            // tb_MNV
            // 
            this.tb_MNV.Location = new System.Drawing.Point(251, 38);
            this.tb_MNV.MaxLength = 10;
            this.tb_MNV.Name = "tb_MNV";
            this.tb_MNV.Size = new System.Drawing.Size(139, 30);
            this.tb_MNV.TabIndex = 2;
            this.tb_MNV.TextChanged += new System.EventHandler(this.tb_MNV_TextChanged);
            // 
            // lb_TNV
            // 
            this.lb_TNV.AutoSize = true;
            this.lb_TNV.Location = new System.Drawing.Point(82, 92);
            this.lb_TNV.Name = "lb_TNV";
            this.lb_TNV.Size = new System.Drawing.Size(143, 25);
            this.lb_TNV.TabIndex = 1;
            this.lb_TNV.Text = "Tên nhân viên:";
            // 
            // lb_MNV
            // 
            this.lb_MNV.AutoSize = true;
            this.lb_MNV.Location = new System.Drawing.Point(82, 38);
            this.lb_MNV.Name = "lb_MNV";
            this.lb_MNV.Size = new System.Drawing.Size(143, 25);
            this.lb_MNV.TabIndex = 0;
            this.lb_MNV.Text = "Mã Nhân Viên:";
            // 
            // pnl_TTNV
            // 
            this.pnl_TTNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnl_TTNV.Controls.Add(this.lb_NgayVaoLam);
            this.pnl_TTNV.Controls.Add(this.lb_NgaySinh);
            this.pnl_TTNV.Controls.Add(this.lb_DienThoai);
            this.pnl_TTNV.Controls.Add(this.lb_DiaChi);
            this.pnl_TTNV.Controls.Add(this.lb_ChucVu);
            this.pnl_TTNV.Controls.Add(this.lb_MaNV);
            this.pnl_TTNV.Controls.Add(this.lb_TenNV);
            this.pnl_TTNV.Controls.Add(this.ptr_NV);
            this.pnl_TTNV.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_TTNV.Location = new System.Drawing.Point(1254, 175);
            this.pnl_TTNV.Name = "pnl_TTNV";
            this.pnl_TTNV.Size = new System.Drawing.Size(670, 880);
            this.pnl_TTNV.TabIndex = 1;
            // 
            // lb_NgayVaoLam
            // 
            this.lb_NgayVaoLam.AutoSize = true;
            this.lb_NgayVaoLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayVaoLam.Location = new System.Drawing.Point(299, 602);
            this.lb_NgayVaoLam.Name = "lb_NgayVaoLam";
            this.lb_NgayVaoLam.Size = new System.Drawing.Size(142, 25);
            this.lb_NgayVaoLam.TabIndex = 7;
            this.lb_NgayVaoLam.Text = "Ngày Vào Làm";
            this.lb_NgayVaoLam.Visible = false;
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgaySinh.Location = new System.Drawing.Point(61, 602);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(103, 25);
            this.lb_NgaySinh.TabIndex = 6;
            this.lb_NgaySinh.Text = "Ngày Sinh";
            this.lb_NgaySinh.Visible = false;
            // 
            // lb_DienThoai
            // 
            this.lb_DienThoai.AutoSize = true;
            this.lb_DienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DienThoai.Location = new System.Drawing.Point(61, 564);
            this.lb_DienThoai.Name = "lb_DienThoai";
            this.lb_DienThoai.Size = new System.Drawing.Size(107, 25);
            this.lb_DienThoai.TabIndex = 5;
            this.lb_DienThoai.Text = "Điện Thoại";
            this.lb_DienThoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_DienThoai.Visible = false;
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiaChi.Location = new System.Drawing.Point(61, 523);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(76, 25);
            this.lb_DiaChi.TabIndex = 4;
            this.lb_DiaChi.Text = "Địa Chỉ";
            this.lb_DiaChi.Visible = false;
            // 
            // lb_ChucVu
            // 
            this.lb_ChucVu.AutoSize = true;
            this.lb_ChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChucVu.Location = new System.Drawing.Point(299, 483);
            this.lb_ChucVu.Name = "lb_ChucVu";
            this.lb_ChucVu.Size = new System.Drawing.Size(89, 25);
            this.lb_ChucVu.TabIndex = 3;
            this.lb_ChucVu.Text = "Chức Vụ";
            this.lb_ChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_ChucVu.Visible = false;
            // 
            // lb_MaNV
            // 
            this.lb_MaNV.AutoSize = true;
            this.lb_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaNV.Location = new System.Drawing.Point(61, 483);
            this.lb_MaNV.Name = "lb_MaNV";
            this.lb_MaNV.Size = new System.Drawing.Size(73, 25);
            this.lb_MaNV.TabIndex = 2;
            this.lb_MaNV.Text = "Mã NV";
            this.lb_MaNV.Visible = false;
            // 
            // lb_TenNV
            // 
            this.lb_TenNV.AutoSize = true;
            this.lb_TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenNV.ForeColor = System.Drawing.Color.Blue;
            this.lb_TenNV.Location = new System.Drawing.Point(168, 436);
            this.lb_TenNV.Name = "lb_TenNV";
            this.lb_TenNV.Size = new System.Drawing.Size(90, 31);
            this.lb_TenNV.TabIndex = 1;
            this.lb_TenNV.Text = "Name";
            this.lb_TenNV.Visible = false;
            // 
            // ptr_NV
            // 
            this.ptr_NV.BackColor = System.Drawing.Color.White;
            this.ptr_NV.Location = new System.Drawing.Point(63, 16);
            this.ptr_NV.Name = "ptr_NV";
            this.ptr_NV.Size = new System.Drawing.Size(448, 417);
            this.ptr_NV.TabIndex = 0;
            this.ptr_NV.TabStop = false;
            this.ptr_NV.Visible = false;
            // 
            // dgv_NV
            // 
            this.dgv_NV.BackgroundColor = System.Drawing.Color.White;
            this.dgv_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_MaNV,
            this.clm_TenNV,
            this.clm_DT,
            this.clm_ChucVu,
            this.clm_GhiChu});
            this.dgv_NV.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_NV.Location = new System.Drawing.Point(0, 175);
            this.dgv_NV.Name = "dgv_NV";
            this.dgv_NV.RowHeadersWidth = 51;
            this.dgv_NV.RowTemplate.Height = 24;
            this.dgv_NV.Size = new System.Drawing.Size(1248, 880);
            this.dgv_NV.TabIndex = 2;
            this.dgv_NV.TabStop = false;
            this.dgv_NV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NV_CellContentClick);
            // 
            // clm_MaNV
            // 
            this.clm_MaNV.HeaderText = "Mã Nhân Viên";
            this.clm_MaNV.MinimumWidth = 125;
            this.clm_MaNV.Name = "clm_MaNV";
            this.clm_MaNV.ReadOnly = true;
            this.clm_MaNV.Width = 125;
            // 
            // clm_TenNV
            // 
            this.clm_TenNV.HeaderText = "Tên Nhân Viên";
            this.clm_TenNV.MinimumWidth = 150;
            this.clm_TenNV.Name = "clm_TenNV";
            this.clm_TenNV.ReadOnly = true;
            this.clm_TenNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clm_TenNV.Width = 150;
            // 
            // clm_DT
            // 
            this.clm_DT.HeaderText = "Điện Thoại";
            this.clm_DT.MinimumWidth = 125;
            this.clm_DT.Name = "clm_DT";
            this.clm_DT.ReadOnly = true;
            this.clm_DT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clm_DT.Width = 125;
            // 
            // clm_ChucVu
            // 
            this.clm_ChucVu.HeaderText = "Chức Vụ";
            this.clm_ChucVu.MinimumWidth = 125;
            this.clm_ChucVu.Name = "clm_ChucVu";
            this.clm_ChucVu.ReadOnly = true;
            this.clm_ChucVu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clm_ChucVu.Width = 125;
            // 
            // clm_GhiChu
            // 
            this.clm_GhiChu.FillWeight = 1000F;
            this.clm_GhiChu.HeaderText = "Ghi Chú";
            this.clm_GhiChu.MinimumWidth = 125;
            this.clm_GhiChu.Name = "clm_GhiChu";
            this.clm_GhiChu.ReadOnly = true;
            this.clm_GhiChu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clm_GhiChu.Width = 360;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Location = new System.Drawing.Point(1258, 80);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(164, 37);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa Thông Tin";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // frm_ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dgv_NV);
            this.Controls.Add(this.pnl_TTNV);
            this.Controls.Add(this.pnl_QLNV);
            this.Name = "frm_ManageEmployee";
            this.Text = "Quản Lý Nhân Viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_ManageEmployee_FormClosed);
            this.Load += new System.EventHandler(this.frm_ManageEmployee_Load);
            this.pnl_QLNV.ResumeLayout(false);
            this.pnl_QLNV.PerformLayout();
            this.pnl_TTNV.ResumeLayout(false);
            this.pnl_TTNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_NV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_QLNV;
        private System.Windows.Forms.Panel pnl_TTNV;
        private System.Windows.Forms.DataGridView dgv_NV;
        private System.Windows.Forms.PictureBox ptr_NV;
        private System.Windows.Forms.Label lb_TenNV;
        private System.Windows.Forms.Label lb_NgayVaoLam;
        private System.Windows.Forms.Label lb_NgaySinh;
        private System.Windows.Forms.Label lb_DienThoai;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_ChucVu;
        private System.Windows.Forms.Label lb_MaNV;
        private System.Windows.Forms.Label lb_TNV;
        private System.Windows.Forms.Label lb_MNV;
        private System.Windows.Forms.Label lb_CV;
        private System.Windows.Forms.TextBox tb_TNV;
        private System.Windows.Forms.TextBox tb_MNV;
        private System.Windows.Forms.ComboBox cb_CVNV;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_GhiChu;
        private System.Windows.Forms.Button btn_Xoa;
    }
}