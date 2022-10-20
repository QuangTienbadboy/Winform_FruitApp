using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FruitApp.Models;

namespace baithi
{
    public partial class frm_MainPage_User : Form
    {

        FruitAppContext ctx = new FruitAppContext();
        public frm_MainPage_User()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadcbb();
            cbb.SelectedIndex = 0;
            FruitAppContext ctx = new FruitAppContext();
            List<TraiCay> lct = ctx.TraiCays.Where(b=>b.SoLuongTonKho>0).ToList();
            loadsanpham(0,lct);

                
            
            
            //  ct.TenTraiCay = textBox4.Text;
            // lct.Add(ct);
            //if (textBox1.Text == "")
            //{
            //    pictureBox1.Location = new Point(45, 90);
            //    pictureBox2.Location = new Point(pictureBox1.Location.X + 345, 90);
            //    pictureBox3.Location = new Point(pictureBox2.Location.X + 345, 90);
            //    pictureBox1.Visible = true;
            //    pictureBox2.Visible = true;
            //    pictureBox3.Visible = true;
            //}
            //else
            //{
            //    if (!label1.Text.Contains(textBox1.Text))
            //    {
            //        pictureBox2.Location = new Point(pictureBox2.Location.X - 345, pictureBox2.Location.Y);
            //        pictureBox3.Location = new Point(pictureBox3.Location.X - 345, pictureBox3.Location.Y);
            //        pictureBox1.Visible = false;
            //    }
            //    else
            //    {
            //        pictureBox1.Location = new Point(45, 90);
            //        pictureBox1.Visible = true;
            //    }
            //    if (!label2.Text.Contains(textBox1.Text))
            //    {
            //        pictureBox3.Location = new Point(pictureBox3.Location.X - 345, pictureBox3.Location.Y);
            //        pictureBox2.Visible = false;
            //    }
            //    else
            //    {
            //        if (pictureBox1.Visible == true)
            //        {
            //            pictureBox2.Location = new Point(pictureBox1.Location.X + 345, pictureBox1.Location.Y);
            //        }
            //        else
            //        {
            //            pictureBox2.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y);
            //        }
            //        pictureBox2.Visible = true;
            //    }
            //    if (!label3.Text.Contains(textBox1.Text))
            //    {
            //        pictureBox3.Visible = false;
            //    }
            //    else
            //    {
            //        if (pictureBox2.Visible == true)
            //        {
            //            pictureBox3.Location = new Point(pictureBox2.Location.X + 345, pictureBox2.Location.Y);
            //        }
            //        else
            //        {
            //            pictureBox3.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y);
            //        }
            //        pictureBox3.Visible = true;
            //    }

        }
        private void loadsanpham(int trang,List<TraiCay> lct)
        {
            int dem = 0;
            foreach (TraiCay tr in lct)
            {
               
                if (dem == trang*4)
                {
                    Ma1 = tr.MaTraiCay;
                    pictureBox1.Image = Image.FromFile(tr.HinhAnh);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtTen1.Text = tr.TenTraiCay + " " + tr.DonViTinh;
                    txtGia1.Text = tr.GiaBan.ToString();
                    if (dem == lct.Count -1)
                    {
                        btnXem2.Visible = false;
                        btnMua2.Visible = false;
                        btnXem3.Visible = false;
                        btnMua3.Visible = false;
                        btnXem4.Visible = false;
                        btnMua4.Visible = false;
                        panel2.Visible = false;
                        panel3.Visible = false;
                        panel4.Visible = false;
                    }
                }
                if (dem == trang * 4+1)
                {
                    Ma2 = tr.MaTraiCay;
                    panel2.Visible = true;
                    pictureBox2.Image = Image.FromFile(tr.HinhAnh);
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtTen2.Text = tr.TenTraiCay + " " + tr.DonViTinh;
                    txtGia2.Text = tr.GiaBan.ToString();
                    if (dem == lct.Count-1)
                    {

                        btnXem3.Visible = false;
                        btnMua3.Visible = false;
                        btnXem4.Visible = false;
                        btnMua4.Visible = false;
                        panel3.Visible = false;
                        panel4.Visible = false;
                    }
                }
                
                if (dem == trang * 4+2)
                {
                    Ma3 = tr.MaTraiCay;
                    panel3.Visible = true;
                    pictureBox3.Image = Image.FromFile(tr.HinhAnh);
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtTen3.Text = tr.TenTraiCay + " " + tr.DonViTinh;
                    txtGia3.Text = tr.GiaBan.ToString();
                    if (dem == lct.Count-1)
                    {
                        btnXem4.Visible = false;
                        btnMua4.Visible = false;
                        panel4.Visible = false ;
                    }
                }
                if (dem == trang * 4 +3)
                {
                    Ma4 = tr.MaTraiCay;
                    panel4.Visible = true;
                    pictureBox4.Image = Image.FromFile(tr.HinhAnh);
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtTen4.Text = tr.TenTraiCay + " " + tr.DonViTinh;
                    txtGia4.Text = tr.GiaBan.ToString();
                }
                dem++;

            }
        }
       
        private void loadcbb()
        {
            FruitAppContext ctx = new FruitAppContext();
            List<TraiCay> lct = ctx.TraiCays.Where(b => b.SoLuongTonKho > 0).ToList();
            if(lct.Count %4 != 0)
            {
                int trang= lct.Count / 4 +1;
                for (int i = 1; i <= trang; i++)
                {
                    
                    cbb.Items.Add("Trang" + i.ToString());
                }
            }
            else
            {
                int trang = lct.Count / 4;
                for(int i = 1; i <= trang; i++)
                {
                    cbb.Items.Add("Trang"+i.ToString());
                }
            }
        }
        private void cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cbb.Text.Length >=8 )
            {

            }
            else
            {
                FruitAppContext ctx = new FruitAppContext();
                List<TraiCay> lct = ctx.TraiCays.Where(b => b.SoLuongTonKho > 0).ToList();
                loadsanpham(int.Parse(cbb.Text[cbb.Text.Length-1].ToString())-1,lct);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            FruitAppContext ctx = new FruitAppContext();
            List<TraiCay> lct = ctx.TraiCays.Where(b => b.SoLuongTonKho > 0).ToList();
            if (txtTimKiem.Text != "")
            {
                lct = lct.Where(x => x.TenTraiCay.ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();
                loadsanpham(0, lct);
               

            }
            else
            {
                loadsanpham(0, lct);
            }

        }

        string Ma1;
        string Ma2;
        string Ma3;
        string Ma4;
        private void btnXem_Click(object sender, EventArgs e)
        {
            frm_CTProDucts f = new frm_CTProDucts();
            f.Owner = this;
            f.layMa = Ma1;
            f.Show();
            this.Hide();
        }

        private void btnXem2_Click(object sender, EventArgs e)
        {
            frm_CTProDucts f = new frm_CTProDucts();
            f.Owner = this;
            f.layMa = Ma2;
            f.Show();
            this.Hide();
        }

        private void btnXem3_Click(object sender, EventArgs e)
        {
            frm_CTProDucts f = new frm_CTProDucts();
            f.Owner = this;
            f.layMa = Ma3;
            f.Show();
            this.Hide();
        }

        private void btnXem4_Click(object sender, EventArgs e)
        {
            frm_CTProDucts f = new frm_CTProDucts();
            f.Owner = this;
            f.layMa = Ma4;
            f.Show();
            this.Hide();
        }

        private void btnMua_Click(object sender, EventArgs e)
        {

        }

        private void frm_MainPage_User_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
