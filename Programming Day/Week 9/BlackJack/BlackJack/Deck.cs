using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Deck
    {
        private List<Card> Cards;

        public Deck()
        {
            Cards = new List<Card>();
            InitializeDeck();
        }

        private void InitializeDeck()
        {

            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    Cards.Add(new Card(value, suit));
                }
            }
        }

        public void Shuffle()
        {
            Random rn = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = rn.Next(n + 1);
                Card value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
        }

        public int CardsLeft()
        {
            return Cards.Count;
        }

        public Card DealCard()
        {
            Card card = Cards[Cards.Count - 1];
            Cards.RemoveAt(Cards.Count - 1);
            return card;
        }
    }
}
