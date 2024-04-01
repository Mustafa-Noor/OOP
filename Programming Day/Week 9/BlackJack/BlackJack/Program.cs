using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".........WELCOME TO BLACK JACK.....");
            Console.WriteLine();
            Console.WriteLine();

            Deck deck = new Deck(); 
            deck.Shuffle();

            BlackJackHand playerHand = new BlackJackHand();
            BlackJackHand dealerHand = new BlackJackHand();

            playerHand.AddCard(deck.DealCard());
            playerHand.AddCard(deck.DealCard());
            dealerHand.AddCard(deck.DealCard());
            dealerHand.AddCard(deck.DealCard());

            Console.WriteLine("Players Card : ");
            foreach(Card c in playerHand.GetHand())
            {
                Console.WriteLine(c.tOString());
            }
            Console.WriteLine();
            Console.WriteLine("The total Value of Player is : " + playerHand.GetBlackJackValue());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Dealers Card : ");
            List<Card> d = dealerHand.GetHand();
            Console.WriteLine(d[0].tOString());
            Console.WriteLine("Total Value: ?");

            while(true)
            {
                Console.Write("Do you want to hit or stand? (h/s): ");
                char choice = char.Parse(Console.ReadLine());

                if(choice == 'h')
                {
                    playerHand.AddCard(deck.DealCard());
                    Console.WriteLine("You drew: " + playerHand.GetCard(playerHand.GetCardCount() - 1).tOString());
                    Console.WriteLine("Total value: " + playerHand.GetBlackJackValue());

                    if(playerHand.GetBlackJackValue() >21)
                    {
                        Console.WriteLine("Busted! You lose");
                        Console.Read();
                        break;
                    }
                }
                else if (choice == 's')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'h' to hit or 's' to stand.");
                }


                Console.WriteLine("Dealer's turn:");
                Console.WriteLine("Dealer's cards:");
                foreach (Card card in dealerHand.GetHand())
                {
                    Console.WriteLine(card.tOString());
                }
                Console.WriteLine($"Total value: {dealerHand.GetBlackJackValue()}");

                while (dealerHand.GetBlackJackValue() < 17)
                {
                    dealerHand.AddCard(deck.DealCard());
                    Console.WriteLine($"Dealer drew: {dealerHand.GetCard(dealerHand.GetCardCount() - 1).tOString()}");
                    Console.WriteLine($"Total value: {dealerHand.GetBlackJackValue()}");
                }

                if (dealerHand.GetBlackJackValue() > 21 || playerHand.GetBlackJackValue() > dealerHand.GetBlackJackValue())
                {
                    Console.WriteLine("Congratulations! You win.");
                    break;
                }
                else if (playerHand.GetBlackJackValue() < dealerHand.GetBlackJackValue())
                {
                    Console.WriteLine("Sorry, you lose.");
                    break;
                }
                
            }

            Console.Read();

        }
    }
}
