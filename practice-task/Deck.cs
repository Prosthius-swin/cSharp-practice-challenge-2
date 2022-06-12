using System;
using System.Collections.Generic;
using System.Linq;

namespace practice_task
{
    public class Deck
    {
        public List<Card> deckOfCards = new List<Card>();
        public Deck()
        {
            Dictionary<int, string> cardDict = new Dictionary<int, string>()
            {
                {1, "Ace"},
                {2, "2"},
                {3, "3"},
                {4, "4"},
                {5, "5"},
                {6, "6"},
                {7, "7"},
                {8, "8"},
                {9, "9"},
                {10, "10"},
                {11, "Jack"},
                {12, "Queen"},
                {13, "King"}
            };
            for (int i = 1; i <= 13; i++)
            {
                deckOfCards.Add(new Card("Hearts", cardDict[i], i));
            }
            for (int i = 1; i <= 13; i++)
            {
                deckOfCards.Add(new Card("Diamonds", cardDict[i], i));
            }
            for (int i = 1; i <= 13; i++)
            {
                deckOfCards.Add(new Card("Spades", cardDict[i], i));
            }
            for (int i = 1; i <= 13; i++)
            {
                deckOfCards.Add(new Card("Clubs", cardDict[i], i));
            }
        }
        public List<Card> ListRemainingCards() => deckOfCards;
        public static Deck shuffle(Deck deck)
        {
            Random rnd = new Random();
            deck.deckOfCards = deck.deckOfCards.OrderBy(x => rnd.Next()).ToList();
            return deck;
        }
    }
}
