using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            Console.WriteLine();
            Console.WriteLine("------------------------------ADD AN ITEM OF CLOTHING----------------------------");
            Console.WriteLine();
            Console.WriteLine("Enter clothing details:");
            Console.WriteLine();
            Console.Write("Give its ID: ");
            int Id = int.Parse(Console.ReadLine());

            Console.Write("Enter the Type: ");
            string type = Console.ReadLine();

            Console.Write("Enter the Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Enter the Color: ");
            string color = Console.ReadLine();

            Console.Write("Enter the Price: Rs ");
            float price = float.Parse(Console.ReadLine());

            Console.Write("Enter the Quantity: ");
            int available = int.Parse(Console.ReadLine());

            ClothesBL c = new ClothesBL(Id, type, gender, color, price, available);
            return c;
        }

        public static void TakeInputForUpdateClothe(ClothesBL cloth)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------UPDATE AN ITEM OF CLOTHING----------------------------");
            Console.WriteLine();
            Console.WriteLine("Enter clothing details:");
            Console.WriteLine();

            Console.Write("Enter the Type: ");
            string type = Console.ReadLine();

            Console.Write("Enter the Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Enter the Color: ");
            string color = Console.ReadLine();

            Console.Write("Enter the Price: Rs ");
            float price = float.Parse(Console.ReadLine());

            Console.Write("Enter the Quantity: ");
            int available = int.Parse(Console.ReadLine());


            cloth.UpdateCloth(gender, color, type, price, available);
        }


        public static int TakeId()
        {
            Console.WriteLine();
            Console.Write("Enter the ID of Clothing you want to BUY: ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        public static int TakeQuantity()
        {
            Console.Write("Enter the Quantity: ");
            return int.Parse(Console.ReadLine());
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
