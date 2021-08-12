using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take as an input an even number and print its absolute value. If the number is odd, print "Please write an even number." and continue reading numbers.

            int number = int.Parse(Console.ReadLine());

            while (number % 2 != 0)
            {
                Console.WriteLine($"Please write an even number.");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {Math.Abs(number)}");

        }
    }
}
