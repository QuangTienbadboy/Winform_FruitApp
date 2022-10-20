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
            frm_RePassWord f = new frm_RePassWord();
            f.Owner = this;
            f.Show();
            this.Hide();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            load();
        }
        internal string matk;
        public void load()
        {
           
            TaiKhoanKhachHang tk = ctx.TaiKhoanKhachHangs.FirstOrDefault(p => p.MaKhachHang == matk);
                txtHoTen.Text = tk.KhachHang.HoTen;
                txtDienThoai.Text = tk.KhachHang.DienThoai;
                txtDiaChi.Text = tk.KhachHang.DiaChi;
                txtEmail.Text =  tk.Email;
                txtNgaySinh.Text = tk.KhachHang.NgaySinh.ToString();
        }
        private void Thông_tin_cá_nhân_Load(object sender, EventArgs e)
        {
            //load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_ReInformation f = new frm_ReInformation();
            f.matk = matk;
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }
    }
}
