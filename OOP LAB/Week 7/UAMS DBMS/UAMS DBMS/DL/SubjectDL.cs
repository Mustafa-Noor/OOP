using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_DBMS
{
    internal class SubjectDL
    {
        public static string ConnnectionString = "Server=GREY\\SQLEXPRESS;Database=UAMS;Trusted_Connnection=True";

        public static List<SubjectBL> GetAllSubjcts()
        {
            List <SubjectBL> subjects = new List<SubjectBL>();
            SqlConnection con = new SqlConnection(ConnnectionString);
            con.Open();
            string query = "Select * from Subject";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                SubjectBL s = new SubjectBL(reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4));
                subjects.Add(s);

            }
            con.Close();
            return subjects;
        }

        public static List <SubjectBL> GetSubjectsForStudent(string rollNumber)
        {
            List<SubjectBL> subjects = new List<SubjectBL>();
            SqlConnection con = new SqlConnection(ConnnectionString);
            con.Open();
            string query = string.Format("Select * from Subject s, StudentsSubjects e where s.SubjectType = e.SubjectTitle and e.StudentRollNumber = {0}; ", rollNumber);
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                SubjectBL s = new SubjectBL(reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4));
                subjects.Add(s);
            }
            con.Close();
            return subjects;
        }


    }
}
