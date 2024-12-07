using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class AdminDashboard : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\mikko\Documents\inventory.mdf;Integrated Security = True; Connect Timeout = 30");
        public AdminDashboard()
        {
            InitializeComponent();
            displayAllUsers();
            displayTodaysCustomers();
            displayTodayIncome();
            displayTotalIncome();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            InitializeComponent();
            displayAllUsers();
            displayTodaysCustomers();
            displayTodayIncome();
            displayTotalIncome();
        }

        public void displayTodaysCustomers()
        {
            CustomersData cData = new CustomersData();
            List<CustomersData> listData = cData.allTodaysCustomers();
            dataGridView1.DataSource = listData;
        }

        public bool checkConnection()
        {
            if(connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayAllUsers()
        {
            if(checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM customers";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if(reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AC.Text =count.ToString();    
                        }
                        reader.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Connection Failed"+ex,"Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayTodayIncome()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT SUM(total_price) FROM customers WHERE order_date = @date";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        DateTime today = DateTime.Today;
                        string getToday = today.ToString("yyyy-MM-dd");

                        cmd.Parameters.AddWithValue("@date", getToday);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            object value = reader[0];

                            if(value != DBNull.Value)
                            {
                                int count = Convert.ToInt32(reader[0]);
                                dashboard_TI.Text ="P" + count.ToString("0.00");
                            }
                            reader.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayTotalIncome()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT SUM(total_price) FROM customers";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                       
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {                        
                                int count = Convert.ToInt32(reader[0]);
                                dashboard_totalIncome.Text = "P" + count.ToString("0.00");
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_totalIncome_Click(object sender, EventArgs e)
        {

        }
    }
}
