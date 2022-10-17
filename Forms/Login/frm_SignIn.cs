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
    public partial class frm_SignIn : Form
    {
        public frm_SignIn()
        {
            InitializeComponent();
        }
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        private void linkQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_ForgotPassword frm_ForgotPassword = new frm_ForgotPassword();
            frm_ForgotPassword.Show();
            this.Hide();
        }

        private void linkTaoTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_SignUp frm_SignUp = new frm_SignUp();
            frm_SignUp.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLoginEmail.Text == "")
                {
                    throw new Exception("Yêu cầu nhập tài khoản email");
                }
                if (txtLoginPassword.Text == "")
                {
                    throw new Exception("Yêu cầu nhập mật khẩu");
                }
                if (Regex.IsMatch(txtLoginEmail.Text, pattern) == false)
                {
                    throw new Exception("Yêu cầu nhập đúng định dạng email");
                }
                if (txtLoginPassword.TextLength < 6)
                {
                    throw new Exception("Yêu cầu nhập mật khẩu lớn hơn 6 kí tự");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
