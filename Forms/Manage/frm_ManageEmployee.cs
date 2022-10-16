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
    public partial class frm_ManageEmployee : Form
    {
        public frm_ManageEmployee()
        {
            InitializeComponent();
        }

        private void frm_ManageEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frm_MainPage_Admin)this.MdiParent).frm_MainPage_Admin_Load(sender, e);
        }

    }
}
