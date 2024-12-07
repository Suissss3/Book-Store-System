using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    internal class AddProductData
    {
        public int id { get; set; }
        public string ProdID { get; set; }
        public string ProdName { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Stock { get; set; }
        public string ImagePath { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }



        public List<AddProductData> AllProductData()
        {
            List<AddProductData> listData = new List<AddProductData>();

            using (SqlConnection connect = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\mikko\Documents\inventory.mdf;Integrated Security = True; Connect Timeout = 30"))
            {
                connect.Open();

                string selectData = "SELECT * FROM products";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        AddProductData apData = new AddProductData();
                        apData.id = (int)reader["id"];
                        apData.ProdID = reader["prod_id"].ToString();
                        apData.ProdName = reader["prod_name"].ToString();
                        apData.Category = reader["category"].ToString();
                        apData.Price = reader["price"].ToString();
                        apData.Stock = reader["stock"].ToString();
                        apData.ImagePath = reader["image_path"].ToString();
                        apData.Status = reader["status"].ToString();
                        apData.Date = reader["date_insert"].ToString();


                        listData.Add(apData);
                    }
                }
            }
            return listData;
        }
        public List<AddProductData> allAvailableProduct()
        {
            List<AddProductData>listData = new List<AddProductData>();
            using (SqlConnection connect = new SqlConnection
            (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\mikko\Documents\inventory.mdf;Integrated Security = True; Connect Timeout = 30"))
            {
                connect.Open();

                string selectData = "SELECT * FROM products WHERE status = @status";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@status", "Available");
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        AddProductData apData = new AddProductData();
                        apData.id = (int)reader["id"];
                        apData.ProdID = reader["prod_id"].ToString();
                        apData.ProdName = reader["prod_name"].ToString();
                        apData.Category = reader["category"].ToString();
                        apData.Price = reader["price"].ToString();
                        apData.Stock = reader["stock"].ToString();
                        apData.ImagePath = reader["image_path"].ToString();
                        apData.Status = reader["status"].ToString();
                        apData.Date = reader["date_insert"].ToString();


                        listData.Add(apData);
                    }
                }
            }
            return listData;
        }
    }
}
