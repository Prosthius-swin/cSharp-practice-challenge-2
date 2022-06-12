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
                for(int i = 0; i < 5; i++)
                {
                    hand.Add(new Card(deck.deckOfCards[0].name, deck.deckOfCards[0].suit, deck.deckOfCards[0].value));
                    deck.deckOfCards.RemoveAt(0);
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
            foreach(Card i in hand) 
            {
                handPointsValue += i.value;
            }
            return handPointsValue;
        }
        public static int CounterPlusOne() => counter;

        public static Hand dealToHand(Deck cardDeck) => new Hand(cardDeck);
    }
}
