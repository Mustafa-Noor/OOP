using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;
using FashionIsUlLibrary;

namespace FashionIsU
{
    public class CartDB:ICartDL
    {
        // This functionality is due to Singleton 
        private static CartDB CartDBInstance; // Instance of CartDB
        private string ConnectionString = ""; // connection string attribute
        private CartDB(string ConnectionString)        
        {
            this.ConnectionString = ConnectionString;
        }
        public static CartDB GetCartDB(string connectionString) // function to get cart db
        {
            if (CartDBInstance == null)
            {
                CartDBInstance = new CartDB(connectionString);
            }
            return CartDBInstance;
        }


        public void SaveItemInCart(ClothesBL cloth, CustomerBL customer) // saves a cloth in cart of customer
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

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

                connection.Close();
            }
        }

        public bool CheckItemInCart(int id, CustomerBL customer) // checks the existence of an item in cart
        {
            

            using (SqlConnection connection = new SqlConnection(ConnectionString))
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


        public void RetrieveCart(CustomerBL customer) // Gets the entire cart of customer from database
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
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

        public void DeleteAnItem(int id, CustomerBL customer) // deletes an item from the cart of the customer
        {
            

            using (SqlConnection connection = new SqlConnection(ConnectionString))
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


        public void UpdateQuantity(int id, CustomerBL customer, int quantity) // changes the quantity of an item in cart
        {
            

            using (SqlConnection connection = new SqlConnection(ConnectionString))
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

        public void EmptyCart(CustomerBL customer) // clears the cart
        {
            

            using (SqlConnection connection = new SqlConnection(ConnectionString))
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
