using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CardGame.AdHoc_Demo;
using CardGame.GameElements;


namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunDemos();

            Program myApp = new Program();
            myApp.RunCardDemo();

        }

        public void RunCardDemo()
        {
            DeckOfCards myDeck = new DeckOfCards();
            myDeck.Shuffle();
            DisplayCards(myDeck);
            //Uh-oh not so secure...
            myDeck.Cards.Add(new Card(Suit.SPADES, CardFace.Ace));
            myDeck.Cards.Add(new Card(Suit.SPADES, CardFace.Ace));
            myDeck.Cards.Add(new Card(Suit.SPADES, CardFace.Ace));
            Console.WriteLine("There are {0} cards in the deck.", myDeck.Cards.Count);

        }

        private void DisplayCards(DeckOfCards myDeck)
        {
            //Just display all the cards
            foreach (Card item in myDeck.Cards)
                Console.WriteLine("{0} of {1}", item.Face, item.Suit);
        }

        static void RunDemos()
        {
            //Run some of the demos
            //ArrayDemo demo1 = new ArrayDemo();
            //demo1.Run();

            //ListDemo demo2 = new ListDemo();
            //demo2.Run();

            QueueDemo demo3 = new QueueDemo();
            //demo3.Run();

            StackDemo demo4 = new StackDemo();
            //demo4.Run();
        }

    }
}
