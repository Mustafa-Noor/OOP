using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;
using FashionIsUlLibrary;

namespace FashionIsU
{
    public class ClothesDB:IClothesDL
    {
        // this is for the singleton functionality
        private static ClothesDB ClothesDBInstance; // instance of clothes db
        private string ConnectionString = "";
        private ClothesDB(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        public static ClothesDB GetClothesDB(string connectionString) // returns the instance
        {
            if (ClothesDBInstance == null)
            {
               ClothesDBInstance = new ClothesDB(connectionString);
            }
            return ClothesDBInstance;
        }

        // adds an item  of clothing in the database
        public bool AddClothes(ClothesBL c)
        {
            
            SqlConnection connection = new SqlConnection(ConnectionString);
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


        public bool CheckClothes() // checks the count of cloths in the database
        {
            
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = string.Format("Select count(*) from Clothes");
            SqlCommand cmd = new SqlCommand(query, connection);
            int count = (int)cmd.ExecuteScalar();
            connection.Close();
            return count > 0;
        }

        public ClothesBL FindClothByID(int id) // finds an item of clothing from the database from their id
        {
            ClothesBL cloth = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
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

        public bool CheckClothExistence(ClothesBL c) // checks if an items exists or not
        {
            bool clothExists = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Clothes WHERE LOWER(Type) = LOWER(@Type) AND LOWER(Gender) = LOWER(@Gender) AND LOWER(Color) = LOWER(@Color)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Type", c.GetType());
                    cmd.Parameters.AddWithValue("@Gender", c.GetGender());
                    cmd.Parameters.AddWithValue("@Color", c.GetColor());

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        clothExists = true;
                    }
                }
            }

            return clothExists;
        }

        public bool CheckClothExistenceByQuantity(ClothesBL c) // checks if an items already exist including their quantity
        {
            bool clothExists = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Clothes WHERE LOWER(Type) = LOWER(@Type) AND LOWER(Gender) = LOWER(@Gender) AND LOWER(Color) = LOWER(@Color) AND Quantity = @Quantity";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Type", c.GetType());
                    cmd.Parameters.AddWithValue("@Gender", c.GetGender());
                    cmd.Parameters.AddWithValue("@Color", c.GetColor());
                    cmd.Parameters.AddWithValue("@Quantity", c.GetQuantity());

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        clothExists = true;
                    }
                }
            }

            return clothExists;
        }




        public void ChangeQuantity(int id, int quantity) //changes the quantity of an item
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
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

        public void UpdateCloth(ClothesBL cloth) // updates an item entirely
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
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


        public List <ClothesBL> GetAllClothes() // returns the list of all clothes
        {
            List <ClothesBL> clothes = new List <ClothesBL>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
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

        public bool DeleteCloth(ClothesBL c) // deletes an item of clothing
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
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
