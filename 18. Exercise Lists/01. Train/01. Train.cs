using System;
using System.Collections.Generic;
using System.Linq;

namespace M05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxPassangers = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commonArgs = command.Split();

                if (commonArgs[0] == "Add")
                {
                    int passengers = int.Parse(commonArgs[1]);
                    wagons.Add(passengers);
                }

                else
                {
                    int passengers = int.Parse(commonArgs[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxPassangers)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
