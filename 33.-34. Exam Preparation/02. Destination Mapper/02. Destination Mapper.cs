using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\/{1}[A-Z]{1}[A-Za-z]{2,}\/{1}|={1}[A-Z]{1}[A-Za-z]{2,}={1}";

            List<string> places = new List<string>();

            int travelPoints = 0;
        
            Regex rgx = new Regex(pattern);
            MatchCollection matches = rgx.Matches(input);
            foreach (Match match in matches)
            {
                string result = match.ToString();

                if (result.Contains("/"))
                {
                    result = result.Replace("/", "");
                }
                else
                {
                    result = result.Replace("=", "");
                }

                travelPoints += result.Length;

                places.Add(result);
            }

            Console.WriteLine($"Destinations: {String.Join(", ", places)}");
            Console.WriteLine($"Travel Points: {travelPoints}");

        }
    }
}
