using Labwork.BL;
using MyLibrary.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Labwork.DL
{
    public class StudentDL
    {

        public static bool SaveStudent(Student student)
        {
            string connectiongString = Utility.GetConnectionString();
            SqlConnection connection  = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("Insert into Student(Roll,Name,Fsc,Matric,Ecat) Values({0}, '{1}', {2}, {3}, {4})", student.Roll, student.Name, student.FSc, student.Matric, student.Ecat);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            
            connection.Close();
            foreach(DegreeProgram degree in student.Prefrences)
            {
                SavePrefrence(degree, student.Roll);
            }
            
            if(rows > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool SavePrefrence(DegreeProgram degreeProgram, int roll) {

            string connectiongString = Utility.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("Insert into StudentPrefrences(DegreeTitle, StudentRoll) values('{0}', {1})", degreeProgram.Title, roll );
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0) { return true; }
            else return false;
          
        }


        public static void FindStudentByRoll(string roll)
        {
            string connectiongString = Utility.GetConnectionString();
            SqlConnection connection = new SqlConnection( connectiongString);
            connection.Open();

            string query = string.Format("select * from students where roll = {0} ", roll);
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            Student student;
            if (reader.Read())
            {

                int dbroll = Convert.ToInt32(reader["Roll"]);
                string Name = Convert.ToString(reader["Name"]);
                float Fsc = Convert.ToSingle(reader["Fsc"]);
                float matric = Convert.ToSingle(reader["Matric"]);
                float Ecat = Convert.ToSingle(reader["Ecat"]);
                student  = new Student(dbroll, Name, Fsc, matric, Ecat);
                student.Prefrences =  LoadStudentAllPrefencesbyRoll(dbroll);

            }

        }


        public static List<DegreeProgram> LoadStudentAllPrefencesbyRoll(int roll)
        {
            string connectiongString = Utility.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select * from StudentPrefrences where StudentRoll = {0} ", roll);
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            List<DegreeProgram> list = new List<DegreeProgram>();
            while(reader.Read()) {

                string pref = Convert.ToString(reader["DegreeTitle"]);
                DegreeProgram degreeProgram = new DegreeProgram();
                degreeProgram.Title = pref;

                list.Add(degreeProgram);    
            
            }
            return list;
        }
     

        public static List<Student> GetAllStudents()
        {
            //here you can write the code to get all students 
            return null;
        }

    }
}
