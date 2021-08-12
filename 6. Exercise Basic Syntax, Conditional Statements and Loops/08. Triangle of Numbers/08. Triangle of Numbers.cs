using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Write a program, which receives a number – n, and prints a triangle from 1 to n as in the examples.
            //Constraints
            //•	n will be in the interval[1...20].

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int n = 0; n < i; n++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                
            }
        }
    }
}
