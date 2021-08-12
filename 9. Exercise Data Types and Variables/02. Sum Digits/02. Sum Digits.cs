using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given a single integer.Your task is to find the sum of its digits.

            int input = int.Parse(Console.ReadLine());
            int sum = 0;

            while (input > 0)
            {
                int digit = input % 10;

                sum += digit;

                input = input / 10;
            }

            Console.WriteLine(sum);
        }
    }
}
