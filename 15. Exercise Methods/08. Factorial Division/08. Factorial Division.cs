using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args) // намираме факториела на две числа и после делим първото на второто
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            long firstResult = factorial(firstNumber);
            long secondResult = factorial(secondNumber);

            double finalResult = (double)firstResult / secondResult;
            Console.WriteLine($"{finalResult:f2}");
        }

        static long factorial(int a)
        {
            long result = 1;
            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
