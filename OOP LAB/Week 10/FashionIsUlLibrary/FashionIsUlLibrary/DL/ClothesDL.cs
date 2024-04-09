using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using FashionIsU.UI;
using FashionIsUlLibrary;

namespace FashionIsU
{
    public class ClothesDL:IClothesDL
    {
        //private static List<ClothesBL> TotalClothes = new List<ClothesBL> { };

        /*
        public static void AddClothes(ClothesBL c)
        {
            TotalClothes.Add(c);
        }

        */

        public bool AddClothes(ClothesBL c)
        {
            string connectiongString = ConsoleUtility.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("Insert into Clothes (Type, Gender, Color, Price, Quantity) Values('{0}', '{1}', '{2}', {3}, {4})", c.GetType(), c.GetGender(), c.GetColor(), c.GetPrice(), c.GetQuantity());
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();

            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
        public static bool CheckClothes()
        {
            return TotalClothes.Count > 0;
        }

        */

        public bool CheckClothes()
        {
            string connectiongString = ConsoleUtility.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("Select count(*) from Clothes");
            SqlCommand cmd = new SqlCommand(query, connection);
            int count = (int)cmd.ExecuteScalar();
            connection.Close();
            return count > 0;
        }

        /*
        public static ClothesBL FindClothByID(int id)
        {
            foreach(ClothesBL c in TotalClothes)
            {
                if(c.GetId() == id)
                {
                    return c;
                }
            }

            return null;
        }
        */
        public  ClothesBL FindClothByID(int id)
        {
            ClothesBL cloth = null;
            string connectionString = ConsoleUtility.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Clothes where ClothesId = @ClothesId";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ClothesId", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            int cID= Convert.ToInt32(reader["ClothesId"]);
                            string type = Convert.ToString(reader["Type"]);
                            string gender = Convert.ToString(reader["Gender"]);
                            string color = Convert.ToString(reader["Color"]);
                            int price = Convert.ToInt32(reader["Price"]);
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                           

                           cloth = new ClothesBL(cID, type, gender, color, price, quantity);
                            
                        }
                        connection.Close();
                    }
                }
            }

            return cloth;

            
        }

        public  void ChangeQuantity(int id, int quantity)
        {
            string connectionString = ConsoleUtility.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "Update Clothes Set Quantity = @quantity WHERE ClothesID = @clothID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@clothID", id);
                    cmd.Parameters.AddWithValue("@quantity", quantity);

                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public  void UpdateCloth(ClothesBL cloth)
        {
            string connectionString = ConsoleUtility.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "Update Clothes Set Type = @type, Gender = @gender, Color = @color, Price = @price, Quantity = @quantity WHERE ClothesID = @clothID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@clothID", cloth.GetId());
                    cmd.Parameters.AddWithValue("@quantity", cloth.GetQuantity());
                    cmd.Parameters.AddWithValue("@type", cloth.GetType());
                    cmd.Parameters.AddWithValue("@gender", cloth.GetGender());
                    cmd.Parameters.AddWithValue("@color", cloth.GetColor());
                    cmd.Parameters.AddWithValue("@price", cloth.GetPrice());

                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        /*
        public static List <ClothesBL> GetAllClothes()
        {
            return TotalClothes;
        }
        */

        public  List <ClothesBL> GetAllClothes()
        {
            List <ClothesBL> clothes = new List <ClothesBL>();
            string connectionString = ConsoleUtility.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Clothes";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
           
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            int cID = Convert.ToInt32(reader["ClothesId"]);
                            string type = Convert.ToString(reader["Type"]);
                            string gender = Convert.ToString(reader["Gender"]);
                            string color = Convert.ToString(reader["Color"]);
                            int price = Convert.ToInt32(reader["Price"]);
                            int quantity = Convert.ToInt32(reader["Quantity"]);


                            ClothesBL cloth = new ClothesBL(cID, type, gender, color, price, quantity);
                            clothes.Add(cloth);

                        }
                        connection.Close();
                    }
                }
            }

            return clothes;
        }
        /*
        public static void DeleteCloth(ClothesBL c)
        {
            TotalClothes.Remove(c);
        }
        */

        public  bool DeleteCloth(ClothesBL c)
        {
            string connectionString = ConsoleUtility.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Clothes WHERE ClothesId = @ClothesId";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ClothesId", c.GetId());

                    // Execute the DELETE query
                    int rowsAffected = cmd.ExecuteNonQuery();
                    connection.Close();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }


    }
}
