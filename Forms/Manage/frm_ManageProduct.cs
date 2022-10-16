﻿using FruitApp.Forms.Manage;
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

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            frm_ThongTin_Product f = new frm_ThongTin_Product();
            f.lb_CapNhat.Visible = false;
            f.Owner = this;
            f.tb_TGBQ.Enabled = true;
            f.ShowDialog();
            if (f.ans == 1)
            {
                FruitAppContext ctx = new FruitAppContext();
                TraiCay tc = new TraiCay()
                {
                    MaTraiCay = f.tb_MaTC.Text,
                    MaLoaiTraiCay = ctx.LoaiTraiCays.FirstOrDefault(p => p.TenLoaiTraiCay == f.cb_LoaiTraiCay.Text).MaLoaiTraiCay,
                    TenTraiCay = f.tb_TenTC.Text,
                    ThoiGianBaoQuan = f.tb_TGBQ.Text,
                    DonViTinh = f.tb_DVT.Text,
                    GiaBan = int.Parse(f.tb_GiaBan.Text),
                    GiaMua = int.Parse(f.tb_GiaMua.Text),
                    HinhAnh = f.image,
                    MoTa = f.rtbx_MoTa.Text,
                    SoLuongTonKho = 0,
                };
                ctx.TraiCays.Add(tc);
                ctx.SaveChanges();
                frm_ManageProduct_Load(sender, e);
            }
        }

        private void btn_SuaSanPham_Click(object sender, EventArgs e)
        {
            frm_ThongTin_Product f = new frm_ThongTin_Product();
            f.lb_Them.Visible = false;
            f.Owner = this;
            f.cb_LoaiTraiCay.Enabled = false;
            f.tb_TenTC.Enabled = false;
            f.tb_TGBQ.Enabled = false;
            FruitAppContext ctx = new FruitAppContext();
            TraiCay tc = ctx.TraiCays.FirstOrDefault(p => p.MaTraiCay == SelectedMaTC);
            f.tb_DVT.Text = tc.DonViTinh;
            f.tb_GiaBan.Text = tc.GiaBan.ToString();
            f.tb_GiaMua.Text = tc.GiaMua.ToString();
            f.tb_MaTC.Text = tc.MaTraiCay;
            f.tb_TenTC.Text = tc.TenTraiCay;
            f.tb_TGBQ.Text = tc.ThoiGianBaoQuan;
            f.loadCombobox();
            f.cb_LoaiTraiCay.SelectedItem = tc.LoaiTraiCay.TenLoaiTraiCay;
            f.rtbx_MoTa.Text = tc.MoTa;
            f.image = tc.HinhAnh;
            f.ptr_TraiCay.Image = Image.FromFile(tc.HinhAnh);
            f.ShowDialog();
            if(f.ans == 1)
            {
                tc.MoTa = f.rtbx_MoTa.Text;
                tc.GiaBan = int.Parse(f.tb_GiaBan.Text);
                tc.GiaMua = int.Parse(f.tb_GiaMua.Text);
                tc.HinhAnh = f.image;
                ctx.SaveChanges();
                frm_ManageProduct_Load(sender, e);
            }
        }

        private string SelectedMaTC = "";

        private void dgv_SP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.RowIndex != dgv_SP.RowCount - 1)
            {
                btn_SuaSanPham.Enabled = true;
                FruitAppContext ctx = new FruitAppContext();
                SelectedMaTC = dgv_SP.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else
            {
                btn_SuaSanPham.Enabled = false;
            }
        }
    }
}
