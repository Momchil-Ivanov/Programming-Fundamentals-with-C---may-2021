using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to check if a given number is a strong number or not.A number is strong if the sum of the Factorial of each digit is equal to the number. For example 145 is a strong number, because 1! + 4! + 5! = 145.Print "yes" if the number is strong and "no" if the number is not strong.

            int inputNumber = int.Parse(Console.ReadLine());
            int firstNumber = inputNumber;
            int sum = 0;

            while (inputNumber > 0)
            {
                int currentNumber = inputNumber % 10;

                int factoriel = 1;

                for (int i = 1; i <= currentNumber; i++)
                {
                    factoriel *= i;
                }

                sum += factoriel;

                inputNumber /= 10;
            }

            if (firstNumber == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");  
            }

        }
    }
}
