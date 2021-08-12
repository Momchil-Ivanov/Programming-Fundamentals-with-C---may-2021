using System;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            double biscsPerDayPerWorker = double.Parse(Console.ReadLine());
            double workersCount = double.Parse(Console.ReadLine());
            double numberOfBiscsForOneMonth = double.Parse(Console.ReadLine());

            double productionPerDay = biscsPerDayPerWorker * workersCount;
            double totalProduction = 0;

            for (int i = 1; i <= 30; i++)
            {

                if (i%3==0)
                {
                    totalProduction += Math.Floor(productionPerDay * 0.75);
                }
                else
                {
                  totalProduction += productionPerDay;
                }
            }

            Console.WriteLine($"You have produced {totalProduction} biscuits for the past month.");
            if (totalProduction>numberOfBiscsForOneMonth)
            {
                double differenceMore = totalProduction - numberOfBiscsForOneMonth;
                double percentageMore = (differenceMore/numberOfBiscsForOneMonth) * 100;
                Console.WriteLine($"You produce {percentageMore:f2} percent more biscuits.");
            }
            else
            {
                double differenceLess = numberOfBiscsForOneMonth - totalProduction;
                double percentageLess = (differenceLess / numberOfBiscsForOneMonth) * 100;
                Console.WriteLine($"You produce {percentageLess:f2} percent less biscuits.");
            }
        }
    }
}
