using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method that prints the sign of an integer number n:

            int number = int.Parse(Console.ReadLine());

            numberChecker(number);
        }
        static void numberChecker(int n)
        {

            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}
