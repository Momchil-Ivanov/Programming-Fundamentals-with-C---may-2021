using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //            3.Exact Sum of Real Numbers
            //Write program to enter n numbers and calculate and print their exact sum(without rounding).
            //Examples
            //Input   Output
            //3
            //1000000000000000000
            //5
            //10  1000000000000000015

            //2
            //0.00000000003
            //333333333333.3  333333333333.30000000003
            //Hints
            //Use BigInteger to not lose precision.

            int numberCount = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < numberCount; i++)
            {
                decimal numberCurrent = decimal.Parse(Console.ReadLine());
                sum += numberCurrent;
            }

            Console.WriteLine(sum);




        }
    }
}
