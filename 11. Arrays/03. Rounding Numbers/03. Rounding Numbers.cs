using System;
using System.Linq;
namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read an array of real numbers(space separated), round them in "away from 0" style and print the output as in the examples:

            double[] array = Console.ReadLine().Split()
                .Select(double.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    array[i] = 0;
                }
                int roundedNumber = (int)Math.Round(array[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{array[i]} => {roundedNumber}");
            }
        }
    }
}
