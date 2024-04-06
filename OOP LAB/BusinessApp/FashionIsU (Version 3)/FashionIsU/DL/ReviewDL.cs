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
            string connectiongString = ConsoleUtility.GetConnectionString();
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
    }
}
