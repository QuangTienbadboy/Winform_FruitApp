using FruitApp.Forms.Manage;
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
    public partial class frm_ManageOrder : Form
    {
        public frm_ManageOrder()
        {
            InitializeComponent();
        }

        private void loadDataGridView(string MaDH, string NgayDatHang)
        {
            try
            {
                dgv_Order.Rows.Clear();
                FruitAppContext ctx = new FruitAppContext();
                List<DonHang> ldh = new List<DonHang>();
                if (cbx_ChuaXacNhan.Checked == false && cbx_DaXacNhan.Checked == false
                    && cbx_DangGiaoHang.Checked == false && cbx_HoanThanh.Checked == false
                    && cbx_DaHuy.Checked == false)
                {
                    ldh = ctx.DonHangs.ToList();
                }
                else
                {
                    if (cbx_ChuaXacNhan.Checked == true)
                    {
                        List<DonHang> tam = ctx.DonHangs.Where(p => p.TrangThai == "Chờ Xác Nhận").ToList();
                        ldh = ldh.Union(tam).ToList();
                    }
                    if (cbx_DaXacNhan.Checked == true)
                    {
                        List<DonHang> tam = ctx.DonHangs.Where(p => p.TrangThai == "Đã Xác Nhận").ToList();
                        ldh = ldh.Union(tam).ToList();
                    }
                    if (cbx_DangGiaoHang.Checked == true)
                    {
                        List<DonHang> tam = ctx.DonHangs.Where(p => p.TrangThai == "Đang Giao Hàng").ToList();
                        ldh = ldh.Union(tam).ToList();
                    }
                    if (cbx_HoanThanh.Checked == true)
                    {
                        List<DonHang> tam = ctx.DonHangs.Where(p => p.TrangThai == "Hoàn Thành").ToList();
                        ldh = ldh.Union(tam).ToList();
                    }
                    if (cbx_DaHuy.Checked == true)
                    {
                        List<DonHang> tam = ctx.DonHangs.Where(p => p.TrangThai == "Đã Hủy").ToList();
                        ldh = ldh.Union(tam).ToList();
                    }
                }
                ldh = ldh.Where(p => p.MaDonHang.ToLower().Contains(MaDH.ToLower())).ToList();
                ldh = ldh.Where(p => p.NgayDatHang.ToShortDateString() == NgayDatHang).ToList();
                foreach (var dh in ldh)
                {
                    int index = dgv_Order.Rows.Add();
                    dgv_Order.Rows[index].Cells[0].Value = dh.MaDonHang;
                    dgv_Order.Rows[index].Cells[1].Value = dh.TaiKhoanKhachHang.KhachHang.HoTen;
                    string s = "";
                    List<ChiTietDonHang> lct = ctx.ChiTietDonHangs.Where(p => p.MaDonHang == dh.MaDonHang).ToList();
                    int d = 0;
                    foreach (var ct in lct)
                    {
                        if (d != lct.Count - 1)
                        {
                            s = s + ct.TraiCay.TenTraiCay + " " + ct.TraiCay.DonViTinh + "x" + ct.SoLuong + ", ";
                            d++;
                        }
                        else
                            s = s + ct.TraiCay.TenTraiCay + " " + ct.TraiCay.DonViTinh + "x" + ct.SoLuong + ".";
                    }
                    dgv_Order.Rows[index].Cells[2].Value = s;
                    dgv_Order.Rows[index].Cells[3].Value = dh.ThanhTien;
                    dgv_Order.Rows[index].Cells[4].Value = dh.NgayDatHang.ToShortDateString();
                    dgv_Order.Rows[index].Cells[5].Value = dh.DiaChiGiaoHang;
                    dgv_Order.Rows[index].Cells[6].Value = dh.TrangThai;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void demDonHang()
        {
            int dem1 = 0, dem2 = 0, dem3 = 0, dem4 = 0, dem5 = 0;
            FruitAppContext ctx = new FruitAppContext();
            List<DonHang> ldh = ctx.DonHangs.Where(p=>p.NgayDatHang.Year == DateTime.Now.Year
            && p.NgayDatHang.Month == DateTime.Now.Month && p.NgayDatHang.Day == DateTime.Now.Day).ToList();
            foreach(DonHang d in ldh)
            {
                if (d.TrangThai == "Chờ Xác Nhận")
                    dem1++;
                if (d.TrangThai == "Đã Xác Nhận")
                    dem2++;
                if (d.TrangThai == "Đang Giao Hàng")
                    dem3++;
                if (d.TrangThai == "Hoàn Thành")
                    dem4++;
                if (d.TrangThai == "Đã Hủy")
                    dem5++;
            }
            lb_ChoXacNhan.Text = "Chờ Xác Nhận: " + dem1.ToString();
            lb_DaXacNhan.Text = "Đã Xác Nhận: " + dem2.ToString();
            lb_DangGiaoHang.Text = "Đang Giao Hàng: " + dem3.ToString();
            lb_HoanThanh.Text = "Hoàn Thành: " + dem4.ToString();
            lb_DaHuy.Text = "Đã Hủy: " + dem5.ToString();
        }

        private void frm_ManageOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frm_MainPage_Admin)this.MdiParent).frm_MainPage_Admin_Load(sender, e);
        }

        private void frm_ManageOrder_Load(object sender, EventArgs e)
        {
            loadDataGridView(tb_MaDonHang.Text, dtpck_NgayOrder.Value.ToShortDateString());
            dtpck_NgayOrder.MaxDate = DateTime.Now;
            dtpck_NgayOrder.MinDate = new DateTime(2022, 10, 01);
            btn_ChangeStatus.Enabled = false;
            demDonHang();
        }

        private string SelectedMaDH = "";

        private void dgv_Order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.RowIndex != dgv_Order.RowCount - 1)
                {
                    if (dgv_Order.Rows[e.RowIndex].Cells[6].Value.ToString() != "Đã Hủy" && dgv_Order.Rows[e.RowIndex].Cells[6].Value.ToString() != "Hoàn Thành")
                    {
                        btn_ChangeStatus.Enabled = true;
                        SelectedMaDH = dgv_Order.Rows[e.RowIndex].Cells[0].Value.ToString();
                    }
                    else
                    {
                        btn_ChangeStatus.Enabled = false;
                    }
                }
                else
                {
                    btn_ChangeStatus.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void tb_MaDonHang_TextChanged(object sender, EventArgs e)
        {
            loadDataGridView(tb_MaDonHang.Text, dtpck_NgayOrder.Value.ToShortDateString());
        }

        private void btn_ChangeStatus_Click(object sender, EventArgs e)
        {
            try
            {
                frm_TrangThai_Order f = new frm_TrangThai_Order();
                f.Owner = this;
                FruitAppContext ctx = new FruitAppContext();
                DonHang dh = ctx.DonHangs.FirstOrDefault(p => p.MaDonHang == SelectedMaDH);
                if (dh.TrangThai == "Đang Giao Hàng")
                {
                    f.rbtn_DaXacNhan.Enabled = false;
                }
                f.ShowDialog();
                if (f.ans == 1)
                {
                    if (f.rbtn_DangGiaoHang.Checked == true)
                    {
                        dh.TrangThai = "Đang Giao Hàng";
                    }
                    else
                    {
                        if (f.rbtn_DaXacNhan.Checked == true)
                        {
                            dh.TrangThai = "Đã Xác Nhận";
                        }
                        else
                        {
                            dh.TrangThai = "Hoàn Thành";
                        }
                    }
                    MessageBox.Show("Thay đổi trạng thái đơn hàng thành công", "Thông Báo");
                    ctx.SaveChanges();
                    frm_ManageOrder_Load(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }
    }
}
