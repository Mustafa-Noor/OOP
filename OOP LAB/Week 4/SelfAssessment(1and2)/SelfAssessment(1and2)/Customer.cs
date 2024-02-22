using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessment_1and2_
{
    internal class Customer
    {
        public string CustomerName;
        public string CustomerAddress;
        public string CustomerContact;

        public Customer(string name, string address, string contact)
        {
            CustomerName = name;
            CustomerAddress = address;
            CustomerContact = contact;
        }
        public List<Product> products = new List<Product>();
        public List<Product> getAllProducts()
        {
            return products; 
        }
        public void addProduct(Product p)
        {
            products.Add(p);
        }

        public float calculateTax()
        {
            float tax = 0;
            for (int i = 0; i < products.Count; i++)
            {
                tax += products[i].price*0.2f;
            }

            return tax;
        }
    }
}
