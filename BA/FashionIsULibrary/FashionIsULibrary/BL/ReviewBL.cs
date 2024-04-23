using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FashionIsU
{
    public class ReviewBL
    {
        // attributes
        private int Rating;
        private string Comment;
        private string Username;

        // Paramterized Constructor
        public ReviewBL(int rating, string comment, string username)
        {
            Rating = rating;
            Comment = comment;
            Username = username;
        }

        // Getter and setters
        public int GetRating()
        {
            return Rating;
        }

        public void SetRating(int value)
        {
            Rating = value;
        }

        public string GetComment()
        {
            return Comment;
        }

        public void SetComment(string value)
        {
            Comment = value;
        }

        public string GetUsername()
        {
            return Username;
        }

        public void SetUsername(string value)
        {
            Username = value;
        }


    }
}
