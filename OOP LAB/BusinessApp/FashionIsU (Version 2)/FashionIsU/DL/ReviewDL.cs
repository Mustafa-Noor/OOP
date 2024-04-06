using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class ReviewDL
    {
        private static List<ReviewBL> AllReviews = new List<ReviewBL>();

        public static void AddReviews(ReviewBL rev)
        {
            AllReviews.Add(rev);
        }
    }
}
