using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intOfTargetList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                List<string> partsOfCommand = command.Split(' ').ToList();
                int index = int.Parse(partsOfCommand[1]);
                int value = int.Parse(partsOfCommand[2]);
                if (partsOfCommand[0] == "Shoot" && index < intOfTargetList.Count && index >= 0)
                {
                    intOfTargetList[index] -= value;
                    if (intOfTargetList[index] <= 0)
                    {
                        intOfTargetList.RemoveAt(index);
                    }
                }
                else if (partsOfCommand[0] == "Add")
                {
                    if (index >= intOfTargetList.Count || index < 0)
                    {
                        Console.WriteLine($"Invalid placement!");
                    }
                    else
                    {
                        intOfTargetList.Insert(index, value);
                    }
                }
                else if (partsOfCommand[0] == "Strike")
                {
                    int startOfRemoval = index - value;
                    int limitOfRemoval = index + value;
                    if (startOfRemoval < 0 || limitOfRemoval >= intOfTargetList.Count || index >= intOfTargetList.Count || index < 0)
                    {
                        Console.WriteLine($"Strike missed!");
                    }
                    else
                    {
                        int countOfRemovedTargets = 1 + 2 * value;
                        intOfTargetList.RemoveRange(startOfRemoval, countOfRemovedTargets);
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join('|', intOfTargetList));
        }
    }
}