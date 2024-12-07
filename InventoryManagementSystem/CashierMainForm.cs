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
    public partial class CashierMainForm : Form
    {

        public CashierMainForm()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to logout?","Confirmation Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;
            cashierOrder1.Visible = false;

            AdminDashboard adForm = adminDashboard1 as AdminDashboard;

            if (adForm != null)
            {
                adForm.refreshData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = true;
            cashierCustomersForm1.Visible = false;
            cashierOrder1.Visible = false;

            CashierCustomersForm ccfForm = cashierCustomersForm1 as CashierCustomersForm;
            AdminAddProducts aapForm = adminAddProducts1 as AdminAddProducts;

            if (aapForm != null)
            {
                aapForm.refreshData();
            }

        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = true;
            cashierOrder1.Visible = false;


            CashierCustomersForm ccfForm = cashierCustomersForm1 as CashierCustomersForm;

            if (ccfForm != null)
            {
                ccfForm.refreshData();
            }
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;
            cashierOrder1.Visible = true;

            CashierOrder coForm = cashierOrder1 as CashierOrder;

            if (coForm != null)
            {
                coForm.refreshData();
            }
        }

        private void adminDashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
