using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();

            while (command != "No More Money")
            {
                List<string> partsOfCommand = command.Split(" ").ToList();
                if (partsOfCommand[0]== "OutOfStock")
                {
                    while (list.Contains(partsOfCommand[1]))
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == partsOfCommand[1])
                            {
                                list[i] = "None";
                            }
                        }
                    }
                }
                if (partsOfCommand[0] == "Required")
                {
                    int index = int.Parse(partsOfCommand[2]);
                    if (index >= 0 && index < list.Count)
                    {
                        if (list[index] != "None")
                        {
                            list[index] = partsOfCommand[1];
                        }
                    }
                }
                if (partsOfCommand[0] == "Last")
                {
                    list.Add(partsOfCommand[1]);
                }
                command = Console.ReadLine();
            }
            while (list.Contains("None"))
            {
                list.Remove("None");
            }

            Console.WriteLine(String.Join(" ", list));
        }
    }
}
