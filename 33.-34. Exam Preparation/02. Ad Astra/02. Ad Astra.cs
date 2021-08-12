using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> foodName = new List<string>();
            List<string> foodExp = new List<string>();
            List<int> foodCal = new List<int>();

            string pattern = @"\|{1}[\sA-Za-z]+\|{1}[0-9]{2}\/[0-9]{2}\/[0-9]{2}\|[0-9]+\||\#{1}[\sA-Za-z]+\#{1}[0-9]{2}\/[0-9]{2}\/[0-9]{2}\#[0-9]+\#";

            int calories = 0;

            Regex rgx = new Regex(pattern);
            MatchCollection matches = rgx.Matches(input);
            foreach (Match match in matches)
            {
                string currentMatch = match.ToString();

                if (currentMatch.Contains("#"))
                {
                    string[] split = currentMatch.Split("#").ToArray();

                    calories += int.Parse(split[3]);

                    foodName.Add(split[1]);
                    foodExp.Add(split[2]);
                    foodCal.Add(int.Parse(split[3]));
                }

                else if (currentMatch.Contains("|"))
                {
                    string[] split = currentMatch.Split("|").ToArray();
 
                    calories += int.Parse(split[3]);

                    foodName.Add(split[1]);
                    foodExp.Add(split[2]);
                    foodCal.Add(int.Parse(split[3]));
                }        
            }

            int days = calories / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");

            for (int i = 0; i < foodName.Count; i++)
            {
                Console.WriteLine($"Item: {foodName[i]}, Best before: {foodExp[i]}, Nutrition: {foodCal[i]}");
            }
        }
    }

}
