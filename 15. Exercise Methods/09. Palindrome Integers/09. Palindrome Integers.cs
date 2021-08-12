using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args) // програма дали едно число се чете еднакво в двете посоки
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                bool isPalindrome = IsPalindrome(input);
                if (isPalindrome)
                {
                    Console.WriteLine($"true");
                }
                else
                {
                    Console.WriteLine($"false");
                }
                input = Console.ReadLine();
            }
        }

        private static bool IsPalindrome(string input)
        {
            string reversedInput = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedInput += input[i];
            }

            bool isPalindrome = input == reversedInput;

            return isPalindrome;
        }
    }
}
