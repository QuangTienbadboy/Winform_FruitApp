using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FruitApp;

namespace FruitApp
{
    public partial class frm_MainPage_Admin : Form
    {
        public frm_MainPage_Admin()
        {
            InitializeComponent();
        }

        private void tsbtn_ManageProduct_Click(object sender, EventArgs e)
        {
            frm_ManageProduct mnp1 = new frm_ManageProduct();
            mnp1.MdiParent = frm_MainPage_Admin.ActiveForm;
            mnp1.Show();
            tstr_Admin.Enabled = false;
            mnstr_Admin.Enabled = false;

        }

        private void tsbtn_ManageOrder_Click(object sender, EventArgs e)
        {
            frm_ManageOrder mno1 = new frm_ManageOrder();
            mno1.MdiParent = frm_MainPage_Admin.ActiveForm;
            mno1.Show();
            tstr_Admin.Enabled = false;
            mnstr_Admin.Enabled = false;
        }

        private void tsbtn_ManageWareHouse_Click(object sender, EventArgs e)
        {
            frm_ManageWareHouse mnw1 = new frm_ManageWareHouse();
            mnw1.MdiParent = frm_MainPage_Admin.ActiveForm;
            mnw1.Show();
            tstr_Admin.Enabled = false;
            mnstr_Admin.Enabled = false;
        }

        private void tsbtn_ManageSuplier_Click(object sender, EventArgs e)
        {
            frm_ManageSuplier mns1 = new frm_ManageSuplier();
            mns1.MdiParent = frm_MainPage_Admin.ActiveForm;
            mns1.Show();
            tstr_Admin.Enabled = false;
            mnstr_Admin.Enabled = false;
        }

        private void tsbtn_ManageEmployee_Click(object sender, EventArgs e)
        {
            frm_ManageEmployee mne1 = new frm_ManageEmployee();
            mne1.MdiParent = frm_MainPage_Admin.ActiveForm;
            mne1.Show();
            tstr_Admin.Enabled = false;
            mnstr_Admin.Enabled = false;
        }

        private void tsbtn_ManageUserAccount_Click(object sender, EventArgs e)
        {
            frm_ManageUserAccount mnua1 = new frm_ManageUserAccount();
            mnua1.MdiParent = frm_MainPage_Admin.ActiveForm;
            mnua1.Show();
            tstr_Admin.Enabled = false;
            mnstr_Admin.Enabled = false;
        }

        private void tsbtn_Statistic_Click(object sender, EventArgs e)
        {
            frm_Statistic sts = new frm_Statistic();
            sts.MdiParent = frm_MainPage_Admin.ActiveForm;
            sts.Show();
            tstr_Admin.Enabled = false;
            mnstr_Admin.Enabled = false;
        }

        private void tsbtn_Exit_Click(object sender, EventArgs e)
        {
            this.Owner.Close();
            this.Close();
        }

        internal void frm_MainPage_Admin_Load(object sender, EventArgs e)
        {
            tstr_Admin.Enabled = true;
            mnstr_Admin.Enabled = true;
        }

        private void tstr_LogOut_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}