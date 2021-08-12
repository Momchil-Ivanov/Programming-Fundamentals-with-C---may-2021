using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            //            You will be given an integer that will be distance in meters.Write a program that converts meters to kilometers formatted to the second decimal point.
            //Examples
            //Input   Output
            //1852    1.85
            //798     0.80

            decimal meters = decimal.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000.0m;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
