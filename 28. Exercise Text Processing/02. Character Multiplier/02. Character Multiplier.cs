using System;
using System.Collections.Generic;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstWord = s[0];
            string secondWord = s[1];

            List<int> firstWordData = new List<int>();
            List<int> secondWordData = new List<int>();

            int multiplied = 0;
            int sum = 0;

            foreach (char c in firstWord)
            {
                System.Convert.ToInt32(c);
                firstWordData.Add(c);
            }
            foreach (char c in secondWord)
            {
                System.Convert.ToInt32(c);
                secondWordData.Add(c);
            }

            if (firstWordData.Count == secondWordData.Count)
            {
                for (int i = 0; i < firstWordData.Count; i++)
                {
                    multiplied = firstWordData[i] * secondWordData[i];
                    sum += multiplied;
                }
            }

            else if (firstWordData.Count > secondWordData.Count)
            {
                for (int i = 0; i < secondWordData.Count; i++)
                {
                    multiplied = firstWordData[i] * secondWordData[i];
                    sum += multiplied;
                }
                for (int j = secondWordData.Count; j < firstWordData.Count; j++)
                {
                    sum += firstWordData[j];
                }
            }

            else
            {
                for (int i = 0; i < firstWordData.Count; i++)
                {
                    multiplied = firstWordData[i] * secondWordData[i];
                    sum += multiplied;
                }
                for (int j = firstWordData.Count; j < secondWordData.Count; j++)
                {
                    sum += secondWordData[j];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
