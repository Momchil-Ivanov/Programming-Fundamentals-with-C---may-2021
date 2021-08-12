using System;

namespace _06._Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes 3 lines of characters and prints them in reversed order with a space between them.

            string firstCharacter = Console.ReadLine();
            string secondCharacter = Console.ReadLine();
            string thirdCharacter = Console.ReadLine();

            Console.WriteLine($"{thirdCharacter} {secondCharacter} {firstCharacter}");
        }
    }
}
