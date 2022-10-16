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
    public partial class frm_ManageSuplier : Form
    {
        public frm_ManageSuplier()
        {
            InitializeComponent();
        }

        private void loadDataGridView()
        {
            dgv_DoiTac.Rows.Clear();
            FruitAppContext ctx = new FruitAppContext();
            List<DoiTac> ldt = ctx.DoiTacs.ToList();
            foreach (var dt in ldt)
            {
                int index = dgv_DoiTac.Rows.Add();
                dgv_DoiTac.Rows[index].Cells[0].Value = dt.MaDoiTac;
                dgv_DoiTac.Rows[index].Cells[1].Value = dt.TenDoiTac;
            }
        }

        private void frm_ManageSuplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frm_MainPage_Admin)this.MdiParent).frm_MainPage_Admin_Load(sender, e);
        }

        private void frm_ManageSuplier_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            btn_Sua.Enabled = false;
            dtpck_ChonNgay.MinDate = new DateTime(2022, 10, 01);
        }

        private string SelectedMaDT = "";

        private void dgv_DoiTac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FruitAppContext ctx = new FruitAppContext();
            if (e.RowIndex != -1 && e.RowIndex != dgv_DoiTac.RowCount - 1)
            {
                DoiTac dt = ctx.DoiTacs.ToList().FirstOrDefault(p => p.MaDoiTac == dgv_DoiTac.Rows[e.RowIndex].Cells[0].Value.ToString());
                tb_MaDoiTac.Text = dt.MaDoiTac;
                SelectedMaDT = dt.MaDoiTac;
                tb_DiaChi.Text = dt.DiaChiDoiTac;
                tb_DienThoai.Text = dt.DienThoai;
                tb_NgayHopTac.Text = dt.NgayHopTac.ToShortDateString();
                tb_TenDoiTac.Text = dt.TenDoiTac;
                if (dt.Fax != null)
                {
                    tb_Fax.Text = dt.Fax;
                }
                else
                {
                    tb_Fax.Text = "";
                }
                if (dt.MaSoThue != null)
                {
                    tb_MaSoThue.Text = dt.MaSoThue;
                }
                else
                {
                    tb_MaSoThue.Text = "";
                }
                if (dt.MoTa != null)
                {
                    rtbx_MoTa.Text = dt.MoTa;
                }
                else
                {
                    rtbx_MoTa.Text = "";
                }
                btn_Sua.Enabled = true;
            }
            else
                btn_Sua.Enabled = false;
        }

        private void An()
        {
            dgv_DoiTac.Enabled = true;
            btn_Them.Enabled = true;
            tb_TenDoiTac.Enabled = false;
            tb_DiaChi.Enabled = false;
            tb_DienThoai.Enabled = false;
            tb_Fax.Enabled = false;
            tb_MaDoiTac.Enabled = false;
            tb_MaSoThue.Enabled = false;
            tb_NgayHopTac.Enabled = false;
            dtpck_ChonNgay.Visible = false;
            btn_Huy.Visible = false;
            btn_Luu.Visible = false;
            rtbx_MoTa.Enabled = false;
        }

        private void Hien()
        {
            dgv_DoiTac.Enabled = false;
            btn_Them.Enabled = false;
            tb_TenDoiTac.Enabled = true;
            tb_DiaChi.Enabled = true;
            tb_DienThoai.Enabled = true;
            tb_Fax.Enabled = true;
            tb_MaDoiTac.Enabled = true;
            tb_MaSoThue.Enabled = true;
            tb_TenDoiTac.Enabled = true;
            dtpck_ChonNgay.Visible = true;
            btn_Huy.Visible = true;
            btn_Luu.Visible = true;
            rtbx_MoTa.Enabled = true;
        }

        private void xoa()
        {
            tb_TenDoiTac.Clear();
            tb_NgayHopTac.Clear();
            tb_DiaChi.Clear();
            tb_DienThoai.Clear();
            tb_Fax.Clear();
            tb_MaDoiTac.Clear();
            tb_MaSoThue.Clear();
            rtbx_MoTa.Clear();
        }

        private int ThemHaySua = 0;

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Hien();
            tb_MaDoiTac.Enabled = false;
            dtpck_ChonNgay.Visible = false;
            tb_TenDoiTac.Enabled = false;
            ThemHaySua = -1;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Hien();
            xoa();
            ThemHaySua = 1;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string s = "Các thông tin sau không được để trống:\n";
                bool flag = false;
                if (tb_MaDoiTac.Text == "")
                {
                    s = s + "Mã đối tác\n";
                    flag = true;
                }
                if (tb_TenDoiTac.Text == "")
                {
                    s = s + "Tên đối tác\n";
                    flag = true;
                }
                if (tb_DiaChi.Text == "")
                {
                    s = s + "Địa chỉ\n";
                    flag = true;
                }
                if (tb_DienThoai.Text == "")
                {
                    s = s + "Điện thoại\n";
                    flag = true;
                }
                if (tb_NgayHopTac.Text == "")
                {
                    s = s + "Ngày hợp tác";
                }
                if (flag == true)
                {
                    throw new Exception(s);
                }
                else
                {
                    FruitAppContext ctx = new FruitAppContext();
                    if(ThemHaySua == 1)
                    {
                        DoiTac dt = new DoiTac() {
                            MaDoiTac = tb_MaDoiTac.Text,
                            TenDoiTac = tb_TenDoiTac.Text,
                            DiaChiDoiTac = tb_DiaChi.Text,
                            DienThoai = tb_DienThoai.Text,
                            Fax = tb_Fax.Text,
                            MaSoThue = tb_MaSoThue.Text,
                            NgayHopTac = dtpck_ChonNgay.Value,
                            MoTa = rtbx_MoTa.Text
                        };
                        ctx.DoiTacs.Add(dt);
                        ctx.SaveChanges();
                        MessageBox.Show("Thêm đối tác mới thành công", "Thông Báo");
                    }
                    else
                    {
                        DoiTac dt = ctx.DoiTacs.FirstOrDefault(p => p.MaDoiTac == SelectedMaDT);
                        dt.MaDoiTac = tb_MaDoiTac.Text;
                        dt.TenDoiTac = tb_TenDoiTac.Text;
                        dt.DiaChiDoiTac = tb_DiaChi.Text;
                        dt.DienThoai = tb_DienThoai.Text;
                        dt.Fax = tb_Fax.Text;
                        dt.MaSoThue = tb_MaSoThue.Text;
                        dt.NgayHopTac = dtpck_ChonNgay.Value;
                        dt.MoTa = rtbx_MoTa.Text;
                        ctx.SaveChanges();
                        MessageBox.Show("Thay đổi thông tin đối tác thành công", "Thông Báo");
                    }
                    An();
                    frm_ManageSuplier_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            An();
        }

        private void dtpck_ChonNgay_ValueChanged(object sender, EventArgs e)
        {
            tb_NgayHopTac.Text = dtpck_ChonNgay.Value.ToShortDateString();
        }
    }
}
