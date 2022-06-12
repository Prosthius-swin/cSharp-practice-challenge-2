using System;
using System.IO;

namespace practice_task
{
    public class Program
    {
        static void Main(string[] args)
        {
            Deck deckOfCards = new Deck();
            Hand hand = new Hand(deckOfCards);
            Hand.CounterPlusOne();
            string menuSelection = "";
            string menu = "1. Create New Deck \n2. Shuffle Deck \n3. Deal New Hand \n4. Display Hand Total Points \n5. Exit \n\n";
            string lineSeparator = "-------------------------";

            string[] savedHandArr = File.ReadAllLines("./saved-hands/saved-hand.csv");
            string savedHandVar = string.Join(",", savedHandArr);
            var values = savedHandVar.Split(',');
            int a = 0;
            int b = 1;
            int c = 2;
            foreach (string i in savedHandArr)
            {
                string name = values[a];
                string suit = values[b];
                int value = int.Parse(values[c]);
                hand.ListHand().Add(new Card(name, suit, value));

                a += 3;
                b += 3;
                c += 3;
            }

            while(menuSelection != "5")
            {
                Console.Write(menu);
                menuSelection = Console.ReadLine();
                Console.WriteLine(lineSeparator + "\n");
                switch(menuSelection)
                {
                    //Create new deck
                    case "1":
                        deckOfCards = new Deck();
                        Console.WriteLine($"A new deck was successfully created\n\nPress enter to continue.\n\n{lineSeparator}");
                        while (Console.ReadKey().Key != ConsoleKey.Enter){}
                    break;
                    
                    //Shuffle deck
                    case "2":
                        Deck.shuffle(deckOfCards);
                        foreach(Card h in deckOfCards.deckOfCards)
                        {
                            Console.WriteLine(h.suit);
                        }
                        Console.WriteLine($"The deck was successfully shuffled\n\nPress enter to continue.\n\n{lineSeparator}");
                        while (Console.ReadKey().Key != ConsoleKey.Enter){}
                    break;

                    //Deal new hand
                    case "3":
                        if(deckOfCards.deckOfCards.Count >= 5)
                        {
                            hand = Hand.dealToHand(deckOfCards);
                            Console.WriteLine("Hand successfully dealt");
                        } else
                        {
                            Console.WriteLine("There are fewer than 5 cards remaining in the deck.");
                        }
                        Console.WriteLine($"\nPress enter to continue.\n\n{lineSeparator}");
                        while (Console.ReadKey().Key != ConsoleKey.Enter){}
                    break;

                    //Display hand total points
                    case "4":
                        int handPointsValue = hand.PointsValue();
                        Console.WriteLine($"The total value of the hand is {handPointsValue}.");
                        Console.WriteLine($"\n\nPress enter to continue.\n\n{lineSeparator}");
                        while (Console.ReadKey().Key != ConsoleKey.Enter){}
                    break;

                    //Exit
                    case "5":
                        using (StreamWriter writer = new StreamWriter("./saved-hands/saved-hand.csv"))
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                writer.WriteLine($"{hand.hand[i].name},{hand.hand[i].suit},{hand.hand[i].value}");
                            }
                            Console.WriteLine($"Current hand saved successfully\n\n{lineSeparator}\nExiting");
                        }
                    break;
                }
            }
        }
    }
}
