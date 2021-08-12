using System;
using System.Numerics;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive number which represent how many lines we will get as an input.On the next N lines, you will receive a string with 2 numbers separated by single space.You need to compare them.If the left number is greater than the right number, you need to print the sum of all digits in the left number, otherwise print the sum of all digits in the right number.

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string phrase = Console.ReadLine();
                string[] words = phrase.Split(' ');
                BigInteger largestNumber = Int32.MinValue;
                BigInteger sumOfDigits = 0;
                foreach (var word in words)
                {
                    var value = word;
                    BigInteger number = Convert.ToInt64(value);
                    if (number >= largestNumber)
                    {
                        largestNumber = number;
                    }
                }
                if (largestNumber < 0)
                {
                    largestNumber = Math.Abs((long)largestNumber);
                }
                while (largestNumber > 0)
                {

                    sumOfDigits += largestNumber % 10;
                    largestNumber = largestNumber / 10;
                }


                Console.WriteLine(sumOfDigits);
            }

        }
    }
}
