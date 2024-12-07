using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

   
        }

 
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddUser1.Visible = false;
            adminAddCategories1.Visible=false;
            adminAddProducts1.Visible=false;
            cashierCustomersForm1.Visible = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to Log out?","Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUser1.Visible = true;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;

            AdminDashboard adForm = adminDashboard1 as AdminDashboard;

            if (adForm != null)
            {
                adForm.refreshData();
            }
        }

        private void adminAddUser1_Load(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUser1.Visible = true;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;

            AdminAddUser aauForm = adminAddUser1 as AdminAddUser;

            if (aauForm != null)
            {
                aauForm.refreshData();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUser1.Visible = false;
            adminAddCategories1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;

            AdminAddCategories aacForm = adminAddCategories1 as AdminAddCategories;

            if (aacForm != null)
            {
                aacForm.refreshData();
            }
        }

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUser1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = true;
            cashierCustomersForm1.Visible = false;

            AdminAddProducts aapForm = adminAddProducts1 as AdminAddProducts;

            if (aapForm != null)
            {
                aapForm.refreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {

        }

        private void customers_btn_Click_1(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUser1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = true;
        }
    }
}
