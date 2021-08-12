using System;

namespace M01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();

            if (type == "int")
            {
                Int(input);
            }
            if (type == "real")
            {
                Real(input);
            }
            if (type == "string")
            {
                String(input);
            }
        }

        private static void String(string input)
        {
            Console.WriteLine($"${input}$");
        }

        private static void Real(string input)
        {
            double result = double.Parse(input);
            result *= 1.5;
            Console.WriteLine($"{result:f2}");
        }

        private static void Int(string input)
        {
            int result = int.Parse(input);
            result *= 2;
            Console.WriteLine($"{result}");
        }
    }
}
