using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsUlLibrary
{
    public class CustomerDB:ICustomerDL
    {
        // this is for singleton functionality
        private static CustomerDB CustomerDBInstance; // make an instance of customerdb
        private string ConnectionString = "";
        private CustomerDB(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        public static CustomerDB GetCustomerDB(string connectionString) // get the instance
        {
            if (CustomerDBInstance == null)
            {
                CustomerDBInstance = new CustomerDB(connectionString);
            }
            return CustomerDBInstance;
        }
        public bool AddCustomer(CustomerBL customer) // adds a customer
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string query = string.Format("Insert into Customers (Username, Password, Email, FirstName, LastName, PhoneNumber, Role) Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", customer.GetUsername(), customer.GetPassword(), customer.GetEmail(), customer.GetFirstName(), customer.GetLastName(), customer.GetPhoneNumber(), customer.GetRole());
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

        public void UpdateProfile(CustomerBL customer) // changes the profile of an customer
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string query = string.Format("UPDATE Customers SET Password = '{0}', Email = '{1}', FirstName = '{2}', LastName = '{3}', PhoneNumber = '{4}' WHERE username = '{5}'", customer.GetPassword(), customer.GetEmail(), customer.GetFirstName(), customer.GetLastName(), customer.GetPhoneNumber(), customer.GetUsername());
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();


        }

        public bool IsCustomerExists(string username) // checks if the customer already exist
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = string.Format("Select count(*) from Customers where Username = '{0}'", username);
            SqlCommand cmd = new SqlCommand(query, connection);
            int count = (int)cmd.ExecuteScalar();
            connection.Close();
            return count > 0;
        }

        public CustomerBL FindCustomer(UserBL user) // find the customer from the database
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Customers WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", user.GetUsername());
                    cmd.Parameters.AddWithValue("@Password", user.GetPassword());

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string username = Convert.ToString(reader["Username"]);
                            string password = Convert.ToString(reader["Password"]);
                            string email = Convert.ToString(reader["Email"]);
                            string fname = Convert.ToString(reader["FirstName"]);
                            string lname = Convert.ToString(reader["LastName"]);
                            string phone = Convert.ToString(reader["PhoneNumber"]);
                            string role = Convert.ToString(reader["Role"]);
                            connection.Close();

                           CustomerBL cus = new CustomerBL(username, password, email, fname, lname, phone, role);
                           return cus;

                        }
                    }

                }

            }

            return null; // User not found
        }

        public List<CustomerBL> GetAllCustomers() // return the list of all customers
        {
            List<CustomerBL> customers = new List<CustomerBL>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Customers";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string username = Convert.ToString(reader["Username"]);
                            string password = Convert.ToString(reader["Password"]);
                            string email = Convert.ToString(reader["Email"]);
                            string fname = Convert.ToString(reader["FirstName"]);
                            string lname = Convert.ToString(reader["LastName"]);
                            string phone = Convert.ToString(reader["PhoneNumber"]);
                            string role = Convert.ToString(reader["Role"]);

                            CustomerBL customer = new CustomerBL(username, password, email, fname, lname, phone, role);
                            customers.Add(customer);
                        }
                        connection.Close();
                    }
                }
            }

            return customers;
        }

        public bool CheckCustomersCount() //checks the count of the customers
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Customers";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    count = (int)cmd.ExecuteScalar();
                }
                connection.Close();
            }

            return count > 0;
        }

        public CustomerBL FindCustomerByUsername(string username) // find the customer from their username
        {
            CustomerBL customer = null;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Customers WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string foundUsername = reader["Username"].ToString();
                            string password = reader["Password"].ToString();
                            string email = reader["Email"].ToString();
                            string fname = reader["FirstName"].ToString();
                            string lname = reader["LastName"].ToString();
                            string phone = reader["PhoneNumber"].ToString();
                            string role = reader["Role"].ToString();

                            customer = new CustomerBL(foundUsername, password, email, fname, lname, phone, role);
                        }
                        connection.Close();
                    }
                }
            }

            return customer;
        }

    }
}
