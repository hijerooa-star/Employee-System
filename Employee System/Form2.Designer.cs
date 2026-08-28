using System;
using System.Windows.Forms;

namespace Employee_System
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tabcontrol = new System.Windows.Forms.TabControl();
            this.tabItem = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudquantity = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdodelivery = new System.Windows.Forms.RadioButton();
            this.rdotakeaway = new System.Windows.Forms.RadioButton();
            this.rdodinin = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chksauce = new System.Windows.Forms.CheckBox();
            this.chkonion = new System.Windows.Forms.CheckBox();
            this.chkextra = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstitem = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.grpitemdetail = new System.Windows.Forms.GroupBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.picitem = new System.Windows.Forms.PictureBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtava = new System.Windows.Forms.TextBox();
            this.lblava = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.tabcurrent = new System.Windows.Forms.TabPage();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txttax = new System.Windows.Forms.TextBox();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.dgcurrentorder = new System.Windows.Forms.DataGridView();
            this.Itemdatagride = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantitydatagrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHill = new System.Windows.Forms.TabPage();
            this.pnlRestauranthall = new System.Windows.Forms.Panel();
            this.btnT10 = new System.Windows.Forms.Button();
            this.btnT9 = new System.Windows.Forms.Button();
            this.btnT8 = new System.Windows.Forms.Button();
            this.btnT2 = new System.Windows.Forms.Button();
            this.btnT3 = new System.Windows.Forms.Button();
            this.btnT4 = new System.Windows.Forms.Button();
            this.btnT5 = new System.Windows.Forms.Button();
            this.btnT6 = new System.Windows.Forms.Button();
            this.btnT7 = new System.Windows.Forms.Button();
            this.btnT1 = new System.Windows.Forms.Button();
            this.btnacc = new System.Windows.Forms.Button();
            this.btnreserve = new System.Windows.Forms.Button();
            this.btnavailable = new System.Windows.Forms.Button();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itemgrad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itemgrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantitygrad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.Tabcontrol.SuspendLayout();
            this.tabItem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudquantity)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpitemdetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picitem)).BeginInit();
            this.tabcurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcurrentorder)).BeginInit();
            this.tabHill.SuspendLayout();
            this.pnlRestauranthall.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenu,
            this.itemToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenu
            // 
            this.fileToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.fileToolStripMenu.Name = "fileToolStripMenu";
            this.fileToolStripMenu.Size = new System.Drawing.Size(42, 20);
            this.fileToolStripMenu.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.loginToolStripMenuItem.Text = "Logout";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.newItemToolStripMenuItem});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.itemToolStripMenuItem.Text = "Items";
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addItemToolStripMenuItem.Text = "Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.newItemToolStripMenuItem.Text = "New  item";
            this.newItemToolStripMenuItem.Click += new System.EventHandler(this.newItemToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentOrderToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.orderToolStripMenuItem.Text = "Orders";
            // 
            // currentOrderToolStripMenuItem
            // 
            this.currentOrderToolStripMenuItem.Name = "currentOrderToolStripMenuItem";
            this.currentOrderToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.currentOrderToolStripMenuItem.Text = "Current Order";
            this.currentOrderToolStripMenuItem.Click += new System.EventHandler(this.currentOrderToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.salesReportToolStripMenuItem.Text = "Sales Report";
            this.salesReportToolStripMenuItem.Click += new System.EventHandler(this.salesReportToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Tabcontrol
            // 
            this.Tabcontrol.Controls.Add(this.tabItem);
            this.Tabcontrol.Controls.Add(this.tabcurrent);
            this.Tabcontrol.Controls.Add(this.tabHill);
            this.Tabcontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabcontrol.Location = new System.Drawing.Point(13, 46);
            this.Tabcontrol.Name = "Tabcontrol";
            this.Tabcontrol.SelectedIndex = 0;
            this.Tabcontrol.Size = new System.Drawing.Size(958, 640);
            this.Tabcontrol.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tabcontrol.TabIndex = 1;
            // 
            // tabItem
            // 
            this.tabItem.Controls.Add(this.panel1);
            this.tabItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabItem.ForeColor = System.Drawing.Color.White;
            this.tabItem.Location = new System.Drawing.Point(4, 26);
            this.tabItem.Name = "tabItem";
            this.tabItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabItem.Size = new System.Drawing.Size(950, 610);
            this.tabItem.TabIndex = 0;
            this.tabItem.Text = "Items";
            this.tabItem.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lstitem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbcategory);
            this.panel1.Controls.Add(this.grpitemdetail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 604);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudquantity);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(557, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 169);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // nudquantity
            // 
            this.nudquantity.ForeColor = System.Drawing.Color.Black;
            this.nudquantity.Location = new System.Drawing.Point(47, 77);
            this.nudquantity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudquantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudquantity.Name = "nudquantity";
            this.nudquantity.Size = new System.Drawing.Size(113, 21);
            this.nudquantity.TabIndex = 1;
            this.nudquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudquantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(52, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Quantity";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdodelivery);
            this.groupBox2.Controls.Add(this.rdotakeaway);
            this.groupBox2.Controls.Add(this.rdodinin);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(307, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 172);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // rdodelivery
            // 
            this.rdodelivery.AutoSize = true;
            this.rdodelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdodelivery.ForeColor = System.Drawing.Color.Black;
            this.rdodelivery.Location = new System.Drawing.Point(22, 129);
            this.rdodelivery.Name = "rdodelivery";
            this.rdodelivery.Size = new System.Drawing.Size(76, 19);
            this.rdodelivery.TabIndex = 3;
            this.rdodelivery.TabStop = true;
            this.rdodelivery.Text = "Delivery";
            this.rdodelivery.UseVisualStyleBackColor = true;
            // 
            // rdotakeaway
            // 
            this.rdotakeaway.AutoSize = true;
            this.rdotakeaway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdotakeaway.ForeColor = System.Drawing.Color.Black;
            this.rdotakeaway.Location = new System.Drawing.Point(21, 92);
            this.rdotakeaway.Name = "rdotakeaway";
            this.rdotakeaway.Size = new System.Drawing.Size(92, 19);
            this.rdotakeaway.TabIndex = 2;
            this.rdotakeaway.TabStop = true;
            this.rdotakeaway.Text = "Take Away";
            this.rdotakeaway.UseVisualStyleBackColor = true;
            // 
            // rdodinin
            // 
            this.rdodinin.AutoSize = true;
            this.rdodinin.BackColor = System.Drawing.Color.Snow;
            this.rdodinin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdodinin.ForeColor = System.Drawing.Color.Black;
            this.rdodinin.Location = new System.Drawing.Point(21, 54);
            this.rdodinin.Name = "rdodinin";
            this.rdodinin.Size = new System.Drawing.Size(71, 19);
            this.rdodinin.TabIndex = 1;
            this.rdodinin.TabStop = true;
            this.rdodinin.Text = "Dine In";
            this.rdodinin.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Order Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chksauce);
            this.groupBox1.Controls.Add(this.chkonion);
            this.groupBox1.Controls.Add(this.chkextra);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(57, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 172);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // chksauce
            // 
            this.chksauce.AutoSize = true;
            this.chksauce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksauce.ForeColor = System.Drawing.Color.Black;
            this.chksauce.Location = new System.Drawing.Point(10, 130);
            this.chksauce.Name = "chksauce";
            this.chksauce.Size = new System.Drawing.Size(66, 19);
            this.chksauce.TabIndex = 15;
            this.chksauce.Text = "Sauce";
            this.chksauce.UseVisualStyleBackColor = true;
            // 
            // chkonion
            // 
            this.chkonion.AutoSize = true;
            this.chkonion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkonion.ForeColor = System.Drawing.Color.Black;
            this.chkonion.Location = new System.Drawing.Point(10, 93);
            this.chkonion.Name = "chkonion";
            this.chkonion.Size = new System.Drawing.Size(88, 19);
            this.chkonion.TabIndex = 14;
            this.chkonion.Text = "NO Onion";
            this.chkonion.UseVisualStyleBackColor = true;
            // 
            // chkextra
            // 
            this.chkextra.AutoSize = true;
            this.chkextra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkextra.ForeColor = System.Drawing.Color.Black;
            this.chkextra.Location = new System.Drawing.Point(10, 55);
            this.chkextra.Name = "chkextra";
            this.chkextra.Size = new System.Drawing.Size(111, 19);
            this.chkextra.TabIndex = 13;
            this.chkextra.Text = "Extra Cheese";
            this.chkextra.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Additions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(34, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(53, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Available Item";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(475, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 11;
            // 
            // lstitem
            // 
            this.lstitem.ForeColor = System.Drawing.Color.Black;
            this.lstitem.FormattingEnabled = true;
            this.lstitem.ItemHeight = 15;
            this.lstitem.Location = new System.Drawing.Point(57, 161);
            this.lstitem.Name = "lstitem";
            this.lstitem.Size = new System.Drawing.Size(225, 139);
            this.lstitem.TabIndex = 3;
            this.lstitem.SelectedIndexChanged += new System.EventHandler(this.lstitem_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(53, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "category";
            // 
            // cmbcategory
            // 
            this.cmbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcategory.ForeColor = System.Drawing.Color.Black;
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Items.AddRange(new object[] {
            "Appetizers",
            "Main Course",
            "Drinks",
            "Desserts"});
            this.cmbcategory.Location = new System.Drawing.Point(57, 65);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(225, 23);
            this.cmbcategory.TabIndex = 1;
            this.cmbcategory.SelectedIndexChanged += new System.EventHandler(this.cmbcategory_SelectedIndexChanged);
            // 
            // grpitemdetail
            // 
            this.grpitemdetail.BackColor = System.Drawing.Color.White;
            this.grpitemdetail.Controls.Add(this.btnnew);
            this.grpitemdetail.Controls.Add(this.picitem);
            this.grpitemdetail.Controls.Add(this.btnadd);
            this.grpitemdetail.Controls.Add(this.txtava);
            this.grpitemdetail.Controls.Add(this.lblava);
            this.grpitemdetail.Controls.Add(this.txtdesc);
            this.grpitemdetail.Controls.Add(this.label2);
            this.grpitemdetail.Controls.Add(this.txtprice);
            this.grpitemdetail.Controls.Add(this.label1);
            this.grpitemdetail.Controls.Add(this.txtname);
            this.grpitemdetail.Controls.Add(this.lblname);
            this.grpitemdetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpitemdetail.ForeColor = System.Drawing.Color.Black;
            this.grpitemdetail.Location = new System.Drawing.Point(339, 24);
            this.grpitemdetail.Name = "grpitemdetail";
            this.grpitemdetail.Size = new System.Drawing.Size(509, 285);
            this.grpitemdetail.TabIndex = 0;
            this.grpitemdetail.TabStop = false;
            this.grpitemdetail.Text = "Item Details";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.White;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.Black;
            this.btnnew.Location = new System.Drawing.Point(45, 200);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(108, 38);
            this.btnnew.TabIndex = 11;
            this.btnnew.Text = "New Item";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // picitem
            // 
            this.picitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picitem.Image = global::Employee_System.Properties.Resources.pizza;
            this.picitem.Location = new System.Drawing.Point(23, 38);
            this.picitem.Name = "picitem";
            this.picitem.Size = new System.Drawing.Size(130, 93);
            this.picitem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picitem.TabIndex = 10;
            this.picitem.TabStop = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.White;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(45, 154);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(108, 40);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Add Item ";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.BackColorChanged += new System.EventHandler(this.btnadd_Click);
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtava
            // 
            this.txtava.Location = new System.Drawing.Point(320, 224);
            this.txtava.Name = "txtava";
            this.txtava.ReadOnly = true;
            this.txtava.Size = new System.Drawing.Size(159, 23);
            this.txtava.TabIndex = 7;
            // 
            // lblava
            // 
            this.lblava.AutoSize = true;
            this.lblava.ForeColor = System.Drawing.Color.Black;
            this.lblava.Location = new System.Drawing.Point(198, 231);
            this.lblava.Name = "lblava";
            this.lblava.Size = new System.Drawing.Size(74, 17);
            this.lblava.TabIndex = 6;
            this.lblava.Text = "Available";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(320, 147);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.ReadOnly = true;
            this.txtdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdesc.Size = new System.Drawing.Size(159, 60);
            this.txtdesc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(198, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(320, 89);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(159, 23);
            this.txtprice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(198, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(320, 38);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(159, 23);
            this.txtname.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.ForeColor = System.Drawing.Color.Black;
            this.lblname.Location = new System.Drawing.Point(198, 47);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(54, 17);
            this.lblname.TabIndex = 0;
            this.lblname.Text = " Name";
            // 
            // tabcurrent
            // 
            this.tabcurrent.Controls.Add(this.txttotal);
            this.tabcurrent.Controls.Add(this.txttax);
            this.tabcurrent.Controls.Add(this.txtsub);
            this.tabcurrent.Controls.Add(this.btnclear);
            this.tabcurrent.Controls.Add(this.btnremove);
            this.tabcurrent.Controls.Add(this.dgcurrentorder);
            this.tabcurrent.Location = new System.Drawing.Point(4, 26);
            this.tabcurrent.Name = "tabcurrent";
            this.tabcurrent.Padding = new System.Windows.Forms.Padding(3);
            this.tabcurrent.Size = new System.Drawing.Size(950, 610);
            this.tabcurrent.TabIndex = 1;
            this.tabcurrent.Text = "Current Order";
            this.tabcurrent.UseVisualStyleBackColor = true;
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.White;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.Color.Black;
            this.txttotal.Location = new System.Drawing.Point(352, 525);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(182, 29);
            this.txttotal.TabIndex = 5;
            this.txttotal.Text = "Total :0.00JD ";
            // 
            // txttax
            // 
            this.txttax.BackColor = System.Drawing.Color.White;
            this.txttax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttax.ForeColor = System.Drawing.Color.Black;
            this.txttax.Location = new System.Drawing.Point(540, 525);
            this.txttax.Name = "txttax";
            this.txttax.Size = new System.Drawing.Size(182, 29);
            this.txttax.TabIndex = 4;
            this.txttax.Text = "Tax: 0.00JD";
            // 
            // txtsub
            // 
            this.txtsub.BackColor = System.Drawing.Color.White;
            this.txtsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsub.ForeColor = System.Drawing.Color.Black;
            this.txtsub.Location = new System.Drawing.Point(728, 525);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(182, 29);
            this.txtsub.TabIndex = 3;
            this.txtsub.Text = "SubTotal: 0.00JD";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.White;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Black;
            this.btnclear.Location = new System.Drawing.Point(64, 522);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(138, 36);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear Order";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.White;
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.Color.Black;
            this.btnremove.Location = new System.Drawing.Point(208, 522);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(138, 36);
            this.btnremove.TabIndex = 1;
            this.btnremove.Text = "Remove Ordet";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // dgcurrentorder
            // 
            this.dgcurrentorder.AllowUserToAddRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgcurrentorder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgcurrentorder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgcurrentorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcurrentorder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Itemdatagride,
            this.Quantitydatagrid,
            this.Extra,
            this.Price,
            this.Total});
            this.dgcurrentorder.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcurrentorder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgcurrentorder.GridColor = System.Drawing.Color.SlateGray;
            this.dgcurrentorder.Location = new System.Drawing.Point(76, 61);
            this.dgcurrentorder.Name = "dgcurrentorder";
            this.dgcurrentorder.RowHeadersWidth = 51;
            this.dgcurrentorder.RowTemplate.Height = 24;
            this.dgcurrentorder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgcurrentorder.Size = new System.Drawing.Size(791, 420);
            this.dgcurrentorder.TabIndex = 0;
            // 
            // Itemdatagride
            // 
            this.Itemdatagride.HeaderText = "Item";
            this.Itemdatagride.MinimumWidth = 6;
            this.Itemdatagride.Name = "Itemdatagride";
            // 
            // Quantitydatagrid
            // 
            this.Quantitydatagrid.HeaderText = "Quantity";
            this.Quantitydatagrid.MinimumWidth = 6;
            this.Quantitydatagrid.Name = "Quantitydatagrid";
            // 
            // Extra
            // 
            this.Extra.HeaderText = "Extra";
            this.Extra.MinimumWidth = 6;
            this.Extra.Name = "Extra";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // tabHill
            // 
            this.tabHill.Controls.Add(this.pnlRestauranthall);
            this.tabHill.ForeColor = System.Drawing.Color.Blue;
            this.tabHill.Location = new System.Drawing.Point(4, 26);
            this.tabHill.Name = "tabHill";
            this.tabHill.Padding = new System.Windows.Forms.Padding(3);
            this.tabHill.Size = new System.Drawing.Size(950, 610);
            this.tabHill.TabIndex = 3;
            this.tabHill.Text = "Hall Map";
            this.tabHill.UseVisualStyleBackColor = true;
            // 
            // pnlRestauranthall
            // 
            this.pnlRestauranthall.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlRestauranthall.Controls.Add(this.btnT10);
            this.pnlRestauranthall.Controls.Add(this.btnT9);
            this.pnlRestauranthall.Controls.Add(this.btnT8);
            this.pnlRestauranthall.Controls.Add(this.btnT2);
            this.pnlRestauranthall.Controls.Add(this.btnT3);
            this.pnlRestauranthall.Controls.Add(this.btnT4);
            this.pnlRestauranthall.Controls.Add(this.btnT5);
            this.pnlRestauranthall.Controls.Add(this.btnT6);
            this.pnlRestauranthall.Controls.Add(this.btnT7);
            this.pnlRestauranthall.Controls.Add(this.btnT1);
            this.pnlRestauranthall.Controls.Add(this.btnacc);
            this.pnlRestauranthall.Controls.Add(this.btnreserve);
            this.pnlRestauranthall.Controls.Add(this.btnavailable);
            this.pnlRestauranthall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRestauranthall.Location = new System.Drawing.Point(3, 3);
            this.pnlRestauranthall.Name = "pnlRestauranthall";
            this.pnlRestauranthall.Size = new System.Drawing.Size(944, 604);
            this.pnlRestauranthall.TabIndex = 0;
            // 
            // btnT10
            // 
            this.btnT10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnT10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT10.ForeColor = System.Drawing.Color.Black;
            this.btnT10.Location = new System.Drawing.Point(667, 495);
            this.btnT10.Name = "btnT10";
            this.btnT10.Size = new System.Drawing.Size(131, 69);
            this.btnT10.TabIndex = 12;
            this.btnT10.Text = "T10";
            this.btnT10.UseVisualStyleBackColor = false;
            this.btnT10.Click += new System.EventHandler(this.btnT10_Click);
            // 
            // btnT9
            // 
            this.btnT9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnT9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT9.ForeColor = System.Drawing.Color.Black;
            this.btnT9.Location = new System.Drawing.Point(215, 363);
            this.btnT9.Name = "btnT9";
            this.btnT9.Size = new System.Drawing.Size(131, 69);
            this.btnT9.TabIndex = 11;
            this.btnT9.Text = "T9";
            this.btnT9.UseVisualStyleBackColor = false;
            this.btnT9.Click += new System.EventHandler(this.btnT9_Click);
            // 
            // btnT8
            // 
            this.btnT8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnT8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT8.ForeColor = System.Drawing.Color.Black;
            this.btnT8.Location = new System.Drawing.Point(536, 363);
            this.btnT8.Name = "btnT8";
            this.btnT8.Size = new System.Drawing.Size(131, 69);
            this.btnT8.TabIndex = 10;
            this.btnT8.Text = "T8";
            this.btnT8.UseVisualStyleBackColor = false;
            this.btnT8.Click += new System.EventHandler(this.btnT8_Click);
            // 
            // btnT2
            // 
            this.btnT2.BackColor = System.Drawing.Color.Red;
            this.btnT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT2.ForeColor = System.Drawing.Color.Black;
            this.btnT2.Location = new System.Drawing.Point(215, 97);
            this.btnT2.Name = "btnT2";
            this.btnT2.Size = new System.Drawing.Size(131, 69);
            this.btnT2.TabIndex = 9;
            this.btnT2.Text = "T2";
            this.btnT2.UseVisualStyleBackColor = false;
            this.btnT2.Click += new System.EventHandler(this.btnT2_Click);
            // 
            // btnT3
            // 
            this.btnT3.BackColor = System.Drawing.Color.Red;
            this.btnT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT3.ForeColor = System.Drawing.Color.Black;
            this.btnT3.Location = new System.Drawing.Point(526, 97);
            this.btnT3.Name = "btnT3";
            this.btnT3.Size = new System.Drawing.Size(131, 69);
            this.btnT3.TabIndex = 8;
            this.btnT3.Text = "T3";
            this.btnT3.UseVisualStyleBackColor = false;
            this.btnT3.Click += new System.EventHandler(this.btnT3_Click);
            // 
            // btnT4
            // 
            this.btnT4.BackColor = System.Drawing.Color.Yellow;
            this.btnT4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT4.ForeColor = System.Drawing.Color.Black;
            this.btnT4.Location = new System.Drawing.Point(383, 495);
            this.btnT4.Name = "btnT4";
            this.btnT4.Size = new System.Drawing.Size(138, 69);
            this.btnT4.TabIndex = 7;
            this.btnT4.Text = "T4";
            this.btnT4.UseVisualStyleBackColor = false;
            this.btnT4.Click += new System.EventHandler(this.btnT4_Click);
            // 
            // btnT5
            // 
            this.btnT5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnT5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT5.ForeColor = System.Drawing.Color.Black;
            this.btnT5.Location = new System.Drawing.Point(69, 224);
            this.btnT5.Name = "btnT5";
            this.btnT5.Size = new System.Drawing.Size(131, 69);
            this.btnT5.TabIndex = 6;
            this.btnT5.Text = "T5";
            this.btnT5.UseVisualStyleBackColor = false;
            this.btnT5.Click += new System.EventHandler(this.btnT5_Click);
            // 
            // btnT6
            // 
            this.btnT6.BackColor = System.Drawing.Color.Yellow;
            this.btnT6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT6.ForeColor = System.Drawing.Color.Black;
            this.btnT6.Location = new System.Drawing.Point(383, 224);
            this.btnT6.Name = "btnT6";
            this.btnT6.Size = new System.Drawing.Size(131, 69);
            this.btnT6.TabIndex = 5;
            this.btnT6.Text = "T6";
            this.btnT6.UseVisualStyleBackColor = false;
            this.btnT6.Click += new System.EventHandler(this.btnT6_Click);
            // 
            // btnT7
            // 
            this.btnT7.BackColor = System.Drawing.Color.Yellow;
            this.btnT7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT7.ForeColor = System.Drawing.Color.Black;
            this.btnT7.Location = new System.Drawing.Point(705, 224);
            this.btnT7.Name = "btnT7";
            this.btnT7.Size = new System.Drawing.Size(131, 69);
            this.btnT7.TabIndex = 4;
            this.btnT7.Text = "T7";
            this.btnT7.UseVisualStyleBackColor = false;
            this.btnT7.Click += new System.EventHandler(this.btnT7_Click);
            // 
            // btnT1
            // 
            this.btnT1.BackColor = System.Drawing.Color.Yellow;
            this.btnT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT1.ForeColor = System.Drawing.Color.Black;
            this.btnT1.Location = new System.Drawing.Point(102, 495);
            this.btnT1.Name = "btnT1";
            this.btnT1.Size = new System.Drawing.Size(131, 69);
            this.btnT1.TabIndex = 3;
            this.btnT1.Text = "T1";
            this.btnT1.UseVisualStyleBackColor = false;
            this.btnT1.Click += new System.EventHandler(this.btnT1_Click);
            // 
            // btnacc
            // 
            this.btnacc.BackColor = System.Drawing.Color.Red;
            this.btnacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacc.ForeColor = System.Drawing.Color.Black;
            this.btnacc.Location = new System.Drawing.Point(559, 16);
            this.btnacc.Name = "btnacc";
            this.btnacc.Size = new System.Drawing.Size(108, 34);
            this.btnacc.TabIndex = 2;
            this.btnacc.Text = "Occupied";
            this.btnacc.UseVisualStyleBackColor = false;
            // 
            // btnreserve
            // 
            this.btnreserve.BackColor = System.Drawing.Color.Yellow;
            this.btnreserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreserve.ForeColor = System.Drawing.Color.Black;
            this.btnreserve.Location = new System.Drawing.Point(373, 16);
            this.btnreserve.Name = "btnreserve";
            this.btnreserve.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnreserve.Size = new System.Drawing.Size(108, 34);
            this.btnreserve.TabIndex = 1;
            this.btnreserve.Text = "Reserved";
            this.btnreserve.UseVisualStyleBackColor = false;
            // 
            // btnavailable
            // 
            this.btnavailable.BackColor = System.Drawing.Color.ForestGreen;
            this.btnavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnavailable.ForeColor = System.Drawing.Color.Black;
            this.btnavailable.Location = new System.Drawing.Point(205, 16);
            this.btnavailable.Name = "btnavailable";
            this.btnavailable.Size = new System.Drawing.Size(108, 34);
            this.btnavailable.TabIndex = 0;
            this.btnavailable.Text = "Available";
            this.btnavailable.UseVisualStyleBackColor = false;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Itemgrad
            // 
            this.Itemgrad.HeaderText = "Item";
            this.Itemgrad.MinimumWidth = 6;
            this.Itemgrad.Name = "Itemgrad";
            this.Itemgrad.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Itemgrade
            // 
            this.Itemgrade.HeaderText = "Item";
            this.Itemgrade.MinimumWidth = 6;
            this.Itemgrade.Name = "Itemgrade";
            this.Itemgrade.Width = 125;
            // 
            // Quantitygrad
            // 
            this.Quantitygrad.HeaderText = "Quantity";
            this.Quantitygrad.MinimumWidth = 6;
            this.Quantitygrad.Name = "Quantitygrad";
            this.Quantitygrad.Width = 125;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(982, 707);
            this.Controls.Add(this.Tabcontrol);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Restaurant Managment System";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Tabcontrol.ResumeLayout(false);
            this.tabItem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudquantity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpitemdetail.ResumeLayout(false);
            this.grpitemdetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picitem)).EndInit();
            this.tabcurrent.ResumeLayout(false);
            this.tabcurrent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcurrentorder)).EndInit();
            this.tabHill.ResumeLayout(false);
            this.pnlRestauranthall.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenu;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem itemToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TabControl Tabcontrol;
        private TabPage tabItem;
        private TabPage tabcurrent;
        private Panel panel1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private CheckBox chksauce;
        private CheckBox chkonion;
        private CheckBox chkextra;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private ListBox lstitem;
        private Label label4;
        private ComboBox cmbcategory;
        private GroupBox grpitemdetail;
        private Button btnadd;
        private TextBox txtava;
        private Label lblava;
        private TextBox txtdesc;
        private Label label2;
        private TextBox txtprice;
        private Label label1;
        private TextBox txtname;
        private Label lblname;
        private RadioButton rdodelivery;
        private RadioButton rdotakeaway;
        private RadioButton rdodinin;
        private Label label8;
        private GroupBox groupBox3;
        private NumericUpDown nudquantity;
        private Label label10;
        private PictureBox picitem;
        private DataGridView dgcurrentorder;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Itemgrade;
        private DataGridViewTextBoxColumn Quantitygrad;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Itemgrad;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Column3;
        private Button btnclear;
        private Button btnremove;
        private TabPage tabHill;
        private Panel pnlRestauranthall;
        private DataGridViewTextBoxColumn Itemdatagride;
        private DataGridViewTextBoxColumn Quantitydatagrid;
        private DataGridViewTextBoxColumn Extra;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Total;
        private ToolStripMenuItem toolStripMenuItem1;
        private TextBox txttotal;
        private TextBox txttax;
        private TextBox txtsub;
        private Button btnnew;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem salesReportToolStripMenuItem;
        private ToolStripMenuItem addItemToolStripMenuItem;
        private ToolStripMenuItem newItemToolStripMenuItem;
        private ToolStripMenuItem currentOrderToolStripMenuItem;
        private Button btnacc;
        private Button btnreserve;
        private Button btnavailable;
        private Button btnT10;
        private Button btnT9;
        private Button btnT8;
        private Button btnT2;
        private Button btnT3;
        private Button btnT4;
        private Button btnT5;
        private Button btnT6;
        private Button btnT7;
        private Button btnT1;
    }
}