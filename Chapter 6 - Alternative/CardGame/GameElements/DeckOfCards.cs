﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.GameElements
{
    class DeckOfCards
    {
        //We are being pretty trusting letting them have driect access to our Cards
        //TODO: Change the data type to an IEnumerable<Card>...
        public List<Card> Cards { get; private set; }

        //the following is a good use of static members of a class
        private static Random _rnd = new Random();  //field for doing random stuff

        public DeckOfCards()
        {
            //Add all 52 cards, in order
            Cards = new List<Card>();
            foreach (Suit aSuit in Enum.GetValues(typeof(Suit)))
                foreach (CardFace aFace in Enum.GetValues(typeof(CardFace)))
                    Cards.Add(new Card(aSuit, aFace));
        }

        public void Shuffle()
        {
            int counter = _rnd.Next(20, 50) * 52;  //how many times fo move a card
            while (counter > 0)
            {
                int index = _rnd.Next(Cards.Count);
                Card aCard = Cards[index];
                Cards.RemoveAt(index);  //Pull card out from middle
                Cards.Add(aCard);       //Add card to the end

                counter--;
            }
        }

        public void Deal(int cards, params Player[] players)
        {
            //A little bit of validation
            if (players == null || players.Length == 0 )
                throw new ArgumentException("Not enough players to deal cards to...");
            foreach (var person in players)
                if(person == null)
                    throw new ArgumentException("Cannot deal to a 'null' player.");
            if (cards <= 0)
                throw new ArgumentOutOfRangeException("Cannot deal " + cards + " cards.");
            if (cards * players.Length > Cards.Count)
                throw new Exception("Not enough cards. Cannot deal " + cards + " to " + players.Length + " players.");
            while (cards > 0)
            {
                foreach (var player in players)
                {
                    //pull from top of deck...
                    Card card = Cards[0];
                    player.Add(card);
                    Cards.RemoveAt(0);
                }
                cards--;  //decrement each time a card is dealt
            }


        }

    
    }
}
