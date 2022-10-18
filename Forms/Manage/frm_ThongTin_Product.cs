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
    public partial class frm_ThongTin_Product : Form
    {
        public frm_ThongTin_Product()
        {
            InitializeComponent();
        }

        internal void loadCombobox()
        {
            cb_LoaiTraiCay.Items.Add("Táo");
            cb_LoaiTraiCay.Items.Add("Cam");
            cb_LoaiTraiCay.Items.Add("Chuối");
            cb_LoaiTraiCay.Items.Add("Nho");
            cb_LoaiTraiCay.Items.Add("Dưa");
            cb_LoaiTraiCay.SelectedItem = "Táo";
        }

        private void frm_ThongTin_Product_Load(object sender, EventArgs e)
        {
            loadCombobox();
            rbtn_DuaHau.Checked = true;
        }

        internal int ans = 0;
        internal string image = "";
        


        private void btn_Browse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "png file (*.png)|*.png|jpg file (*.jpg)|*.jpg" })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        ptr_TraiCay.Image = Image.FromFile(ofd.FileName);
                        image = ofd.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string s = "Các thông tin sau không được để trống:";
                bool flag = false;
                if (tb_TenTC.Text == "")
                {
                    s = s + "\nTên trái cây";
                    flag = true;
                }
                if (tb_TGBQ.Text == "")
                {
                    s = s + "\nThời gian bảo quản";
                    flag = true;
                }
                if (tb_DVT.Text == "")
                {
                    s = s + "\nĐơn vị tính";
                    flag = true;
                }
                if (tb_GiaBan.Text == "")
                {
                    s = s + "\nGiá bán";
                    flag = true;
                }
                if (tb_GiaMua.Text == "")
                {
                    s = s + "\nGiá mua";
                    flag = true;
                }
                if (image == "")
                {
                    s = s + "\nHình ảnh";
                    flag = true;
                }
                if (rtbx_MoTa.Text == "")
                {
                    s = s + "\nMô tả";
                    flag = true;
                }
                if (flag == true)
                    throw new Exception(s);
                else
                {
                    flag = false;
                    s = "Các thông tin sau không hợp lệ:";
                    foreach(var c in tb_GiaBan.Text)
                    {
                        if (c < 48 || c > 57)
                        {
                            s = s + "\nGiá bán";
                            flag = true;
                            break;
                        }
                    }
                    foreach (var c in tb_GiaMua.Text)
                    {
                        if (c < 48 || c > 57)
                        {
                            s = s + "\nGiá mua";
                            flag = true;
                            break;
                        }
                    }
                    if(flag == true)
                    {
                        throw new Exception(s);
                    }
                    else
                    {
                        ans = 1;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            ans = -1;
            this.Close();
        }

        private string newMaTC(string lastMaTC)
        {
            string s = "";
            if (!lastMaTC.Contains("TDH"))
            {
                s += lastMaTC[0];
                s += lastMaTC[1];
                int temp = 1 + (int.Parse(lastMaTC[5].ToString()) + int.Parse(lastMaTC[4].ToString()) * 10
                    + int.Parse(lastMaTC[3].ToString()) * 100 + int.Parse(lastMaTC[2].ToString()) * 1000);
                if (temp < 1000)
                {
                    s += "0";
                }
                else
                {
                    s += (temp / 1000).ToString();
                    temp = temp % 1000;
                }
                if (temp < 100)
                {
                    s += "0";
                }
                else
                {
                    s += (temp / 100).ToString();
                    temp = temp % 100;
                }
                if (temp < 10)
                {
                    s += "0";
                }
                else
                {
                    s += (temp / 10).ToString();
                    temp = temp % 10;
                }
                if (temp == 0)
                {
                    s += "0";
                }
                else
                {
                    s += temp.ToString();
                }
            }
            else
            {
                s += lastMaTC[0];
                s += lastMaTC[1];
                s += lastMaTC[2];
                int temp = 1 + (int.Parse(lastMaTC[5].ToString()) + int.Parse(lastMaTC[4].ToString()) * 10
                    + int.Parse(lastMaTC[3].ToString()) * 100);
                if (temp < 100)
                {
                    s += "0";
                }
                else
                {
                    s += (temp / 100).ToString();
                    temp = temp % 100;
                }
                if (temp < 10)
                {
                    s += "0";
                }
                else
                {
                    s += (temp / 10).ToString();
                    temp = temp % 10;
                }
                if (temp == 0)
                {
                    s += "0";
                }
                else
                {
                    s += temp.ToString();
                }
            }
            return s;
        }

        private void cb_LoaiTraiCay_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FruitAppContext ctx = new FruitAppContext();
                if (cb_LoaiTraiCay.Text == "Dưa")
                {
                    rbtn_DuaHau.Visible = true;
                    rbtn_DuaLuoi.Visible = true;
                    if (rbtn_DuaHau.Checked == true)
                    {
                        tb_MaTC.Text = newMaTC(ctx.TraiCays.Where(p => p.MaTraiCay.Contains("TDH")).ToList().Max(p => p.MaTraiCay));
                    }
                    else
                    {
                        tb_MaTC.Text = newMaTC(ctx.TraiCays.Where(p => p.MaTraiCay.Contains("DL")).ToList().Max(p => p.MaTraiCay));
                    }
                }
                else
                {
                    rbtn_DuaHau.Visible = false;
                    rbtn_DuaLuoi.Visible = false;
                    if (cb_LoaiTraiCay.Text == "Táo")
                    {
                        tb_MaTC.Text = newMaTC(ctx.TraiCays.Where(p => p.MaTraiCay.Contains("TA")).ToList().Max(p => p.MaTraiCay));
                    }
                    if (cb_LoaiTraiCay.Text == "Cam")
                    {
                        tb_MaTC.Text = newMaTC(ctx.TraiCays.Where(p => p.MaTraiCay.Contains("CA")).ToList().Max(p => p.MaTraiCay));
                    }
                    if (cb_LoaiTraiCay.Text == "Chuối")
                    {
                        tb_MaTC.Text = newMaTC(ctx.TraiCays.Where(p => p.MaTraiCay.Contains("CH")).ToList().Max(p => p.MaTraiCay));
                    }
                    if (cb_LoaiTraiCay.Text == "Nho")
                    {
                        tb_MaTC.Text = newMaTC(ctx.TraiCays.Where(p => p.MaTraiCay.Contains("NH")).ToList().Max(p => p.MaTraiCay));
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }
    }
}
