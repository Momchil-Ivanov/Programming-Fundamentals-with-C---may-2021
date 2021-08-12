using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Write a method that receives two number and an operator, calculates the result and returns it. You will be given three lines of input. The first will be the first number, the second one will be the operator and the last one will be the second number.The possible operators are: / *+-
            //Print the result rounded up to the second decimal point.

            int firstNumber = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            double finalResult = Calculate(firstNumber, command, secondNumber);
            Console.WriteLine($"{finalResult:f0}");
        }
        static double Calculate (int a, string @operator, int b)
        {
            double result = 0;
            if (@operator == "/")
            {
                result = a / b;
            }
            if (@operator == "*")
            {
                result = a * b;
            }
            if (@operator == "+")
            {
                result = a + b;
            }
            if (@operator == "-")
            {
                result = a - b;
            }

            return result;
        }           
    }
}
