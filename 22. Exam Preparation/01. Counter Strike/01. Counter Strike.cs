using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string distance = Console.ReadLine();

            int wonBattles = 0;
            int wonBatlesCounter = 0;
            bool enoughEnergy = true;
            while (distance != "End of battle")
            {
                int intOfDistance = int.Parse(distance);
                if (intOfDistance>energy)
                {
                    enoughEnergy = false;
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    break;
                }
                energy -= intOfDistance;
                wonBattles++;
                wonBatlesCounter++;
                if (wonBatlesCounter == 3)
                {
                    energy += wonBattles;
                    wonBatlesCounter = 0;
                }
                distance = Console.ReadLine();
            }

            if (enoughEnergy)
            {
                Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
            }
        }
    }
}
