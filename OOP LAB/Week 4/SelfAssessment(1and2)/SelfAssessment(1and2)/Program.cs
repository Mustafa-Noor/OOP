using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessment_1and2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("Mustafa", "Gulberg", "123123");
            Product p1 = new Product("Hoodie", "Winter", 1200);
            Product p2 = new Product("Sweater", "Winter", 1100);
            Product p3 = new Product("Shirt", "Summer", 500);

            c.addProduct(p1);
            c.addProduct(p3);

            Console.WriteLine("The cart is follows: ");
            
            List<Product> products = c.getAllProducts();

            for(int i=0; i<products.Count; i++)
            {
                Console.WriteLine(products[i].name + "\t\t\t" + products[i].category + "\t\t\t" + products[i].price + "\t\t\t");
            }

            float tax = c.calculateTax();

            Console.WriteLine("The total tax will be: Rs " + tax);

            Console.Read();


        }
    }
}
