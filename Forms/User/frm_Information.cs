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
namespace baithi
{
    
    public partial class frm_Information : Form
    {
        FruitAppContext ctx = new FruitAppContext();
        public frm_Information()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            load();
        }
        public void load()
        {
           
            List<TaiKhoanKhachHang> khachHangs = ctx.TaiKhoanKhachHangs.ToList();
            foreach (var item in khachHangs)
            {
                txtHoTen.Text = item.KhachHang.HoTen;
                txtDienThoai.Text = item.KhachHang.DienThoai;
                txtDiaChi.Text = item.KhachHang.DiaChi;
                txtEmail.Text =  item.Email;
                txtNgaySinh.Text = item.KhachHang.NgaySinh.ToString();


           
            }
        }
        private void Thông_tin_cá_nhân_Load(object sender, EventArgs e)
        {
            //load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frm_ReInformation().Show();
            this.Hide();
        }
    }
}
