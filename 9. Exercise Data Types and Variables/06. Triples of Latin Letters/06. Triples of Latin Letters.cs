using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read an integer n and print all triples of the first n small Latin letters, ordered alphabetically:

            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    for (int k = 0; k < input; k++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + j);
                        char thirdChar = (char)('a' + k);

                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
