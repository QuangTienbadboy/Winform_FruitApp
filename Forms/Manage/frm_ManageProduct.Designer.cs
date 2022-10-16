namespace FruitApp
{
    partial class frm_ManageProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_SP = new System.Windows.Forms.DataGridView();
            this.lb_MaTraiCay = new System.Windows.Forms.Label();
            this.lb_TenTraiCay = new System.Windows.Forms.Label();
            this.lb_LoaiTraiCay = new System.Windows.Forms.Label();
            this.tb_MaTraiCay = new System.Windows.Forms.TextBox();
            this.tb_TenTraiCay = new System.Windows.Forms.TextBox();
            this.cb_LoaiTraiCay = new System.Windows.Forms.ComboBox();
            this.btn_ThemSanPham = new System.Windows.Forms.Button();
            this.btn_SuaSanPham = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.clm_MaTraiCay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_TenTraiCay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_LoaiTraiCay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_GiaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_TonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_SP
            // 
            this.dgv_SP.BackgroundColor = System.Drawing.Color.White;
            this.dgv_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_MaTraiCay,
            this.clm_TenTraiCay,
            this.clm_LoaiTraiCay,
            this.clm_DonViTinh,
            this.clm_GiaBan,
            this.clm_GiaMua,
            this.clm_TonKho});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_SP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_SP.Location = new System.Drawing.Point(0, 338);
            this.dgv_SP.Name = "dgv_SP";
            this.dgv_SP.ReadOnly = true;
            this.dgv_SP.RowHeadersWidth = 51;
            this.dgv_SP.RowTemplate.Height = 24;
            this.dgv_SP.Size = new System.Drawing.Size(1924, 717);
            this.dgv_SP.TabIndex = 0;
            this.dgv_SP.TabStop = false;
            this.dgv_SP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SP_CellClick);
            // 
            // lb_MaTraiCay
            // 
            this.lb_MaTraiCay.AutoSize = true;
            this.lb_MaTraiCay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaTraiCay.Location = new System.Drawing.Point(138, 33);
            this.lb_MaTraiCay.Name = "lb_MaTraiCay";
            this.lb_MaTraiCay.Size = new System.Drawing.Size(120, 25);
            this.lb_MaTraiCay.TabIndex = 1;
            this.lb_MaTraiCay.Text = "Mã Trái Cây";
            // 
            // lb_TenTraiCay
            // 
            this.lb_TenTraiCay.AutoSize = true;
            this.lb_TenTraiCay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenTraiCay.Location = new System.Drawing.Point(581, 33);
            this.lb_TenTraiCay.Name = "lb_TenTraiCay";
            this.lb_TenTraiCay.Size = new System.Drawing.Size(127, 25);
            this.lb_TenTraiCay.TabIndex = 2;
            this.lb_TenTraiCay.Text = "Tên Trái Cây";
            // 
            // lb_LoaiTraiCay
            // 
            this.lb_LoaiTraiCay.AutoSize = true;
            this.lb_LoaiTraiCay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoaiTraiCay.Location = new System.Drawing.Point(1044, 30);
            this.lb_LoaiTraiCay.Name = "lb_LoaiTraiCay";
            this.lb_LoaiTraiCay.Size = new System.Drawing.Size(129, 25);
            this.lb_LoaiTraiCay.TabIndex = 3;
            this.lb_LoaiTraiCay.Text = "Loại Trái Cây";
            // 
            // tb_MaTraiCay
            // 
            this.tb_MaTraiCay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaTraiCay.Location = new System.Drawing.Point(97, 61);
            this.tb_MaTraiCay.MaxLength = 12;
            this.tb_MaTraiCay.Name = "tb_MaTraiCay";
            this.tb_MaTraiCay.Size = new System.Drawing.Size(199, 30);
            this.tb_MaTraiCay.TabIndex = 4;
            this.tb_MaTraiCay.TextChanged += new System.EventHandler(this.cb_LoaiTraiCay_SelectedIndexChanged);
            // 
            // tb_TenTraiCay
            // 
            this.tb_TenTraiCay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenTraiCay.Location = new System.Drawing.Point(457, 61);
            this.tb_TenTraiCay.MaxLength = 100;
            this.tb_TenTraiCay.Name = "tb_TenTraiCay";
            this.tb_TenTraiCay.Size = new System.Drawing.Size(399, 30);
            this.tb_TenTraiCay.TabIndex = 5;
            this.tb_TenTraiCay.TextChanged += new System.EventHandler(this.cb_LoaiTraiCay_SelectedIndexChanged);
            // 
            // cb_LoaiTraiCay
            // 
            this.cb_LoaiTraiCay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LoaiTraiCay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiTraiCay.FormattingEnabled = true;
            this.cb_LoaiTraiCay.Location = new System.Drawing.Point(986, 58);
            this.cb_LoaiTraiCay.Name = "cb_LoaiTraiCay";
            this.cb_LoaiTraiCay.Size = new System.Drawing.Size(242, 33);
            this.cb_LoaiTraiCay.TabIndex = 6;
            this.cb_LoaiTraiCay.SelectedIndexChanged += new System.EventHandler(this.cb_LoaiTraiCay_SelectedIndexChanged);
            // 
            // btn_ThemSanPham
            // 
            this.btn_ThemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemSanPham.Location = new System.Drawing.Point(1315, 53);
            this.btn_ThemSanPham.Name = "btn_ThemSanPham";
            this.btn_ThemSanPham.Size = new System.Drawing.Size(165, 38);
            this.btn_ThemSanPham.TabIndex = 7;
            this.btn_ThemSanPham.Text = "Thêm Trái Cây";
            this.btn_ThemSanPham.UseVisualStyleBackColor = true;
            this.btn_ThemSanPham.Click += new System.EventHandler(this.btn_ThemSanPham_Click);
            // 
            // btn_SuaSanPham
            // 
            this.btn_SuaSanPham.Enabled = false;
            this.btn_SuaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaSanPham.Location = new System.Drawing.Point(1486, 52);
            this.btn_SuaSanPham.Name = "btn_SuaSanPham";
            this.btn_SuaSanPham.Size = new System.Drawing.Size(174, 38);
            this.btn_SuaSanPham.TabIndex = 8;
            this.btn_SuaSanPham.Text = "Sửa Thông Tin";
            this.btn_SuaSanPham.UseVisualStyleBackColor = true;
            this.btn_SuaSanPham.Click += new System.EventHandler(this.btn_SuaSanPham_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.Location = new System.Drawing.Point(1666, 52);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(123, 38);
            this.btn_Import.TabIndex = 10;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            // 
            // clm_MaTraiCay
            // 
            this.clm_MaTraiCay.HeaderText = "Mã Trái Cây";
            this.clm_MaTraiCay.MinimumWidth = 125;
            this.clm_MaTraiCay.Name = "clm_MaTraiCay";
            this.clm_MaTraiCay.ReadOnly = true;
            this.clm_MaTraiCay.Width = 200;
            // 
            // clm_TenTraiCay
            // 
            this.clm_TenTraiCay.HeaderText = "Tên Trái Cây";
            this.clm_TenTraiCay.MinimumWidth = 125;
            this.clm_TenTraiCay.Name = "clm_TenTraiCay";
            this.clm_TenTraiCay.ReadOnly = true;
            this.clm_TenTraiCay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clm_TenTraiCay.Width = 475;
            // 
            // clm_LoaiTraiCay
            // 
            this.clm_LoaiTraiCay.HeaderText = "Loại Trái Cây";
            this.clm_LoaiTraiCay.MinimumWidth = 125;
            this.clm_LoaiTraiCay.Name = "clm_LoaiTraiCay";
            this.clm_LoaiTraiCay.ReadOnly = true;
            this.clm_LoaiTraiCay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clm_LoaiTraiCay.Width = 200;
            // 
            // clm_DonViTinh
            // 
            this.clm_DonViTinh.HeaderText = "Đơn Vị Tính";
            this.clm_DonViTinh.MinimumWidth = 125;
            this.clm_DonViTinh.Name = "clm_DonViTinh";
            this.clm_DonViTinh.ReadOnly = true;
            this.clm_DonViTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clm_DonViTinh.Width = 200;
            // 
            // clm_GiaBan
            // 
            this.clm_GiaBan.HeaderText = "Giá Bán";
            this.clm_GiaBan.MinimumWidth = 100;
            this.clm_GiaBan.Name = "clm_GiaBan";
            this.clm_GiaBan.ReadOnly = true;
            // 
            // clm_GiaMua
            // 
            this.clm_GiaMua.HeaderText = "Giá Mua";
            this.clm_GiaMua.MinimumWidth = 100;
            this.clm_GiaMua.Name = "clm_GiaMua";
            this.clm_GiaMua.ReadOnly = true;
            // 
            // clm_TonKho
            // 
            this.clm_TonKho.HeaderText = "Số Lượng";
            this.clm_TonKho.MinimumWidth = 125;
            this.clm_TonKho.Name = "clm_TonKho";
            this.clm_TonKho.ReadOnly = true;
            this.clm_TonKho.Width = 200;
            // 
            // frm_ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btn_SuaSanPham);
            this.Controls.Add(this.btn_ThemSanPham);
            this.Controls.Add(this.cb_LoaiTraiCay);
            this.Controls.Add(this.tb_TenTraiCay);
            this.Controls.Add(this.tb_MaTraiCay);
            this.Controls.Add(this.lb_LoaiTraiCay);
            this.Controls.Add(this.lb_TenTraiCay);
            this.Controls.Add(this.lb_MaTraiCay);
            this.Controls.Add(this.dgv_SP);
            this.Name = "frm_ManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Sản Phẩm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_ManageProduct_FormClosed);
            this.Load += new System.EventHandler(this.frm_ManageProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SP;
        private System.Windows.Forms.Label lb_MaTraiCay;
        private System.Windows.Forms.Label lb_TenTraiCay;
        private System.Windows.Forms.Label lb_LoaiTraiCay;
        private System.Windows.Forms.TextBox tb_MaTraiCay;
        private System.Windows.Forms.TextBox tb_TenTraiCay;
        private System.Windows.Forms.ComboBox cb_LoaiTraiCay;
        private System.Windows.Forms.Button btn_ThemSanPham;
        private System.Windows.Forms.Button btn_SuaSanPham;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_MaTraiCay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_TenTraiCay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_LoaiTraiCay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_GiaMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_TonKho;
    }
}