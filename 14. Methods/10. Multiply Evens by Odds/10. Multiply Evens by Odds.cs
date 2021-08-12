using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Create a program that multiplies the sum of all even digits of a number by the sum of all odd digits of the same number:
            //•	Create a method called GetMultipleOfEvenAndOdds()
            //•	Create a method GetSumOfEvenDigits()
            //•	Create GetSumOfOddDigits()
            //•	You may need to use Math.Abs() for negative numbers

            int input = int.Parse(Console.ReadLine());
            input = Math.Abs(input);
            int result = GetMultipleOfEvenAndOdds(input);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int n)
        {
            int OddValue = GetSumOfOddDigits(n);
            int EvenValue = GetSumOfEvenDigits(n);

            int result = OddValue * EvenValue;

            return result;
        }

        static int GetSumOfOddDigits(int n)
        {
            
            int SumOfOdds = 0;
            while (n > 0)
            {
                int testNumber = n % 10;
                if (testNumber % 2 != 0)
                {
                    SumOfOdds += testNumber;
                }
                n /= 10;
            }

            return SumOfOdds;
        }

        static int GetSumOfEvenDigits(int n)
        {
            
            int SumOfEvens = 0;
            while (n > 0)
            {
                int testNumber = n % 10;
                if (testNumber % 2 == 0)
                {
                    SumOfEvens += testNumber;
                }
                n /= 10;

            }

            return SumOfEvens;
        }
    }
}
