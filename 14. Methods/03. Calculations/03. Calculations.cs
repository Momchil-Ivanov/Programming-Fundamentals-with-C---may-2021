using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that receives a string on the first line(add, multiply, subtract, divide) and on the next two lines receives two numbers.Create four methods(for each calculation) and invoke the right one depending on the command.The method should also print the result(needs to be void)

            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                add(firstNumber, secondNumber);
            }
            if (command == "multiply")
            {
                multiply(firstNumber, secondNumber);
            }
            if (command == "subtract")
            {
                subtract(firstNumber, secondNumber);
            }
            if (command == "divide")
            {
                divide(firstNumber, secondNumber);
            }
        }
        static void add(double x, double y)
        {
            double result = x + y;
            Console.WriteLine($"{result}");
        }
        static void multiply(double x, double y)
        {
            double result = x * y;
            Console.WriteLine($"{result}");
        }
        static void subtract(double x, double y)
        {
            double result = x - y;
            Console.WriteLine($"{result}");
        }
        static void divide(double x, double y)
        {
            double result = x / y;
            Console.WriteLine($"{result}");
        }
    }
}
