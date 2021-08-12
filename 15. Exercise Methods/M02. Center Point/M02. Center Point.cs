using System;

namespace M02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double xFirst = double.Parse(Console.ReadLine());
            double yFirst = double.Parse(Console.ReadLine());
            double xSecond = double.Parse(Console.ReadLine());
            double ySecond = double.Parse(Console.ReadLine());

            CompareTwoPoints(xFirst, yFirst, xSecond, ySecond);


        }

        static void CompareTwoPoints(double xFirst, double yFirst, double xSecond, double ySecond)
        {
            double result1 = Math.Abs(xFirst) + Math.Abs(yFirst);
            double result2 = Math.Abs(xSecond) + Math.Abs(ySecond);

            if (result1 < result2)
            {
                Console.WriteLine($"({xFirst}, {yFirst})");
            }
            else
            {
                Console.WriteLine($"({xSecond}, {ySecond})");
            }
        }
    }
}
