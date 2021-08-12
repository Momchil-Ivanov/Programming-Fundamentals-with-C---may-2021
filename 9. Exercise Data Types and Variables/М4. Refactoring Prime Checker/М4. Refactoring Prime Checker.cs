using System;

namespace _04._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given a program that checks if numbers in a given range[2...N] are prime. For each number is printed "{number} -> {true or false}".The code however, is not very well written.Your job is to modify it in a way that is easy to read and understand.

            int input = int.Parse(Console.ReadLine());
            for (int firstNumber = 2; firstNumber <= input; firstNumber++)
            {
                bool isPrime = true;
                for (int cepitel = 2; cepitel < firstNumber; cepitel++)
                {
                    if (firstNumber % cepitel == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("{0} -> {1}", firstNumber, "true");
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", firstNumber, "false");
                }
            }

        }
    }
}
