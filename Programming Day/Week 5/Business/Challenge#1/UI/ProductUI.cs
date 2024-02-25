using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Challenge_1;

namespace Challenge_1
{
    internal class ProductUI
    {
        public static ProductBL TakeInputForProduct()
        {
            Console.WriteLine();
            Console.Write("Enter the Name of the Product: ");
            string ProductName = Console.ReadLine();
            Console.Write("Enter the Category of the Product: ");
            string Catregory = Console.ReadLine();
            Console.Write("Enter the Price of the Product: ");
            float Price = float.Parse(Console.ReadLine());
            Console.Write("Enter the Available Stock of the Product: ");
            int Stock = int.Parse(Console.ReadLine());
            Console.Write("Enter the Threshold Quantity: ");
            int ThresholdQuantity = int.Parse(Console.ReadLine());

            ProductBL p = new ProductBL(ProductName, Catregory, Price, Stock, ThresholdQuantity);
            return p;
        }

        public static void DisplayProductInformation()
        {
            foreach (ProductBL stored in ProductDL.Products)
            {
                Console.WriteLine();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("| Name of Product     | " + stored.NameOfProduct);
                Console.WriteLine("| Product Category    | " + stored.ProductCategory);
                Console.WriteLine("| Product Price       | " + stored.ProductPrice.ToString("C2"));
                Console.WriteLine("| Available Stock     | " + stored.AvailableStock);
                Console.WriteLine("| Minimum Stock Thresh| " + stored.MinimumStockThreshold);
                Console.WriteLine("------------------------------------");
            }
        }

        public static void DisplayProduct(ProductBL product)
        {
            Console.WriteLine($"Name of Product: {product.NameOfProduct}");
            Console.WriteLine($"Product Category: {product.ProductCategory}");
            Console.WriteLine($"Product Price: {product.ProductPrice:C2}");
            Console.WriteLine($"Available Stock: {product.AvailableStock}");
            Console.WriteLine($"Minimum Stock Threshold: {product.MinimumStockThreshold}");
        }

        public static void DisplayTax()
        {
            foreach (ProductBL product in ProductDL.Products)
            {
                float salesTax = product.CalculateTax();
                Console.WriteLine($"Product: {product.NameOfProduct}, Sales Tax: {salesTax:C2}");
            }
        }

        public static void DisplayToBeOrdered()
        {
            foreach (ProductBL product in ProductDL.Products)
            {
                if(product.AvailableStock < product.MinimumStockThreshold)
                {
                    Console.WriteLine($"Product: {product.NameOfProduct}, Available Stock: {product.AvailableStock}, Minimum Stock Threshold: {product.MinimumStockThreshold}");
                }
            }
        }

        public static void ProductNotFound()
        {
            Console.WriteLine("Product Not Found");
            Thread.Sleep(200);
        }

        public static string TakeName()
        {
            Console.Write("Enter the Name of the Product: ");
            string Name= Console.ReadLine();
            return Name;
        }

        public static int TakeQuantity()
        {
            Console.WriteLine("Enter the Quantity: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
