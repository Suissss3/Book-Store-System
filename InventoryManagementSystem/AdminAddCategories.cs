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
    public partial class AdminAddCategories : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mikko\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");

        public AdminAddCategories()
        {
            InitializeComponent();
            displayAllCategoriesData();

        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAllCategoriesData();
        }
        public void displayAllCategoriesData()
        {
            CategoriesData cData = new CategoriesData();
            List<CategoriesData> listData = cData.AllCategoriesData();
            dataGridView1.DataSource = listData;
        }

        private void addCategories_addBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "")
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string checkCat = "SELECT * FROM categories WHERE category = @cat";

                        using(SqlCommand cmd = new SqlCommand(checkCat, connect)) 
                        {
                            cmd.Parameters.AddWithValue("@cat",addCategories_category.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if(table.Rows.Count > 0)
                            {
                                MessageBox.Show("Category: " + addCategories_category.Text.Trim()+ "already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO categories (category, date) VALUES (@cat ,@date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());
                                    DateTime now = DateTime.Now;
                                    insertD.Parameters.AddWithValue("@date", now);

                                    insertD.ExecuteNonQuery();
                                    clearFields();
                                    displayAllCategoriesData();
                                    

                                    MessageBox.Show("Added Succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Connection Failed " +ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                return true;
            else
                return false;
        }

        private void addCategories_category_TextChanged(object sender, EventArgs e)
        {

        }
    
        public void clearFields()
        {
            addCategories_category.Text = "";
        }
        private void addCategories_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;

                addCategories_category.Text = row.Cells[1].Value.ToString();
            }    
        }

        private void addCategories_updateBtn_Click(object sender, EventArgs e)
        {
                if (addCategories_category.Text == "")
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Are you sure you want to Update Cat ID?" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE categories SET category = @cat WHERE id = @id";

                            using (SqlCommand insertD = new SqlCommand(updateData, connect))
                            {
                                insertD.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());
                                insertD.Parameters.AddWithValue("id", getID);

                                insertD.ExecuteNonQuery();
                                clearFields();
                                displayAllCategoriesData();


                             MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                            }                        
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Failed " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
               
            }
        }

        private void addCategories_removeBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "")
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Remove Cat ID?" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string removeData = "DELETE FROM categories WHERE id = @id";

                            using (SqlCommand removeD = new SqlCommand(removeData, connect))
                            {
                                removeD.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());
                                removeD.Parameters.AddWithValue("id", getID);

                                removeD.ExecuteNonQuery();
                                clearFields();
                                displayAllCategoriesData();


                                MessageBox.Show("Removed Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Failed " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
