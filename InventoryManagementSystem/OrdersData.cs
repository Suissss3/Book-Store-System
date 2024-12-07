using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    internal class OrdersData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mikko\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");

        public int ID { set; get; }
        public string CID { set; get;}
  
        public string Pname { set; get; }
        public string Category { set; get; }
        public string QTY { set; get; }
        public string OrigPrice { set; get; }
        public string TotalPrice { set; get; }
 

        public List<OrdersData> allOrdersData()
        {
            List<OrdersData> listData = new List<OrdersData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    int custID = 0;
                    string selectCustData = "SELECT MAX(customer_id) FROM orders";

                    using (SqlCommand cmd = new SqlCommand(selectCustData, connect))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int temp = Convert.ToInt32(result);
                            if (temp == 0)
                            {
                                custID = 1;
                            }
                            else
                            {
                                custID = temp;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error ID");
                        }
                    }
                    string selectData = "SELECT * FROM orders WHERE customer_id = @cID";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cID", custID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            OrdersData oData = new OrdersData();

                            oData.ID = (int)reader["id"];
                            oData.CID = reader["customer_id"].ToString();
                            oData.Pname = reader["prod_name"].ToString();
                            oData.Category = reader["category"].ToString();
                            oData.OrigPrice = reader["orig_price"].ToString();
                            oData.QTY = reader["qty"].ToString();
                            oData.TotalPrice = reader["total_price"].ToString();

                            listData.Add(oData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ConnectionFaile" + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }
    }
}


