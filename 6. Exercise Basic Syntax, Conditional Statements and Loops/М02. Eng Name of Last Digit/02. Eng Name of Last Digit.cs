using System;

namespace _02._Eng_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int lastdigit = number % 10;

            string digitWord = string.Empty;

            if (lastdigit == 0) 
            {
                digitWord = "zero";
            }
            else if (lastdigit == 1)
            {
                digitWord = "one";
            }
            else if (lastdigit == 2)
            {
                digitWord = "two";
            }
            else if (lastdigit == 3)
            {
                digitWord = "three";
            }
            else if (lastdigit == 4)
            {
                digitWord = "four";
            }
            else if (lastdigit == 5)
            {
                digitWord = "five";
            }
            else if (lastdigit == 6)
            {
                digitWord = "six";
            }
            else if (lastdigit == 7)
            {
                digitWord = "seven";
            }
            else if (lastdigit == 8)
            {
                digitWord = "eight";
            }
            else if (lastdigit == 9)
            {
                digitWord = "nine";
            }

            Console.WriteLine(digitWord);
        }
    }
}
