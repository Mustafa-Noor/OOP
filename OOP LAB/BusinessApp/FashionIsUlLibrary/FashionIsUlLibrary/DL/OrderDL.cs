using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using FashionIsU.UI;
using FashionIsUlLibrary;

namespace FashionIsU
{
    public class OrderDL:IOrderDL
    {
        //private static List <OrderBL> TotalOrders = new List <OrderBL> ();

        /*
        public static void AddOrder(OrderBL order)
        {
            TotalOrders.Add (order);
        }
        */
        public bool AddOrder(OrderBL order)
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

        public void SaveOrderItems(int OrderId, OrderBL order)
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

        public List<OrderBL> RetrieveOrdersOfCustomer(CustomerBL customer)
        {
            List <OrderBL> Orders = new List <OrderBL>();
            string connectionString = ConsoleUtility.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Orders WHERE Username = @username";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", customer.GetUsername());
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            int orderID = Convert.ToInt32(reader["OrderID"]);
                            DateTime orderDate = Convert.ToDateTime(reader["OrderDate"]);
                            int price = Convert.ToInt32(reader["TotalPrice"]);
                            string address = Convert.ToString(reader["DeliveryAddress"]);
                            string paymentType = Convert.ToString(reader["PaymentType"]);
                            List<ClothesBL> Clothes = GetListOfClothesInOrder(orderID);
                            if (paymentType == "Cash")
                            {
                                
                                OrderBL order = new OrderBL(orderID, orderDate, Clothes, price, address, new Cash(paymentType), customer.GetUsername());
                                Orders.Add(order);
                            }
                            else
                            {
                                OrderBL order = new OrderBL(orderID, orderDate, Clothes, price, address, new Card(paymentType, "m", "1234"), customer.GetUsername());
                                Orders.Add(order);
                            }
                            
                            
                        }
                        connection.Close();
                    }
                }
            }

            return Orders;

        }

        public List <ClothesBL> GetListOfClothesInOrder(int orderID)
        {
            List<ClothesBL> Clothes = new List<ClothesBL>();
            string connectionString = ConsoleUtility.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM OrderItems WHERE OrderID = @OrderID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {   
                    
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            int clothesID = Convert.ToInt32(reader["ClothesID"]);
                            string type = Convert.ToString(reader["Type"]);
                            string gender = Convert.ToString(reader["Gender"]);
                            string color = Convert.ToString(reader["Color"]);
                            int price = Convert.ToInt32(reader["Price"]);
                            int quantity = Convert.ToInt32(reader["Quantity"]);

                            ClothesBL cloth = new ClothesBL(clothesID, type, gender, color, price, quantity);
                            Clothes.Add(cloth);
                        }
                        connection.Close();
                    }
                }
            }

            return Clothes;
        }




        /*
        public List <OrderBL> GetAllOrder()
        {
            return TotalOrders;
        }
        */
    }
}
