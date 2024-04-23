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
        // this is for the singleton functionality
        private static ReviewFH ReviewFHInstance; // instance 
        private string FilePath = "";
        private ReviewFH(string FilePath)
        {
            this.FilePath = FilePath;
        }
        public static ReviewFH GetReviewFH(string filePath) // get the instance
        {
            if (ReviewFHInstance == null)
            {
                ReviewFHInstance = new ReviewFH(filePath);
            }
            return ReviewFHInstance;
        }

        public bool AddReviews(ReviewBL rev, ClothesBL cloth) // add review in file
        {
            using (StreamWriter f = new StreamWriter(FilePath, true))
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

        public void RetrieveReviews(ClothesBL c) // get the list of reviews against a cloth
        {
            if (File.Exists(FilePath))
            {
                using (StreamReader f = new StreamReader(FilePath))
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

        public void DeleteReview(ClothesBL c) //delete a review
        {
                if (File.Exists(FilePath))
                {
                    List<string> remainingLines = new List<string>();

                    using (StreamReader f = new StreamReader(FilePath))
                    {
                        string record;
                        while ((record = f.ReadLine()) != null)
                        {
                            if (!string.IsNullOrEmpty(record))
                            {
                               string[] splittedRecord = record.Split(',');
                               int currentClothId = Convert.ToInt32(splittedRecord[3]);

                               // If the clothId matches the specified clothId, skip adding the review
                               if (currentClothId != c.GetId())
                               {
                                   remainingLines.Add(record);
                               }
                            }
                        }
                    }

                    // Write the remaining reviews back to the file
                    File.WriteAllLines(FilePath, remainingLines);
                }
            

        }

        
    }
}
