using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FashionIsU.UI;

namespace FashionIsU
{
    internal class ClothesUI
    {
        public static void DisplayAllClothes()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------DISPLAY ALL CLOTHES---------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine("|{0,-15}|{1,-15}|{2,-15}|{3,-15}|{4,-15}|{5,-15}|", "ClothesID","Type", "Gender", "Color", "Price", "Availability");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            foreach (ClothesBL c in ClothesDL.GetAllClothes())
            {
                Console.WriteLine("|{0,-15}|{1,-15}|{2,-15}|{3,-15}|{4,-15}|{5,-15}|", c.GetId(), c.GetType(), c.GetGender(), c.GetColor(), "Rs"+c.GetPrice(), c.GetQuantity());
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------");
        }


        public static void NoClothesFound()
        {
            Console.WriteLine("No Clothes Found ....");
            Thread.Sleep(500);
        }

        public static void IncorrectId()
        {
            Console.WriteLine("No Cloth found against that ID ....");
            Thread.Sleep(500);
        }

        public static ClothesBL TakeInputForClothes()
        {
            int Id = 0;
            int price =0, available = 0;
            string temp;


            Console.WriteLine();
            Console.WriteLine("------------------------------ADD AN ITEM OF CLOTHING----------------------------");
            Console.WriteLine();
            Console.WriteLine("Enter clothing details:");
            Console.WriteLine();
            Console.Write("Enter the Type: ");
            string type = Console.ReadLine();
            type = ConsoleUtility.ValidateWordsWithInt(type);
            Console.Write("Enter the Gender: ");
            string gender = Console.ReadLine();
            gender = ConsoleUtility.ValidateGender(gender);
            Console.Write("Enter the Color: ");
            string color = Console.ReadLine();
            color = ConsoleUtility.ValidateWordsWithInt(color);
            Console.Write("Enter the Price: Rs ");
            temp = Console.ReadLine();
            price = ConsoleUtility.ValidateInt(temp, price);
            Console.Write("Enter the Quantity: ");
            temp = Console.ReadLine();
            available = ConsoleUtility.ValidateInt(temp, available);

            ClothesBL c = new ClothesBL(type, gender, color, price, available);
            return c;
        }

        public static void TakeInputForUpdateClothe(ClothesBL cloth)
        {
            int price = 0, available = 0;
            string temp;

            Console.WriteLine();
            Console.WriteLine("------------------------------UPDATE AN ITEM OF CLOTHING----------------------------");
            Console.WriteLine();
            Console.WriteLine("Enter clothing details:");
            Console.WriteLine();

            Console.Write("Enter the Type: ");
            string type = Console.ReadLine();
            type = ConsoleUtility.ValidateWordsWithInt(type);

            Console.Write("Enter the Gender: ");
            string gender = Console.ReadLine();
            gender = ConsoleUtility.ValidateGender(gender);

            Console.Write("Enter the Color: ");
            string color = Console.ReadLine();
            color = ConsoleUtility.ValidateWordsWithInt(color);
            Console.Write("Enter the Price: Rs ");
            temp = Console.ReadLine();
            price= ConsoleUtility.ValidateInt(temp, price);

            Console.Write("Enter the Quantity: ");
            temp = Console.ReadLine();
            available = ConsoleUtility.ValidateInt(temp, available);

            cloth.UpdateCloth(gender, color, type, price, available);
        }


        public static int TakeId()
        {
            int id = 0;
            Console.WriteLine();
            Console.Write("Enter the ID of Clothing : ");
            string temp = Console.ReadLine() ;
            id = ConsoleUtility.ValidateInt(temp, id);
            return id;
        }

        public static int TakeQuantity()
        {
            int quantity = 0;
            Console.Write("Enter the Quantity: ");
            string temp = Console.ReadLine();
            quantity = ConsoleUtility.ValidateInt(temp, quantity);
            return quantity;
        }

        public static void NotPossible()
        {
            Console.WriteLine("Not Possible....");
            Thread.Sleep(500);
        }

        public static void ClothUpdatedSuccessfully()
        {
            Console.WriteLine("Cloth Updated Successfully....");
            Thread.Sleep(500);
        }

        public static void ClothDeletedSuccessfully()
        {
            Console.WriteLine("Cloth Deleted Successfully....");
            Thread.Sleep(500);
        }
    }
}
