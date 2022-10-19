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
using FruitApp.Models;
using System.Net;
using System.Net.Mail;
using static System.Data.Entity.Infrastructure.Design.Executor;
using System.Runtime.Remoting.Contexts;

namespace FruitApp
{
    public partial class frm_ForgotPassword : Form
    {
        String randomCodeQuenMatKhau;
        public static String to;

        FruitAppContext connectDB = new FruitAppContext();

        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        public frm_ForgotPassword()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_SignUp frm_SignUp = new frm_SignUp();
            frm_SignUp.Show();
            this.Hide();
        }

        private void txtQuenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatKhauMoi.Text == "")
                {
                    throw new Exception("Yêu cầu nhập mật khẩu mới");
                }
                if (txtMatKhauMoi.TextLength < 8)
                {
                    throw new Exception("Yêu cầu nhập mật khẩu dài hơn 8 kí tự");
                }

                if (txtMatKhauMoi.Text != txtNhapLaiMatKhauMoi.Text)
                {
                    throw new Exception("Yêu cầu nhập lại mật khẩu phải trùng");
                }
                TaiKhoanKhachHang khUpdate = connectDB.TaiKhoanKhachHangs.FirstOrDefault(p => p.Email == txtQuenTaiKhoan.Text);
                if (khUpdate != null)
                {
                    khUpdate.MatKhau = txtMatKhauMoi.Text;
                    connectDB.SaveChanges();
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Hide();
                    frm_SignIn frm_SignIn = new frm_SignIn();
                    frm_SignIn.Show();

                }

                }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void SetTimeout(Action action, int timeout)
        {
            var timer = new Timer();
            timer.Interval = timeout;
            timer.Tick += (s, e) =>
            {
                action();
                timer.Stop();
            };
            timer.Start();
        }

        private void btnOTPQuenMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQuenTaiKhoan.Text == "")
                {
                    throw new Exception("Yêu cầu nhập tài khoản email");
                }

                if (Regex.IsMatch(txtQuenTaiKhoan.Text, pattern) == false)
                {
                    throw new Exception("Yêu cầu nhập đúng định dạng email");
                }
                TaiKhoanKhachHang kh = connectDB.TaiKhoanKhachHangs.FirstOrDefault(p => p.Email == txtQuenTaiKhoan.Text);

                if (kh == null)
                {
                    throw new Exception("Tài khoản không tồn tại");
                }

                String from, pass, messageBody;
                Random rand = new Random();
                randomCodeQuenMatKhau = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (txtQuenTaiKhoan.Text).ToString();
                from = "nguyenquocnhat03012002@gmail.com";
                pass = "eowenkfdoxuvfnsu";
                messageBody = "Mã kích hoạt tài khoản là: " + randomCodeQuenMatKhau;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Create a new account";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                var action = new Action(() =>
                {
                    randomCodeQuenMatKhau = "";
                });

                SetTimeout(action, 300000);
                smtp.Send(message);
                MessageBox.Show("Code Send Successfully");
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerifyOTP_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOTPQuenMatKhau.Text == "")
                {
                    throw new Exception("Vui lòng nhập mã OTP");
                }
                if (randomCodeQuenMatKhau == (txtOTPQuenMatKhau.Text).ToString())
            {
                to = txtQuenTaiKhoan.Text;
                    MessageBox.Show("Mã xác nhập thành công");
                    txtMatKhauMoi.Enabled = true;
                    txtNhapLaiMatKhauMoi.Enabled = true;
                    btnQuenMatKhau.Enabled = true;
            }
            else
            {
                throw new Exception("Mã OTP đã nhập không đúng");
            }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
