﻿using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find online more information about ASCII(American Standard Code for Information Interchange) and write a program that prints part of the ASCII table of characters at the console.  On the first line of input you will receive the char index you should start with and on the second line - the index of the last character you should print.

            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                char result = Convert.ToChar(i);
                Console.Write($"{result} ");
            }
        }
    }
}
