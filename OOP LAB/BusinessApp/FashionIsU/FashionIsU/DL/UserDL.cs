using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class UserDL
    {
        private static List<UserBL> Users = new List<UserBL>();

        public static void AddUser(UserBL u)
        {
            Users.Add(u);
        }

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

        public static UserBL FindUser(UserBL u)
        {
            foreach (UserBL stored in Users)
            {
                if(u.GetUsername() == stored.GetUsername())
                { return stored; }
            }
            return null;
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
