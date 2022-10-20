using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class DiaChi : Form
    {
        public DiaChi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t = 0;
            MessageBox.Show("Bạn có muốn thoát không"," ",MessageBoxButtons.OK );
            this.Close();
        }
        internal int t = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDiaChiNhanHang.Text != "")
                {
                    t = 1;
                    MessageBox.Show("Bạn Đã Đặt Hàng Thành Công");
                    this.Close();
                }
                else
                {
                    throw new Exception("Bạn cần nhập địa chỉ");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DiaChi_Load(object sender, EventArgs e)
        {
            
        }
    }
}
