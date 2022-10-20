//using FruitApp.Forms.User;
//using FruitApp.Models;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;
//using Image = System.Drawing.Image;

//namespace DoAn
//{
//    public partial class frm_Cart : Form
//    {
//        SqlConnection con;
//        public frm_Cart()
//        {
//            InitializeComponent();
//        }
//        //public bool KetNoi(String server, String database)
//        //{
//        //    try
//        //    {
//        //        String s = " Data source = " + server + " ; database = " + database + " ; Integrated Security = true ";
//        //        con = new SqlConnection(s);
//        //        con.Open();
//        //        return true;
//        //    }
//        //    catch (Exception e)
//        //    {
//        //        MessageBox.Show(e.Message);
//        //        return false;
//        //    }
//        //}
//        //DataTable TruyVan(String s)
//        //{

//        //    SqlDataAdapter da;
//        //    DataSet ds = new DataSet();
//        //    try
//        //    {
//        //        da = new SqlDataAdapter(s, con);
//        //        da.Fill(ds, "KQ");
//        //        con.Close();
//        //        return ds.Tables["KQ"];
//        //    }
//        //    catch (Exception e)
//        //    {
//        //        MessageBox.Show("Loi truy van CSDL.");
//        //        return new DataTable();

//        //    }
//        //}
//        private void loadDataGitWies()
//        {
           
            
//                int index = DataGW1.Rows.Add();
//                DataGW1.Rows[index].Cells[0].Value = "CA0001";
//                DataGW1.Rows[index].Cells[1].Value = "Cam vàng Úc";
//                DataGW1.Rows[index].Cells[2].Value = "1";
//                DataGW1.Rows[index].Cells[3].Value = "66000";
            
//        }

//        //void Xoa()
//        //{

//        // txtMaTraiCay.Clear();

//        //    txttentraicay.clear();
//        //    txtsoluong.clear();

//        //}


//        //private void listView1_SelectedIndexChanged(object sender, EventArgs e)
//        //{
//        //    FruitAppContext ctx = new FruitAppContext();
//        //    TraiCay tc = ctx.TraiCays.FirstOrDefault(p => p.MaTraiCay == listView1.SelectedItems[0].SubItems[0].Text);
//        //    txtMaTraiCay.Text = tc.MaTraiCay;
//        //    txtTenTraiCay.Text = tc.TenTraiCay;
//        //    txtSoLuong.Text = listView1.SelectedItems[0].SubItems[2].Text;

//        //    txtThanhTien.Text = listView1.SelectedItems[0].SubItems[3].Text;
//        //    ptAnh.Image = Image.FromFile(tc.HinhAnh);
//        //    //if (listView1.SelectedItems.Count > 0)
//        //    // {


//        //    //     txtMaTraiCay.Text = listView1.SelectedItems[0].SubItems[0].Text;

//        //    //     txtTenTraiCay.Text = listView1.SelectedItems[0].SubItems[1].Text;

//        //    //     txtSoLuong.Text = listView1.SelectedItems[0].SubItems[2].Text;

//        //    //     txtThanhTien.Text = listView1.SelectedItems[0].SubItems[3].Text;




//        //    // }
//        //}
//        //bool DatHang(string s)
//        //{
//        //    try
//        //    {
//        //        SqlCommand cmd = new SqlCommand(s, con);
//        //        cmd.ExecuteNonQuery();
//        //        con.Close();
//        //        return true;
//        //    }
//        //    catch (Exception e)
//        //    {
//        //        MessageBox.Show(" Loi cap nhat CSDL . ");
//        //        return false;
//        //    }
//        //}

//        //private void btDatHang_Click(object sender, EventArgs e)
//        //{
//        //    if (KetNoi("DESKTOP-OTT02BM\\SQLEXPRESS", "FruitApp") == false)
//        //    {
//        //        MessageBox.Show("Nhan OK de thoat", "Ket noi khong thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Stop);
//        //        return;
//        //    }

//        //    string ht = txtMaTraiCay.Text;
//        //    string ns = txtTenTraiCay.Text;
//        //    string dc = txtSoLuong.Text;
//        //    string h = txtThanhTien.Text;

//        //    string s = "insert into ChiTietDonHang  values(N'" + ht + "','" + ns + "',N'" + dc + "','" + h + "')";
//        //    if (DatHang(s) == true)
//        //    {
//        //        //listView1.Items.Clear();
//        //        //LayDuLieu_Len_Listview();
//        //    }
//        // }

//        //           private void btxoa_click(object sender, eventargs e)
//        //            {
//        //        if (MessageBox.Show("Bạn Có Muốn Xóa Mặt Hàng Này Không!", "Xóa Mặt Hàng Này!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
//        //        {
//        //         DataGW1.Rows.RemoveAt(SelectedRow);
//        //        }
//        //}


//        private void ThongTin()
//        {

