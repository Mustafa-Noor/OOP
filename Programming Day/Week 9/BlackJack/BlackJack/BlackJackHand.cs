using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class BlackJackHand:Hand
    {
        public int GetBlackJackValue()
        {
            int val;
            bool ace;
            int cards = base.GetCardCount();
            val = 0;
            ace = false;

            foreach (Card card in base.GetHand())
            { 
                if(card.GetValue() == 1)
                {
                    if (!ace)
                    {
                        ace = true;
                        val += 11;
                    }
                    else
                    {
                        val += 1;
                    }
                }
                else if(card.GetValue() >=2 && card.GetValue()<=10)
                {
                    val += card.GetValue();
                }
                else if (card.GetValue() >=11 && card.GetValue()<=13)
                {
                    val += 10;
                }
            }

            return val;
        }
    }
}
