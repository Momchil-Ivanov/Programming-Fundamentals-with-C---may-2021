using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            string command = Console.ReadLine();

            int movesNumber = 0;
            while (command!="end" && input.Count >= 2)
            {
                List<string> commandParts = command.Split(' ').ToList();
                int indexOne = int.Parse(commandParts[0]);
                int indexTwo = int.Parse(commandParts[1]);
                if (indexOne<0||indexOne>= input.Count||indexTwo<0||indexTwo>= input.Count||indexOne==indexTwo)
                {
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                    input.Insert(input.Count/2, $"-{movesNumber+1}a");
                    input.Insert(input.Count/2, $"-{movesNumber+1}a");
                }
                else if (input[indexOne]==input[indexTwo])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {input[indexOne]}!");
                    if (indexOne<indexTwo)
                    {
                        input.RemoveAt(indexTwo);
                        input.RemoveAt(indexOne);
                    }
                    else
                    {
                        input.RemoveAt(indexOne);
                        input.RemoveAt(indexTwo);
                    }
                }
                else
                {
                    Console.WriteLine($"Try again!");
                }        
                command = Console.ReadLine();
                movesNumber++;
            }
            if (input.Count < 2)
            {
                Console.WriteLine($"You have won in {movesNumber} turns!");
            }
            else 
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(String.Join(' ', input));
            }
        }
    }
}
