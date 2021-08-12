using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstWorker = double.Parse(Console.ReadLine());
            double secondWorker = double.Parse(Console.ReadLine());
            double thirdWorker = double.Parse(Console.ReadLine());
            double people = double.Parse(Console.ReadLine());

            double totalWorkPerHour = firstWorker + secondWorker + thirdWorker;
            double hourCounter = 0;
            double breakCounter = 0;
            while (people > 0)
            {
                hourCounter++;
                breakCounter++;
                if (breakCounter == 4)
                {
                    people += totalWorkPerHour;
                    breakCounter = 0;
                }
                people -= totalWorkPerHour;                     
            }

            Console.WriteLine($"Time needed: {hourCounter}h.");
        }
    }
}
