﻿using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            int reminder = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(input[i].ToString());

                int product = currentDigit * multiplier + reminder;

                int result = product % 10;

                reminder = product / 10;

                sb.Insert(0, result);
            }

            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }

            if (input == "0" || multiplier == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(sb);
            }
        }
    }
}
