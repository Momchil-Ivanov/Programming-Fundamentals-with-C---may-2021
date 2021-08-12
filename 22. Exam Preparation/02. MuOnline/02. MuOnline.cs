using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> data = input.Split('|').ToList();

            double health = 100;
            double bitcoins = 0;

            for (int i = 0; i < data.Count; i++)
            {
                List<string> currentData = data[i].Split(' ').ToList();
                if (currentData[0] == "potion")
                {
                    health += double.Parse(currentData[1]);
                    if (health > 100)
                    {
                        double overheal = health - 100;
                        double healing = double.Parse(currentData[1]) - overheal;
                        Console.WriteLine($"You healed for {healing} hp.");
                        health = 100;
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {currentData[1]} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }
                else if (currentData[0] == "chest")
                {
                    bitcoins += double.Parse(currentData[1]);
                    Console.WriteLine($"You found {currentData[1]} bitcoins.");
                }
                else
                {
                    health -= double.Parse(currentData[1]);
                    if (health>0)
                    {
                        Console.WriteLine($"You slayed {currentData[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {currentData[0]}.");
                        Console.WriteLine($"Best room: {i+1}");
                        break;
                    }
                }
            }
            if (health>0)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
