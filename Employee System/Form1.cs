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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
                string username = txtusername.Text;
                string password = txtpassword.Text;


                if (username == "admin" && password == "123")
                {

                    Form2 main = new Form2();

                    main.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    

