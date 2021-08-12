using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method that calculates and returns the value of a number raised to a given power:

            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = powerRaiser(number, power);
            Console.WriteLine(result);
        }

         static double powerRaiser(double number, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;

        }
        
    }
}
