using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registrations = new Dictionary<string, string>();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "register")
                {
                    if (!registrations.ContainsKey(input[1])) 
                    {
                        registrations.Add(input[1], input[2]);
                        Console.WriteLine($"{input[1]} registered {input[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {input[2]}");
                    }
                }
                else
                {
                    if (registrations.ContainsKey(input[1]))
                    {
                        registrations.Remove(input[1]);
                        Console.WriteLine($"{input[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                    }
                }
            }

            foreach (var registration in registrations)
            {
                Console.WriteLine($"{registration.Key} => {registration.Value}");
            }
        }
    }
}
