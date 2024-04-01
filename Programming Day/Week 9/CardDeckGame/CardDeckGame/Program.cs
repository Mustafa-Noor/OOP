using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeckGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck d = new Deck();
            Console.WriteLine("Welcome to the High Low Game");
            d.Shuffle();
            Card c = d.DealCard();
            Console.WriteLine("The card is : " + c.tOString());
            while (true)
            {
                
                Console.Write("Enter the number of Suit of the Next: ");
                int suit  = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of Value of the Next: ");
                int value = int.Parse(Console.ReadLine());

                Card next = new Card(suit, value);
                Card c1 = d.DealCard();
               

                if(!checkCard(c1,next))
                {
                    Console.WriteLine("The next card from the deck is : " + c1.tOString());
                    Console.WriteLine("You Lose");
                    break;
                }
                else
                {
                    Console.WriteLine("The next card from the deck is : " + c1.tOString());
                    Console.WriteLine("Nice Move on Now ... ");
                    Console.WriteLine();
                }

                


            }

            Console.Read();
        }

        public static bool checkCard(Card c , Card n)
        {
            if(c.GetSuit() <= n.GetSuit() && c.GetValue() <= n.GetSuit())
            {
                return true;
            }
            return false;
        }
        
    }
}
