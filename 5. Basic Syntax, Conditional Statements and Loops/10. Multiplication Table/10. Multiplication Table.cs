using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive an integer as an input from the console. Print the 10 times table for this integer. See the examples below for more information.
            //Output - Print every row of the table in the following format: {theInteger} X {times} = {product}
            //Constraints - The integer will be in the interval [1…100]

            int number = int.Parse(Console.ReadLine());

            var times = 1;

            while (times <=10)
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
                times++;
            }
        }
    }
}
