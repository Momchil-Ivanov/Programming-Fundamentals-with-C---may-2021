using System;
using System.Linq;
namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read two arrays and print on the console whether they are identical or not. Arrays are identical if their elements are equal.If the arrays are identical find the sum of the first one and print on the console following message: "Arrays are identical. Sum: {sum}", otherwise find the first index where the arrays differ and print on the console following message: "Arrays are not identical. Found difference at {index} index".

            int[] input1= Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] input2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int differentIndexNumber = -1;
            int sum = 0;

            for (int i = 0; i < input1.Length; i++)
            {
                int currentNumber1 = input1[i];
                int currentNumber2 = input2[i];

                sum += currentNumber1;

                if (currentNumber1 != currentNumber2)
                {
                    differentIndexNumber = i;
                    break;
                }
            }

            if (differentIndexNumber >= 0)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {differentIndexNumber} index");
            }
            else
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

        }
    }
}
