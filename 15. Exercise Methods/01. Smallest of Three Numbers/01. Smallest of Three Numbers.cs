using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args) // намиране на най-малко от три числа с метод
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            calculate(firstNumber, secondNumber, thirdNumber);
        }

        static int calculate(int a, int b, int c)
        {
            int minNumber = int.MaxValue;

            if (a < b && a < c)
            {
                Console.WriteLine(a);
                minNumber = a;

            }
            else if (b < a && b < c)
            {
                Console.WriteLine(b);
                minNumber = b;

            }
            else
            {
                Console.WriteLine(c);
                minNumber = c;

            }
            return minNumber;

        }
    }
}
