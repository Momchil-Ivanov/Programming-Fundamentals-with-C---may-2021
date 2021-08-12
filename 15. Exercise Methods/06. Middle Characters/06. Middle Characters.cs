using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args) // задача за намиране на средно разположени числа
        {
            string input = Console.ReadLine();

            string result = printMiddleCharacter(input);

            Console.WriteLine(result);
        }

        static string printMiddleCharacter(string word)
        {
            string result = string.Empty;

            if (word.Length % 2 == 1)
            {
                result = word[word.Length / 2].ToString();
            }
            else
            {
                result = word[word.Length / 2 - 1].ToString();
                result += word[word.Length / 2]; // при четен брой 2 числа се явяват средни
            }

            return result;
        }
    }
}
