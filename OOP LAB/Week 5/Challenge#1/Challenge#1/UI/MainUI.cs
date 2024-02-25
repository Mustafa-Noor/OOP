using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class MainUI
    {
        public static string MainMenu()
        {
            Console.WriteLine("------Departmental Store------");
            Console.WriteLine();
            Console.WriteLine("1. SIGN IN");
            Console.WriteLine("2. SIGN UP");
            Console.WriteLine("3. EXIT");
            Console.Write("ENTER YOUR CHOICE: ");
            string Choice = Console.ReadLine();
            return Choice;
        }

       
    }
}
