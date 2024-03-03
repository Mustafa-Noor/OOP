using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // AS AGGREGATION

            List<AuthorBL> Authors = new List<AuthorBL>();

            AuthorBL a1 = new AuthorBL("SAHI", "X@gmail.com", "female");
            AuthorBL a2 = new AuthorBL("Mustafa", "y@gmail.com", "male");

            Authors.Add(a1);
            Authors.Add(a2);

            BookBL b = new BookBL("Jack Of All Trades", Authors, 1000, 10);

            b.DisplayBookDetails();
            Console.Read();

        }
    }
}
