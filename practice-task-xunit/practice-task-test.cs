using System;
using System.Collections.Generic;
using Xunit;
using practice_task;

namespace practice_task_xunit
{
    public class CardTest
    {
        [Fact]
        public void ConstructorTest()
        {
            Card c = new Card("Hearts", "Ace", 1);

            Assert.Equal("Ace", c.name);
            Assert.Equal("Hearts", c.suit);
            Assert.Equal(1, c.value);
        }
    }
    public class DeckTest
    {
        [Fact]
        public void ConstructorTest()
        {
            Deck d = new Deck();
            Assert.Equal(52, d.deckOfCards.Count);

            foreach(Card n in d.deckOfCards)
            {
                
            }

            List<string> cardSuits = new List<string>();
            foreach(Card h in d.deckOfCards)
            {
                cardSuits.Add(h.suit);
            }
            int counter = 0;
            while(counter < 52)
            {
                switch(counter)
                {
                    case < 13:
                        Assert.Equal("Hearts", cardSuits[counter]);
                        counter++;   
                    break;

                    case < 26:
                        Assert.Equal("Diamonds", cardSuits[counter]);
                        counter++;   
                    break;

                    case < 39:
                        Assert.Equal("Spades", cardSuits[counter]);
                        counter++;   
                    break;

                    case < 52:
                        Assert.Equal("Clubs", cardSuits[counter]);
                        counter++;   
                    break;
                }
            }
        }
    }
}
