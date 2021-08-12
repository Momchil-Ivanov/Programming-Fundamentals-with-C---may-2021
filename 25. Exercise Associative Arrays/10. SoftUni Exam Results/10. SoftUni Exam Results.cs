using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "exam finished")
            {
                string[] inputData = input.Split("-");

                string userName = inputData[0];
                string programmingLanguage = inputData[1];
       
                if (programmingLanguage == "banned")
                {
                    results.Remove(userName);

                    input = Console.ReadLine();
                    continue;
                }

                int points = int.Parse(inputData[2]);

                if (!results.ContainsKey(userName))
                {
                    results.Add(userName, points);
                }
                else if (results[userName] < points)
                {
                    results[userName] = points;
                }

                if (!submissions.ContainsKey(programmingLanguage))
                {
                    submissions.Add(programmingLanguage, 0);
                }

                submissions[programmingLanguage]++;

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");

            foreach (var (username, points) in results
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{username} | {points}");
            }

            Console.WriteLine("Submissions:");

            foreach (var (language, count) in submissions
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{language} - {count}");
            }
        }
    }
}
