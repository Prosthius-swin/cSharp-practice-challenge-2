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
            Deck notShuffled = new Deck();
            Deck shuffled = new Deck();
            List<string> notShuffledString = new List<string>();
            List<string> shuffledString = new List<string>();

            Deck.shuffle(shuffled);
            for(int i = 0; i < 52; i++)
            {
                notShuffledString.Add($"{notShuffled.deckOfCards[i].suit}, {notShuffled.deckOfCards[i].name}, {notShuffled.deckOfCards[i].value}");
                shuffledString.Add($"{shuffled.deckOfCards[i].suit}, {shuffled.deckOfCards[i].name}, {shuffled.deckOfCards[i].value}");
            }
            Assert.NotEqual(notShuffledString, shuffledString);

            Deck one = new Deck();
            Deck two = new Deck();
            List<string> oneString = new List<string>();
            List<string> twoString = new List<string>();
            
            Deck.shuffle(one);
            Deck.shuffle(two);            
            for(int i = 0; i < 52; i++)
            {
                oneString.Add($"{one.deckOfCards[i].suit}, {one.deckOfCards[i].name}, {one.deckOfCards[i].value}");
                twoString.Add($"{two.deckOfCards[i].suit}, {two.deckOfCards[i].name}, {two.deckOfCards[i].value}");
            }
            Assert.NotEqual(oneString, twoString);
        }

        [Fact]
        public void DealTest()
        {
            Deck dealTestDeck = new Deck();
            Deck deckTopSix = new Deck();
            deckTopSix.deckOfCards.Clear();
            for(int i = 0; i < 6; i++)
            {
                deckTopSix.deckOfCards.Add(new Card(dealTestDeck.deckOfCards[i].suit, dealTestDeck.deckOfCards[i].name, dealTestDeck.deckOfCards[i].value));
            }
            
            Hand dealTestHand = new Hand(dealTestDeck);
            List<Card> dealTestHandCard = new List<Card>();
            for(int i = 0; i < 5; i++)
            {
                dealTestHandCard.Add(new Card(dealTestHand.hand[i].suit, dealTestHand.hand[i].name, dealTestHand.hand[i].value));
            }

            for(int i = 0; i < 5; i++)
            {
                Assert.Equal(deckTopSix.deckOfCards[i].suit, dealTestHand.hand[i].suit);
                Assert.Equal(deckTopSix.deckOfCards[i].name, dealTestHand.hand[i].name);
                Assert.Equal(deckTopSix.deckOfCards[i].value, dealTestHand.hand[i].value);
            }
            Assert.Equal(deckTopSix.deckOfCards[5].suit, dealTestDeck.deckOfCards[0].suit);
            Assert.Equal(deckTopSix.deckOfCards[5].name, dealTestDeck.deckOfCards[0].name);
            Assert.Equal(deckTopSix.deckOfCards[5].value, dealTestDeck.deckOfCards[0].value);
        }
    }

    public class HandTest
    {
        [Theory]
        [InlineData(1, 1, 1, 1, 2, 6)]
        [InlineData(1, 2, 3, 4, 5, 15)]
        [InlineData(2, 2, 2, 2, 13, 21)]
        public void PointsValueTest(int value1, int value2, int value3, int value4, int value5, int expected)
        {
            Deck p = new Deck();
            Hand testHand = new Hand(p);
            testHand.hand.Clear();

            testHand.hand.Add(new Card("Hearts", "test", value1));
            testHand.hand.Add(new Card("Hearts", "test", value2));
            testHand.hand.Add(new Card("Hearts", "test", value3));
            testHand.hand.Add(new Card("Hearts", "test", value4));
            testHand.hand.Add(new Card("Hearts", "test", value5));            

            int result = testHand.PointsValue();
            Assert.Equal(expected, result);
        }
    } 
}
