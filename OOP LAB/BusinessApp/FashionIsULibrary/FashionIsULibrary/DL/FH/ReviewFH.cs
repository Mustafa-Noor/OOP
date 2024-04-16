using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsUlLibrary;

namespace FashionIsU
{
    public class ReviewFH:IReviewDL
    {
        public bool AddReviews(ReviewBL rev, ClothesBL cloth)
        {
            string path = UtilityClass.GetReviewsFilePath();
            using (StreamWriter f = new StreamWriter(path, true))
            {
                if (f != null)
                {
                    f.WriteLine(rev.GetRating() + "," + rev.GetComment() + "," + rev.GetUsername() + "," + cloth.GetId());
                    f.Flush();
                    return true;
                }
            }
            return false;
        }

        public void RetrieveReviews(ClothesBL c)
        {
            string path = UtilityClass.GetReviewsFilePath();
            if (File.Exists(path))
            {
                using (StreamReader f = new StreamReader(path))
                {
                    string record;
                    while ((record = f.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(record))
                        {
                            string[] splittedRecord = record.Split(',');
                            int clothId = Convert.ToInt32(splittedRecord[3]);
                            if (clothId == c.GetId())
                            {
                                int rating = Convert.ToInt32(splittedRecord[0]);
                                string comment = splittedRecord[1];
                                string username = splittedRecord[2];
                                ReviewBL rev = new ReviewBL(rating, comment, username);
                                c.AddReview(new ReviewBL(rev.GetRating(), rev.GetComment(), rev.GetUsername()));
                            }
                        }
                    }
                }
            }
        }
    }
}
