using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputParts = input.Split(" -> ");
                if (!companies.ContainsKey(inputParts[0]))
                {
                    companies.Add(inputParts[0], new List<string>());
                }
                if (!companies[inputParts[0]].Contains(inputParts[1]))
                {
                    companies[inputParts[0]].Add(inputParts[1]);
                }
                input = Console.ReadLine();
            }

            foreach (var kvp in companies.OrderBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var employeeID in kvp.Value)
                {
                    Console.WriteLine($"-- {employeeID}");
                }
            }
        }
    }
}
