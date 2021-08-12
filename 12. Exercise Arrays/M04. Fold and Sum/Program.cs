using System;
using System.Linq;

namespace M04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int k = input.Length / 4;
            int[] newInput = new int[2 * k];

            for (int i = 0; i < k; i++) // използва се специална формула за целта
            {
                newInput[i] = input[k - (i + 1)] + input[k + i];
                newInput[newInput.Length - 1 - i] = input[newInput.Length - 1 - i + k] + input[(newInput.Length - 1 - i) + (k + 2 * i + 1)];
            }
            Console.WriteLine(string.Join(" ", newInput));
        }
    }
}
