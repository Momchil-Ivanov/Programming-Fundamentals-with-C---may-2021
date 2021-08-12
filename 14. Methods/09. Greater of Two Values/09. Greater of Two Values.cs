using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method GetMax() that returns the greater of two values(the values can be of type int, char or string)

            string type = Console.ReadLine();

            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            if (type == "int")
            {
                int firstInt = int.Parse(firstValue);
                int secondInt = int.Parse(secondValue);
                int result = GetMax(firstInt, secondInt);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(firstValue);
                char secondChar = char.Parse(secondValue);
                char result = (char)GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string result = GetMax(firstValue, secondValue);
                Console.WriteLine(result);
            }
        }

        static string GetMax(string firstValue, string secondValue)
        {
            int result = firstValue.CompareTo(secondValue);

            int firstValueSum = GetSumOfASCII(firstValue);
            int secondValueSum = GetSumOfASCII(secondValue);

            if (result > 0)
            {
                return firstValue;
            }

            return secondValue;
        }

        private static int GetSumOfASCII(string value)
        {
            int valueSum = 0;

            for (int i = 0; i < value.Length; i++)
            {
                valueSum += value[i];
            }

            return valueSum;
        }

        static int GetMax(int firstInt, int SecondInt)
        {
            if (firstInt > SecondInt)
            {
                return firstInt;
            }

            return SecondInt;
        }
    }
}
