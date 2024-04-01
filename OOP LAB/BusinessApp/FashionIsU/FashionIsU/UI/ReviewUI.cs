using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class ReviewUI
    {
        public static ReviewBL TakeReview(ClothesBL cloth, CustomerBL cus)
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------Leave A Review--------------------------------------------");
            Console.WriteLine();
            Console.Write("Enter " + cloth.GetType() + " Rating (from 1 to 5): ");
            int rate = int.Parse(Console.ReadLine());
            Console.Write("Enter Its Review: ");
            string comment =  Console.ReadLine();

            ReviewBL rev = new ReviewBL(rate, comment, cus.GetUsername());
            return rev;


        }


        public static void ReviewAddedSuccess()
        {
            Console.WriteLine();
            Console.WriteLine("Review Has Been Added Successfully...");
            Console.WriteLine();
            Thread.Sleep(300);
        }
    }
}
