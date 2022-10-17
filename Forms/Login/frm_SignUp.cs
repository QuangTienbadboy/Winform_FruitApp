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

namespace FruitApp
{
    public partial class frm_SignUp : Form
    {
       
        public frm_SignUp()
        {
            InitializeComponent();
        }
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        private void linkDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_SignIn frm_SignIn = new frm_SignIn();
            frm_SignIn.Show();
            this.Hide();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDangKyEmail.Text == "")
                {
                    throw new Exception("Yêu cầu nhập tài khoản email");
                }
                if (txtDangKyMatKhau.Text == "")
                {
                    throw new Exception("Yêu cầu nhập mật khẩu");
                }
                if (Regex.IsMatch(txtDangKyEmail.Text, pattern) == false)
                {
                    throw new Exception("Yêu cầu nhập đúng định dạng email");
                }
                if (txtDangKyMatKhau.TextLength < 6)
                {
                    throw new Exception("Yêu cầu nhập mật khẩu lớn hơn 6 kí tự");
                }
                if (txtDangKyMatKhau.Text != txtDangKyMatKhauLai.Text)
                {
                    throw new Exception("Yêu cầu nhập mật khẩu lại phải trùng");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
