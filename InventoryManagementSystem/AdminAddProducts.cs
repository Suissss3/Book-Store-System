﻿using System;
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
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Security.Policy;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics;

namespace InventoryManagementSystem
{
    public partial class AdminAddProducts : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mikko\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminAddProducts()
        {
            InitializeComponent();
            displayCategories();
            displayAllProductData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategories();
            displayAllProductData();
        }
        public void displayAllProductData()
        {
            AddProductData apData = new AddProductData();
            List<AddProductData> listData = apData.AllProductData();
            dataGridView1.DataSource = listData;
        }

        public bool emptyFields()
        {
            if (addProducts_prodID.Text == "" || addProducts_prodName.Text == "" || addProducts_category.SelectedIndex == -1 || addProducts_price.Text == "" || addProducts_stock.Text == "" || addProducts_status.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayCategories()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM categories";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader= cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                addProducts_category.Items.Add(reader["category"].ToString());
                            }
                        }
                    }
                }catch(Exception ex)
                {

                } 
                finally
                {
                    connect.Close();
                }
            }
        }

        private void addProducts_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
                 if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM products WHERE prod_id = @prodID";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if(table.Rows.Count > 0)
                        {
                            MessageBox.Show("Product ID: " + addProducts_prodID.Text.Trim() + " already exists","Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }else
                        {
                            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                            string relativePath = Path.Combine("Product_Directory",addProducts_prodID.Text.Trim() + ".jpg");
                            string path = Path.Combine(baseDirectory, relativePath);

                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);   
                            }
                            File.Copy(addProducts_imageView.ImageLocation, path, true);

                            string insertData = "INSERT INTO products" + "(prod_id,prod_name,category,price,stock,image_path,status,date_insert)" +
                                "VALUES(@prodID,@prodName,@cat,@price,@stock,@path,@status,@date)";

                            using(SqlCommand insertD = new SqlCommand(insertData, connect))
                            {
                                insertD.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                                insertD.Parameters.AddWithValue("@prodName", addProducts_prodName.Text.Trim());
                                insertD.Parameters.AddWithValue("@cat", addProducts_category.SelectedItem);
                                insertD.Parameters.AddWithValue("@price", addProducts_price.Text.Trim());
                                insertD.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                                insertD.Parameters.AddWithValue("@path", path);
                                insertD.Parameters.AddWithValue("@status", addProducts_status.SelectedItem);

                                DateTime today = DateTime.Today;
                                insertD.Parameters.AddWithValue("@date", today);

                                insertD.ExecuteNonQuery();
                                clearFields();
                                    displayAllProductData();

                                MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                MessageBox.Show("Failed Connection" + ex ,"Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (connect.State != ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void addProducts_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *png)|*.jpg;*.png";
                string imagePath = "";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath =dialog.FileName;
                    addProducts_imageView.ImageLocation = imagePath;
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clearFields()
        {
            addProducts_prodID.Text = "";
            addProducts_prodName.Text = "";
            addProducts_category.SelectedIndex = -1;
            addProducts_price.Text = "";
            addProducts_stock.Text = "";
            addProducts_status.SelectedIndex = -1;
            addProducts_imageView.Image = null;
        }

        private void addProducts_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;

                addProducts_prodID.Text = row.Cells[1].Value.ToString();
                addProducts_prodName.Text = row.Cells[2].Value.ToString();
                addProducts_category.SelectedText = row.Cells[3].Value.ToString();
                addProducts_price.Text = row.Cells[4].Value.ToString();
                addProducts_stock.Text = row.Cells[5].Value.ToString();

                string imagepath = row.Cells[6].Value.ToString();
                try
                {
                    if (imagepath != null)
                    {
                        addProducts_imageView.Image = Image.FromFile(imagepath);    
                    }

                }catch(Exception ex)
                {
                    MessageBox.Show("Error Image" + ex, "Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                addProducts_status.Text = row.Cells[7].Value.ToString();
            }
        }

        private void addProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update ID?" + addProducts_prodID.Text.Trim() + "?","Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();
                       
                            string updateData = "UPDATE products SET prod_id =@prodID, prod_name =@prodName, category = @cat,price = @price,stock = @stock,status = @status WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodName", addProducts_prodName.Text.Trim());
                                updateD.Parameters.AddWithValue("@cat", addProducts_category.SelectedItem);
                                updateD.Parameters.AddWithValue("@price", addProducts_price.Text.Trim());
                                updateD.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.Parameters.AddWithValue("@status", addProducts_status.SelectedItem);

                                updateD.ExecuteNonQuery();
                                clearFields();
                                displayAllProductData();

                                MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed Connection" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
               
            }
        }

        private void addProducts_removeBtn_Click(object sender, EventArgs e)
        {
       
                if (MessageBox.Show("Are you sure you want to Delete ID: ?" + addProducts_prodID.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "DELETE FROM products WHERE id=@id";

                            using (SqlCommand deleteD = new SqlCommand(updateData, connect))
                            {
                                 deleteD.Parameters.AddWithValue("@id", getID);
                                 deleteD.ExecuteNonQuery();
                                clearFields();
                                displayAllProductData();

                                MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed Connection" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }

        private void addProducts_price_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

