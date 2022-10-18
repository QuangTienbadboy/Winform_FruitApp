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
    public partial class frm_TrangThai_Order : Form
    {
        internal int ans = 0;
        public frm_TrangThai_Order()
        {
            InitializeComponent();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            ans = -1;
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            ans = 1;
            this.Close();
        }
    }
}
