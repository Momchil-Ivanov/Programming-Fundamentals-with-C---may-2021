using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //read a list of integers:
            List<int> integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            //receive commands to manipulate the list:
            string[] command = Console.ReadLine()
                .Split()
                .ToArray();

            //stop the program when you receive the command "end":
            while (command[0] != "end")
            {
                //Delete {element} - delete all elements in the array, which are equal to the given element:
                if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);

                    integers.RemoveAll(n => n == element);
                }

                //Insert {element} {position} - insert an element and the given position:
                if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);

                    integers.Insert(position, element);
                }

                command = Console.ReadLine()
                    .Split()
                    .ToArray();
            }

            //print the numbers in the array separated by a single whitespace:
            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
