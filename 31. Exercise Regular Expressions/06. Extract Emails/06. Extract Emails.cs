using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s)([A-Za-z0-9]+[-._]*[A-Za-z0-9]+)@([A-Za-z]+(([-.])[A-Za-z]+)*\.[a-z]{2,})";

            string input = Console.ReadLine();

            MatchCollection matchCollection = Regex.Matches(input, pattern);

            foreach (Match item in matchCollection)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
