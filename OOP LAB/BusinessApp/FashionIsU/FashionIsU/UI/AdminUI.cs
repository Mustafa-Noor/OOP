using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class AdminUI
    {
        public static AdminBL TakeInfoAdmin(UserBL user)
        {
            Console.Write("Enter Description Of Admin: ");
            string descr = Console.ReadLine();

            AdminBL a = new AdminBL(user, descr);
            return a;
        }
    }

}
