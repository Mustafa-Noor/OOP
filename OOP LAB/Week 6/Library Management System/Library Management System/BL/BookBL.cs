using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class BookBL
    {
        private string KitabName;
        private List <AuthorBL> Authors;
        private float Price;
        private int Quantity;


        public BookBL(string kitabName,List <AuthorBL> Authors, float price, int quantity)
        {
            KitabName = kitabName;
            this.Authors = Authors;
            Price = price;
            Quantity = quantity;
        }

        public void AddAuthor(AuthorBL a)
        {
            Authors.Add(a);
        }

        public bool SetKitabName(string name)
        {
            if(KitabName != null)
            {
                this.KitabName = name;
                return true;
            }
            return false;
        }

        public string GetName()
        {
            return this.KitabName;
        }

        public void SetAuthor(List<AuthorBL> Authors)
        {

            this.Authors = Authors;
        }

        public List <AuthorBL> GetAuthor()
        {
            return this.Authors;
        }

        public bool SetPrice(float price)
        {
            if (price >= 0)
            {
                this.Price = price;
                return true;
            }
            return false;
        }

        public float GetPrice()
        {
            return this.Price;
        }

        public bool SetQuantity(int quantity)
        {
            if (quantity >= 0)
            {
                this.Quantity = quantity;
                return true;
            }
            return false;
        }

        public int GetQuantity()
        {
            return this.Quantity;
        }

        public void DisplayBookDetails()
        {
            Console.WriteLine("Name: " + this.KitabName);
            Console.WriteLine("Price: " + this.Price);
            Console.WriteLine("Quantity: " + this.Quantity);
            Console.Write("Authors: ");
            foreach (AuthorBL a in Authors)
            {
                Console.Write(a.GetName() + " ");
            }
            
        }



    }
}
