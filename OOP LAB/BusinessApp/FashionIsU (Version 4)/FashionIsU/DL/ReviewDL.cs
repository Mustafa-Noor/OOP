using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU.UI;

namespace FashionIsU
{
    internal class ReviewDL
    {
        private static List<ReviewBL> AllReviews = new List<ReviewBL>();

        /*
        public static void AddReviews(ReviewBL rev)
        {
            AllReviews.Add(rev);
        }
        */

        public static bool AddReviews(ReviewBL rev, ClothesBL cloth)
        {
            string connectiongString = UtilityClass.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("Insert into Reviews (Rating, Comment, Username, ClothID) Values('{0}', '{1}', '{2}', {3})", rev.GetRating(), rev.GetComment(), rev.GetUsername(), cloth.GetId());
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

        public static void RetrieveReviews(ClothesBL c)
        {
            
            string connectionString = UtilityClass.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Reviews where clothid = @id";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("id", c.GetId());

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            int rating = Convert.ToInt32(reader["Rating"]);
                            string comment = Convert.ToString(reader["Comment"]);
                            string username = Convert.ToString(reader["Username"]);
                            

                            ReviewBL rev = new ReviewBL(rating, comment, username);
                            c.AddReview(new ReviewBL(rev.GetRating(), rev.GetComment(), rev.GetUsername()));

                        }
                        connection.Close();
                    }
                }
            }

            
        }
    }
}
