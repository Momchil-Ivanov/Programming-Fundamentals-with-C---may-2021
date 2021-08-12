using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read two names and a delimiter. Print the names joined by the delimiter.

            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimeter = Console.ReadLine();

            Console.WriteLine($"{firstName}{delimeter}{secondName}");
        }
    }
}
