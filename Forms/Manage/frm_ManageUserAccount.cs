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
    public partial class frm_ManageUserAccount : Form
    {
        public frm_ManageUserAccount()
        {
            InitializeComponent();
        }

        private void loadDataGridView()
        {
            dgv_KhachHang.Rows.Clear();
            FruitAppContext ctx = new FruitAppContext();
            List<TaiKhoanKhachHang> ltk = ctx.TaiKhoanKhachHangs.ToList();
            foreach(var tk in ltk)
            {
                int index = dgv_KhachHang.Rows.Add();
                dgv_KhachHang.Rows[index].Cells[0].Value = tk.MaKhachHang;
                dgv_KhachHang.Rows[index].Cells[1].Value = tk.KhachHang.HoTen;
            }
        }

        private void frm_ManageUserAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frm_MainPage_Admin)this.MdiParent).frm_MainPage_Admin_Load(sender, e);
        }

        private void frm_ManageUserAccount_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            btn_Sua.Enabled = false;
            dtpck_ChonNgay.MinDate = new DateTime(DateTime.Now.Year - 50, DateTime.Now.Month, DateTime.Now.Day);
            dtpck_ChonNgay.MaxDate = new DateTime(DateTime.Now.Year - 10, DateTime.Now.Month, DateTime.Now.Day);
        }

        private string MaKH = "";

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FruitAppContext ctx = new FruitAppContext();
            if (e.RowIndex != -1 && e.RowIndex != dgv_KhachHang.RowCount - 1)
            {
                TaiKhoanKhachHang user = ctx.TaiKhoanKhachHangs.ToList().FirstOrDefault(p => p.MaKhachHang == dgv_KhachHang.Rows[e.RowIndex].Cells[0].Value.ToString());
                tb_MaKhachHang.Text = user.MaKhachHang;
                MaKH = user.MaKhachHang;
                tb_Email.Text = user.Email;
                tb_TenKhachHang.Text = user.KhachHang.HoTen;
                if(user.KhachHang.NgaySinh != null)
                {
                    DateTime ns = (DateTime)user.KhachHang.NgaySinh;
                    tb_NgaySinh.Text = ns.ToShortDateString();
                    dtpck_ChonNgay.Value = ns;
                }
                else
                {
                    dtpck_ChonNgay.Value = dtpck_ChonNgay.MaxDate;
                    tb_NgaySinh.Text = "";
                }
                if(user.KhachHang.DiaChi != null)
                {
                    tb_DiaChi.Text = user.KhachHang.DiaChi;
                }
                else
                {
                    tb_DiaChi.Text = "";
                }
                if(user.KhachHang.DienThoai != null)
                {
                    tb_DienThoai.Text = user.KhachHang.DienThoai;
                }
                else
                {
                    tb_DienThoai.Text = "";
                }
                btn_Sua.Enabled = true;
            }
            else
                btn_Sua.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            tb_TenKhachHang.Enabled = true;
            tb_DienThoai.Enabled = true;
            tb_DiaChi.Enabled = true;
            dtpck_ChonNgay.Visible = true;
            btn_Huy.Visible = true;
            btn_Luu.Visible = true;
            dgv_KhachHang.Enabled = false;
            tb_NgaySinh.Clear();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            tb_TenKhachHang.Enabled = false;
            tb_DienThoai.Enabled = false;
            tb_DiaChi.Enabled = false;
            dtpck_ChonNgay.Visible = false;
            btn_Huy.Visible = false;
            btn_Luu.Visible = false;
            dgv_KhachHang.Enabled = true;
            tb_NgaySinh.Clear();
        }

        private void dtpck_ChonNgay_ValueChanged(object sender, EventArgs e)
        {
            tb_NgaySinh.Text = dtpck_ChonNgay.Value.ToString("dd-MM-yyyy");
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (tb_TenKhachHang.Text == "")
            {
                MessageBox.Show("Tên khách hàng không được phép để trống", "Thông Báo");
            }
            else
            {
                FruitAppContext ctx = new FruitAppContext();
                TaiKhoanKhachHang user = ctx.TaiKhoanKhachHangs.FirstOrDefault(p => p.MaKhachHang == MaKH);
                user.KhachHang.HoTen = tb_TenKhachHang.Text;
                if (tb_NgaySinh != null)
                    user.KhachHang.NgaySinh = dtpck_ChonNgay.Value;
                user.KhachHang.DiaChi = tb_DiaChi.Text;
                user.KhachHang.DienThoai = tb_DienThoai.Text;
                ctx.SaveChanges();
                MessageBox.Show("Thay đổi thành công", "Thông Báo");
                btn_Huy_Click(sender, e);
                frm_ManageUserAccount_Load(sender, e);
            }
        }
    }
}
