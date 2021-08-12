using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double result = 0;

            foreach (var currentItem in input)
            {
                char starChar = currentItem[0];
                char endChar = currentItem[currentItem.Length - 1];
                double number = double.Parse(currentItem.Substring(1, currentItem.Length-2));

                if (char.IsUpper(starChar))
                {
                    number /= starChar - 64;
                }
                else
                {
                    number *= starChar - 96;
                }

                if (char.IsUpper(endChar))
                {
                    number -= endChar - 64;
                }
                else
                {
                    number += endChar - 96;
                }

                result += number;
            }

            Console.WriteLine($"{result:F2}");
        }
    }
}
