using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rewrite you program so it can receive the multiplier from the console. Print the table from the given multiplier to 10. If the given multiplier is more than 10 - print only one row with the integer, the given multiplier and the product. See the examples below for more information.
            //Output - Print every row of the table in the following format: {theInteger} X {times} = {product}
            //Constraints - The integer will be in the interval [1…100]

            int number = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());


            while (times <= 10)
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
                times++;
            }

            times--;

            while (times >10)
            {
                Console.WriteLine($"{number} X {times+1} = {number * (times+1)}");
                break;
            }
        }
    }
}
