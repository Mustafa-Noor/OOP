using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labwork.BL;
using MyLibrary.Utils;

namespace Labwork.DL
{
    public class DegreeProgramDL
    {
        public static bool SaveDegree(DegreeProgram degree)
        {
            string connectionString = Utility.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Use parameterized query to prevent SQL injection and handle string values properly
                string query = "INSERT INTO Degree (Title, duration) VALUES (@Title, @Duration)";
                SqlCommand cmd = new SqlCommand(query, connection);

                // Add parameters with proper data types
                cmd.Parameters.AddWithValue("@Title", degree.Title);
                cmd.Parameters.AddWithValue("@Duration", degree.Duration);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public static bool UpdateDegree(DegreeProgram degree, string title)
        {
            string connectiongString = Utility.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("UPDATE Degree SET Title = '{0}', Duration = {1} WHERE title = {2}",
                degree.Title,degree.Duration, title);

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

        public static void DeleteDegreet(string title)
        {
            string connectionString = Utility.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Delete the student from the Student table
                string deleteStudentQuery = string.Format("DELETE FROM Degree WHERE title = {0}", title);
                SqlCommand deleteStudentCommand = new SqlCommand(deleteStudentQuery, connection);
                int rowsAffected = deleteStudentCommand.ExecuteNonQuery();
            }
        }

        public static List<DegreeProgram> GetAllDegrees()
        {
            List<DegreeProgram> degrees = new List<DegreeProgram>();

            string connectionString = Utility.GetConnectionString(); // Get connection string
            string query = "SELECT * FROM Degree"; // SQL query to select all degrees

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    
                    string title = Convert.ToString(reader["title"]);
                    int duration = Convert.ToInt32(reader["duration"]);

                    DegreeProgram degree = new DegreeProgram(title, duration);

                    degrees.Add(degree);
                }

                connection.Close();
            }

            return degrees;
        }

    }
}
