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

    public partial class frm_CTProDucts : Form
    {
        FruitAppContext ctx = new FruitAppContext();
        public frm_CTProDucts()
        {
            InitializeComponent();
        }
        internal string layMa;
        private void CTSanPham_Load(object sender, EventArgs e)
        {
            
            TraiCay item = ctx.TraiCays.FirstOrDefault(p=>p.MaTraiCay == layMa);
                pictureBox1.Image = Image.FromFile(item.HinhAnh);
                txtGia.Text = item.GiaBan.ToString();
                txtMoTa.Text = item.MoTa;
                txtSoLuong.Text = item.SoLuongTonKho.ToString();
                txtTenSP.Text = item.TenTraiCay;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }
    }
}
