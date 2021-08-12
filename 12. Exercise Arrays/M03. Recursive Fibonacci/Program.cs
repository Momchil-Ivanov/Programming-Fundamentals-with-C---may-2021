using System;
using System.Linq;

namespace fibonacci_recursive
{
    class Program
    {
        static void Main()
        {
            int nFibonacci = int.Parse(Console.ReadLine()); //кое число от реда на Фибоначи да върне

            if (nFibonacci <= 1) // в случай че имаме първото число, 0 или отрицателно число
            {
                Console.WriteLine(1);
            }

            else
            {

                double plusPhi = (1 + Math.Sqrt(5)) / 2; // използваме специална формула за ред на Фибоначи
                double minusPhi = (1 - Math.Sqrt(5)) / 2;


                double fibonacci = (Math.Pow(plusPhi, nFibonacci) - Math.Pow((-minusPhi), nFibonacci))
                    / Math.Sqrt(5);

                long roundedFib = (long)Math.Round(fibonacci);

                Console.WriteLine(roundedFib); // принтираме резултата

            }
        }
    }
}