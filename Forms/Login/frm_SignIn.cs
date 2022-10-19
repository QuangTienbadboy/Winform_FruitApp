using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FruitApp.Models;

namespace FruitApp
{
    public partial class frm_SignIn : Form
    {
        FruitAppContext connectDB = new FruitAppContext();
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
                
                if (txtLoginPassword.TextLength < 8)
                {
                    throw new Exception("Yêu cầu nhập mật khẩu lớn hơn 6 kí tự");
                }

                if (cbbQuyen.Text == "Admin")
                {
                    TaiKhoanQuanLy admin = connectDB.TaiKhoanQuanLies.FirstOrDefault(p => p.Username == txtLoginEmail.Text);

                    if (admin == null)
                    {
                        throw new Exception("Tài khoản không tồn tại");
                    }
                    if (admin.MatKhau.ToString() != txtLoginPassword.Text)
                    {
                        throw new Exception("Mật khẩu không hợp lệ");
                    } else
                    {
                        frm_MainPage_Admin f = new frm_MainPage_Admin();
                        f.Owner = this;
                        f.Show();
                        this.Hide();
                    }
                }

                if (cbbQuyen.Text == "Khách hàng")
                {
                    if (Regex.IsMatch(txtLoginEmail.Text, pattern) == false)
                    {
                        throw new Exception("Yêu cầu nhập đúng định dạng email");
                    }
                    TaiKhoanKhachHang kh = connectDB.TaiKhoanKhachHangs.FirstOrDefault(p => p.Email == txtLoginEmail.Text);

                    if (kh == null)
                    {
                        throw new Exception("Tài khoản không tồn tại");
                    }
                    if (kh.MatKhau.ToString() != txtLoginPassword.Text)
                    {
                        throw new Exception("Mật khẩu không hợp lệ");
                    }
                    else
                    {
                        frm_MainPage_User f = new frm_MainPage_User();
                        f.Owner = this;
                        f.Show();
                        this.Hide();
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLoginPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
