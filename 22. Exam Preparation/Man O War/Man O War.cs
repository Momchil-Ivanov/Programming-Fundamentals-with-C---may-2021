using System;
using System.Collections.Generic;
using System.Linq;

namespace Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> pirateShip = Console.ReadLine().Split(">").Select(double.Parse).ToList();
            List<double> warShip = Console.ReadLine().Split(">").Select(double.Parse).ToList();
            double maxHealth = double.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            bool lost = false;
            bool gameOver = false;
            while (command!="Retire")
            {
                List<string> commandParts = command.Split(" ").ToList();
                if (commandParts[0]=="Fire")
                {
                    int index = int.Parse(commandParts[1]);
                    int damage = int.Parse(commandParts[2]);
                    if (index>=0 && index<warShip.Count)
                    {
                        warShip[index] -= damage;
                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine($"You won! The enemy ship has sunken.");
                            gameOver = true;
                            break;
                        }
                    }          
                }
                if (commandParts[0] == "Defend")
                {
                    int startIndex = int.Parse(commandParts[1]);
                    int endIndex = int.Parse(commandParts[2]);
                    int damage = int.Parse(commandParts[3]);
                    if (startIndex>=0 && endIndex>=0 && startIndex<pirateShip.Count && endIndex<pirateShip.Count && startIndex!=endIndex)
                    {
                        for (int i = startIndex; i < endIndex+1; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i]<=0)
                            {
                                lost = true;
                            }
                        }
                    }
                    if (lost)
                    {
                        Console.WriteLine($"You lost! The pirate ship has sunken.");
                        gameOver = true;
                        break;
                    }
                }
                if (commandParts[0] == "Repair")
                {
                    int index = int.Parse(commandParts[1]);
                    int health = int.Parse(commandParts[2]);
                    if (index>=0 && index<pirateShip.Count)
                    {
                        pirateShip[index] += health;
                        if (pirateShip[index]>maxHealth)
                        {
                            pirateShip[index] = maxHealth;
                        }
                    }
                }
                if (commandParts[0] == "Status")
                {
                    int count = 0;
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i]<maxHealth/5)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }  
                command = Console.ReadLine();
            }
            if (!gameOver)
            {
                double PirateShipSum = 0;
                double warShipSum = 0;
                for (int i = 0; i < pirateShip.Count; i++)
                {
                    PirateShipSum += pirateShip[i];
                }
                for (int i = 0; i < warShip.Count; i++)
                {
                    warShipSum += warShip[i];
                }
                Console.WriteLine($"Pirate ship status: {PirateShipSum}");
                Console.WriteLine($"Warship status: {warShipSum}");
            }
        }
    }
}
