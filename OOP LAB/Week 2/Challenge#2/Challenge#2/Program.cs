﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[30]; // arrays of product objects
            int productCounter = 0; // this keeps track of the products

            while (true) 
            {
                clearScreen();
                string choice = menu(); // displays the menu
                if (choice == "1")
                {
                    clearScreen();
                    products[productCounter] = takeInput(); // takes input for the product and stores it in object array at product counter index
                    productCounter++; // increments the product count
                    returnforAll();
                }
                else if (choice == "2")
                {
                    clearScreen();
                    displayProducts(products, productCounter); // this diplays the info of the products
                    returnforAll();

                }
                else if (choice == "3")
                {
                    clearScreen();
                    if (productCounter > 0)
                    {
                        
                        float sum = calculateSum(products, productCounter); // it calculates the sum
                        Console.WriteLine("The sum of all the products in the store is : Rs {0}", sum);
                    }
                    else
                    {
                        Console.WriteLine("There are no products yet...");
                    }
                    returnforAll();
                }
                else if (choice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Input...");
                    Thread.Sleep(200);
                }
            }

        }

        // this displays the menu and returns the option choice
        static string menu()
        {
            Console.WriteLine("1. Add Products");
            Console.WriteLine("2. Show Products");
            Console.WriteLine("3. Total Store Worth");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your Choice: ");
            string choice = Console.ReadLine();
            return choice;
        }

        // this takes input about the details of the product and returns them as one object
        static Product takeInput()
        {
            Product product = new Product();
            Console.Write("Enter the Product ID : ");
            product.Id = int.Parse(Console.ReadLine());
            Console.Write("Enter the Product's Name: ");
            product.Name = Console.ReadLine();
            Console.Write("Enter the Product's Price: Rs ");
            product.price = float.Parse(Console.ReadLine());
            Console.Write("Enter the Product's Category: ");
            product.Category = Console.ReadLine();
            Console.Write("Enter the Product's Brand Name: ");
            product.BrandName = Console.ReadLine();
            Console.Write("Enter the Product's Country: ");
            product.Country = Console.ReadLine();

            return product;
        }

        // this displays the information of the object
        static void displayProducts(Product[] products, int productCounter)
        {
            Console.WriteLine("Index \t\t ID \t\t Name \t\t Price \t\t Category \t\t Brand Name \t\t Country");
            for (int i = 0; i < productCounter; i++)
            {
                Console.WriteLine(i + 1 + "\t\t" + products[i].Id + "\t\t" + products[i].Name + "\t\t Rs" + products[i].price + "\t\t" + products[i].Category + "\t\t" + products[i].BrandName + "\t\t" + products[i].Country);
            }
        }

        // this function calculates the sum of the price of the products
        static float calculateSum(Product[] products, int productCounter)
        {
            float sum = 0;
            for (int i = 0; i < productCounter; i++)
            {
                sum = sum + products[i].price;
            }

            return sum;
        }

        static void returnforAll() //this is used as a return function for all functions
        {
            Console.WriteLine();
            Console.Write("Press any key to return...");
            Console.Read();
        }

        static void clearScreen()
        {
            Console.Clear();
            Console.WriteLine("-----------Products Management System-------------");
            Console.WriteLine();

        }
    }

    internal class Product
    {
        public int Id;
        public string Name;
        public float price;
        public string Category;
        public string BrandName;
        public string Country;
    }
}
