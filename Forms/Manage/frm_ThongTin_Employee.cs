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

        private void loadCombobox()
        {
            cb_CV.Items.Add("Quản Lý");
            cb_CV.Items.Add("Nhân Viên Kho");
            cb_CV.Items.Add("Nhân Viên Giao Hàng");
            cb_CV.Items.Add("Nhân Viên CSKH");
            cb_CV.SelectedItem = "Nhân Viên Kho";
        }

        private void frm_ThongTin_Employee_Load(object sender, EventArgs e)
        {
            loadCombobox();
        }

        internal int ans = 0;
        internal string image = "";

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string s = "Các thông tin sau không được để trống:\n";
                bool flag = false;
                if(tb_TenNV.Text == "")
                {
                    s = s + "Tên nhân viên\n";
                    flag = true;
                }
                if (tb_NgaySinh.Text == "")
                {
                    s = s + "Ngày sinh\n";
                    flag = true;
                }
                if (tb_DiaChi.Text == "")
                {
                    s = s + "Địa chỉ\n";
                    flag = true;
                }
                if (tb_DienThoai.Text == "")
                {
                    s = s + "Tên nhân viên\n";
                    flag = true;
                }
                if (tb_NgayBD.Text == "")
                {
                    s = s + "Ngày bắt đầu làm việc\n";
                    flag = true;
                }
                if (flag == true)
                    throw new Exception(s);
                else
                {
                    ans = 1;
                    this.Close();
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
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "png file (*.png)|*.png|jpg file (*.jpg)|*.jpg" })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    ptr_NV.Image = Image.FromFile(ofd.FileName);
                    image = ofd.FileName;
                }
            }
        }
    }
}
