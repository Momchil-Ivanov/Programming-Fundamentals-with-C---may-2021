using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads 3 lines of input.On each line you get a single character. Combine all the characters into one string and print it on the console.

            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
            string thirdLine = Console.ReadLine();

            Console.WriteLine($"{firstLine}{secondLine}{thirdLine}");
        }
    }
}
