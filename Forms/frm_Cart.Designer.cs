namespace DoAn
{
    partial class frm_Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cart));
            this.fruitAppDataSet = new DoAn.FruitAppDataSet();
            this.fruitAppDataSet1 = new DoAn.FruitAppDataSet1();
            this.txtTenTraiCay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaTraiCay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btDatHang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.ptAnh = new System.Windows.Forms.PictureBox();
            this.DataGW1 = new System.Windows.Forms.DataGridView();
            this.clMaTraiCay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenTraiCay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fruitAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitAppDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGW1)).BeginInit();
            this.SuspendLayout();
            // 
            // fruitAppDataSet
            // 
            this.fruitAppDataSet.DataSetName = "FruitAppDataSet";
            this.fruitAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fruitAppDataSet1
            // 
            this.fruitAppDataSet1.DataSetName = "FruitAppDataSet1";
            this.fruitAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTenTraiCay
            // 
            this.txtTenTraiCay.Enabled = false;
            this.txtTenTraiCay.Location = new System.Drawing.Point(135, 72);
            this.txtTenTraiCay.Name = "txtTenTraiCay";
            this.txtTenTraiCay.Size = new System.Drawing.Size(100, 22);
            this.txtTenTraiCay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Trái Cây";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaTraiCay);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtThanhTien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btDatHang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.txtTenTraiCay);
            this.panel1.Controls.Add(this.ptAnh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 344);
            this.panel1.TabIndex = 5;
            // 
            // txtMaTraiCay
            // 
            this.txtMaTraiCay.Enabled = false;
            this.txtMaTraiCay.Location = new System.Drawing.Point(135, 18);
            this.txtMaTraiCay.Name = "txtMaTraiCay";
            this.txtMaTraiCay.Size = new System.Drawing.Size(100, 22);
            this.txtMaTraiCay.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã Trái Cây";
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btXoa.Image = global::DoAn.Properties.Resources.icons8_close_48;
            this.btXoa.Location = new System.Drawing.Point(229, 276);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(111, 53);
            this.btXoa.TabIndex = 10;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btxoa_click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ảnh ";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(135, 233);
            this.txtThanhTien.Multiline = true;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(100, 22);
            this.txtThanhTien.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thành Tiền";
            // 
            // btDatHang
            // 
            this.btDatHang.Image = ((System.Drawing.Image)(resources.GetObject("btDatHang.Image")));
            this.btDatHang.Location = new System.Drawing.Point(51, 276);
            this.btDatHang.Name = "btDatHang";
            this.btDatHang.Size = new System.Drawing.Size(104, 53);
            this.btDatHang.TabIndex = 2;
            this.btDatHang.UseVisualStyleBackColor = true;
            this.btDatHang.Click += new System.EventHandler(this.btDatHang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(135, 158);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 22);
            this.txtSoLuong.TabIndex = 5;
            // 
            // ptAnh
            // 
            this.ptAnh.Location = new System.Drawing.Point(363, 21);
            this.ptAnh.Name = "ptAnh";
            this.ptAnh.Size = new System.Drawing.Size(208, 200);
            this.ptAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptAnh.TabIndex = 4;
            this.ptAnh.TabStop = false;
            // 
            // DataGW1
            // 
            this.DataGW1.AllowUserToOrderColumns = true;
            this.DataGW1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.DataGW1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGW1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaTraiCay,
            this.clTenTraiCay,
            this.clSoLuong,
            this.clThanhTien});
            this.DataGW1.Location = new System.Drawing.Point(655, 60);
            this.DataGW1.Name = "DataGW1";
            this.DataGW1.RowHeadersWidth = 51;
            this.DataGW1.RowTemplate.Height = 24;
            this.DataGW1.Size = new System.Drawing.Size(673, 344);
            this.DataGW1.TabIndex = 7;
            this.DataGW1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGW1_CellClick);
            // 
            // clMaTraiCay
            // 
            this.clMaTraiCay.HeaderText = "Mã Trái Cây";
            this.clMaTraiCay.MinimumWidth = 6;
            this.clMaTraiCay.Name = "clMaTraiCay";
            this.clMaTraiCay.Width = 125;
            // 
            // clTenTraiCay
            // 
            this.clTenTraiCay.HeaderText = "Tên Trái Cây";
            this.clTenTraiCay.MinimumWidth = 6;
            this.clTenTraiCay.Name = "clTenTraiCay";
            this.clTenTraiCay.Width = 125;
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số Lượng";
            this.clSoLuong.MinimumWidth = 6;
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.Width = 125;
            // 
            // clThanhTien
            // 
            this.clThanhTien.HeaderText = "Thành Tiền";
            this.clThanhTien.MinimumWidth = 6;
            this.clThanhTien.Name = "clThanhTien";
            this.clThanhTien.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(599, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giỏ Hàng";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(898, 423);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(176, 22);
            this.txtTongTien.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(794, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tổng Tiền";
            // 
            // frm_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = global::DoAn.Properties.Resources.icons8_fruit_58;
            this.ClientSize = new System.Drawing.Size(1340, 511);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.DataGW1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Cart";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fruitAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitAppDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGW1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FruitAppDataSet fruitAppDataSet;
        private FruitAppDataSet1 fruitAppDataSet1;
        private System.Windows.Forms.TextBox txtTenTraiCay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDatHang;
        private System.Windows.Forms.PictureBox ptAnh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaTraiCay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.DataGridView DataGW1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaTraiCay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenTraiCay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
    }
}

