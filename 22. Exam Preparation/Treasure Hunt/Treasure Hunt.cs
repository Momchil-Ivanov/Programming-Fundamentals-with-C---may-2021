using System;
using System.Collections.Generic;
using System.Linq;

namespace Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> loot = Console.ReadLine().Split("|").ToList();
            string command = Console.ReadLine();

            double sum = 0;
            double sumAverage = 0;
            while (command!="Yohoho!")
            {
                List<string> partOfCommands = command.Split(" ").ToList();
                if (partOfCommands[0]=="Loot")
                {
                    for (int i = 1; i < partOfCommands.Count; i++)
                    {
                        if (!loot.Contains(partOfCommands[i]))
                        {
                            loot.Insert(0, partOfCommands[i]);
                        }
                    }
                }
                if (partOfCommands[0] == "Drop")
                {
                    int index = int.Parse(partOfCommands[1]);
                    if (index >= 0 && index < loot.Count)
                    {
                        string movedItem = loot[index];
                        loot.RemoveAt(index);
                        loot.Add(movedItem);
                    }
                }
                if (partOfCommands[0] == "Steal")
                {
                    List<string> stealedLoot = new List<string>();
                    int count = int.Parse(partOfCommands[1]);
                    if (count>loot.Count)
                    {
                        for (int i = 0; i < loot.Count; i++)
                        {
                            stealedLoot.Add(loot[i]);
                        }
                        loot.RemoveRange(0, loot.Count);
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stealedLoot.Add(loot[loot.Count-1]);
                            loot.RemoveAt(loot.Count - 1);
                        }
                        stealedLoot.Reverse();
                    }
                    Console.WriteLine(String.Join(", ", stealedLoot));
                    stealedLoot.RemoveRange(0, stealedLoot.Count);
                }
                command = Console.ReadLine();
            }
            if (loot.Count>0)
            {
                for (int i = 0; i < loot.Count; i++)
                {
                    string lootWord = loot[i];
                    double wordValue = lootWord.Length;
                    sum += wordValue;
                }
                sumAverage = sum / loot.Count;
                Console.WriteLine($"Average treasure gain: {sumAverage:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine($"Failed treasure hunt.");
            }
        }
    }
}
