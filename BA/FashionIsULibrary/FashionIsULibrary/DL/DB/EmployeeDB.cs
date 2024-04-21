using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsULibrary
{
    public class EmployeeDB
    {
        string ConnectionString = UtilityClass.GetConnectionString();
        public bool AddEmployee(EmployeeBL employee)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string query = string.Format("Insert into Employees (Username, Password, Email, FirstName, LastName, PhoneNumber, Role, Position) Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", employee.GetUsername(), employee.GetPassword(), employee.GetEmail(), employee.GetFirstName(), employee.GetLastName(), employee.GetPhoneNumber(), employee.GetRole(), employee.GetPosition());
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

        public void RetrieveEmployees(AdminBL admin)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Employees";
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
                            string position = Convert.ToString(reader["Position"]);

                            EmployeeBL emp = new EmployeeBL(username, password, email, fname, lname, phone, role, position);
                            admin.AddEmployee(emp);
                        }
                        connection.Close();
                    }
                }
            }
        }

        public void UpdateProfile(EmployeeBL employee)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string query = string.Format("UPDATE Employees SET Password = '{0}', Email = '{1}', FirstName = '{2}', LastName = '{3}', PhoneNumber = '{4}' WHERE username = '{5}'", employee.GetPassword(), employee.GetEmail(), employee.GetFirstName(), employee.GetLastName(), employee.GetPhoneNumber(), employee.GetUsername());
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();


        }

        public bool IsEmployeeExists(string username)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = string.Format("Select count(*) from Employees where Username = '{0}'", username);
            SqlCommand cmd = new SqlCommand(query, connection);
            int count = (int)cmd.ExecuteScalar();
            connection.Close();
            return count > 0;
        }

        public EmployeeBL FindEmployee(UserBL user)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Employees WHERE Username = @Username AND Password = @Password";
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
                            string position = Convert.ToString(reader["Position"]);
                            connection.Close();

                            EmployeeBL emp = new EmployeeBL(username, password, email, fname, lname, phone, role, position);
                            return emp;
                        }
                    }

                }

            }

            return null; // User not found
        }

        public List<EmployeeBL> GetAllEmployees()
        {
            List<EmployeeBL> Employees = new List<EmployeeBL>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Employees";
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
                            string position = Convert.ToString(reader["Position"]);

                            EmployeeBL emp = new EmployeeBL(username, password, email, fname, lname, phone, role, position);
                            Employees.Add(emp);
                        }
                        connection.Close();
                    }
                }
            }

            return Employees;
        }

        public bool CheckEmployeesCount()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Employees";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    count = (int)cmd.ExecuteScalar();
                }
                connection.Close();
            }

            return count > 0;
        }

        public EmployeeBL FindEmployeesByUsername(string username)
        {
            EmployeeBL employee = null;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Employees WHERE Username = @Username";
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
                            string position = reader["Position"].ToString();

                            employee = new EmployeeBL(username, password, email, fname, lname, phone, role, position);
                        }
                        connection.Close();
                    }
                }
            }

            return employee;
        }
    }
}
