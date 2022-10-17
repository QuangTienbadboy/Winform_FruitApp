using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitApp
{
    public partial class frm_ForgotPassword : Form
    {
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
    }
}
