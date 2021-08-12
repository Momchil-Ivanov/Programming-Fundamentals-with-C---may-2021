using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints the next n odd numbers (starting from 1) and on the last row prints the sum of them.
            //Input - On the first line, you will receive a number – n. This number shows how many odd numbers you should print.
            //Output - Print the next n odd numbers, starting from 1, separated by new lines. On the last line, print the sum of these numbers.
            //Constraints - n will be in the interval [1…100]

            int one = -1;
            int sum = 0;

            int wantedNumber = int.Parse(Console.ReadLine());

            for (int n = 1; n < wantedNumber+1; n++)
            {
                int number = one + 2 * n;
                Console.WriteLine(number);
                sum += number;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
