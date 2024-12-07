using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace InventoryManagementSystem
{
    class UsersData
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string status { get; set; }
        public string date { get; set; }



        public List<UsersData> AllUsersData()
        {
            List<UsersData> listData = new List<UsersData>();

            using (SqlConnection connect = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\mikko\Documents\inventory.mdf;Integrated Security = True; Connect Timeout = 30"))
            {
                connect.Open();

                string selectData = "SELECT * FROM users";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        UsersData uData = new UsersData();
                        uData.id = (int)reader["id"];
                        uData.username = reader["username"].ToString();
                        uData.password = reader["password"].ToString();
                        uData.role = reader["role"].ToString();
                        uData.status = reader["status"].ToString();
                        uData.date = reader["date"].ToString();


                        listData.Add(uData);
                    }
                }
            }
            return listData;
        }
    }
}


