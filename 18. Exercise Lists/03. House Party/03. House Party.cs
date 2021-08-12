using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a program that keeps track of guests, that are going to a house party:

            //on the first line of input, you are going to receive the number of commands you are going to receive:
            int commandsCount = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine()
                .Split()
                .ToArray();

                //on the next lines you are going to receive one of the following messages: 
                //"{name} is going!":
                if (command[2] == "going!")
                {
                    //if you receive the first message, you have to add the person if he/she is not in the list and if he/she is in the list print on the console:"{name} is already in the list!":
                    if (names.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        names.Add(command[0]);
                    }
                }

                //"{name} is not going!":
                if (command[2] == "not")
                {
                    //if you receive the second message, you have to remove the person if he/she is in the list and if not print: "{name} is not in the list!". At the end print all the guests:
                    if (names.Contains(command[0]))
                    {
                        names.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }

            //at the end print all the guests:
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
