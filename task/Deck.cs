using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace practice_task
{
    class Deck : Card
    {
        public Card card { get; set; }
        //public List<Deck> deckOfCards = new List<Deck>();
        public Deck(string pName, string pSuit, int pValue) :base (pName, pSuit, pValue)
        {
            name = pName;
            suit = pSuit;
            value = pValue;
        }
       
        public List<Deck> getDeckOfCards()
        {
            return deckOfCards;
        }

        public void createDeck()
        {
            public static List<Deck> deckOfCards = new List<Deck>()
            {
                new Deck("Ace", "Spades", 1),
                new Deck("2", "Spades", 2),
                new Deck("3", "Spades", 3),
                new Deck("4", "Spades", 4),
                new Deck("5", "Spades", 5),
                new Deck("6", "Spades", 6),
                new Deck("7", "Spades", 7),
                new Deck("8", "Spades", 8),
                new Deck("9", "Spades", 9),
                new Deck("10", "Spades", 10),
                new Deck("Jack", "Spades", 11),
                new Deck("Queen", "Spades", 12),
                new Deck("King", "Spades", 13),
                new Deck("Ace", "Hearts", 1),
                new Deck("2", "Hearts", 2),
                new Deck("3", "Hearts", 3),
                new Deck("4", "Hearts", 4),
                new Deck("5", "Hearts", 5),
                new Deck("6", "Hearts", 6),
                new Deck("7", "Hearts", 7),
                new Deck("8", "Hearts", 8),
                new Deck("9", "Hearts", 9),
                new Deck("10", "Hearts", 10),
                new Deck("Jack", "Hearts", 11),
                new Deck("Queen", "Hearts", 12),
                new Deck("King", "Hearts", 13),
                new Deck("Ace", "Clubs", 1),
                new Deck("2", "Clubs", 2),
                new Deck("3", "Clubs", 3),
                new Deck("4", "Clubs", 4),
                new Deck("5", "Clubs", 5),
                new Deck("6", "Clubs", 6),
                new Deck("7", "Clubs", 7),
                new Deck("8", "Clubs", 8),
                new Deck("9", "Clubs", 9),
                new Deck("10", "Clubs", 10),
                new Deck("Jack", "Clubs", 11),
                new Deck("Queen", "Clubs", 12),
                new Deck("King", "Clubs", 13),
                new Deck("Ace", "Diamonds", 1),
                new Deck("2", "Diamonds", 2),
                new Deck("3", "Diamonds", 3),
                new Deck("4", "Diamonds", 4),
                new Deck("5", "Diamonds", 5),
                new Deck("6", "Diamonds", 6),
                new Deck("7", "Diamonds", 7),
                new Deck("8", "Diamonds", 8),
                new Deck("9", "Diamonds", 9),
                new Deck("10", "Diamonds", 10),
                new Deck("Jack", "Diamonds", 11),
                new Deck("Queen", "Diamonds", 12),
                new Deck("King", "Diamonds", 13)
            };
        }
        /*public static void Shuffle()
        {
            var randomized = DeckOfCards.OrderBy(item => rnd.Next());
            foreach (var value in randomized)
            {
                Console.WriteLine(value);
            }
        }*/
    }
}
