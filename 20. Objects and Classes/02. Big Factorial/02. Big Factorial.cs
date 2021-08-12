using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FactorialCalculator calculator = new FactorialCalculator(n);
            Console.WriteLine(calculator.Calculate());
        }
    }
    class FactorialCalculator
    {
        public FactorialCalculator(int n)
        {
            N = n;
        }
        public int N { get; set; }

        public BigInteger Calculate()
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }

}
