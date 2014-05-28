using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.GameElements
{
    class Player
    {
        private List<Card> Hand { get; set; }
        public int Count { get { return Hand.Count; } }

        public Player()
        {
            Hand = new List<Card>();
        }

        public void Add(Card freshCard)
        {
            Hand.Add(freshCard);
        }

        public Card Peek(int CardPosition)
        {
            if (CardPosition < 0 || CardPosition >= Count)
                throw new ArgumentOutOfRangeException("No card at position " + CardPosition + " - only " + Count + " cards in my hand.");
            return Hand[CardPosition];
        }

        public Card Pull(int CardPosition)
        {
            if (CardPosition < 0 || CardPosition >= Count)
                throw new ArgumentOutOfRangeException("No card at position " + CardPosition + " - only " + Count + " cards in my hand.");
            return Hand[CardPosition];
            Card discarded = Hand[CardPosition];
            Hand.RemoveAt(CardPosition);
            return discarded;
        }


    }
}
