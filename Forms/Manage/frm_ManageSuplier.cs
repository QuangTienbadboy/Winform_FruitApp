﻿using System;
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
    public partial class frm_ManageSuplier : Form
    {
        public frm_ManageSuplier()
        {
            InitializeComponent();
        }

        private void frm_ManageSuplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frm_MainPage_Admin)this.MdiParent).frm_MainPage_Admin_Load(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
