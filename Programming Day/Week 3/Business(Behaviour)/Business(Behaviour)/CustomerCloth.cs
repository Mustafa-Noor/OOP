using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Behaviour_
{
    internal class CustomerCloth
    {
        
        public string nameOfCloth;
        public float price;
        public int available;

        public void displayCart(int i)
        {
             Console.WriteLine((i + 1) + "\t\t" + nameOfCloth + "\t\t Rs" + price + "\t\t\t" + available);
            
        }

    }
}
