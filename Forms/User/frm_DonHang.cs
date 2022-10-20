using DoAn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frm_Donhang : Form
    {
        SqlConnection con;
        public frm_Donhang()
        {
            InitializeComponent();
        }

        //private void loadDataGridView(string MaTK)
        //{
        //    try
        //    {
        //        DataGw3.Rows.Clear();
        //        FruitAppContext ctx = new FruitAppContext();
        //        List<DonHang> ldh = ctx.DonHangs.Where(p => p.MaTaiKhoan == MaTK);
        //        if (ldh.Count > 0)
        //        {
        //            foreach (var dh in ldh)
        //            {
        //                int index = DataGw3.Rows.Add();
        //                DataGw3.Rows[index].Cells[0].Value = dh.MaDonHang;
        //                string s = "";
        //                List<ChiTietDonHang> lct = ctx.ChiTietDonHangs.Where(p => p.MaDonHang == dh.MaDonHang).ToList();
        //                int d = 0;
        //                foreach (var ct in lct)
        //                {
        //                    if (d != lct.Count - 1)
        //                    {
        //                        s = s + ct.TraiCay.TenTraiCay + " " + ct.TraiCay.DonViTinh + "x" + ct.SoLuong + ", ";
        //                        d++;
        //                    }
        //                    else
        //                        s = s + ct.TraiCay.TenTraiCay + " " + ct.TraiCay.DonViTinh + "x" + ct.SoLuong + ".";
        //                }
        //                da.Rows[index].Cells[1].Value = s;
        //                dgv_Order.Rows[index].Cells[2].Value = dh.ThanhTien;
        //                dgv_Order.Rows[index].Cells[3].Value = dh.NgayDatHang.ToShortDateString();
        //                dgv_Order.Rows[index].Cells[4].Value = dh.TrangThai;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Thông Báo");
        //    }
        //}

        private void ĐơnHàng_Load(object sender, EventArgs e)
        {

        }
    }
}
