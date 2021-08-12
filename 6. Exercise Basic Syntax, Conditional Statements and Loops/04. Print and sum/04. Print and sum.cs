using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to display numbers from given start to given end and their sum.All the numbers will be integers. On the first line you will receive the start, on the second the end.

            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = firstNumber; i <= lastNumber ; i++)
            {
                sum += i;
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");


        }
    }
}
