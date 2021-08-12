using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //CWrite a program that finds the longest sequence of equal elements in an array of integers. If several longest sequences exist, print the leftmost one.

            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int maxElements = 0;
            int currentEqualElement = 1;
            int element = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i+1])
                {
                    currentEqualElement++;
                }
                else
                {
                    currentEqualElement = 1;
                }

                if (currentEqualElement>maxElements)
                {
                    maxElements = currentEqualElement;
                    element = input[i];
                }
              
            }

            for (int i = 0; i < maxElements; i++)
            {
                Console.Write($"{element} ");
            }
            
        }
    }
}
