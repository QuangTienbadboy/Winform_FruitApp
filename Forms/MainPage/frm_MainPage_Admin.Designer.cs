namespace FruitApp
{
    partial class frm_MainPage_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tstr_Admin = new System.Windows.Forms.ToolStrip();
            this.tsbtn_ManageProduct = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_ManageOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_ManageSuplier = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_ManageEmployee = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_ManageUserAccount = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_Exit = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Statistic = new System.Windows.Forms.ToolStripButton();
            this.mnstr_Admin = new System.Windows.Forms.MenuStrip();
            this.mnstr_System_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenu_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenu_Order = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenu_Suplier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenu_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenu_UserAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenu_LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstr_Statistic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstr_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.tstr_Admin.SuspendLayout();
            this.mnstr_Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstr_Admin
            // 
            this.tstr_Admin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tstr_Admin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_ManageProduct,
            this.toolStripSeparator4,
            this.tsbtn_ManageOrder,
            this.toolStripSeparator7,
            this.tsbtn_ManageSuplier,
            this.toolStripSeparator1,
            this.tsbtn_ManageEmployee,
            this.toolStripSeparator2,
            this.tsbtn_ManageUserAccount,
            this.toolStripSeparator3,
            this.tsbtn_Exit,
            this.tsbtn_Statistic});
            this.tstr_Admin.Location = new System.Drawing.Point(0, 36);
            this.tstr_Admin.Name = "tstr_Admin";
            this.tstr_Admin.Size = new System.Drawing.Size(1225, 71);
            this.tstr_Admin.TabIndex = 0;
            this.tstr_Admin.Text = "toolStrip1";
            // 
            // tsbtn_ManageProduct
            // 
            this.tsbtn_ManageProduct.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.tsbtn_ManageProduct.Image = global::FruitApp.Properties.Resources.icons8_fruit_58;
            this.tsbtn_ManageProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_ManageProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_ManageProduct.Name = "tsbtn_ManageProduct";
            this.tsbtn_ManageProduct.Size = new System.Drawing.Size(229, 68);
            this.tsbtn_ManageProduct.Text = "Sản Phẩm";
            this.tsbtn_ManageProduct.Click += new System.EventHandler(this.tsbtn_ManageProduct_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 71);
            // 
            // tsbtn_ManageOrder
            // 
            this.tsbtn_ManageOrder.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.tsbtn_ManageOrder.Image = global::FruitApp.Properties.Resources.icons8_shopping_cart_48;
            this.tsbtn_ManageOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_ManageOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_ManageOrder.Name = "tsbtn_ManageOrder";
            this.tsbtn_ManageOrder.Size = new System.Drawing.Size(224, 68);
            this.tsbtn_ManageOrder.Text = "Đơn Hàng";
            this.tsbtn_ManageOrder.Click += new System.EventHandler(this.tsbtn_ManageOrder_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 71);
            // 
            // tsbtn_ManageSuplier
            // 
            this.tsbtn_ManageSuplier.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.tsbtn_ManageSuplier.Image = global::FruitApp.Properties.Resources.icons8_bussiness_man_64;
            this.tsbtn_ManageSuplier.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_ManageSuplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_ManageSuplier.Name = "tsbtn_ManageSuplier";
            this.tsbtn_ManageSuplier.Size = new System.Drawing.Size(196, 68);
            this.tsbtn_ManageSuplier.Text = "Đối Tác";
            this.tsbtn_ManageSuplier.Click += new System.EventHandler(this.tsbtn_ManageSuplier_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // tsbtn_ManageEmployee
            // 
            this.tsbtn_ManageEmployee.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.tsbtn_ManageEmployee.Image = global::FruitApp.Properties.Resources.icons8_employees_64;
            this.tsbtn_ManageEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_ManageEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_ManageEmployee.Name = "tsbtn_ManageEmployee";
            this.tsbtn_ManageEmployee.Size = new System.Drawing.Size(243, 68);
            this.tsbtn_ManageEmployee.Text = "Nhân Viên";
            this.tsbtn_ManageEmployee.Click += new System.EventHandler(this.tsbtn_ManageEmployee_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
            // 
            // tsbtn_ManageUserAccount
            // 
            this.tsbtn_ManageUserAccount.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.tsbtn_ManageUserAccount.Image = global::FruitApp.Properties.Resources.icons8_user_48;
            this.tsbtn_ManageUserAccount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_ManageUserAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_ManageUserAccount.Name = "tsbtn_ManageUserAccount";
            this.tsbtn_ManageUserAccount.Size = new System.Drawing.Size(252, 68);
            this.tsbtn_ManageUserAccount.Text = "Khách Hàng";
            this.tsbtn_ManageUserAccount.Click += new System.EventHandler(this.tsbtn_ManageUserAccount_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 71);
            // 
            // tsbtn_Exit
            // 
            this.tsbtn_Exit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtn_Exit.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.tsbtn_Exit.Image = global::FruitApp.Properties.Resources.icons8_close_48;
            this.tsbtn_Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Exit.Name = "tsbtn_Exit";
            this.tsbtn_Exit.Size = new System.Drawing.Size(158, 52);
            this.tsbtn_Exit.Text = "Thoát";
            this.tsbtn_Exit.Click += new System.EventHandler(this.tsbtn_Exit_Click);
            // 
            // tsbtn_Statistic
            // 
            this.tsbtn_Statistic.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.tsbtn_Statistic.Image = global::FruitApp.Properties.Resources.icons8_graphs_64;
            this.tsbtn_Statistic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_Statistic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Statistic.Name = "tsbtn_Statistic";
            this.tsbtn_Statistic.Size = new System.Drawing.Size(231, 68);
            this.tsbtn_Statistic.Text = "Thống Kê";
            this.tsbtn_Statistic.Click += new System.EventHandler(this.tsbtn_Statistic_Click);
            // 
            // mnstr_Admin
            // 
            this.mnstr_Admin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnstr_Admin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnstr_System_Admin,
            this.mnstr_Statistic,
            this.mnstr_Help});
            this.mnstr_Admin.Location = new System.Drawing.Point(0, 0);
            this.mnstr_Admin.Name = "mnstr_Admin";
            this.mnstr_Admin.Size = new System.Drawing.Size(1225, 36);
            this.mnstr_Admin.TabIndex = 2;
            this.mnstr_Admin.Text = "menuStrip1";
            // 
            // mnstr_System_Admin
            // 
            this.mnstr_System_Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenu_Product,
            this.tsmenu_Order,
            this.tsmenu_Suplier,
            this.tsmenu_Employee,
            this.tsmenu_UserAccount,
            this.tsmenu_LogOut,
            this.tsmenu_Exit});
            this.mnstr_System_Admin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnstr_System_Admin.Name = "mnstr_System_Admin";
            this.mnstr_System_Admin.Size = new System.Drawing.Size(111, 32);
            this.mnstr_System_Admin.Text = "Hệ Thống";
            // 
            // tsmenu_Product
            // 
            this.tsmenu_Product.Name = "tsmenu_Product";
            this.tsmenu_Product.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.tsmenu_Product.Size = new System.Drawing.Size(268, 32);
            this.tsmenu_Product.Text = "Sản Phẩm";
            this.tsmenu_Product.Click += new System.EventHandler(this.tsbtn_ManageProduct_Click);
            // 
            // tsmenu_Order
            // 
            this.tsmenu_Order.Name = "tsmenu_Order";
            this.tsmenu_Order.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.tsmenu_Order.Size = new System.Drawing.Size(268, 32);
            this.tsmenu_Order.Text = "Đơn Hàng";
            this.tsmenu_Order.Click += new System.EventHandler(this.tsbtn_ManageOrder_Click);
            // 
            // tsmenu_Suplier
            // 
            this.tsmenu_Suplier.Name = "tsmenu_Suplier";
            this.tsmenu_Suplier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.tsmenu_Suplier.Size = new System.Drawing.Size(268, 32);
            this.tsmenu_Suplier.Text = "Đối Tác";
            this.tsmenu_Suplier.Click += new System.EventHandler(this.tsbtn_ManageSuplier_Click);
            // 
            // tsmenu_Employee
            // 
            this.tsmenu_Employee.Name = "tsmenu_Employee";
            this.tsmenu_Employee.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.tsmenu_Employee.Size = new System.Drawing.Size(268, 32);
            this.tsmenu_Employee.Text = "Nhân Viên";
            this.tsmenu_Employee.Click += new System.EventHandler(this.tsbtn_ManageEmployee_Click);
            // 
            // tsmenu_UserAccount
            // 
            this.tsmenu_UserAccount.Name = "tsmenu_UserAccount";
            this.tsmenu_UserAccount.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.tsmenu_UserAccount.Size = new System.Drawing.Size(268, 32);
            this.tsmenu_UserAccount.Text = "Khách Hàng";
            this.tsmenu_UserAccount.Click += new System.EventHandler(this.tsbtn_ManageUserAccount_Click);
            // 
            // tsmenu_LogOut
            // 
            this.tsmenu_LogOut.Name = "tsmenu_LogOut";
            this.tsmenu_LogOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.tsmenu_LogOut.Size = new System.Drawing.Size(268, 32);
            this.tsmenu_LogOut.Text = "Đăng Xuất";
            this.tsmenu_LogOut.Click += new System.EventHandler(this.tstr_LogOut_Click);
            // 
            // tsmenu_Exit
            // 
            this.tsmenu_Exit.Name = "tsmenu_Exit";
            this.tsmenu_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmenu_Exit.Size = new System.Drawing.Size(268, 32);
            this.tsmenu_Exit.Text = "Thoát";
            this.tsmenu_Exit.Click += new System.EventHandler(this.tsbtn_Exit_Click);
            // 
            // mnstr_Statistic
            // 
            this.mnstr_Statistic.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnstr_Statistic.Name = "mnstr_Statistic";
            this.mnstr_Statistic.Size = new System.Drawing.Size(109, 32);
            this.mnstr_Statistic.Text = "Thống Kê";
            // 
            // mnstr_Help
            // 
            this.mnstr_Help.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnstr_Help.Name = "mnstr_Help";
            this.mnstr_Help.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.mnstr_Help.Size = new System.Drawing.Size(67, 32);
            this.mnstr_Help.Text = "Help";
            // 
            // frm_MainPage_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 483);
            this.Controls.Add(this.tstr_Admin);
            this.Controls.Add(this.mnstr_Admin);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnstr_Admin;
            this.Name = "frm_MainPage_Admin";
            this.Text = "Quản Lý";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_MainPage_Admin_FormClosed);
            this.Load += new System.EventHandler(this.frm_MainPage_Admin_Load);
            this.tstr_Admin.ResumeLayout(false);
            this.tstr_Admin.PerformLayout();
            this.mnstr_Admin.ResumeLayout(false);
            this.mnstr_Admin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstr_Admin;
        private System.Windows.Forms.ToolStripButton tsbtn_ManageProduct;
        private System.Windows.Forms.ToolStripButton tsbtn_ManageOrder;
        private System.Windows.Forms.ToolStripButton tsbtn_ManageSuplier;
        private System.Windows.Forms.ToolStripButton tsbtn_ManageEmployee;
        private System.Windows.Forms.ToolStripButton tsbtn_ManageUserAccount;
        private System.Windows.Forms.ToolStripButton tsbtn_Exit;
        private System.Windows.Forms.ToolStripButton tsbtn_Statistic;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.MenuStrip mnstr_Admin;
        private System.Windows.Forms.ToolStripMenuItem mnstr_System_Admin;
        private System.Windows.Forms.ToolStripMenuItem mnstr_Statistic;
        private System.Windows.Forms.ToolStripMenuItem mnstr_Help;
        private System.Windows.Forms.ToolStripMenuItem tsmenu_Product;
        private System.Windows.Forms.ToolStripMenuItem tsmenu_Order;
        private System.Windows.Forms.ToolStripMenuItem tsmenu_Suplier;
        private System.Windows.Forms.ToolStripMenuItem tsmenu_Employee;
        private System.Windows.Forms.ToolStripMenuItem tsmenu_UserAccount;
        private System.Windows.Forms.ToolStripMenuItem tsmenu_LogOut;
        private System.Windows.Forms.ToolStripMenuItem tsmenu_Exit;
    }
}