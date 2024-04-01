using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Card
    {
        private int value;
        private int suit;

        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public int GetSuit()
        {
            return this.suit;
        }

        public int GetValue()
        { return this.value; }

        public string GetSuitAsString()
        {
            if (suit == 1)
            {
                return "Clubs";
            }
            else if (suit == 2)
            {
                return "Diamonds";
            }
            else if (suit == 3)
            {
                return "Spades";
            }
            else if (suit == 4)
            {
                return "Hearts";
            }
            else
            {
                return null;
            }
        }

        public string GetValueAsString()
        {
            if (value == 1)
            {
                return "Ace";
            }
            else if (value >= 2 && value <= 10)
            {
                return $"{value}";
            }
            else if (value == 11)
            {
                return "Jack";
            }
            else if (value == 12)
            {
                return "Queen";
            }
            else if (value == 13)
            {
                return "King";
            }
            else
            { return null; }

        }

        public string tOString()
        {
            return (GetValueAsString() + " of " + GetSuitAsString());
        }
    }
}
