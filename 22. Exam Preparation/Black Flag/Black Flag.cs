using System;

namespace Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double plunderForADay = double.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double totalPlunder = 0;
            double dayCounter = 0;
            for (int i = 0; i < days; i++)
            {
                dayCounter++;
                totalPlunder += plunderForADay;
                if (dayCounter%3==0)
                {
                    totalPlunder += plunderForADay * 0.5;
                }
                if (dayCounter%5==0)
                {
                    totalPlunder -= totalPlunder * 0.3;
                }
            }

            if (totalPlunder>=expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                double percentage = totalPlunder / expectedPlunder * 100;
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
