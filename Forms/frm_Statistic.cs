using FruitApp.Forms;
using FruitApp.Models;
using Microsoft.Reporting.WinForms;
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
    public partial class frm_Statistic : Form
    {
        public frm_Statistic()
        {
            InitializeComponent();
        }

        private void loadComboBox()
        {
            FruitAppContext ctx = new FruitAppContext();
            List<DonHang> ldh = ctx.DonHangs.ToList();
            cb_ChiTietDonHang.DataSource = ldh;
            cb_ChiTietDonHang.DisplayMember = "MaDonHang";
            cb_ChiTietDonHang.SelectedIndex = ldh.Count - 1;
        }

        private void frm_Statistic_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frm_MainPage_Admin)this.MdiParent).frm_MainPage_Admin_Load(sender, e);
        }

        private void frm_Statistic_Load(object sender, EventArgs e)
        {
            cb_XemTheoNgay.Items.Add("Theo Ngày");
            cb_XemTheoNgay.Items.Add("Theo Các Ngày");
            cb_XemTheoNgayDH.Items.Add("Theo Ngày");
            cb_XemTheoNgayDH.Items.Add("Theo Các Ngày");
            dtpck_1Ngay.MinDate = new DateTime(2022, 10, 01);
            dtpck_1Ngay.MaxDate = DateTime.Now;
            dtpck_TuNgay.MinDate = new DateTime(2022, 10, 01);
            dtpck_TuNgay.MaxDate = DateTime.Now;
            dtpck_DenNgay.MinDate = new DateTime(2022, 10, 01);
            dtpck_DenNgay.MaxDate = DateTime.Now;
            dtpck_1NgayDH.MinDate = new DateTime(2022, 10, 01);
            dtpck_1NgayDH.MaxDate = DateTime.Now;
            dtpck_TuNgayDH.MinDate = new DateTime(2022, 10, 01);
            dtpck_TuNgayDH.MaxDate = DateTime.Now;
            dtpck_DenNgayDH.MinDate = new DateTime(2022, 10, 01);
            dtpck_DenNgayDH.MaxDate = DateTime.Now;
            dtpck_TuNgayDT.MinDate = new DateTime(2022, 10, 01);
            dtpck_TuNgayDT.MaxDate = DateTime.Now;
            dtpck_DenNgayDT.MinDate = new DateTime(2022, 10, 01);
            dtpck_DenNgayDT.MaxDate = DateTime.Now;
            dtpck_TuNgayDT.Value = new DateTime(2022, 10, 01);
            tb_TuNgayDT.Clear();
            resetDTPCKTC();
            resetDTPCKDH();
            loadComboBox();
            dtpck_DoanhThuTrongNgay.MinDate = new DateTime(2022, 10, 01);
            dtpck_DoanhThuTrongNgay.MaxDate = DateTime.Now;
            dtpck_DonHangTrongNgay.MinDate = new DateTime(2022, 10, 01);
            dtpck_DonHangTrongNgay.MaxDate = DateTime.Now;
            dtpck_TraiCayTrongNgay.MinDate = new DateTime(2022, 10, 01);
            dtpck_TraiCayTrongNgay.MaxDate = DateTime.Now;
            tb_DoanhThuTrongNgay.Clear();
            tb_TraiCayTrongNgay.Clear();
            tb_DonHangTrongNgay.Clear();
        }

        private void resetDTPCKTC()
        {
            dtpck_DenNgay.Value = new DateTime(2022, 10, 17);
            dtpck_TuNgay.Value = new DateTime(2022, 10, 01);
            tb_DenNgay.Clear();
            tb_TuNgay.Clear();
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points.Clear();
        }

        private void resetDTPCKDH()
        {
            dtpck_DenNgayDH.Value = new DateTime(2022, 10, 17);
            dtpck_TuNgayDH.Value = new DateTime(2022, 10, 01);
            tb_DenNgayDH.Clear();
            tb_TuNgayDH.Clear();
            chart_DonHangTheoTrangThai.Series["Đơn Hàng"].Points.Clear();
        }

        private void cb_XemTheoNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_XemTheoNgay.Text == "Theo Ngày")
            {
                lb_1Ngay.Visible = true;
                lb_TuNgay.Visible = false;
                lb_DenNgay.Visible = false;
                dtpck_1Ngay.Visible = true;
                dtpck_DenNgay.Visible = false;
                dtpck_TuNgay.Visible = false;
                tb_1Ngay.Visible = true;
                tb_DenNgay.Visible = false;
                tb_TuNgay.Visible = false;
                resetDTPCKTC();
            }
            else
            {
                lb_1Ngay.Visible = false;
                lb_TuNgay.Visible = true;
                lb_DenNgay.Visible = true;
                dtpck_1Ngay.Visible = false;
                dtpck_DenNgay.Visible = true;
                dtpck_TuNgay.Visible = true;
                tb_1Ngay.Visible = false;
                tb_DenNgay.Visible = true;
                tb_TuNgay.Visible = true;
                tb_1Ngay.Clear();
            }
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points.Clear();
        }

        private void dtpck_DenNgay_ValueChanged(object sender, EventArgs e)
        {
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points.Clear();
            tb_DenNgay.Text = dtpck_DenNgay.Value.ToString("dd-MM-yyyy");
            dtpck_TuNgay.MaxDate = new DateTime(dtpck_DenNgay.Value.Year, dtpck_DenNgay.Value.Month, dtpck_DenNgay.Value.Day);
            if(tb_TuNgay.Text != "")
            {
                int dem1 = 0, dem2 = 0, dem3 = 0, dem4 = 0, dem5 = 0;
                demTraiCay(ref dem1,ref dem2,ref dem3,ref dem4,ref dem5);
                veChartTC(dem1, dem2, dem3, dem4, dem5);
            }
        }

        private void dtpck_TuNgay_ValueChanged(object sender, EventArgs e)
        {
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points.Clear();
            tb_TuNgay.Text = dtpck_TuNgay.Value.ToString("dd-MM-yyyy");
            dtpck_DenNgay.MinDate = new DateTime(dtpck_TuNgay.Value.Year, dtpck_TuNgay.Value.Month, dtpck_TuNgay.Value.Day);
            if (tb_DenNgay.Text != "")
            {
                int dem1 = 0, dem2 = 0, dem3 = 0, dem4 = 0, dem5 = 0;
                demTraiCay(ref dem1,ref dem2,ref dem3,ref dem4,ref dem5);
                veChartTC(dem1, dem2, dem3, dem4, dem5);
            }
        }

        private void demTraiCay(ref int dem1,ref int dem2,ref int dem3,ref int dem4,ref int dem5)
        {
            FruitAppContext ctx = new FruitAppContext();
            List<ChiTietDonHang> lct = ctx.ChiTietDonHangs.Where(p =>
            p.DonHang.NgayDatHang.Year <= dtpck_DenNgay.Value.Year
            &&
            p.DonHang.NgayDatHang.Month <= dtpck_DenNgay.Value.Month
            &&
            p.DonHang.NgayDatHang.Day <= dtpck_DenNgay.Value.Day
            &&
            p.DonHang.NgayDatHang.Year >= dtpck_TuNgay.Value.Year
            &&
            p.DonHang.NgayDatHang.Month >= dtpck_TuNgay.Value.Month
            &&
            p.DonHang.NgayDatHang.Day >= dtpck_TuNgay.Value.Day
            &&
            p.DonHang.TrangThai == "Hoàn Thành"
                ).ToList();
            foreach (var ct in lct)
            {
                if (ct.TraiCay.LoaiTraiCay.MaLoaiTraiCay == "LTC001")
                    dem1 = dem1 + ct.SoLuong;
                if (ct.TraiCay.LoaiTraiCay.MaLoaiTraiCay == "LTC002")
                    dem2 = dem2 + ct.SoLuong;
                if (ct.TraiCay.LoaiTraiCay.MaLoaiTraiCay == "LTC003")
                    dem3 = dem3 + ct.SoLuong;
                if (ct.TraiCay.LoaiTraiCay.MaLoaiTraiCay == "LTC004")
                    dem4 = dem4 + ct.SoLuong;
                if (ct.TraiCay.LoaiTraiCay.MaLoaiTraiCay == "LTC005")
                    dem5 = dem5 + ct.SoLuong;
            }
        }

        private void demDonHang(ref int dem1, ref int dem2, ref int dem3, ref int dem4, ref int dem5)
        {
            FruitAppContext ctx = new FruitAppContext();
            List<DonHang> ldh = ctx.DonHangs.Where(p =>
            p.NgayDatHang.Year <= dtpck_DenNgayDH.Value.Year
            &&
            p.NgayDatHang.Month <= dtpck_DenNgayDH.Value.Month
            &&
            p.NgayDatHang.Day <= dtpck_DenNgayDH.Value.Day
            &&
            p.NgayDatHang.Year >= dtpck_TuNgayDH.Value.Year
            &&
            p.NgayDatHang.Month >= dtpck_TuNgayDH.Value.Month
            &&
            p.NgayDatHang.Day >= dtpck_TuNgayDH.Value.Day
                ).ToList();
            foreach (var dh in ldh)
            {
                if (dh.TrangThai == "Chờ Xác Nhận")
                    dem1++;
                if (dh.TrangThai == "Đã Xác Nhận")
                    dem2++;
                if (dh.TrangThai == "Đang Giao Hàng")
                    dem3++;
                if (dh.TrangThai == "Hoàn Thành")
                    dem4++;
                if (dh.TrangThai == "Đã Hủy")
                    dem5++;
            }
        }
        
        private void veChartTC(int dem1, int dem2, int dem3, int dem4, int dem5)
        {
            //
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points.Add(dem1);
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[0].AxisLabel = "Táo";
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[0].LegendText = "Táo";
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[0].Label = dem1.ToString();
            //
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points.Add(dem2);
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[1].Color = Color.Orange;
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[1].AxisLabel = "Cam";
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[1].LegendText = "Cam";
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[1].Label = dem2.ToString();
            //
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points.Add(dem3);
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[2].Color = Color.Yellow;
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[2].AxisLabel = "Chuối";
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[2].LegendText = "Chuối";
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[2].Label = dem3.ToString();
            //
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points.Add(dem4);
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[3].Color = Color.Purple;
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[3].AxisLabel = "Nho";
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[3].LegendText = "Nho";
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[3].Label = dem4.ToString();
            //
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points.Add(dem5);
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[4].Color = Color.Lime;
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[4].AxisLabel = "Dưa";
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[4].LegendText = "Dưa";
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points[4].Label = dem5.ToString();
        }

        private void veChartDH(int dem1, int dem2, int dem3, int dem4, int dem5)
        {
            chart_DonHangTheoTrangThai.Series["Đơn Hàng"].IsValueShownAsLabel = true;
            if (dem1 != 0)
                chart_DonHangTheoTrangThai.Series["Đơn Hàng"].Points.AddXY("Chờ Xác Nhận", dem1);
            if (dem2 != 0)
                chart_DonHangTheoTrangThai.Series["Đơn Hàng"].Points.AddXY("Đã Xác Nhận", dem2);
            if (dem3 != 0)
                chart_DonHangTheoTrangThai.Series["Đơn Hàng"].Points.AddXY("Đang Giao Hàng", dem3);
            if (dem4 != 0)
                chart_DonHangTheoTrangThai.Series["Đơn Hàng"].Points.AddXY("Hoàn Thành", dem4);
            if (dem5 != 0)
                chart_DonHangTheoTrangThai.Series["Đơn Hàng"].Points.AddXY("Đã Hủy", dem5);
        }

        private void dtpck_1Ngay_ValueChanged(object sender, EventArgs e)
        {
            chart_LoaiTraiCayBanDuoc.Series["Táo"].Points.Clear();
            tb_1Ngay.Text = dtpck_1Ngay.Value.ToString("dd-MM-yyyy");
            FruitAppContext ctx = new FruitAppContext();
            List<ChiTietDonHang> lct = ctx.ChiTietDonHangs.Where(p=>
            p.DonHang.NgayDatHang.Year == dtpck_1Ngay.Value.Year 
            &&
            p.DonHang.NgayDatHang.Month == dtpck_1Ngay.Value.Month
            &&
            p.DonHang.NgayDatHang.Day == dtpck_1Ngay.Value.Day
                ).ToList();
            int dem1 = 0, dem2 = 0, dem3 = 0, dem4 = 0, dem5 = 0;
            foreach(var ct in lct)
            {
                if (ct.TraiCay.LoaiTraiCay.MaLoaiTraiCay == "LTC001")
                    dem1 = dem1 + ct.SoLuong;
                if (ct.TraiCay.LoaiTraiCay.MaLoaiTraiCay == "LTC002")
                    dem2 = dem2 + ct.SoLuong;
                if (ct.TraiCay.LoaiTraiCay.MaLoaiTraiCay == "LTC003")
                    dem3 = dem3 + ct.SoLuong;
                if (ct.TraiCay.LoaiTraiCay.MaLoaiTraiCay == "LTC004")
                    dem4 = dem4 + ct.SoLuong;
                if (ct.TraiCay.LoaiTraiCay.MaLoaiTraiCay == "LTC005")
                    dem5 = dem5 + ct.SoLuong;
            }
            veChartTC(dem1, dem2, dem3, dem4, dem5);
        }

        private void dtpck_1NgayDH_ValueChanged(object sender, EventArgs e)
        {
            chart_DonHangTheoTrangThai.Series["Đơn Hàng"].Points.Clear();
            tb_1NgayDH.Text = dtpck_1NgayDH.Value.ToString("dd-MM-yyyy");
            FruitAppContext ctx = new FruitAppContext();
            List<DonHang> ldh = ctx.DonHangs.Where(p =>
            p.NgayDatHang.Year == dtpck_1NgayDH.Value.Year
            &&
            p.NgayDatHang.Month == dtpck_1NgayDH.Value.Month
            &&
            p.NgayDatHang.Day == dtpck_1NgayDH.Value.Day
                ).ToList();
            int dem1 = 0, dem2 = 0, dem3 = 0, dem4 = 0, dem5 = 0;
            foreach (var dh in ldh)
            {
                if (dh.TrangThai == "Chờ Xác Nhận")
                    dem1++;
                if (dh.TrangThai == "Đã Xác Nhận")
                    dem2++;
                if (dh.TrangThai == "Đang Giao Hàng")
                    dem3++;
                if (dh.TrangThai == "Hoàn Thành")
                    dem4++;
                if (dh.TrangThai == "Đã Hủy")
                    dem5++;
            }
            veChartDH(dem1, dem2, dem3, dem4, dem5);
        }

        private void dtpck_DenNgayDH_ValueChanged(object sender, EventArgs e)
        {
            chart_DonHangTheoTrangThai.Series["Đơn Hàng"].Points.Clear();
            tb_DenNgayDH.Text = dtpck_DenNgayDH.Value.ToString("dd-MM-yyyy");
            dtpck_TuNgayDH.MaxDate = new DateTime(dtpck_DenNgayDH.Value.Year, dtpck_DenNgayDH.Value.Month, dtpck_DenNgayDH.Value.Day);
            if (tb_TuNgayDH.Text != "")
            {
                int dem1 = 0, dem2 = 0, dem3 = 0, dem4 = 0, dem5 = 0;
                demDonHang(ref dem1, ref dem2, ref dem3, ref dem4, ref dem5);
                veChartDH(dem1, dem2, dem3, dem4, dem5);
            }
        }

        private void cb_XemTheoNgayDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_XemTheoNgayDH.Text == "Theo Ngày")
            {
                lb_1NgayDH.Visible = true;
                lb_TuNgayDH.Visible = false;
                lb_DenNgayDH.Visible = false;
                dtpck_1NgayDH.Visible = true;
                dtpck_DenNgayDH.Visible = false;
                dtpck_TuNgayDH.Visible = false;
                tb_1NgayDH.Visible = true;
                tb_DenNgayDH.Visible = false;
                tb_TuNgayDH.Visible = false;
                resetDTPCKDH();
            }
            else
            {
                lb_1NgayDH.Visible = false;
                lb_TuNgayDH.Visible = true;
                lb_DenNgayDH.Visible = true;
                dtpck_1NgayDH.Visible = false;
                dtpck_DenNgayDH.Visible = true;
                dtpck_TuNgayDH.Visible = true;
                tb_1NgayDH.Visible = false;
                tb_DenNgayDH.Visible = true;
                tb_TuNgayDH.Visible = true;
                tb_1NgayDH.Clear();
            }
            chart_DonHangTheoTrangThai.Series["Đơn Hàng"].Points.Clear();
        }

        private void dtpck_TuNgayDH_ValueChanged(object sender, EventArgs e)
        {
            chart_DonHangTheoTrangThai.Series["Đơn Hàng"].Points.Clear();
            tb_TuNgayDH.Text = dtpck_TuNgayDH.Value.ToString("dd-MM-yyyy");
            dtpck_DenNgayDH.MinDate = new DateTime(dtpck_TuNgayDH.Value.Year, dtpck_TuNgayDH.Value.Month, dtpck_TuNgayDH.Value.Day);
            if (tb_DenNgayDH.Text != "")
            {
                int dem1 = 0, dem2 = 0, dem3 = 0, dem4 = 0, dem5 = 0;
                demDonHang(ref dem1, ref dem2, ref dem3, ref dem4, ref dem5);
                veChartDH(dem1, dem2, dem3, dem4, dem5);
            }
        }

        private void dtpck_TuNgayDT_ValueChanged(object sender, EventArgs e)
        {
            chart_DoanhThu.Series["Thu Nhập"].Points.Clear();
            tb_TuNgayDT.Text = dtpck_TuNgayDT.Value.ToString("dd-MM-yyyy");
            dtpck_DenNgayDT.MinDate = new DateTime(dtpck_TuNgayDT.Value.Year, dtpck_TuNgayDT.Value.Month, dtpck_TuNgayDT.Value.Day);
        }

        private void dtpck_DenNgayDT_ValueChanged(object sender, EventArgs e)
        {
            chart_DoanhThu.Series["Thu Nhập"].Points.Clear();
            tb_DenNgayDT.Text = dtpck_DenNgayDT.Value.ToString("dd-MM-yyyy");
            dtpck_TuNgayDT.MaxDate = new DateTime(dtpck_DenNgayDT.Value.Year, dtpck_DenNgayDT.Value.Month, dtpck_DenNgayDT.Value.Day);
        }

        private void tb_TuNgayDT_TextChanged(object sender, EventArgs e)
        {
            if (tb_DenNgayDT.Text != "")
            {
                FruitAppContext ctx = new FruitAppContext();
                List<ChiTietDonHang> lct = ctx.ChiTietDonHangs.Where(p =>
                p.DonHang.NgayDatHang.Year <= dtpck_DenNgayDT.Value.Year
                &&
                p.DonHang.NgayDatHang.Month <= dtpck_DenNgayDT.Value.Month
                &&
                p.DonHang.NgayDatHang.Day <= dtpck_DenNgayDT.Value.Day
                &&
                p.DonHang.NgayDatHang.Year >= dtpck_TuNgayDT.Value.Year
                &&
                p.DonHang.NgayDatHang.Month >= dtpck_TuNgayDT.Value.Month
                &&
                p.DonHang.NgayDatHang.Day >= dtpck_TuNgayDT.Value.Day
                &&
                p.DonHang.TrangThai == "Hoàn Thành"
                ).ToList();
                long sum = 0;
                int dem = 0;
                if (lct.Count > 0)
                {
                    DateTime currentDays = new DateTime(lct[0].DonHang.NgayDatHang.Year,
                        lct[0].DonHang.NgayDatHang.Month, lct[0].DonHang.NgayDatHang.Day);
                    string currentDay = currentDays.ToShortDateString();
                    foreach (var ct in lct)
                    {
                        if (ct.DonHang.NgayDatHang.ToShortDateString() == currentDay)
                        {
                            sum += ct.TraiCay.GiaBan * ct.SoLuong - ct.TraiCay.GiaMua * ct.SoLuong;
                        }
                        else
                        {
                            dem++;
                            chart_DoanhThu.Series["Thu Nhập"].Points.AddXY(currentDays.ToString("dd-MM-yyyy"), sum);
                            sum = ct.TraiCay.GiaBan * ct.SoLuong - ct.TraiCay.GiaMua * ct.SoLuong;
                            currentDays = new DateTime(ct.DonHang.NgayDatHang.Year,
                                ct.DonHang.NgayDatHang.Month, ct.DonHang.NgayDatHang.Day);
                            currentDay = currentDays.ToShortDateString();
                        }
                        if (dem > 0 && ct.MaDonHang == lct[lct.Count - 1].MaDonHang && ct.MaTraiCay == lct[lct.Count - 1].MaTraiCay)
                        {
                            chart_DoanhThu.Series["Thu Nhập"].Points.AddXY(currentDays.ToString("dd-MM-yyyy"), sum);
                        }
                    }
                }
            }
        }

        private void tb_DenNgayDT_TextChanged(object sender, EventArgs e)
        {
            if (tb_TuNgayDT.Text != "")
            {
                FruitAppContext ctx = new FruitAppContext();
                List<ChiTietDonHang> lct = ctx.ChiTietDonHangs.Where(p =>
                p.DonHang.NgayDatHang.Year <= dtpck_DenNgayDT.Value.Year
                &&
                p.DonHang.NgayDatHang.Month <= dtpck_DenNgayDT.Value.Month
                &&
                p.DonHang.NgayDatHang.Day <= dtpck_DenNgayDT.Value.Day
                &&
                p.DonHang.NgayDatHang.Year >= dtpck_TuNgayDT.Value.Year
                &&
                p.DonHang.NgayDatHang.Month >= dtpck_TuNgayDT.Value.Month
                &&
                p.DonHang.NgayDatHang.Day >= dtpck_TuNgayDT.Value.Day
                &&
                p.DonHang.TrangThai == "Hoàn Thành"
                ).ToList();
                long sum = 0;
                int dem = 0;
                if (lct.Count > 0)
                {
                    DateTime currentDays = new DateTime(lct[0].DonHang.NgayDatHang.Year,
                        lct[0].DonHang.NgayDatHang.Month, lct[0].DonHang.NgayDatHang.Day);
                    string currentDay = currentDays.ToShortDateString();
                    foreach (var ct in lct)
                    {
                        if (ct.DonHang.NgayDatHang.ToShortDateString() == currentDay)
                        {
                            sum += ct.TraiCay.GiaBan * ct.SoLuong - ct.TraiCay.GiaMua * ct.SoLuong;
                        }
                        else
                        {
                            dem++;
                            chart_DoanhThu.Series["Thu Nhập"].Points.AddXY(currentDays.ToString("dd-MM-yyyy"), sum);
                            sum = ct.TraiCay.GiaBan * ct.SoLuong - ct.TraiCay.GiaMua * ct.SoLuong;
                            currentDays = new DateTime(ct.DonHang.NgayDatHang.Year,
                                ct.DonHang.NgayDatHang.Month, ct.DonHang.NgayDatHang.Day);
                            currentDay = currentDays.ToShortDateString();
                        }
                        if (dem > 0 && ct.MaDonHang == lct[lct.Count - 1].MaDonHang && ct.MaTraiCay == lct[lct.Count - 1].MaTraiCay)
                        {
                            chart_DoanhThu.Series["Thu Nhập"].Points.AddXY(currentDays.ToString("dd-MM-yyyy"), sum);
                        }
                    }
                }
            }
        }

        private void btn_Xuat1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_DonHangTrongNgay.Text == "")
                    throw new Exception("Vui lòng chọn ngày muốn xem");
                else {
                    FruitAppContext ctx = new FruitAppContext();
                    List<DonHang> ldh = ctx.DonHangs.Where(
                        p=>p.NgayDatHang.Year == dtpck_DonHangTrongNgay.Value.Year
                        && p.NgayDatHang.Month == dtpck_DonHangTrongNgay.Value.Month
                        && p.NgayDatHang.Day == dtpck_DonHangTrongNgay.Value.Day
                        ).ToList();
                    if(ldh.Count > 0)
                    {
                        frm_Report f = new frm_Report();
                        f.Owner = this;
                        ReportParameter param = new ReportParameter("NgayDatHang", tb_DonHangTrongNgay.Text);
                        f.reportViewer1.LocalReport.ReportPath = "../../Report1.rdlc";
                        f.reportViewer1.LocalReport.SetParameters(param);
                        var reportDataSource = new ReportDataSource("DSDonHang", ldh);
                        f.reportViewer1.LocalReport.DataSources.Clear();
                        f.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                        f.ShowDialog();
                    }
                    else
                    {
                        throw new Exception("Ngày này không có đơn hàng");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void btn_Xuat2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_TraiCayTrongNgay.Text == "")
                    throw new Exception("Vui lòng chọn ngày muốn xem");
                else
                {
                    FruitAppContext ctx = new FruitAppContext();
                    List<ChiTietDonHang> ldh = ctx.ChiTietDonHangs.Where(
                        p => p.DonHang.NgayDatHang.Year == dtpck_TraiCayTrongNgay.Value.Year
                        && p.DonHang.NgayDatHang.Month == dtpck_TraiCayTrongNgay.Value.Month
                        && p.DonHang.NgayDatHang.Day == dtpck_TraiCayTrongNgay.Value.Day
                        && p.DonHang.TrangThai == "Hoàn Thành"
                        ).ToList();
                    if (ldh.Count > 0)
                    {
                        List<TraiCayBanTrongNgay> ltctn = new List<TraiCayBanTrongNgay>();
                        List<TraiCay> ltc = ctx.TraiCays.ToList();
                        foreach(var tc in ltc)
                        {
                            int sum = 0;
                            foreach(var ct in ldh){
                                if (tc.MaTraiCay == ct.MaTraiCay)
                                    sum += ct.SoLuong;
                            }
                            if(sum != 0)
                            {
                                TraiCayBanTrongNgay report = new TraiCayBanTrongNgay();
                                report.TenTraiCay = tc.TenTraiCay;
                                report.SoLuong = sum;
                                ltctn.Add(report);
                            }
                        }
                        frm_Report f = new frm_Report();
                        f.Owner = this;
                        ReportParameter param = new ReportParameter("Ngay", tb_TraiCayTrongNgay.Text);
                        f.reportViewer1.LocalReport.ReportPath = "../../Report2.rdlc";
                        f.reportViewer1.LocalReport.SetParameters(param);
                        var reportDataSource = new ReportDataSource("TraiCayDS", ltctn);
                        f.reportViewer1.LocalReport.DataSources.Clear();
                        f.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                        f.ShowDialog();
                    }
                    else
                    {
                        throw new Exception("Ngày này không bán được trái cây");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void btn_Xuat3_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_ChiTietDonHang.Text == "")
                    throw new Exception("Vui lòng chọn đơn hàng");
                else
                {
                    FruitAppContext ctx = new FruitAppContext();
                    List<ChiTietDonHang> ldh = ctx.ChiTietDonHangs.Where(
                        p=>p.MaDonHang == cb_ChiTietDonHang.Text
                        ).ToList();
                    if (ldh.Count > 0)
                    {
                        List<ChiTietDonHangReport> lct = new List<ChiTietDonHangReport>();
                        foreach(var ct in ldh)
                        {
                            ChiTietDonHangReport report = new ChiTietDonHangReport();
                            report.MaDonHang = ct.MaDonHang;
                            report.TenTraiCay = ct.TraiCay.TenTraiCay;
                            report.SoLuong = ct.SoLuong;
                            report.GiaBan = ct.GiaBan;
                            lct.Add(report);
                        }
                        frm_Report f = new frm_Report();
                        f.Owner = this;
                        ReportParameter param = new ReportParameter("MaDonHang", cb_ChiTietDonHang.Text);
                        f.reportViewer1.LocalReport.ReportPath = "../../Report3.rdlc";
                        f.reportViewer1.LocalReport.SetParameters(param);
                        var reportDataSource = new ReportDataSource("CTDHDataSet", lct);
                        f.reportViewer1.LocalReport.DataSources.Clear();
                        f.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                        f.ShowDialog();
                    }
                    else
                    {
                        throw new Exception("Ngày này không có đơn hàng");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void btn_Xuat4_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_DoanhThuTrongNgay.Text == "")
                    throw new Exception("Vui lòng chọn ngày muốn xem");
                else
                {
                    FruitAppContext ctx = new FruitAppContext();
                    List<ChiTietDonHang> ldh = ctx.ChiTietDonHangs.Where(
                        p => p.DonHang.NgayDatHang.Year == dtpck_DoanhThuTrongNgay.Value.Year
                        && p.DonHang.NgayDatHang.Month == dtpck_DoanhThuTrongNgay.Value.Month
                        && p.DonHang.NgayDatHang.Day == dtpck_DoanhThuTrongNgay.Value.Day
                        && p.DonHang.TrangThai == "Hoàn Thành"
                        ).ToList();
                    if (ldh.Count > 0)
                    {
                        List<ThuNhap> lct = new List<ThuNhap>();
                        foreach (var ct in ldh)
                        {
                            ThuNhap report = new ThuNhap();
                            report.MaDonHang = ct.MaDonHang;
                            report.TenTraiCay = ct.TraiCay.TenTraiCay;
                            report.SoLuong = ct.SoLuong;
                            report.GiaMua = ct.TraiCay.GiaMua;
                            report.GiaBan = ct.TraiCay.GiaBan;
                            lct.Add(report);
                        }
                        frm_Report f = new frm_Report();
                        f.Owner = this;
                        ReportParameter param = new ReportParameter("Ngay", tb_DoanhThuTrongNgay.Text);
                        f.reportViewer1.LocalReport.ReportPath = "../../Report4.rdlc";
                        f.reportViewer1.LocalReport.SetParameters(param);
                        var reportDataSource = new ReportDataSource("ThuNhapDS", lct);
                        f.reportViewer1.LocalReport.DataSources.Clear();
                        f.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                        f.ShowDialog();
                    }
                    else
                    {
                        throw new Exception("Ngày này không có thu nhập");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void dtpck_DonHangTrongNgay_ValueChanged(object sender, EventArgs e)
        {
            tb_DonHangTrongNgay.Text = dtpck_DonHangTrongNgay.Value.ToString("dd-MM-yyyy");
        }

        private void dtpck_TraiCayTrongNgay_ValueChanged(object sender, EventArgs e)
        {
            tb_TraiCayTrongNgay.Text = dtpck_TraiCayTrongNgay.Value.ToString("dd-MM-yyyy");
        }

        private void dtpck_DoanhThuTrongNgay_ValueChanged(object sender, EventArgs e)
        {
            tb_DoanhThuTrongNgay.Text = dtpck_DoanhThuTrongNgay.Value.ToString("dd-MM-yyyy");
        }
    }
}
