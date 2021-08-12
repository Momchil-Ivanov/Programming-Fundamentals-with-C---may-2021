using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, int> heroesHealth = new Dictionary<string, int>();
            Dictionary<string, int> heroesMana = new Dictionary<string, int>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] heroData = Console.ReadLine().Split(" ").ToArray();

                string heroName = heroData[0];
                int heroHealth = int.Parse(heroData[1]);
                int heroMana = int.Parse(heroData[2]);

                if (heroHealth > 100)
                {
                    heroHealth = 100;
                }

                if (heroMana > 200)
                {
                    heroMana = 200;
                }

                heroesHealth.Add(heroName, heroHealth);
                heroesMana.Add(heroName, heroMana);
            }

            string[] command = Console.ReadLine().Split(" - ").ToArray();

            while (command[0] != "End")
            {
                string action = command[0];
                string heroName = command[1];

                if (action == "CastSpell")
                {
                    int manaNeeded = int.Parse(command[2]);
                    string spellName = command[3];

                    if (heroesMana[heroName] < manaNeeded)
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }

                    else
                    {
                        heroesMana[heroName] -= manaNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesMana[heroName]} MP!");
                    }
                }

                if (action == "TakeDamage")
                {
                    int damage = int.Parse(command[2]);
                    string attacker = command[3];

                    if (heroesHealth[heroName] <= damage)
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroesHealth.Remove(heroName);
                        heroesMana.Remove(heroName);
                    }

                    else
                    {
                        heroesHealth[heroName] -= damage;
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesHealth[heroName]} HP left!");
                    }
                }

                if (action == "Recharge")
                {
                    int amount = int.Parse(command[2]);

                    int startingHeroMana = heroesMana[heroName];
                    heroesMana[heroName] += amount;

                    if (heroesMana[heroName] > 200)
                    {
                        heroesMana[heroName] = 200;                        
                    }
                  
                    int amountRecovered = heroesMana[heroName] - startingHeroMana;
                    Console.WriteLine($"{heroName} recharged for {amountRecovered} MP!");
                }

                if (action == "Heal")
                {
                    int amount = int.Parse(command[2]);

                    int startingHeroHealth = heroesHealth[heroName];
                    heroesHealth[heroName] += amount;

                    if (heroesHealth[heroName] > 100)
                    {
                        heroesHealth[heroName] = 100;
                    }

                    int amountRecovered = heroesHealth[heroName] - startingHeroHealth;
                    Console.WriteLine($"{heroName} healed for {amountRecovered} HP!");
                }

                command = Console.ReadLine().Split(" - ").ToArray();
            }

            var ordered = heroesHealth.OrderByDescending(x => x.Value).ThenBy(key => key.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in ordered)
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"  HP: {item.Value}");
                Console.WriteLine($"  MP: {heroesMana[item.Key]}");
            }
        }
    }
}
