using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessNew
{
    internal class Clothes
    {
        public Clothes(string name, float price1, int available1) 
        { 
            nameOfCloth = name;
            price = price1;
            available = available1;

        }
        public string nameOfCloth;
        public float price;
        public int available;
    }
}
