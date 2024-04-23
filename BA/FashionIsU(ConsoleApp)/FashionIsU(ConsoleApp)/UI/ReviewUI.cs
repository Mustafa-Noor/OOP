using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using FashionIsU.UI;

namespace FashionIsU
{
    internal class ReviewUI
    {
        public static ReviewBL TakeReview(ClothesBL cloth, CustomerBL cus) // this takes the input for the customer
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------Leave A Review--------------------------------------------");
            Console.WriteLine();
            Console.Write("Enter " + cloth.GetType() + " Rating (from 1 to 5): ");
            string temp = Console.ReadLine();
            int rate = ConsoleValidationUI.ValidateRating(temp);
            Console.Write("Enter Its Review: ");
            string comment =  Console.ReadLine();
            comment = ConsoleValidationUI.ValidateSentences(comment);

            ReviewBL rev = new ReviewBL(rate, comment, cus.GetUsername());
            return rev;


        }


        public static void ReviewAddedSuccess() // this shows the review is added
        {
            Console.WriteLine();
            Console.WriteLine("Review Has Been Added Successfully...");
            Console.WriteLine();
            Thread.Sleep(300);
        }


        public static void DisplayReview(ClothesBL cloth) // this displays the review list
        {
            Console.WriteLine("----------------------------CHECK REVIEWS FOR AN ITEM-----------------------------");
            Console.WriteLine("|{0,-10}|{1,-40}|{2,-20}|", "Rating", "Comment", "Username");
            Console.WriteLine("----------------------------------------------------------------------------------");
            foreach (ReviewBL rev in cloth.GetReviews())
            {
                Console.WriteLine("|{0,-10}|{1,-40}|{2,-20}|", rev.GetRating(), rev.GetComment(), rev.GetUsername());
            }
            Console.WriteLine("---------------------------------------------------------------------------------");
        }

    }
}
