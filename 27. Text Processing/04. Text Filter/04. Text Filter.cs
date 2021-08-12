using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] censoredWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var word in censoredWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
