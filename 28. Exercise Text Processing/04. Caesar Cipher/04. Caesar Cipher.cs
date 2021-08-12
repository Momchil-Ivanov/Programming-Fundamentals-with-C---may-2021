using System;
using System.Collections.Generic;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Empty;
            char first = new char();

            for (int i = 0; i < input.Length; i++)
            {
                first = input[i];
                char nextChar = (char)((int)first + 3);
                output += nextChar;
            }
            Console.WriteLine(output);
        }
    }
}
