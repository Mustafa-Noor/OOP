using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU.UI;
using FashionIsUlLibrary;

namespace FashionIsU
{
    public class CartDL: ICartDL
    {
        public void SaveCart(CartBL cart, CustomerBL customer)
        {
            string connectionString = ConsoleUtility.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (ClothesBL cloth in cart.GetCartItems())
                {
                    if(!CheckItemInCart(cloth.GetId(), customer))
                    {
                        string query = "INSERT INTO Carts (Username, ClothesId, Type, Gender, Color, Price, Quantity) VALUES (@Username, @ClothId, @Type, @Gender, @Color, @Price, @Quantity);";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@Username", customer.GetUsername());
                            cmd.Parameters.AddWithValue("@ClothId", cloth.GetId()); // Assuming you have a property for ClothId in your OrderItem class
                            cmd.Parameters.AddWithValue("@Type", cloth.GetType()); // Assuming you have a property for Quantity in your OrderItem class
                            cmd.Parameters.AddWithValue("@Gender", cloth.GetGender());
                            cmd.Parameters.AddWithValue("@Color", cloth.GetColor());
                            cmd.Parameters.AddWithValue("@Price", cloth.GetPrice());
                            cmd.Parameters.AddWithValue("@Quantity", cloth.GetQuantity());


                            cmd.ExecuteNonQuery();
                        }
                    }
                    
                }

                connection.Close();
            }
        }

        public  bool CheckItemInCart(int id, CustomerBL customer)
        {
            string connectionString = ConsoleUtility.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Carts WHERE ClothesID = @clothID and Username = @username";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@clothID", id);
                    cmd.Parameters.AddWithValue("@username", customer.GetUsername());
                        
                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }


        public void RetrieveCart(CustomerBL customer)
        {
            
            string connectionString = ConsoleUtility.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Carts WHERE Username = @username";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", customer.GetUsername());
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            int clothesID = Convert.ToInt32(reader["ClothesID"]);
                            string type = Convert.ToString(reader["Type"]);
                            string gender = Convert.ToString(reader["Gender"]);
                            string color = Convert.ToString(reader["Color"]);
                            int price = Convert.ToInt32(reader["Price"]);
                            int quantity  = Convert.ToInt32(reader["Quantity"]);

                            ClothesBL cloth = new ClothesBL(clothesID, type, gender, color, price, quantity);
                            customer.GetCart().AddIntoCart(cloth);
                        }
                        connection.Close();
                    }
                }
            }
            
            
        }

        public void DeleteAnItem(int id, CustomerBL customer)
        {
            string connectionString = ConsoleUtility.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "Delete FROM Carts WHERE ClothesID = @clothID and Username = @username";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@clothID", id);
                    cmd.Parameters.AddWithValue("@username", customer.GetUsername());

                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }


        public  void UpdateQuantity(int id, CustomerBL customer, int quantity)
        {
            string connectionString = ConsoleUtility.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "Update Carts Set Quantity = @quantity WHERE ClothesID = @clothID and Username = @username";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@clothID", id);
                    cmd.Parameters.AddWithValue("@username", customer.GetUsername());
                    cmd.Parameters.AddWithValue("@quantity", quantity);

                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void EmptyCart(CustomerBL customer)
        {
            string connectionString = ConsoleUtility.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "Delete from Carts WHERE Username = @username";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    
                    cmd.Parameters.AddWithValue("@username", customer.GetUsername());
                    

                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }





    }
}
