using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"\|{1}(?<bossName>[A-Z]{4,})\|{1}:{1}#{1}(?<title>[A-Za-z]{1,} [A-Za-z]{1,})#{1}";

                Match m = Regex.Match(input, pattern);

                if (m.Success)
                {
                    string[] splitForName = input.Split("|").ToArray();
                    string[] splitForTitle = input.Split("#").ToArray();

                    string bossName = splitForName[1];
                    string title = splitForTitle[1];

                    Console.WriteLine($"{bossName}, The {title}");
                    Console.WriteLine($">> Strength: {bossName.Length}");
                    Console.WriteLine($">> Armor: {title.Length}");
                }

                else
                {
                    Console.WriteLine($"Access denied!");
                }
            }
        }
    }
}
