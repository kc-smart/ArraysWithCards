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

            //Deal cards
            while (count < deck.Count)
            {
                warOne.Add(deck[count]);
                warTwo.Add(deck[count + 1]);
                count = count + 2;
            }

            //Display each hand
            Console.WriteLine("\n\nPlayer one has the following cards: ");
            count = 0;
            while (count < warOne.Count)
            {

                Console.WriteLine(warOne[count]);
                count++;
            }

            Console.WriteLine("Player two has the following cards: ");
            count = 0;
            while (count < warTwo.Count)
            {

                Console.WriteLine(warTwo[count]);
                count++;
            }

            while (warOne.Count != 52 || warTwo.Count != 52)
            {

                //Set values
                int handOne = 0;

                count = 0;

            playerOneValue:
                //Player one hand
                if (warOne[count].Contains("2"))
                {
                    handOne = 2;
                }
                else if (warOne[count].Contains("3"))
                {
                    handOne = 3;
                }
                else if (warOne[count].Contains("4"))
                {
                    handOne = 4;
                }
                else if (warOne[count].Contains("5"))
                {
                    handOne = 5;
                }
                else if (warOne[count].Contains("6"))
                {
                    handOne = 6;
                }
                else if (warOne[count].Contains("7"))
                {
                    handOne = 7;
                }
                else if (warOne[count].Contains("8"))
                {
                    handOne = 8;
                }
                else if (warOne[count].Contains("9"))
                {
                    handOne = 9;
                }
                else if (warOne[count].Contains("10"))
                {
                    handOne = 10;
                }
                else if (warOne[count].Contains("Jack"))
                {
                    handOne = 11;
                }
                else if (warOne[count].Contains("Queen"))
                {
                    handOne = 12;
                }
                else if (warOne[count].Contains("King"))
                {
                    handOne = 13;
                }
                else
                {
                    handOne = 14;
                }

                //Display value of handOne
                Console.WriteLine($"Player one's hand is worth {handOne}.");

                int handTwo = 0;

                //Player two hand
                if (warTwo[count].Contains("2"))
                {
                    handTwo = 2;
                }
                else if (warTwo[count].Contains("3"))
                {
                    handTwo = 3;
                }
                else if (warTwo[count].Contains("4"))
                {
                    handTwo = 4;
                }
                else if (warTwo[count].Contains("5"))
                {
                    handTwo = 5;
                }
                else if (warTwo[count].Contains("6"))
                {
                    handTwo = 6;
                }
                else if (warTwo[count].Contains("7"))
                {
                    handTwo = 7;
                }
                else if (warTwo[count].Contains("8"))
                {
                    handTwo = 8;
                }
                else if (warTwo[count].Contains("9"))
                {
                    handTwo = 9;
                }
                else if (warTwo[count].Contains("10"))
                {
                    handTwo = 10;
                }
                else if (warTwo[count].Contains("Jack"))
                {
                    handTwo = 11;
                }
                else if (warTwo[count].Contains("Queen"))
                {
                    handTwo = 12;
                }
                else if (warTwo[count].Contains("King"))
                {
                    handTwo = 13;
                }
                else
                {
                    handTwo = 14;
                }


                //Display value of handTwo
                Console.WriteLine($"Player two's hand is worth {handTwo}.");

                //Compare cards
                if (handOne > handTwo)
                {
                    if (count == 2) { goto finishOne; }

                    Console.WriteLine($"Player one wins with {warOne[count]}.");
                    //player one wins hand
                    warOne.Add(warTwo[count]);
                    warOne.Add(warOne[count]);
                    warTwo.Remove(warTwo[count]);
                    warOne.Remove(warOne[count]);



                }
                else if (handOne < handTwo)
                {
                    if (count == 2) { goto finishTwo; }

                    Console.WriteLine($"Player two wins with {warTwo[count]}.");

                    //player two wins hand
                    warTwo.Add(warOne[count]);
                    warTwo.Add(warTwo[count]);
                    warOne.Remove(warOne[count]);
                    warTwo.Remove(warTwo[count]);
                }
                else if (handOne == handTwo)
                {
                    //draw + deal another two cards
                    count = count + 2;

                    //go back to beginning of loop
                    goto playerOneValue;
                }
                else
                {
                    Console.WriteLine("Error!!!!");
                    goto results;
                }

            finishOne:
                //winner gets all cards dealt
                Console.WriteLine($"Player one won the battle with {warOne[count + 2]}");
                warOne.Add(warOne[count]);
                warOne.Add(warOne[count + 1]);
                warOne.Add(warOne[count + 2]);
                warOne.Add(warTwo[count]);
                warOne.Add(warTwo[count + 1]);
                warOne.Add(warTwo[count + 2]);
                warOne.RemoveRange(0, 2);
                warTwo.RemoveRange(0, 2);

            finishTwo:
                //winner gets all cards dealt
                Console.WriteLine($"Player two won the battle with {warTwo[count + 2]}");
                warTwo.Add(warOne[count]);
                warTwo.Add(warOne[count + 1]);
                warTwo.Add(warOne[count + 2]);
                warTwo.Add(warTwo[count]);
                warTwo.Add(warTwo[count + 1]);
                warTwo.Add(warTwo[count + 2]);
                warOne.RemoveRange(0, 2);
                warTwo.RemoveRange(0, 2);

            }




        //Game results
        results:
            if (warOne.Count > warTwo.Count)
            {
                Console.WriteLine("Player one wins with " + warOne.Count + " cards!");
            }
            else
            {
                Console.WriteLine("Player one wins with " + warTwo.Count + " cards!");
            }




        }
    }
}
