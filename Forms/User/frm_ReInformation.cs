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
    public partial class frm_ReInformation : Form
    {
        FruitAppContext ctx = new FruitAppContext();
        public frm_ReInformation()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try {
                
                if (txtDienThoai.Text.Length != 10)
                    throw new Exception("Dien Thoai ko Hop le");
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtDienThoai.Text, @"^([0]+(3|5|7|8|9|1[2|6|8|9]))+([0-9]{8})$"))
                    throw new Exception("Dien Thoai ko Hop le");
              
                TaiKhoanKhachHang db = ctx.TaiKhoanKhachHangs.FirstOrDefault(p => p.Email == txtEmail.Text);

                    if (db != null)
                    {
                        db.KhachHang.HoTen = txtHoTen.Text;
                        db.KhachHang.DienThoai = txtDienThoai.Text;
                        db.KhachHang.DiaChi = txtDiaChi.Text;
                        db.Email = txtEmail.Text;

                        DateTime theDate = dateTimePicker1.Value.Date;
                        db.KhachHang.NgaySinh = theDate;
                        ctx.SaveChanges();
                    this.Owner.Show();
                        this.Hide();
                    
           
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        public void load()
        {

            
        }
        internal string matk;
        private void SuaThongTin_Load(object sender, EventArgs e)
        {
            TaiKhoanKhachHang tk = ctx.TaiKhoanKhachHangs.FirstOrDefault(p => p.MaKhachHang == matk);
            txtHoTen.Text = tk.KhachHang.HoTen;
            txtDienThoai.Text = tk.KhachHang.DienThoai;
            txtDiaChi.Text = tk.KhachHang.DiaChi;
            txtEmail.Text = tk.Email;
            if(tk.KhachHang.NgaySinh != null)
                dateTimePicker1.Value = (DateTime)tk.KhachHang.NgaySinh;
        }
           private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }


    }
