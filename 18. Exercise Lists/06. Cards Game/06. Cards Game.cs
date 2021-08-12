using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //you will be given two hands of cards, which will be integer numbers. Assume that you have two players. You have to find out the winning deck and respectively the winner:

            //you start from the beginning of both hands:
            List<int> playerOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> playerTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            //compare the cards from the first deck to the cards from the second deck. The player, who has the bigger card, takes both cards and puts them at the back of his hand - the second player's card is last, and the first person's card (the winning one) is before it (second to last) and the player with the smaller card must remove the card from his deck:

            //the game is over, when one of the decks is left without any cards:
            while (playerOne.Count > 0 && playerTwo.Count > 0)
            {
                if (playerOne[0] > playerTwo[0])
                {
                    int elementOne = playerOne[0];
                    int elementTwo = playerTwo[0];
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                    playerOne.Add(elementOne);
                    playerOne.Add(elementTwo);
                }
                else if (playerOne[0] < playerTwo[0])
                {
                    int elementOne = playerOne[0];
                    int elementTwo = playerTwo[0];
                    playerTwo.RemoveAt(0);
                    playerOne.RemoveAt(0);
                    playerTwo.Add(elementTwo);
                    playerTwo.Add(elementOne);
                }

                //if both players' cards have the same values - no one wins, and the two cards must be removed from the decks:
                else
                {
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                }
            }

            //you have to print the winner on the console and the sum of the left cards:"{First/Second} player wins! Sum: {sum}".
            if (playerOne.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {playerOne.Sum()}");
            }
        }
    }
}
