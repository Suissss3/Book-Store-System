using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace InventoryManagementSystem
{
    
    public partial class Form1 : Form
    {
        public static string username;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mikko\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();

            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showpass.Checked ? '\0' : '*';
        }
        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                try
                {

                    connect.Open();

                    string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Login Succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MainForm mForm = new MainForm();
                            mForm.Show();

                            this.Hide();
                        }

                        /*
                                                connect.Open();
                                                string selectData = "SELECT COUNT (*) FROM users WHERE username = @usern AND password = @pass";

                                                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                                                {
                                                    cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                                                    cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                                                    cmd.Parameters.AddWithValue("@status", "Active");

                                                    int rowCount = (int)cmd.ExecuteScalar();

                                                    if (rowCount > 0)
                                                    {
                                                        string selectRole = "SELECT role FROM users WHERE username = @usern AND password = @pass";

                                                        using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                                                        {
                                                            getRole.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                                                            getRole.Parameters.AddWithValue("@pass", login_password.Text.Trim());


                                                            string userRole = getRole.ExecuteScalar() as string;
                                                            MessageBox.Show("Login Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                            if (userRole == "Admin")
                                                            {
                                                                MainForm mForm = new MainForm();
                                                                mForm.Show();

                                                                this.Hide();
                                                            }
                                                            else
                                                            {
                                                                CashierMainForm cmForm = new CashierMainForm();
                                                                cmForm.Show();

                                                                this.Hide();
                                                            }
                                                        }
                                                    }*/
                        else
                        {
                            MessageBox.Show(
                                   "Incorrect Username/ Password or theres no Admin Approval", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                                  "Connection failed" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
                }
            }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showpass.Checked ? '\0' : '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


