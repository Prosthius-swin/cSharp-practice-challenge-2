using System;
using System.Collections.Generic;

namespace practice_task
{
    public class Hand
    {
        public static int counter { get; set; }
        public List<Card> hand = new List<Card>();
        public Hand(Deck deck)
        { 
            if(counter == 1)
            {
                Random rnd = new Random();
                for(int i = 0; i < 5; i++)
                {
                    int cardAddToHand = rnd.Next(0, deck.deckOfCards.Count);
                    hand.Add(new Card(deck.deckOfCards[cardAddToHand].name, deck.deckOfCards[cardAddToHand].suit, deck.deckOfCards[cardAddToHand].value));
                    deck.deckOfCards.RemoveAt(cardAddToHand);
                }
            } else
            {
                counter = 1;
            }
        }
        public List<Card> ListHand() => hand;
        public int PointsValue()
        {
            int handPointsValue = 0;
            foreach(Card i in ListHand()) 
            {
                handPointsValue += i.value;
            }
            return handPointsValue;
        }
        public static int CounterPlusOne() => counter;

        public static Hand dealToHand(Deck cardDeck) => new Hand(cardDeck);
    }
}
