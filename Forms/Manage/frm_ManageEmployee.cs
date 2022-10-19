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

namespace FruitApp.Forms.Manage
{
    public partial class frm_ManageEmployee : Form
    {
        public frm_ManageEmployee()
        {
            InitializeComponent();
        }

        private void loadDataGridView(string ChucVu, string MaNV, string TenNV)
        {
            dgv_NV.Rows.Clear();
            FruitAppContext ctx = new FruitAppContext();
            List<NhanVien> lnv = new List<NhanVien>();
            if (ChucVu != "Tất cả")
            {
                lnv = ctx.NhanViens.Where(p => p.ChucVu == ChucVu).ToList();
            }
            else
            {
                lnv = ctx.NhanViens.ToList();
            }
            lnv = lnv.Where(p => p.MaNhanVien.ToLower().Contains(MaNV.ToLower())).ToList();
            lnv = lnv.Where(p => p.TenNhanVien.ToLower().Contains(TenNV.ToLower())).ToList();
            foreach (var nv in lnv)
            {
                int index = dgv_NV.Rows.Add();
                dgv_NV.Rows[index].Cells[0].Value = nv.MaNhanVien;
                dgv_NV.Rows[index].Cells[1].Value = nv.TenNhanVien;
                dgv_NV.Rows[index].Cells[2].Value = nv.DienThoai;
                dgv_NV.Rows[index].Cells[3].Value = nv.ChucVu;
                dgv_NV.Rows[index].Cells[4].Value = nv.GhiChu;
            }
        }

        private void loadCombobox()
        {
            cb_CVNV.Items.Add("Quản Lý");
            cb_CVNV.Items.Add("Nhân Viên Kho");
            cb_CVNV.Items.Add("Nhân Viên Giao Hàng");
            cb_CVNV.Items.Add("Nhân Viên CSKH");
            cb_CVNV.Items.Add("Tất cả");
            cb_CVNV.SelectedItem = "Tất cả";
        }

        private void hienThi()
        {
            ptr_NV.Visible = true;
            lb_MaNV.Visible = true;
            lb_TenNV.Visible = true;
            lb_NgaySinh.Visible = true;
            lb_NgayVaoLam.Visible = true;
            lb_DienThoai.Visible = true;
            lb_ChucVu.Visible = true;
            lb_DiaChi.Visible = true;
            btn_Sua.Enabled = true;
            dgv_NV.Enabled = true;
        }

        private void An()
        {
            ptr_NV.Visible = false;
            lb_MaNV.Visible = false;
            lb_TenNV.Visible = false;
            lb_NgaySinh.Visible = false;
            lb_NgayVaoLam.Visible = false;
            lb_DienThoai.Visible = false;
            lb_ChucVu.Visible = false;
            lb_DiaChi.Visible = false;
            btn_Sua.Enabled = false;
            dgv_NV.Enabled = false;
        }

