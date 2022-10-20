using FruitApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace baithi
{
    public partial class frm_RePassWord : Form
    {
        FruitAppContext ctx = new FruitAppContext();
        public frm_RePassWord()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMKCu.Text == "")
                {
                    throw new Exception("Yêu cầu nhập mật khẩu mới");
                }
                if (txtMKMoi.Text == "")
                {
                    throw new Exception("Yêu cầu nhập mật khẩu mới");
                }
                if (txtMKMoi.TextLength < 8)
                {
                    throw new Exception("Yêu cầu nhập mật khẩu dài hơn 8 kí tự");
                }
                if (!Regex.IsMatch(txtMKMoi.Text, @"^(?=.*[a-zA-Z])(?=.*[0-9])"))
                {
                    throw new Exception("Yêu cầu nhập đủ cả kí tự lẫn số");
                }
                if (txtMKMoi.Text != txtNhapLai.Text)
                {
                    throw new Exception("Yêu cầu nhập lại mật khẩu phải trùng");
                }
                TaiKhoanKhachHang khUpdate = ctx.TaiKhoanKhachHangs.FirstOrDefault(p => p.MatKhau == txtMKCu.Text); 

                if (khUpdate != null)
                {
                    khUpdate.MatKhau = txtMKMoi.Text;
                    ctx.SaveChanges();
                    MessageBox.Show("Đổi mật khẩu thành công");      
                    new frm_RePassWord().Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Sai mật khẩu cũ, mời nhập lại");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
