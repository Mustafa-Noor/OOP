using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    internal class Clothes
    {
        public Clothes(string name, float price1, int available1)
        {
            nameOfCloth = name;
            price = price1;
            available = available1;
        }

        public Clothes() { }
        public string nameOfCloth;
        public float price;
        public int available;

        public void displayClothes(int i)
        {

            Console.WriteLine((i + 1) + "\t\t" + nameOfCloth + "\t\t Rs" + price + "\t\t\t" + available);

        }
    }
}
