using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class OrderDL
    {
        private static List <OrderBL> TotalOrders = new List <OrderBL> ();

        public static void AddOrder(OrderBL order)
        {
            TotalOrders.Add (order);
        }

        public static List <OrderBL> GetAllOrder()
        {
            return TotalOrders;
        }
    }
}
