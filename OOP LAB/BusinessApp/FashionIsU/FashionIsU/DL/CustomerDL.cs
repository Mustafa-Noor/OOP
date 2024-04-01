using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class CustomerDL
    {
        private static List <CustomerBL> Customers = new List<CustomerBL> ();
        public static void AddCustomer(CustomerBL c)
        {
            Customers.Add(c);
        }

        public static CustomerBL FindCustomer(UserBL u)
        {
            foreach(CustomerBL cus in Customers)
            {
                if(cus.GetUsername() == u.GetUsername() && cus.GetPassword() == u.GetPassword())
                {
                    return cus;
                }
            }
            return null;
        }

        public static List<CustomerBL> GetAllCustomers()
        {
            return Customers;
        }

        public static bool CheckCustomers()
        { return Customers.Count > 0;}

        /*
        public static bool AddCustomerInDB(CustomerBL customer, string connectionString)
        {
            // SQL INSERT INTO statement
            string query = @"INSERT INTO Customer (CustomerAddress,Username) VALUES (@CustomerAddress,@Username)
";

            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a command with the SQL query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@Username", customer.GetUsername());
                    command.Parameters.AddWithValue("@CustomerAddress",customer.GetCustomerAddress());


                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the command (INSERT)
                        command.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        return false;
                    }
                }
            }
        }
        */
    }
}
