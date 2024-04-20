using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;
using FashionIsUlLibrary;

namespace FashionIsU
{
    public class ReviewDB:IReviewDL
    {
       // private List<ReviewBL> AllReviews = new List<ReviewBL>();

        /*
        public void AddReviews(ReviewBL rev)
        {
            AllReviews.Add(rev);
        }
        */

        public void DeleteReview(ClothesBL c)
        {
            string connectionString = UtilityClass.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "Delete FROM Reviews WHERE ClothesID = @clothID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@clothID", c.GetId());
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public bool AddReviews(ReviewBL rev, ClothesBL cloth)
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

        public void RetrieveReviews(ClothesBL c)
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
