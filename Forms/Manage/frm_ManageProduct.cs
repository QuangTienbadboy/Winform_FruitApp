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

namespace FruitApp
{
    public partial class frm_ManageProduct : Form
    {
        public frm_ManageProduct()
        {
            InitializeComponent();
        }

        private void loadDataGridView(string TenLoaiTraiCay, string MaTraiCay, string TenTraiCay)
        {
            dgv_SP.Rows.Clear();
            FruitAppContext ctx = new FruitAppContext();
            List<TraiCay> ltc = new List<TraiCay>();
            if (TenLoaiTraiCay != "Tất cả") 
            {
                ltc = ctx.TraiCays.Where(p => p.LoaiTraiCay.TenLoaiTraiCay == TenLoaiTraiCay).ToList();
            }
            else
            {
                ltc = ctx.TraiCays.ToList();
            }
            ltc = ltc.Where(p => p.MaTraiCay.ToLower().Contains(MaTraiCay.ToLower())).ToList();
            ltc = ltc.Where(p => p.TenTraiCay.ToLower().Contains(TenTraiCay.ToLower())).ToList();
            foreach (var tc in ltc)
            {
                int index = dgv_SP.Rows.Add();
                dgv_SP.Rows[index].Cells[0].Value = tc.MaTraiCay;
                dgv_SP.Rows[index].Cells[1].Value = tc.TenTraiCay;
                dgv_SP.Rows[index].Cells[2].Value = tc.LoaiTraiCay.TenLoaiTraiCay;
                dgv_SP.Rows[index].Cells[3].Value = tc.DonViTinh;
                dgv_SP.Rows[index].Cells[4].Value = tc.GiaBan;
                dgv_SP.Rows[index].Cells[5].Value = tc.GiaMua;
                dgv_SP.Rows[index].Cells[6].Value = tc.SoLuongTonKho;
            }
        }

        private void loadCombobox()
        {
            cb_LoaiTraiCay.Items.Add("Táo");
            cb_LoaiTraiCay.Items.Add("Cam");
            cb_LoaiTraiCay.Items.Add("Chuối");
            cb_LoaiTraiCay.Items.Add("Nho");
            cb_LoaiTraiCay.Items.Add("Dưa");
            cb_LoaiTraiCay.Items.Add("Tất cả");
            cb_LoaiTraiCay.SelectedItem = "Tất cả";
        }

        private void frm_ManageProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frm_MainPage_Admin)this.MdiParent).frm_MainPage_Admin_Load(sender, e);
        }

        private void frm_ManageProduct_Load(object sender, EventArgs e)
        {
            loadDataGridView(cb_LoaiTraiCay.Text, tb_MaTraiCay.Text, tb_TenTraiCay.Text);
            loadCombobox();
        }

        private void cb_LoaiTraiCay_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataGridView(cb_LoaiTraiCay.Text, tb_MaTraiCay.Text, tb_TenTraiCay.Text);
        }
    }
}
