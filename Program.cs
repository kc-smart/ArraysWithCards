using System;
//using System.Collections;
using System.Collections.Generic;

namespace ArraysWithCards
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Explorer Mode*/
            var value = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var suit = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
            //make deck list instead of array?
            var deck = new List<string>();

            //list counts/size
            var numberOfValues = value.Length;
            var numberOfSuits = suit.Length;
            var beginCount = deck.Count;

            //deck count prior to loop
            Console.WriteLine($"There are {numberOfSuits} suits with {numberOfValues} cards each.");
            Console.WriteLine($"Our deck currently has {beginCount} cards.");

            //populate deck
            var deckPos = 0;

            for (var counterOne = 0; counterOne < numberOfSuits; counterOne++)
            {
                for (var counterTwo = 0; counterTwo < numberOfValues; counterTwo++)
                {
                    deck.Insert(deckPos, value[counterTwo] + " of " + suit[counterOne]);
                    Console.WriteLine(deck[deckPos]);
                    deckPos++;
                }
            }


            //deck count after building deck
            var endCount = deck.Count;
            Console.WriteLine($"Our deck now has {endCount} cards.");

            //Shuffle deck
            int numberOfCards = deck.Count;
            var random = new Random();

            for (int i = 0; i < 52; i++)
            {
                //Step 1: Randomly select a card.
                var card = random.Next(i);

                //Step 2: Swap random card
                var temp = deck[i];
                deck[i] = deck[card];
                deck[card] = temp;
            }

            //Print new deck
            Console.WriteLine("New deck order: ");
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(deck[i]);
            }



            /*Adventure Mode*/
            //deal two cards


            //deal two cards to multiple players; max 7 players
            Console.Write("How many players? ");
            var numberOfPlayers = Console.ReadLine();
            int players = int.Parse(numberOfPlayers);

            if (players < 8)
            {
                var handOne = new List<string>();
                var handTwo = new List<string>();
                //additional players
                int i = 0;

                while (i < players * 2)
                {

                    handOne.Add(deck[i]);
                    handTwo.Add(deck[i + 1]);
                    //how to add player based on user input?
                    i = i + players;
                }

                Console.WriteLine("Player one has the " + handOne[0] + " and the " + handOne[1]);
                Console.WriteLine("Player two has the " + handTwo[0] + " and the " + handTwo[1]);
            }
            else
            {
                Console.WriteLine("Too many players! Game can only have up to 7 players.");
            }

            /*Epic Mode*/

            //War
            var warOne = new List<string>();
            var warTwo = new List<string>();
            int count = 0;

            while (count < deck.Count)
            {

                warOne.Add(deck[count]);
                warTwo.Add(deck[count + 1]);
                count = count + 2;
            }





        }
    }
}
