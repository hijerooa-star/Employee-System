using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_System
{
    public partial class Form2 : Form
    {
        public object Tabcontrol1 { get; private set; }

        public Form2()
        {
            InitializeComponent();

            dgcurrentorder.DefaultCellStyle.ForeColor = Color.Black;
            dgcurrentorder.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        // Category
        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstitem.Items.Clear();

            if (cmbcategory.SelectedItem == null)
                return;

            string category = cmbcategory.SelectedItem.ToString();

            if (category == "Appetizers")
            {
                lstitem.Items.Add("Greek Salad");
                lstitem.Items.Add("French Fries");
                lstitem.Items.Add("Chicken Wings");
            }
            else if (category == "Main Course")
            {
                lstitem.Items.Add("Chicken Burger");
                lstitem.Items.Add("Pizza");
                lstitem.Items.Add("Pasta");
            }
            else if (category == "Drinks")
            {
                lstitem.Items.Add("Cola");
                lstitem.Items.Add("Orange Juice");
                lstitem.Items.Add("Water");
            }
            else if (category == "Desserts")
            {
                lstitem.Items.Add("Cake");
                lstitem.Items.Add("Ice Cream");
                lstitem.Items.Add("Cheesecake");
            }
        }

        // Item details
        private void lstitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstitem.SelectedItem == null)
                return;

            string item = lstitem.SelectedItem.ToString();

            txtname.Text = item;

            if (item == "Chicken Burger")
                txtprice.Text = "5.00";
            else if (item == "Pizza")
                txtprice.Text = "6.00";
            else if (item == "Pasta")
                txtprice.Text = "5.50";
            else if (item == "Greek Salad")
                txtprice.Text = "3.00";
            else if (item == "French Fries")
                txtprice.Text = "2.00";
            else if (item == "Chicken Wings")
                txtprice.Text = "4.50";
            else if (item == "Cola")
                txtprice.Text = "1.00";
            else if (item == "Orange Juice")
                txtprice.Text = "1.50";
            else if (item == "Water")
                txtprice.Text = "0.50";
            else if (item == "Cake")
                txtprice.Text = "2.50";
            else if (item == "Ice Cream")
                txtprice.Text = "2.00";
            else if (item == "Cheesecake")
                txtprice.Text = "3.00";

            if (item == "Chicken Burger")
                txtdesc.Text = "Chicken burger with cheese";
            else if (item == "Pizza")
                txtdesc.Text = "Fresh cheese pizza";
            else if (item == "Pasta")
                txtdesc.Text = "Creamy pasta";
            else if (item == "Greek Salad")
                txtdesc.Text = "Fresh Greek salad";
            else if (item == "French Fries")
                txtdesc.Text = "Crispy French fries";
            else if (item == "Chicken Wings")
                txtdesc.Text = "Crispy chicken wings";
            else if (item == "Cola")
                txtdesc.Text = "Cold soft drink";
            else if (item == "Orange Juice")
                txtdesc.Text = "Fresh orange juice";
            else if (item == "Water")
                txtdesc.Text = "Mineral water";
            else if (item == "Cake")
                txtdesc.Text = "Chocolate cake";
            else if (item == "Ice Cream")
                txtdesc.Text = "Vanilla ice cream";
            else if (item == "Cheesecake")
                txtdesc.Text = "Creamy cheesecake";

            if (item == "Cheesecake" || item == "Cola")
                txtava.Text = "No";
            else
                txtava.Text = "Yes";

            if (item == "Chicken Burger")
                picitem.Image = Properties.Resources.Chicken_Burger;
            else if (item == "Pizza")
                picitem.Image = Properties.Resources.pizza;
            else if (item == "Pasta")
                picitem.Image = Properties.Resources.pasta;
            else if (item == "Greek Salad")
                picitem.Image = Properties.Resources.Salad;
            else if (item == "French Fries")
                picitem.Image = Properties.Resources.French_Fries;
            else if (item == "Chicken Wings")
                picitem.Image = Properties.Resources.Chicken_wings;
            else if (item == "Cola")
                picitem.Image = Properties.Resources.cola;
            else if (item == "Orange Juice")
                picitem.Image = Properties.Resources.Juice;
            else if (item == "Water")
                picitem.Image = Properties.Resources.water;
            else if (item == "Cake")
                picitem.Image = Properties.Resources.cake;
            else if (item == "Ice Cream")
                picitem.Image = Properties.Resources.ice_cream;
            else if (item == "Cheesecake")
                picitem.Image = Properties.Resources.cheesecake;
        }

        // Add item
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (lstitem.SelectedItem == null)
            {
                MessageBox.Show("Please select an item.");
                return;
            }

            string extra = "";

            if (chkextra.Checked)
                extra += "Extra Cheese ";

            if (chksauce.Checked)
                extra += "Sauce ";

            if (chkonion.Checked)
                extra += "No Onion";

            if (extra == "")
                extra = "None";

            int quantity = (int)nudquantity.Value;
            decimal price = decimal.Parse(txtprice.Text);
            decimal total = price * quantity;

            dgcurrentorder.Rows.Add(
                txtname.Text,
                quantity,
                extra,
                price,
                total
            );

            CalculateTotal();
        }

        // Clear order
        private void btnclear_Click(object sender, EventArgs e)
        {
            dgcurrentorder.Rows.Clear();

            txtsub.Text = "Subtotal: 0.00";
            txttax.Text = "Tax: 0.00";
            txttotal.Text = "Total: 0.00";
        }

        // Calculate
        private void CalculateTotal()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dgcurrentorder.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    subtotal += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }

            decimal tax = subtotal * 0.16m;
            decimal total = subtotal + tax;

            txtsub.Text = "Subtotal: " + subtotal.ToString("0.00");
            txttax.Text = "Tax: " + tax.ToString("0.00");
            txttotal.Text = "Total: " + total.ToString("0.00");
        }

        // Remove
        private void btnremove_Click(object sender, EventArgs e)
        {
            if (dgcurrentorder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            foreach (DataGridViewRow row in dgcurrentorder.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dgcurrentorder.Rows.Remove(row);
                }
            }

            CalculateTotal();
        }

        // New item
        private void btnnew_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtprice.Clear();
            txtdesc.Clear();

            cmbcategory.SelectedIndex = -1;
            lstitem.Items.Clear();

            txtava.Text = "Yes";
            picitem.Image = null;
            nudquantity.Value = 1;

            chkextra.Checked = false;
            chksauce.Checked = false;
            chkonion.Checked = false;
        }

        // Menu strip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
     
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
       "SYSTEM INFORMATION\n\n" +
       "Restaurant Ordering System\n\n" +
       "This system helps employees manage restaurant items, " +
       "create and review customer orders, and view sales information.\n\n" +
       "The system is designed to make order management " +
       "simple, fast, and organized.",
       "Help - System Information");
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnadd.PerformClick();

        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnnew.PerformClick();

        }

        private void currentOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabcontrol.SelectedTab = tabcurrent;

        }

            private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal totalSales = 0;
            int totalItems = 0;

            foreach (DataGridViewRow row in dgcurrentorder.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells["Quantity"].Value != null)
                        totalItems += Convert.ToInt32(row.Cells["Quantity"].Value);

                    if (row.Cells["Total"].Value != null)
                        totalSales += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }

            MessageBox.Show(
                "SALES REPORT\n\n" +
                "Total Items Sold: " + totalItems + "\n" +
                "Total Sales: " + totalSales.ToString("0.00") + " JD",
                "Sales Report");
        }
        private void MakeOval(Button btn)
        {
            System.Drawing.Drawing2D.GraphicsPath path =
                new System.Drawing.Drawing2D.GraphicsPath();

            path.AddEllipse(0, 0, btn.Width, btn.Height);

            btn.Region = new Region(path);
        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            // tabel buttons shape
            MakeOval(btnT1);
            MakeOval(btnT2);
            MakeOval(btnT3);
            MakeOval(btnT4);
            MakeOval(btnT6);
            MakeOval(btnT7);
        }
        private void ChangeTableStatus(Button table)
        {
            if (table.BackColor == Color.Green)
            {
                // Available → Reserved
                table.BackColor = Color.Red;
            }
            else if (table.BackColor == Color.Red)
            {
                // Reserved → Occupied
                table.BackColor = Color.Yellow;
            }
            else
            {
                // Occupied → Available
                table.BackColor = Color.Green;
            }
        }
            private void btnT1_Click(object sender, EventArgs e)
        {
            ChangeTableStatus(btnT1);
        }

        private void btnT2_Click(object sender, EventArgs e)
        {
            ChangeTableStatus(btnT2);
        }

        private void btnT3_Click(object sender, EventArgs e)
        {
            ChangeTableStatus(btnT3);
        }

        private void btnT4_Click(object sender, EventArgs e)
        {
            ChangeTableStatus(btnT4);
        }

        private void btnT5_Click(object sender, EventArgs e)
        {
            ChangeTableStatus(btnT5);
        }

        private void btnT6_Click(object sender, EventArgs e)
        {
            ChangeTableStatus(btnT6);
        }

        private void btnT7_Click(object sender, EventArgs e)
        {
            ChangeTableStatus(btnT7);
        }

        private void btnT8_Click(object sender, EventArgs e)
        {
            ChangeTableStatus(btnT8);
        }

        private void btnT9_Click(object sender, EventArgs e)
        {
            ChangeTableStatus(btnT9);
        }

        private void btnT10_Click(object sender, EventArgs e)
        {
            ChangeTableStatus(btnT10);
        }

    }
    
}