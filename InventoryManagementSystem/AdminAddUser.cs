using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace InventoryManagementSystem
{
    public partial class AdminAddUser : UserControl
    {
        public AdminAddUser()
        {
            InitializeComponent();

            displayAllUsersData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAllUsersData();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mikko\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");

        public void displayAllUsersData()
        {
            UsersData uData = new UsersData();
            List<UsersData> listData = uData.AllUsersData();
            dataGridView1.DataSource = listData;
        }


        private void addUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == "" ||
                addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty Field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string checkUsername = "SELECT * FROM users WHERE username= @usern";
                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(addUsers_username.Text.Trim() +
                                    "is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username , password , role , status, date)" +
                           "VALUES(@usern,@pass,@role,@status,@date)";
                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@pass", addUsers_password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                                    insertD.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    displayAllUsersData();
                                    clearFields();
                                    MessageBox.Show("Added Successfully", "Information  Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed" + ex, "Error Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
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

        public void clearFields()
        {
            addUsers_username.Text = "";
            addUsers_password.Text = "";
            addUsers_role.SelectedIndex = -1;
            addUsers_status.SelectedIndex = -1;
        }
        private void addUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == "" ||
              addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty Field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update User ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();


                            string updateData = "UPDATE users SET username = @usern," +
                        "password = @pass,role = @role,status = @status WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                updateD.Parameters.AddWithValue("@pass", addUsers_password.Text.Trim());
                                updateD.Parameters.AddWithValue("@role", addUsers_role.SelectedItem);
                                updateD.Parameters.AddWithValue("@status", addUsers_status.SelectedItem);
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                clearFields();
                                displayAllUsersData();

                                MessageBox.Show("Updated Succefully!", "Information Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Failed" + ex, "Error Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }


            }
        }
        private int getID = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                string username = row.Cells[1].Value.ToString();
                string password = row.Cells[2].Value.ToString();
                string role = row.Cells[3].Value.ToString();
                string status = row.Cells[4].Value.ToString();
                string date = row.Cells[5].Value.ToString();

                addUsers_username.Text = username;
                addUsers_password.Text = password;
                addUsers_role.Text = role;
                addUsers_status.Text = status;

            }
        }

        private void addUsers_removeBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == "" ||
           addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty Field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Remove User ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();


                            string updateData = "DELETE FROM users WHERE id =@id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                clearFields();
                                displayAllUsersData();

                                MessageBox.Show("Deleted Succefully!", "Information Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Failed" + ex, "Error Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }
        }
    }
}


