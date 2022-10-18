using FruitApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitApp.Forms.Manage
{
    public partial class frm_ThongTin_Employee : Form
    {
        public frm_ThongTin_Employee()
        {
            InitializeComponent();
        }

        internal void loadCombobox()
        {
            cb_CV.Items.Add("Quản Lý");
            cb_CV.Items.Add("Nhân Viên Kho");
            cb_CV.Items.Add("Nhân Viên Giao Hàng");
            cb_CV.Items.Add("Nhân Viên CSKH");
            cb_CV.SelectedItem = "Nhân Viên Kho";
        }

        private void frm_ThongTin_Employee_Load(object sender, EventArgs e)
        {
            dtpck_NgayBD.MinDate = new DateTime(2022, 10, 01);
            dtpck_NgayBD.MaxDate = DateTime.Now;
            dtpck_NgaySinh.MinDate = new DateTime(DateTime.Now.Year - 65, DateTime.Now.Month, DateTime.Now.Day);
            dtpck_NgaySinh.MaxDate = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);
            tb_NgaySinh.Clear();
            tb_NgayBD.Clear();
        }

        internal int ans = 0;
        internal string image = null;

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string s = "Các thông tin sau không được để trống:";
                bool flag = false;
                if(tb_TenNV.Text == "")
                {
                    s = s + "\nTên nhân viên";
                    flag = true;
                }
                if (tb_NgaySinh.Text == "")
                {
                    s = s + "\nNgày sinh";
                    flag = true;
                }
                if (tb_DiaChi.Text == "")
                {
                    s = s + "\nĐịa chỉ";
                    flag = true;
                }
                if (tb_DienThoai.Text == "")
                {
                    s = s + "\nĐiện thoại";
                    flag = true;
                }
                if (tb_NgayBD.Text == "")
                {
                    s = s + "\nNgày bắt đầu làm việc";
                    flag = true;
                }
                if (flag == true)
                    throw new Exception(s);
                else
                {
                    flag = false;
                    if(tb_DienThoai.Text.Length != 10)
                        flag = true;
                    foreach (char c in tb_DienThoai.Text)
                    {
                        if(c < 48 || c > 57)
                        {
                            flag = true;
                        }
                    }
                    if(flag == true)
                    {
                        throw new Exception("Điện thoại không hợp lệ");
                    }
                    else
                    {
                        ans = 1;
                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            ans = -1;
            this.Close();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "png file (*.png)|*.png|jpg file (*.jpg)|*.jpg" })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        ptr_NV.Image = Image.FromFile(ofd.FileName);
                        image = ofd.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void dtpck_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            tb_NgaySinh.Text = dtpck_NgaySinh.Value.ToString("dd-MM-yyyy");
        }

        private void dtpck_NgayBD_ValueChanged(object sender, EventArgs e)
        {
            tb_NgayBD.Text = dtpck_NgayBD.Value.ToString("dd-MM-yyyy");
        }
    }
}
