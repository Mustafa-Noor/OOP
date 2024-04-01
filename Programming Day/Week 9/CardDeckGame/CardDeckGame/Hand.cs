using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeckGame
{
    internal class Hand
    {
        List<Card> hand;
        public Hand() 
        {
            hand = new List<Card>();
        }

        public void Clear()
        { hand.Clear(); }

        public void AddCard(Card c)
        { hand.Add(c); }

        public void RemoveCard(Card c) {  hand.Remove(c); }

        public void RemoveCard(int position)
        {
            hand.RemoveAt(position);
        }
        public int GetCardCount()
        { return hand.Count; }

        public Card GetCard(int position) {  return hand[position]; }

        public void SortBySuit()
        {
            hand = hand.OrderBy(cards => cards.GetSuit()).ThenBy(cards => cards.GetValue()).ToList();
        }

        public void SortByValue()
        {
            hand = hand.OrderBy(cards => cards.GetValue()).ThenBy(cards => cards.GetSuit()).ToList();
        }


    }
}
