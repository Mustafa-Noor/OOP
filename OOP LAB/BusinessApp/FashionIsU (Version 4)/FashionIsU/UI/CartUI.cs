using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FashionIsU.UI
{
    internal class CartUI
    {
        public static void AddedToCart()
        {
            Console.WriteLine("Item successfully added to Cart.");
            Thread.Sleep(300);
        }

        public static void DisplayCart(List <ClothesBL> Cart, CartBL c)
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("| ClothesID |    Type    |   Gender   |  Color  |  Price  | Quantity |");
            Console.WriteLine("-------------------------------------------------------------------");

            

            foreach (ClothesBL item in Cart)
            {
                Console.WriteLine($"| {item.GetId(),-10} | {item.GetType(),-11} | {item.GetGender(),-10} | {item.GetColor(),-7} | {item.GetPrice(),-7} | {item.GetQuantity(),-8} |");
               
            }

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"Total: {c.GetTotalCartAmount()}");
            Console.WriteLine("-------------------------------------------------------------------");
        }

        public static void CartIsEmpty()
        {
            Console.WriteLine("Cart is Empty ...");
            Thread.Sleep(300);
        }

        public static void CartItemDel()
        {
            Console.WriteLine("Cart Item Deleted Successfully...");
            Thread.Sleep(300);
        }

        public static void CartItemUpdated()
        {
            Console.WriteLine("Cart Item Updated Successfully...");
            Thread.Sleep(300);
        }

        public static void ItemAlreadyBought()
        {
            Console.WriteLine("Item is Already Present In Cart...");
            Thread.Sleep(300);
        }
    }
}

