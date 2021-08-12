using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints whether a given character is upper -case or lower case.

            {
                bool res;
                char val = char.Parse(Console.ReadLine());
                res = Char.IsUpper(val);
                if ( ""+res == "True")
                {
                    Console.WriteLine("upper-case");
                }
                else
                {
                    Console.WriteLine("lower-case");
                }
            }
        }
    }
}
