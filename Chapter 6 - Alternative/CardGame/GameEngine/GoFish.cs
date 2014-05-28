using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CardGame.GameElements;

namespace CardGame.GameEngine
{
    //TODO: Push some parts to an abstract class called AbstractCardGame
    class GoFish
    {
        private DeckOfCards Deck { get; set; }
        private Player[] Players { get; set; }

        public GoFish(params AbstractFishPlayer[] players)
        {
            //TODO: Validate the list of polayers, that there are from 2 to 5 players
            this.Players = players;
            Deck = new DeckOfCards();
        }

        public void Play()
        {
            //Run the game - this is like the Main() method of your game
            SetUp();
            bool gameOver = false;
            Player winner = null;
            do
            {
                foreach (var person in Players)
                {
                    //as IFishPlayer is a method of safe casting
                    bool foundMatch = TakeTurn(person as IFishPlayer);
                    if (foundMatch)
                        RemovePairs(person);
                    if (person.Count == 0)
                    {
                        gameOver = true;
                        winner = person;
                        break;  //jump out of this foreach loop
                    }

                }
            } while (!gameOver);
            //TODO: Find some way to say who won...
        }

        public void SetUp()
        {
            //Run the game - this is like the Main() method of your game
            Deck.Shuffle();
            Deck.Deal(5, Players);
        }

        private bool TakeTurn(IFishPlayer person)
        {
            throw new NotImplementedException();
        }

        private void RemovePairs(Player person)
        {
            throw new NotImplementedException();
        }

    }
}
