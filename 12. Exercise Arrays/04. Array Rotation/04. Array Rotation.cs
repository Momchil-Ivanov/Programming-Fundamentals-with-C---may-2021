using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that receives an array and number of rotations you have to perform(first element goes at the end) Print the resulting array.

            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int rotations = int.Parse(Console.ReadLine());


            for (int i = 0; i < rotations; i++)
            {

                int firstNumber = input[0];

                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1];
                }

                input[input.Length - 1] = firstNumber;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