        private void frm_ManageEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frm_MainPage_Admin)this.MdiParent).frm_MainPage_Admin_Load(sender, e);
        }

        private void frm_ManageEmployee_Load(object sender, EventArgs e)
        {
            loadDataGridView(cb_CVNV.Text, tb_MNV.Text, tb_TNV.Text);
            loadCombobox();
            An();
            dgv_NV.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private string SelectedMaNV = "";

        private void dgv_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FruitAppContext ctx = new FruitAppContext();
                if (e.RowIndex != -1 && e.RowIndex != dgv_NV.RowCount - 1)
                {
                    btn_Sua.Enabled = true;
                    btn_Xoa.Enabled = true;
                    NhanVien nv = ctx.NhanViens.ToList().FirstOrDefault(p => p.MaNhanVien == dgv_NV.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (nv.HinhAnh != null)
                    {
                        ptr_NV.Image = Image.FromFile(nv.HinhAnh);
                        ptr_NV.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        ptr_NV.Image = null;
                    }
                    lb_TenNV.Text = nv.TenNhanVien;
                    lb_MaNV.Text = "Mã NV: " + nv.MaNhanVien;
                    SelectedMaNV = nv.MaNhanVien;
                    lb_ChucVu.Text = "Chức vụ: " + nv.ChucVu;
                    lb_DiaChi.Text = "Địa chỉ: " + nv.DiaChi;
                    lb_NgaySinh.Text = "Ngày sinh: " + nv.NgaySinh.ToShortDateString();
                    lb_NgayVaoLam.Text = "Ngày bắt đầu: " + nv.NgayBatDauLamViec.ToShortDateString();
                    lb_DienThoai.Text = "Điện thoại: " + nv.DienThoai;
                    hienThi();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void cb_CVNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataGridView(cb_CVNV.Text, tb_MNV.Text, tb_TNV.Text);
        }

        private void tb_MNV_TextChanged(object sender, EventArgs e)
        {
            loadDataGridView(cb_CVNV.Text, tb_MNV.Text, tb_TNV.Text);
        }

        private void tb_TNV_TextChanged(object sender, EventArgs e)
        {
            loadDataGridView(cb_CVNV.Text, tb_MNV.Text, tb_TNV.Text);
        }

        private string newMaNV(string lastMaNV)
        {
            string s = "NV";
            int temp = 1+(int.Parse(lastMaNV[5].ToString()) + int.Parse(lastMaNV[4].ToString())*10
                + int.Parse(lastMaNV[3].ToString())*100 + int.Parse(lastMaNV[2].ToString())*1000);
            if(temp < 1000)
            {
                s += "0";
            }
            else
            {
                s += (temp / 1000).ToString();
                temp = temp%1000;
            }
            if(temp < 100)
            {
                s += "0";
            }
            else
            {
                s += (temp / 100).ToString();
                temp = temp % 100;
            }
            if(temp < 10)
            {
                s += "0";
            }
            else
            {
                s += (temp / 10).ToString();
                temp = temp % 10;
            }
            if(temp == 0)
            {
                s += "0";
            }
            else
            {
                s += temp.ToString();
            }
            return s;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                FruitAppContext ctx = new FruitAppContext();
                frm_ThongTin_Employee f = new frm_ThongTin_Employee();
                f.Owner = this;
                f.lb_CapNhat.Visible = false;
                f.tb_MaNV.Text = newMaNV(ctx.NhanViens.Max(p => p.MaNhanVien));
                f.loadCombobox();
                f.ShowDialog();
                if (f.ans == 1)
                {
                    NhanVien nv = new NhanVien()
                    {
                        MaNhanVien = f.tb_MaNV.Text,
                        TenNhanVien = f.tb_TenNV.Text,
                        ChucVu = f.cb_CV.Text,
                        DiaChi = f.tb_DiaChi.Text,
                        DienThoai = f.tb_DienThoai.Text,
                        NgaySinh = f.dtpck_NgaySinh.Value,
                        NgayBatDauLamViec = f.dtpck_NgayBD.Value,
                        HinhAnh = f.image,
                        GhiChu = f.rtbx_GhiChu.Text
                    };
                    ctx.NhanViens.Add(nv);
                    ctx.SaveChanges();
                    frm_ManageEmployee_Load(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                FruitAppContext ctx = new FruitAppContext();
                NhanVien nv = ctx.NhanViens.FirstOrDefault(p => p.MaNhanVien == SelectedMaNV);
                frm_ThongTin_Employee f = new frm_ThongTin_Employee();
                f.Owner = this;
                f.lb_Them.Visible = false;
                f.dtpck_NgayBD.Visible = false;
                f.tb_MaNV.Text = nv.MaNhanVien;
                f.tb_DiaChi.Text = nv.DiaChi;
                f.tb_DienThoai.Text = nv.DienThoai;
                f.tb_NgayBD.Text = nv.NgayBatDauLamViec.ToShortDateString();
                f.tb_NgaySinh.Text = nv.NgaySinh.ToShortDateString();
                f.tb_TenNV.Text = nv.TenNhanVien;
                f.loadCombobox();
                f.cb_CV.SelectedItem = nv.ChucVu;
                f.rtbx_GhiChu.Text = nv.GhiChu;
                if (nv.HinhAnh != null)
                {
                    f.ptr_NV.Image = Image.FromFile(nv.HinhAnh);
                    f.image = nv.HinhAnh;
                }
                f.ShowDialog();
                if (f.ans == 1)
                {
                    nv.TenNhanVien = f.tb_TenNV.Text;
                    nv.ChucVu = f.cb_CV.Text;
                    nv.NgaySinh = f.dtpck_NgaySinh.Value;
                    nv.DiaChi = f.tb_DiaChi.Text;
                    nv.DienThoai = f.tb_DienThoai.Text;
                    nv.GhiChu = f.rtbx_GhiChu.Text;
                    nv.HinhAnh = f.image;
                    ctx.SaveChanges();
                    frm_ManageEmployee_Load(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                FruitAppContext ctx = new FruitAppContext();
                NhanVien nv = ctx.NhanViens.FirstOrDefault(p => p.MaNhanVien == SelectedMaNV);
                DialogResult dlg = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên \"" + nv.TenNhanVien
                    + "\"?", "Thông Báo", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    if (nv.ChucVu == "Quản Lý")
                    {
                        DialogResult subdlg = MessageBox.Show("Đây là quản lý bạn có chắc chắn muốn xóa?"
                            , "Thông Báo",MessageBoxButtons.YesNo);
                        if(subdlg == DialogResult.Yes)
                        {
                            TaiKhoanQuanLy tk = ctx.TaiKhoanQuanLies.FirstOrDefault(
                                p => p.MaNhanVien == nv.MaNhanVien);
                            if(tk != null)
                                ctx.TaiKhoanQuanLies.Remove(tk);
                            ctx.NhanViens.Remove(nv);
                            ctx.SaveChanges();
                            MessageBox.Show("Xóa nhân viên thành công", "Thông Báo");
                            frm_ManageEmployee_Load(sender, e);
                        }
                    }
                    else
                    {
                        ctx.NhanViens.Remove(nv);
                        ctx.SaveChanges();
                        MessageBox.Show("Xóa nhân viên thành công", "Thông Báo");
                        frm_ManageEmployee_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }
    }
}
