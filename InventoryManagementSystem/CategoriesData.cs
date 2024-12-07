using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    internal class CategoriesData
    {
        public int id { get; set; }
        public string category { get; set; }
        public string date { get; set; }
        public List<CategoriesData> AllCategoriesData()
        {
            List<CategoriesData> listData = new List<CategoriesData>();

            using (SqlConnection connect = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\mikko\Documents\inventory.mdf;Integrated Security = True; Connect Timeout = 30"))
            {
                connect.Open();

                string selectData = "SELECT * FROM categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CategoriesData cData = new CategoriesData();
                        cData.id = (int)reader["id"];
                        cData.category = reader["category"].ToString();
                        cData.date = reader["date"].ToString();


                        listData.Add(cData);
                    }
                }
            }
            return listData;
        }
    }
}
