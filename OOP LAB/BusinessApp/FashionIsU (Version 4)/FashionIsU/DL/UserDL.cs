using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU.UI;

namespace FashionIsU
{
    internal class UserDL
    {
        
    /*
        public static void AddUser(UserBL u)
        {
            Users.Add(u);
        }
    */

        public static bool AddUser(UserBL user)
        {
            string connectiongString = UtilityClass.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("Insert into Users (Username, Password, Email, FirstName, LastName, PhoneNumber, Role) Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", user.GetUsername(), user.GetPassword(), user.GetEmail(), user.GetFirstName(), user.GetLastName(), user.GetPhoneNumber(), user.GetRole());
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

        public static void UpdateProfile(UserBL user)
        {
            string connectiongString = UtilityClass.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("UPDATE Users SET Password = '{0}', Email = '{1}', FirstName = '{2}', LastName = '{3}', PhoneNumber = '{4}' WHERE username = '{5}'", user.GetPassword(), user.GetEmail(), user.GetFirstName(), user.GetLastName(), user.GetPhoneNumber(), user.GetUsername());
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();

            
        }

        public static bool IsUserExists(UserBL cUser)
        {
            string connectiongString = UtilityClass.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("Select count(*) from Users where Username = '{0}'", cUser.GetUsername());
            SqlCommand cmd = new SqlCommand(query, connection);
            int count = (int)cmd.ExecuteScalar();
            connection.Close();
            return count > 0;
        }

        /*
        public static bool IsUserExists(UserBL cUser)
        {
            foreach (UserBL stored in Users)
            {
                if (cUser.GetUsername() == stored.GetUsername())
                {
                    return true;
                }
            }
            return false;
        }
        */
        /*
        public static UserBL FindUser(UserBL u)
        {
            foreach (UserBL stored in Users)
            {
                if(u.GetUsername() == stored.GetUsername() && u.GetPassword() == stored.GetPassword())
                { return stored; }
            }
            return null;
        }
        */

        public static UserBL FindUser(UserBL u)
        {
            string connectionString = UtilityClass.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", u.GetUsername());
                    cmd.Parameters.AddWithValue("@Password", u.GetPassword());

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


                            if(role == "customer")
                            {
                                CustomerBL customer = new CustomerBL(username, password, email, fname, lname, phone, role);
                                return customer;
                            }
                            else
                            {
                                EmployeeBL employee = new EmployeeBL(username, password, email, fname, lname, phone, role);
                                return employee;
                            }


                        }
                    }
                   
                }
                
            }

            return null; // User not found
        }

        public static List<CustomerBL> GetAllCustomers()
        {
            List<CustomerBL> customers = new List<CustomerBL>();
            string connectionString = UtilityClass.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Users WHERE Role = 'customer'";
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

        public static bool CheckCustomersCount()
        {
            int count = 0;
            string connectionString = UtilityClass.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Role = 'customer'";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    count = (int)cmd.ExecuteScalar();
                }
                connection.Close() ;
            }

            return count>0;
        }

        public static CustomerBL FindCustomerByUsername(string username)
        {
            CustomerBL customer = null;
            string connectionString = UtilityClass.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Users WHERE Username = @Username AND Role = 'customer'";
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






        /*
        public static bool AddUserInDB(UserBL user, string connectionString)
        {
            // SQL INSERT INTO statement
            string query = @"INSERT INTO [User] (Username, Password, Email, FirstName, LastName, PhoneNumber) VALUES (@Username, @Password, @Email, @FirstName, @LastName, @PhoneNumber)
";

            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a command with the SQL query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@Username", user.GetUsername());
                    command.Parameters.AddWithValue("@Password", user.GetPassword());
                    command.Parameters.AddWithValue("@Email", user.GetEmail());
                    command.Parameters.AddWithValue("@FirstName", user.GetFirstName());
                    command.Parameters.AddWithValue("@LastName", user.GetLastName());
                    command.Parameters.AddWithValue("@PhoneNumber", user.GetPhoneNumber());

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