//            int sum = 0;
//            for (int i = 0; i <= DataGW1.Rows.Count - 1; i++)
//            {
//                sum = sum + int.Parse(DataGW1.Rows[i].Cells[3].Value.ToString());
//            }
//            txtTongTien.Text = sum.ToString();
//            txtMaTraiCay.Clear();
//            txtTenTraiCay.Clear();
//            txtSoLuong.Clear();
//            txtThanhTien.Clear();
//            ptAnh.Image = null;
//        }
//        private string newMaDH(string lastMaDH)
//        {
//            string s = "DH";
//            int temp = 1 + (int.Parse(lastMaDH[5].ToString()) + int.Parse(lastMaDH[4].ToString()) * 10
//                + int.Parse(lastMaDH[3].ToString()) * 100 + int.Parse(lastMaDH[2].ToString()) * 1000);
//            if (temp < 1000)
//            {
//                s += "0";
//            }
//            else
//            {
//                s += (temp / 1000).ToString();
//                temp = temp % 1000;
//            }
//            if (temp < 100)
//            {
//                s += "0";
//            }
//            else
//            {
//                s += (temp / 100).ToString();
//                temp = temp % 100;
//            }
//            if (temp < 10)
//            {
//                s += "0";
//            }
//            else
//            {
//                s += (temp / 10).ToString();
//                temp = temp % 10;
//            }
//            if (temp == 0)
//            {
//                s += "0";
//            }
//            else
//            {
//                s += temp.ToString();
//            }
//            return s;
//        }
//        private void Form1_Load(object sender, EventArgs e)
//        {
//            loadDataGitWies();
//            DataGW1.AllowUserToAddRows = false;

//            int sum = 0;
//            for (int i = 0; i <= DataGW1.Rows.Count - 1; i++)
//            {
//                sum = sum + int.Parse(DataGW1.Rows[i].Cells[3].Value.ToString());
//            }
//            txtTongTien.Text = sum.ToString();


//        }
//        private int SelectedRow = -1;

//        private void DataGW1_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            SelectedRow = e.RowIndex;
//            FruitAppContext ctx = new FruitAppContext();
//            TraiCay tc = ctx.TraiCays.ToList().FirstOrDefault(p => p.MaTraiCay == DataGW1.Rows[e.RowIndex].Cells[0].Value.ToString());
//            txtMaTraiCay.Text = tc.MaTraiCay;
//            txtTenTraiCay.Text = tc.TenTraiCay;
//            txtSoLuong.Text = DataGW1.Rows[e.RowIndex].Cells[2].Value.ToString();

//            txtThanhTien.Text = DataGW1.Rows[e.RowIndex].Cells[3].Value.ToString();
//            ptAnh.Image = Image.FromFile(tc.HinhAnh);
//        }

//        private void btxoa_click(object sender, EventArgs e)
//        {
            
//                DataGW1.Rows.RemoveAt(SelectedRow);
//            ThongTin();



//            }
       
//        private void btDatHang_Click(object sender, EventArgs e)
//        {

//            frm_DiaChi f = new frm_DiaChi();
            
//            f.txtTongTien.Text = txtTongTien.Text;
//            f.Owner = this;
//            f.ShowDialog();
//            if(f.t ==1)
//            {
//                FruitAppContext s = new FruitAppContext();
//                string MDH = newMaDH(s.DonHangs.Max(p=>p.MaDonHang));
//                DonHang DH = new DonHang()
//                {
//                    MaDonHang = MDH,
//                    MaTaiKhoan = "US0004",
//                    NgayDatHang = DateTime.Now,
//                    ThanhTien = int.Parse(txtTongTien.Text),
//                    TrangThai = "Chờ Xác Nhận",
//                    DiaChiGiaoHang = f.txtDiaChiNhanHang.Text,
//                    NgayGiaoHang = DateTime.Now,


//                };
//                s.DonHangs.Add(DH);
//                s.SaveChanges();
//                for (int i = 0; i < DataGW1.Rows.Count ; i++)
//                {

//                    string MaTraiCay = DataGW1.Rows[i].Cells[0].Value.ToString();
//                    MessageBox.Show(MaTraiCay);
//                    ChiTietDonHang ct = new ChiTietDonHang()

//                    {
//                        MaDonHang = MDH,
//                        MaTraiCay = MaTraiCay,
//                        GiaBan = s.TraiCays.FirstOrDefault(p => p.MaTraiCay == MaTraiCay).GiaBan,
//                        SoLuong = int.Parse(DataGW1.Rows[i].Cells[2].Value.ToString())
//                    };
//                    s.ChiTietDonHangs.Add(ct);
//                    s.SaveChanges();
//                }

               
//                DataGW1.Rows.Clear();

//                txtTongTien.Clear();

//            }    


//        }

       

       

//        //private void DataGW1_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        //{
//        //    DataGW1.AllowUserToAddRows = false;
            
//        //    int sum =0;
//        //    for(int i = 0; i <= DataGW1.Rows.Count-1; i++)
//        //    {
//        //        sum = sum + int.Parse(DataGW1.Rows[i].Cells[3].Value.ToString());
//        //    }
//        //    txtTongTien.Text = sum.ToString();
//        //}
//    } }
