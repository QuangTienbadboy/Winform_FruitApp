namespace FruitApp.Forms.Manage
{
    partial class frm_TrangThai_Order
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
            this.rbtn_DaXacNhan = new System.Windows.Forms.RadioButton();
            this.rbtn_DangGiaoHang = new System.Windows.Forms.RadioButton();
            this.rbtn_HoanThanh = new System.Windows.Forms.RadioButton();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtn_DaXacNhan
            // 
            this.rbtn_DaXacNhan.AutoSize = true;
            this.rbtn_DaXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_DaXacNhan.Location = new System.Drawing.Point(309, 110);
            this.rbtn_DaXacNhan.Name = "rbtn_DaXacNhan";
            this.rbtn_DaXacNhan.Size = new System.Drawing.Size(150, 29);
            this.rbtn_DaXacNhan.TabIndex = 1;
            this.rbtn_DaXacNhan.TabStop = true;
            this.rbtn_DaXacNhan.Text = "Đã Xác Nhận";
            this.rbtn_DaXacNhan.UseVisualStyleBackColor = true;
            // 
            // rbtn_DangGiaoHang
            // 
            this.rbtn_DangGiaoHang.AutoSize = true;
            this.rbtn_DangGiaoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_DangGiaoHang.Location = new System.Drawing.Point(309, 168);
            this.rbtn_DangGiaoHang.Name = "rbtn_DangGiaoHang";
            this.rbtn_DangGiaoHang.Size = new System.Drawing.Size(178, 29);
            this.rbtn_DangGiaoHang.TabIndex = 2;
            this.rbtn_DangGiaoHang.TabStop = true;
            this.rbtn_DangGiaoHang.Text = "Đang Giao Hàng";
            this.rbtn_DangGiaoHang.UseVisualStyleBackColor = true;
            // 
            // rbtn_HoanThanh
            // 
            this.rbtn_HoanThanh.AutoSize = true;
            this.rbtn_HoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_HoanThanh.Location = new System.Drawing.Point(309, 223);
            this.rbtn_HoanThanh.Name = "rbtn_HoanThanh";
            this.rbtn_HoanThanh.Size = new System.Drawing.Size(142, 29);
            this.rbtn_HoanThanh.TabIndex = 3;
            this.rbtn_HoanThanh.TabStop = true;
            this.rbtn_HoanThanh.Text = "Hoàn Thành";
            this.rbtn_HoanThanh.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(258, 285);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(112, 35);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(397, 285);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(112, 35);
            this.btn_Huy.TabIndex = 5;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(233, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thay Đổi Trạng Thái";
            // 
            // frm_TrangThai_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.rbtn_HoanThanh);
            this.Controls.Add(this.rbtn_DangGiaoHang);
            this.Controls.Add(this.rbtn_DaXacNhan);
            this.Name = "frm_TrangThai_Order";
            this.Text = "Thay Đổi Trạng Thái";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.RadioButton rbtn_DaXacNhan;
        internal System.Windows.Forms.RadioButton rbtn_DangGiaoHang;
        internal System.Windows.Forms.RadioButton rbtn_HoanThanh;
    }
}