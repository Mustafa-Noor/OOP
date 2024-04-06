using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using FashionIsU.UI;

namespace FashionIsU
{
    internal class OrderDL
    {
        private static List <OrderBL> TotalOrders = new List <OrderBL> ();

        /*
        public static void AddOrder(OrderBL order)
        {
            TotalOrders.Add (order);
        }
        */
        public static bool AddOrder(OrderBL order)
        {
            string connectiongString = ConsoleUtility.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            

            connection.Open();

            string query = string.Format("Insert into Orders (OrderDate, TotalPrice, DeliveryAddress, PaymentType, Username) OUTPUT INSERTED.OrderID Values('{0}', '{1}', '{2}', '{3}', '{4}')", order.GetOrderDate(), order.GetTotalPrice(), order.GetDeliveryAddress(), order.GetPaymentMethod().GetPaymentType(), order.GetUsername());
            SqlCommand cmd = new SqlCommand(query, connection);
            int orderId = (int)cmd.ExecuteScalar();
            connection.Close();
            SaveOrderItems(orderId, order);
            if(orderId != 0)
            {
                return true;
            }
            return false;
           
        }

        public static void SaveOrderItems(int OrderId, OrderBL order)
        {
                string connectionString = ConsoleUtility.GetConnectionString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (ClothesBL cloth in order.GetItems())
                    {
                        string query = "INSERT INTO OrderItems (OrderId, ClothesId, Type, Gender, Color, Price, Quantity) VALUES (@OrderId, @ClothId, @Type, @Gender, @Color, @Price, @Quantity);";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@OrderId", OrderId);
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

        



        public static List <OrderBL> GetAllOrder()
        {
            return TotalOrders;
        }
    }
}
