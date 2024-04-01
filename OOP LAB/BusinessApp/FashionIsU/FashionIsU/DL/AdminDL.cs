using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsU
{
    internal class AdminDL
    {
        private static List <AdminBL> Admins = new List <AdminBL> ();

        public static void AddAdmin(AdminBL a)
        {
            Admins.Add (a); 
        }
    }
}
