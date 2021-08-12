using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which prints all unique pairs in an array of integers whose sum is equal to a given number.

            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int givenNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length-1; j++)
                {
                    if (input[i] + input[j + 1] == givenNumber)
                    {
                        Console.WriteLine($"{input[i]} {input[j + 1]}");
                    }
                }
                   
               
            }
        }
    }
}
