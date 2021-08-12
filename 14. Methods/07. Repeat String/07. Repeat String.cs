using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that receives a string and a repeat count n(integer). The method should return a new string(the old one repeated n times)

            string input = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            string result = repeater(input, times);

            Console.WriteLine(result);
        }

         static string repeater(string str, int count)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                 result += str;
            }
            return result;
        }
    }
}
