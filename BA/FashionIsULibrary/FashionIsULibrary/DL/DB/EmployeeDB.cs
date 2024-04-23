using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsUlLibrary
{
    public class EmployeeDB:IEmployeeDL
    {
        // this is for the singleton functionality
        private static EmployeeDB EmployeeDBInstance; // instance 
        private string ConnectionString = "";
        private EmployeeDB(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        public static EmployeeDB GetEmployeeDB(string connectionString) // get the instance 
        {
            if (EmployeeDBInstance == null)
            {
                EmployeeDBInstance = new EmployeeDB(connectionString);
            }
            return EmployeeDBInstance;
        }
        public bool AddEmployee(EmployeeBL employee) // adds an employee in the database
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

        public void RetrieveEmployees(AdminBL admin) // loads all employees in the list contained by admin
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
                            admin.AddEmployee(new EmployeeBL(emp));
                        }
                        connection.Close();
                    }
                }
            }
        }

        public void UpdateProfile(EmployeeBL employee) // changes the profile of an employee
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string query = string.Format("UPDATE Employees SET Password = '{0}', Email = '{1}', FirstName = '{2}', LastName = '{3}', PhoneNumber = '{4}' , Position = '{5}' WHERE username = '{6}'", employee.GetPassword(), employee.GetEmail(), employee.GetFirstName(), employee.GetLastName(), employee.GetPhoneNumber(), employee.GetPosition(), employee.GetUsername());
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();


        }
        

        public List<EmployeeBL> GetAllEmployees() // gets the list of all employees present in the database
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

        public bool DeleteEmployee(EmployeeBL employee) // deletes an employee from the database
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "DELETE FROM Employees where username = @username";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", employee.GetUsername());

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
