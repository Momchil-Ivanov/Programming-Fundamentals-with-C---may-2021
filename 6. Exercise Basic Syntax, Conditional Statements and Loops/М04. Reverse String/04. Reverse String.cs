using System;
using System.Linq;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = string.Join("", input.Reverse());
            Console.WriteLine(input);


        }
    }
}
