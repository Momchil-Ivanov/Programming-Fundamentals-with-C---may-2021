using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args) // пишат се два метода съответно за събиране и изваждане на числа
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int firstResult = sum(firstNumber, secondNumber);
            int secondResult = subtract(firstResult, thirdNumber);

            Console.WriteLine(secondResult);
        }

        static int subtract(int a, int b)
        {
            int result = a - b;
            return result;
        }

        static int sum(int a, int b)
        {
            int result = a + b;
            return result;
        }

    }
}
