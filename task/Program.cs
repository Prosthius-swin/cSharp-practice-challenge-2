using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace practice_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "1. Create New Deck \n2. Shuffle Deck \n3. Deal New Hand \n4. Display Hand Total Points \n5. Exit \n\n";

            Console.Write(menu);
            string menuSelection = Console.ReadLine();

            while(menuSelection != "5")
            {
                switch(menuSelection)
                {
                    //Create new deck
                    case "1":
                        /*List<Deck> newDeck = new List<Deck>();
                        newDeck.getDeckOfCards();
                        foreach (Card i in getDeckOfCards)
                        {
                            Console.WriteLine(i);
                        }*/
                        createDeck();
                    break;

                    //Shuffle deck
                    case "2":
                        /*List<Card> deckOfCardsRnd = new List<Card>();
                        //deckOfCardsRnd = DeckOfCards;
                        //deckOfCardsRnd.Shuffle();
                        deckOfCardsRnd = DeckOfCards.OrderBy(item => rnd.Next());
                            foreach (var i in DeckOfCardsRnd)
                            {
                                Console.WriteLine(i);
                            }*/
                    break;

                    //Deal new hand
                    case "3":

                    break;

                    //Display hand total points
                    case "4":

                    break;

                    //Exit
                    case "5":
                    break;
                }
            }
        }
    }
}
