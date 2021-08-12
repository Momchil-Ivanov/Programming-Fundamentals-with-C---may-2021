using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([:|*]){2,2}[A-Z]{1,}[a-z]{2,}\1{2,2}";
            string numberPattern = "[0-9]";
            string input = Console.ReadLine();
            List<string> finalEmojis = new List<string>();

            int coolThreshold = 1;

            Regex rgxNumberPattern = new Regex(numberPattern);
            foreach (Match match in rgxNumberPattern.Matches(input))
            {
                coolThreshold *= int.Parse(match.Value);
            }

            int emojiCount = 0;

            Regex rgxPattern = new Regex(pattern);
            foreach (Match match in rgxPattern.Matches(input))
            {
                int value = 0;
                string result = match.ToString();
                string originalResult = result;
                result = result.Remove(result.Length - 2, 2);
                result = result.Remove(0, 2);

                foreach (char c in result)
                {
                    value += System.Convert.ToInt32(c);
                }

                if (value >= coolThreshold)
                {
                    finalEmojis.Add(originalResult);
                }

                emojiCount++;
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{emojiCount} emojis found in the text. The cool ones are:");
            for (int i = 0; i < finalEmojis.Count; i++)
            {
                Console.WriteLine(finalEmojis[i]);
            }      
        }
    }
}
