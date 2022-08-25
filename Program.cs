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


            //Display top two cards



            /*Adventure Mode*/
            //deal two cards


            //deal two cards to multiple players


            /*Epic Mode*/

            //War





        }
    }
}
