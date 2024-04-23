using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FashionIsU.UI;
using FashionIsUlLibrary;

namespace FashionIsU
{
    internal class ClothesUI
    {
        public static void DisplayAllClothes(List <ClothesBL> AllClothes) // display all the list of clothes
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------DISPLAY ALL CLOTHES---------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine("|{0,-15}|{1,-15}|{2,-15}|{3,-15}|{4,-15}|{5,-15}|", "ClothesID","Type", "Gender", "Color", "Price", "Availability");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            foreach (ClothesBL c in AllClothes)
            {
                Console.WriteLine("|{0,-15}|{1,-15}|{2,-15}|{3,-15}|{4,-15}|{5,-15}|", c.GetId(), c.GetType(), c.GetGender(), c.GetColor(), "Rs"+c.GetPrice(), c.GetQuantity());
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------");
        }


        public static void NoClothesFound() // displays that clothes are not found
        {
            Console.WriteLine("No Clothes Found ....");
            Thread.Sleep(500);
        }

        public static void IncorrectId() // shows that id is incorrect
        {
            Console.WriteLine("No Cloth found against that ID ....");
            Thread.Sleep(500);
        }

        public static ClothesBL TakeInputForClothes() // takes the input for adding a cloth
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
            type = ConsoleValidationUI.ValidateWordsWithInt(type);
            Console.Write("Enter the Gender: ");
            string gender = Console.ReadLine();
            gender = ConsoleValidationUI.ValidateGender(gender);
            Console.Write("Enter the Color: ");
            string color = Console.ReadLine();
            color = ConsoleValidationUI.ValidateWordsWithInt(color);
            Console.Write("Enter the Price: Rs ");
            temp = Console.ReadLine();
            price = ConsoleValidationUI.ValidateInt(temp, price);
            Console.Write("Enter the Quantity: ");
            temp = Console.ReadLine();
            available = ConsoleValidationUI.ValidateInt(temp, available);

            ClothesBL c = new ClothesBL(type, gender, color, price, available);
            return c;
        }

        public static ClothesBL TakeInputForUpdateClothe(ClothesBL cloth) // takes the input for updating cloth
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
            type = ConsoleValidationUI.ValidateWordsWithInt(type);

            Console.Write("Enter the Gender: ");
            string gender = Console.ReadLine();
            gender = ConsoleValidationUI.ValidateGender(gender);

            Console.Write("Enter the Color: ");
            string color = Console.ReadLine();
            color = ConsoleValidationUI.ValidateWordsWithInt(color);
            Console.Write("Enter the Price: Rs ");
            temp = Console.ReadLine();
            price= ConsoleValidationUI.ValidateInt(temp, price);

            Console.Write("Enter the Quantity: ");
            temp = Console.ReadLine();
            available = ConsoleValidationUI.ValidateInt(temp, available);

            return new ClothesBL(type, gender, color, price, available);
            
        }


        public static int TakeId() // takes the id of cloth
        {
            int id = 0;
            Console.WriteLine();
            Console.Write("Enter the ID of Clothing : ");
            string temp = Console.ReadLine() ;
            id = ConsoleValidationUI.ValidateInt(temp, id);
            return id;
        }

        public static int TakeQuantity() // takes the quantity of cloth
        {
            int quantity = 0;
            Console.Write("Enter the Quantity: ");
            string temp = Console.ReadLine();
            quantity = ConsoleValidationUI.ValidateInt(temp, quantity);
            return quantity;
        }

        public static void NotPossible() // shows that it is not possible
        {
            Console.WriteLine("Not Possible....");
            Thread.Sleep(500);
        }

        public static void ClothUpdatedSuccessfully() // show that cloth is updated successfully
        {
            Console.WriteLine("Cloth Updated Successfully....");
            Thread.Sleep(500);
        }

        public static void ClothDeletedSuccessfully() // shows that cloth is deleted successfully
        {
            Console.WriteLine("Cloth Deleted Successfully....");
            Thread.Sleep(500);
        }

        public static void ClothAlreadyExist() // shows that cloth already exist
        {
            Console.WriteLine("Cloth Already Exist....");
            Thread.Sleep(500);
        }
    }
}
