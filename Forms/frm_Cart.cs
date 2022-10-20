
using DoAn;
using FruitApp.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace FruitApp
{
    public partial class frm_Cart : Form
    {
     
        public frm_Cart()
        {
            InitializeComponent();
        }
        
        

        void xoa()
        {

            txtMaTraiCay.Clear();

            txtTenTraiCay.Clear();
            txtSoLuong.Clear();

        }


       
        

        

        //           private void btxoa_click(object sender, eventargs e)
        //            {
        //        if (MessageBox.Show("Bạn Có Muốn Xóa Mặt Hàng Này Không!", "Xóa Mặt Hàng Này!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
        //        {
        //         DataGW1.Rows.RemoveAt(SelectedRow);
        //        }
        //}


        private void ThongTin()
        {

            int sum = 0;
            for (int i = 0; i <= DataGW1.Rows.Count - 1; i++)
            {
                sum = sum + int.Parse(DataGW1.Rows[i].Cells[3].Value.ToString());
            }
            txtTongTien.Text = sum.ToString();
            txtMaTraiCay.Clear();
            txtTenTraiCay.Clear();
            txtSoLuong.Clear();
            txtThanhTien.Clear();
            ptAnh.Image = null;
        }
        private string newMaDH(string lastMaDH)
        {
            string s = "DH";
            int temp = 1 + (int.Parse(lastMaDH[5].ToString()) + int.Parse(lastMaDH[4].ToString()) * 10
                + int.Parse(lastMaDH[3].ToString()) * 100 + int.Parse(lastMaDH[2].ToString()) * 1000);
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
            return s;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            DataGW1.AllowUserToAddRows = false;

            int sum = 0;
            for (int i = 0; i <= DataGW1.Rows.Count - 1; i++)
            {
                sum = sum + int.Parse(DataGW1.Rows[i].Cells[3].Value.ToString());
            }
            txtTongTien.Text = sum.ToString();


        }
        private int SelectedRow = -1;

        private void DataGW1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            FruitAppContext ctx = new FruitAppContext();
            TraiCay tc = ctx.TraiCays.ToList().FirstOrDefault(p => p.MaTraiCay == DataGW1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtMaTraiCay.Text = tc.MaTraiCay;
            txtTenTraiCay.Text = tc.TenTraiCay;
            txtSoLuong.Text = DataGW1.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtThanhTien.Text = DataGW1.Rows[e.RowIndex].Cells[3].Value.ToString();
            ptAnh.Image = Image.FromFile(tc.HinhAnh);
        }

        private void btxoa_click(object sender, EventArgs e)
        {

            DataGW1.Rows.RemoveAt(SelectedRow);
            ThongTin();



        }
        internal void ThemSP(string matraicay)
        {
            FruitAppContext ctx = new FruitAppContext();
            TraiCay tc = ctx.TraiCays.FirstOrDefault(p => p.MaTraiCay == matraicay);
            int selectedrow = -1;

            for(int i = 0;i<DataGW1.Rows.Count-1;i++)
            {
                if (DataGW1.Rows[i].Cells[0].Value.ToString() ==tc.MaTraiCay)
                    selectedrow = i;

            }
            MessageBox.Show(selectedrow.ToString());
            if(selectedrow == -1)
            {
                int index = DataGW1.Rows.Add();
                DataGW1.Rows[index].Cells[0].Value=tc.MaTraiCay;
                DataGW1.Rows[index].Cells[1].Value = tc.TenTraiCay;
                DataGW1.Rows[index].Cells[2].Value = "1";
                DataGW1.Rows[index].Cells[3].Value = tc.GiaBan.ToString();
            }
            else
            {
                DataGW1.Rows[selectedrow].Cells[2].Value= (int.Parse(DataGW1.Rows[selectedrow].Cells[2].Value.ToString())+1).ToString();
            }
        }

        private void btDatHang_Click(object sender, EventArgs e)
        {

            DiaChi f =new DiaChi();

            f.txtTongTien.Text = txtTongTien.Text;
            f.Owner = this;
            f.ShowDialog();
            if (f.t == 1)
            {
                FruitAppContext s = new FruitAppContext();
                string MDH = newMaDH(s.DonHangs.Max(p => p.MaDonHang));
                DonHang DH = new DonHang()
                {
                    MaDonHang = MDH,
                    MaTaiKhoan = "US0005",
                    NgayDatHang = DateTime.Now,
                    ThanhTien = int.Parse(txtTongTien.Text),
                    TrangThai = "Chờ Xác Nhận",
                    DiaChiGiaoHang = f.txtDiaChiNhanHang.Text,
                    NgayGiaoHang = DateTime.Now,


                };
                s.DonHangs.Add(DH);
                s.SaveChanges();
                for (int i = 0; i < DataGW1.Rows.Count; i++)
                {

                    string MaTraiCay = DataGW1.Rows[i].Cells[0].Value.ToString();
                    MessageBox.Show(MaTraiCay);
                    ChiTietDonHang ct = new ChiTietDonHang()

                    {
                        MaDonHang = MDH,
                        MaTraiCay = MaTraiCay,
                        GiaBan = s.TraiCays.FirstOrDefault(p => p.MaTraiCay == MaTraiCay).GiaBan,
                        SoLuong = int.Parse(DataGW1.Rows[i].Cells[2].Value.ToString())
                    };
                    s.ChiTietDonHangs.Add(ct);
                    s.SaveChanges();
                }


                DataGW1.Rows.Clear();

                txtTongTien.Clear();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }





        //private void DataGW1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGW1.AllowUserToAddRows = false;

        //    int sum =0;
        //    for(int i = 0; i <= DataGW1.Rows.Count-1; i++)
        //    {
        //        sum = sum + int.Parse(DataGW1.Rows[i].Cells[3].Value.ToString());
        //    }
        //    txtTongTien.Text = sum.ToString();
        //}
    }
}
