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
using FruitApp.Model;
using System.Net;
using System.Net.Mail;

namespace FruitApp
{
    public partial class frm_SignUp : Form
    {
        String randomCode;
        public static String to;

        ModelFruitApp connectDB = new ModelFruitApp();

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
                if (txtDangKyMatKhau.TextLength < 8)
                {
                    throw new Exception("Yêu cầu nhập mật khẩu lớn hơn8 kí tự");
                }
                
                if (txtDangKyMatKhau.Text != txtDangKyMatKhauLai.Text)
                {
                    throw new Exception("Yêu cầu nhập mật khẩu lại phải trùng");
                }
                if (txtOTPDangKy.Text == "")
                {
                    throw new Exception("Yêu cầu nhập mã OTP");

                }
                TaiKhoanKhachHang db = connectDB.TaiKhoanKhachHangs.FirstOrDefault(p => p.Email == txtDangKyEmail.Text);
                if (db != null)
                {
                    throw new Exception("Tài khoản đã có người đăng ký");
                }

                if (randomCode == (txtOTPDangKy.Text).ToString())
                {
                    to = txtDangKyEmail.Text;

                    int allKH = connectDB.KhachHangs.Count();
                    KhachHang kh = new KhachHang()
                    {
                        MaKhachHang = "KH000" + (allKH + 1).ToString(),
                        HoTen = txtHoVaTen.Text
                    };
                    connectDB.KhachHangs.Add(kh);
                    connectDB.SaveChanges();

                    int allTK = connectDB.TaiKhoanKhachHangs.Count();
                    TaiKhoanKhachHang tkkh = new TaiKhoanKhachHang()
                    {
                        MaTaiKhoan = "US000" + (allTK + 1).ToString() ,
                        MaKhachHang = kh.MaKhachHang ,
                        Email = txtDangKyEmail.Text,
                        MatKhau = txtDangKyMatKhau.Text,
                        Admin = false
                    };
                    connectDB.TaiKhoanKhachHangs.Add(tkkh);
                    connectDB.SaveChanges();


                    frm_SignIn frm_SignIn = new frm_SignIn();
                    frm_SignIn.Show();
                    this.Hide();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDangKyMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDangKyMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void btnOTPDangKy_Click(object sender, EventArgs e)
        {

            TaiKhoanKhachHang db = connectDB.TaiKhoanKhachHangs.FirstOrDefault(p => p.Email == txtDangKyEmail.Text);
            if (db != null)
            {
                MessageBox.Show("Tài khoản đã có người đăng ký");
                return;
            }

            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtDangKyEmail.Text).ToString();
            from = "nguyenquocnhat03012002@gmail.com";
            pass = "eowenkfdoxuvfnsu";
            messageBody = "Mã kích hoạt tài khoản là: " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Create a new account";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Send Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
