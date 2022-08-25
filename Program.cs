using System;
//using System.Collections;
using System.Collections.Generic;

namespace ArraysWithCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var suit = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
            //make deck list instead of array?
            var deck = new List<string>();

            //list counts/size
            var numberOfValues = value.Length;
            var numberOfSuits = suit.Length;
            var beginCount = deck.Count;

            //deck count prior to loop
            Console.WriteLine(numberOfSuits);
            Console.WriteLine(numberOfValues);
            Console.WriteLine(beginCount);

            //populate deck
            var counterOne = 0;
            var counterTwo = 0;
            var deckPos = 0;

            while (counterOne < numberOfSuits)
            {
                while (counterTwo < numberOfValues)
                {
                    //Console.WriteLine(cardNumber);
                    deck.Insert(deckPos, value[counterTwo] + " of " + suit[counterOne]);
                    Console.WriteLine(deck[deckPos]);
                    counterTwo++;
                    deckPos++;
                    var numberOfCards = deck.Count;
                    Console.WriteLine(numberOfCards);
                }

                counterOne++;
                Console.WriteLine("Outer while loop.");
            }


            //deck count after building deck
            var endCount = deck.Count;
            Console.WriteLine(endCount);

        }
    }
}
