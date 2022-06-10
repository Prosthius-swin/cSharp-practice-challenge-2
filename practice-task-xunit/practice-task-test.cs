using System;
using System.Collections.Generic;
using Xunit;
using practice_task;
using System.Linq;

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

            List<string> cardName = new List<string>();
            foreach(Card t in d.deckOfCards)
            {
                cardName.Add(t.name);
            }

            int totalAce = cardName.Count(s => s == "Ace");
            Assert.Equal(4, totalAce);
            int total2 = cardName.Count(s => s == "2");
            Assert.Equal(4, total2);
            int total3 = cardName.Count(s => s == "3");
            Assert.Equal(4, total3);
            int total4 = cardName.Count(s => s == "4");
            Assert.Equal(4, total4);
            int total5 = cardName.Count(s => s == "5");
            Assert.Equal(4, total5);
            int total6 = cardName.Count(s => s == "6");
            Assert.Equal(4, total6);
            int total7 = cardName.Count(s => s == "7");
            Assert.Equal(4, total7);
            int total8 = cardName.Count(s => s == "8");
            Assert.Equal(4, total8);
            int total9 = cardName.Count(s => s == "9");
            Assert.Equal(4, total9);
            int total10 = cardName.Count(s => s == "10");
            Assert.Equal(4, total10);
            int totalJack = cardName.Count(s => s == "Jack");
            Assert.Equal(4, totalJack);
            int totalQueen = cardName.Count(s => s == "Queen");
            Assert.Equal(4, totalQueen);
            int totalKing = cardName.Count(s => s == "King");
            Assert.Equal(4, totalKing);    
        }

        [Fact]
        public void ShuffleTest()
        {
            Deck d = new Deck();
            Deck shuffled = new Deck();
            Deck.shuffle(shuffled);
            Assert.NotEqual(d, shuffled);

            Deck one = new Deck();
            Deck two = new Deck();
            Deck.shuffle(one);
            Deck.shuffle(two);
            Assert.NotEqual(one, two);
        }

        [Fact]
        public void DealTest()
        {
            
        }
    } 
}
