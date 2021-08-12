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

            double xThird = double.Parse(Console.ReadLine());
            double yThird = double.Parse(Console.ReadLine());
            double xForth = double.Parse(Console.ReadLine());
            double yForth = double.Parse(Console.ReadLine());




            CompareTwoLines(xFirst, yFirst, xSecond, ySecond, xThird, yThird, xForth, yForth);

        }

        static void CompareTwoPoints(double a, double b, double c, double d)
        {
            double first = Math.Sqrt(Math.Pow(Math.Abs(a), 2) + Math.Pow(Math.Abs(b), 2));
            double second = Math.Sqrt(Math.Pow(Math.Abs(c), 2) + Math.Pow(Math.Abs(d), 2));

            if (first > second)
            {
                Console.WriteLine($"({c}, {d})({a}, {b})");
            }
            else
            {
                Console.WriteLine($"({a}, {b})({c}, {d})");
            }
        }

        static void CompareTwoLines(double a, double b, double c, double d, double e, double f, double g, double h)
        {
            double distanceFirstLine = Math.Sqrt(Math.Pow(Math.Abs(a - c), 2) + Math.Pow(Math.Abs(b - d), 2));
            double distanceSecondLine = Math.Sqrt(Math.Pow(Math.Abs(e - g), 2) + Math.Pow(Math.Abs(f - h), 2));

            if (distanceFirstLine >= distanceSecondLine)
            {
                CompareTwoPoints(a, b, c, d);
            }
            else
            {
                CompareTwoPoints(e, f, g, h);
            }
        }
    }
}
