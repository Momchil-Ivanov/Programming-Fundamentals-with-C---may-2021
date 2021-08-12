using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a program to append several arrays of numbers. Arrays are separated by '|'. Values are separated by spaces(' ', one or several). Order the arrays from the last to the first, and their values from left to right:

            string[] input = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToArray();

            string temporal = string
                .Join(" ", input);

            string[] result = temporal
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
