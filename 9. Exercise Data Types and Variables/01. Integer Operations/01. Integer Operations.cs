using System;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read four integer numbers. Add first to the second, divide(integer) the sum by the third number and multiply the result by the fourth number. Print the result.

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int forthNumber = int.Parse(Console.ReadLine());

            int result = ((firstNumber + secondNumber) / thirdNumber) * forthNumber;

            Console.WriteLine(result);
        }
    }
}
