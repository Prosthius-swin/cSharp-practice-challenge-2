using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace practice_task
{
    class Card : Deck
    {
        public string name { get; set; }
        public string suit { get; set; }
        public int value { get; set; }
        public Card(string pName, string pSuit, int pValue)
        {
            name = pName;
            suit = pSuit;
            value = pValue;
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
