namespace FruitApp
{
    partial class frm_ManageSuplier
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
            this.dgv_DoiTac = new System.Windows.Forms.DataGridView();
            this.clm_MaDoiTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_TenDoiTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_DoiTac = new System.Windows.Forms.Panel();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lb_MaDoiTac = new System.Windows.Forms.Label();
            this.lb_TenDoiTac = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_MaDoiTac = new System.Windows.Forms.TextBox();
            this.tb_Fax = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_TenDoiTac = new System.Windows.Forms.TextBox();
            this.tb_DienThoai = new System.Windows.Forms.TextBox();
            this.tb_MaSoThue = new System.Windows.Forms.TextBox();
            this.tb_NgayHopTac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbx_MoTa = new System.Windows.Forms.RichTextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.dtpck_ChonNgay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoiTac)).BeginInit();
            this.pnl_DoiTac.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DoiTac
            // 
            this.dgv_DoiTac.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DoiTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DoiTac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_MaDoiTac,
            this.clm_TenDoiTac});
            this.dgv_DoiTac.Location = new System.Drawing.Point(0, 215);
            this.dgv_DoiTac.Name = "dgv_DoiTac";
            this.dgv_DoiTac.RowHeadersWidth = 51;
            this.dgv_DoiTac.RowTemplate.Height = 24;
            this.dgv_DoiTac.Size = new System.Drawing.Size(760, 650);
            this.dgv_DoiTac.TabIndex = 0;
            this.dgv_DoiTac.TabStop = false;
            this.dgv_DoiTac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DoiTac_CellClick);
            // 
            // clm_MaDoiTac
            // 
            this.clm_MaDoiTac.HeaderText = "Mã Đối Tác";
            this.clm_MaDoiTac.MinimumWidth = 125;
            this.clm_MaDoiTac.Name = "clm_MaDoiTac";
            this.clm_MaDoiTac.ReadOnly = true;
            this.clm_MaDoiTac.Width = 175;
            // 
            // clm_TenDoiTac
            // 
            this.clm_TenDoiTac.HeaderText = "Tên Đối Tác";
            this.clm_TenDoiTac.MinimumWidth = 175;
            this.clm_TenDoiTac.Name = "clm_TenDoiTac";
            this.clm_TenDoiTac.ReadOnly = true;
            this.clm_TenDoiTac.Width = 350;
            // 
            // pnl_DoiTac
            // 
            this.pnl_DoiTac.Controls.Add(this.btn_Sua);
            this.pnl_DoiTac.Controls.Add(this.btn_Them);
            this.pnl_DoiTac.Location = new System.Drawing.Point(0, 0);
            this.pnl_DoiTac.Name = "pnl_DoiTac";
            this.pnl_DoiTac.Size = new System.Drawing.Size(760, 213);
            this.pnl_DoiTac.TabIndex = 1;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(436, 75);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(167, 38);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa Thông Tin";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(175, 75);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(167, 38);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm Đối Tác";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lb_MaDoiTac
            // 
            this.lb_MaDoiTac.AutoSize = true;
            this.lb_MaDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaDoiTac.Location = new System.Drawing.Point(874, 111);
            this.lb_MaDoiTac.Name = "lb_MaDoiTac";
            this.lb_MaDoiTac.Size = new System.Drawing.Size(113, 25);
            this.lb_MaDoiTac.TabIndex = 2;
            this.lb_MaDoiTac.Text = "Mã Đối Tác";
            // 
            // lb_TenDoiTac
            // 
            this.lb_TenDoiTac.AutoSize = true;
            this.lb_TenDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenDoiTac.Location = new System.Drawing.Point(1122, 111);
            this.lb_TenDoiTac.Name = "lb_TenDoiTac";
            this.lb_TenDoiTac.Size = new System.Drawing.Size(120, 25);
            this.lb_TenDoiTac.TabIndex = 3;
            this.lb_TenDoiTac.Text = "Tên Đối Tác";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1122, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Số Thuế";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(874, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(874, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1265, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số Điện Thoại";
            // 
            // tb_MaDoiTac
            // 
            this.tb_MaDoiTac.Enabled = false;
            this.tb_MaDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaDoiTac.Location = new System.Drawing.Point(879, 150);
            this.tb_MaDoiTac.MaxLength = 6;
            this.tb_MaDoiTac.Name = "tb_MaDoiTac";
            this.tb_MaDoiTac.Size = new System.Drawing.Size(167, 30);
            this.tb_MaDoiTac.TabIndex = 8;
            // 
            // tb_Fax
            // 
            this.tb_Fax.Enabled = false;
            this.tb_Fax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Fax.Location = new System.Drawing.Point(879, 399);
            this.tb_Fax.MaxLength = 15;
            this.tb_Fax.Name = "tb_Fax";
            this.tb_Fax.Size = new System.Drawing.Size(199, 30);
            this.tb_Fax.TabIndex = 14;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Enabled = false;
            this.tb_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DiaChi.Location = new System.Drawing.Point(879, 277);
            this.tb_DiaChi.MaxLength = 100;
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(318, 30);
            this.tb_DiaChi.TabIndex = 15;
            // 
            // tb_TenDoiTac
            // 
            this.tb_TenDoiTac.Enabled = false;
            this.tb_TenDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenDoiTac.Location = new System.Drawing.Point(1126, 150);
            this.tb_TenDoiTac.MaxLength = 50;
            this.tb_TenDoiTac.Name = "tb_TenDoiTac";
            this.tb_TenDoiTac.Size = new System.Drawing.Size(329, 30);
            this.tb_TenDoiTac.TabIndex = 16;
            // 
            // tb_DienThoai
            // 
            this.tb_DienThoai.Enabled = false;
            this.tb_DienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DienThoai.Location = new System.Drawing.Point(1270, 277);
            this.tb_DienThoai.MaxLength = 10;
            this.tb_DienThoai.Name = "tb_DienThoai";
            this.tb_DienThoai.Size = new System.Drawing.Size(185, 30);
            this.tb_DienThoai.TabIndex = 17;
            // 
            // tb_MaSoThue
            // 
            this.tb_MaSoThue.Enabled = false;
            this.tb_MaSoThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaSoThue.Location = new System.Drawing.Point(1126, 399);
            this.tb_MaSoThue.MaxLength = 15;
            this.tb_MaSoThue.Name = "tb_MaSoThue";
            this.tb_MaSoThue.Size = new System.Drawing.Size(199, 30);
            this.tb_MaSoThue.TabIndex = 18;
            // 
            // tb_NgayHopTac
            // 
            this.tb_NgayHopTac.Enabled = false;
            this.tb_NgayHopTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NgayHopTac.Location = new System.Drawing.Point(879, 501);
            this.tb_NgayHopTac.MaxLength = 10;
            this.tb_NgayHopTac.Name = "tb_NgayHopTac";
            this.tb_NgayHopTac.Size = new System.Drawing.Size(199, 30);
            this.tb_NgayHopTac.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(874, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ngày Hợp Tác";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(874, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Mô Tả";
            // 
            // rtbx_MoTa
            // 
            this.rtbx_MoTa.Enabled = false;
            this.rtbx_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbx_MoTa.Location = new System.Drawing.Point(882, 613);
            this.rtbx_MoTa.MaxLength = 256;
            this.rtbx_MoTa.Name = "rtbx_MoTa";
            this.rtbx_MoTa.Size = new System.Drawing.Size(573, 252);
            this.rtbx_MoTa.TabIndex = 22;
            this.rtbx_MoTa.Text = "";
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(1126, 494);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(141, 37);
            this.btn_Luu.TabIndex = 23;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Visible = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(1314, 494);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(141, 37);
            this.btn_Huy.TabIndex = 24;
            this.btn_Huy.Text = "Hủy Bỏ";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Visible = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // dtpck_ChonNgay
            // 
            this.dtpck_ChonNgay.Location = new System.Drawing.Point(1059, 505);
            this.dtpck_ChonNgay.Name = "dtpck_ChonNgay";
            this.dtpck_ChonNgay.Size = new System.Drawing.Size(17, 22);
            this.dtpck_ChonNgay.TabIndex = 25;
            this.dtpck_ChonNgay.Visible = false;
            this.dtpck_ChonNgay.ValueChanged += new System.EventHandler(this.dtpck_ChonNgay_ValueChanged);
            // 
            // frm_ManageSuplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dtpck_ChonNgay);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.rtbx_MoTa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_NgayHopTac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_MaSoThue);
            this.Controls.Add(this.tb_DienThoai);
            this.Controls.Add(this.tb_TenDoiTac);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.tb_Fax);
            this.Controls.Add(this.tb_MaDoiTac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_TenDoiTac);
            this.Controls.Add(this.lb_MaDoiTac);
            this.Controls.Add(this.pnl_DoiTac);
            this.Controls.Add(this.dgv_DoiTac);
            this.Name = "frm_ManageSuplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Đối Tác";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_ManageSuplier_FormClosed);
            this.Load += new System.EventHandler(this.frm_ManageSuplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoiTac)).EndInit();
            this.pnl_DoiTac.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DoiTac;
        private System.Windows.Forms.Panel pnl_DoiTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_MaDoiTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_TenDoiTac;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label lb_MaDoiTac;
        private System.Windows.Forms.Label lb_TenDoiTac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_MaDoiTac;
        private System.Windows.Forms.TextBox tb_Fax;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_TenDoiTac;
        private System.Windows.Forms.TextBox tb_DienThoai;
        private System.Windows.Forms.TextBox tb_MaSoThue;
        private System.Windows.Forms.TextBox tb_NgayHopTac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbx_MoTa;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.DateTimePicker dtpck_ChonNgay;
    }
}