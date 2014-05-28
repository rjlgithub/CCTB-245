﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.GameElements
{
    //Extra data types that relate to the Card class
    public enum Suit { HEARTS, DIAMONDS, CLUBS, SPADES }
    public enum CardFace
    {
        Ace = 1,
        Deuce,
        Three,Four,Five,Six,Seven,Eight,Nine,Ten,Jack,Queen,King
    }

    //An Immutable type - A card cannot be changed once it is created
    public class Card
    {
        public Suit Suit { get; private set; }
        public CardFace Face { get; private set; }
        public int FaceValue
        {
            get
            {
                int value = (int) Face;  //one valid use of casting
                if (value > 10)
                    value = 10;  //Jack, Queen, King
                return value;
            }
        }

        //TODO:  Create a constructor that takes two parameters: a Suit and a CardFace
        public Card(Suit suit, CardFace cardFace)
        {
            Suit = suit;
            Face = cardFace;
        }

        public override string ToString()
        {
            return string.Format("{0} of {1}",Face,Suit);
        }

    }
}
