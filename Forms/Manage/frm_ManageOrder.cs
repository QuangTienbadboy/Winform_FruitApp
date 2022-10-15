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
    public partial class frm_ManageOrder : Form
    {
        public frm_ManageOrder()
        {
            InitializeComponent();
        }

        private void frm_ManageOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frm_MainPage_Admin)this.MdiParent).frm_MainPage_Admin_Load(sender, e);
        }

        private void frm_ManageOrder_Load(object sender, EventArgs e)
        {
            dtpck_NgayOrder.MaxDate = DateTime.Now;
            dtpck_NgayOrder.MinDate = new DateTime(2022,01,01);
        }
    }
}