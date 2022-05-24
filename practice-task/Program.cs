using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace practice_task
{
    class Program : Deck
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

                    break;

                    //Shuffle deck
                    case "2":
                        List<Card> deckOfCardsRnd = new List<Card>();
                        //deckOfCardsRnd = DeckOfCards;
                        //deckOfCardsRnd.Shuffle();
                        var DeckOfCardsRnd = DeckOfCards.OrderBy(item => rnd.Next());
                            foreach (var i in DeckOfCardsRnd)
                            {
                                Console.WriteLine(i);
                            }
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
