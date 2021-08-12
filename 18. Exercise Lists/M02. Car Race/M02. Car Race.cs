using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> time = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            double sumLeft = 0; // decimal е добре когато става въпрос за пари...тук може и дабъл да ползваме...даже judge дава 90/100 с децимал...
            double sumRight = 0;

            for (int i = 0; i < time.Count / 2; i++)
            {
                sumLeft += time[i];

                if (time[i] == 0)
                {
                    sumLeft *= 0.8;
                }
                //else
                //{
                //    sumLeft += time[i];
                //}

                //if (time[time.Count - i - 1] == 0)
                //{
                //    sumRight *= 0.8m;
                //}
                //else
                //{
                //    sumRight += time[time.Count - i - 1];
                //}
            }

            for (int i = time.Count - 1; i > time.Count / 2; i--)
            {
                sumRight += time[i];

                if (time[i] == 0)
                {
                    sumRight *= 0.8;
                }
            }

            //if (sumLeft <= sumRight) // тук как да разберем кой е победителя ако времето им е И равно "<="
            if (sumLeft < sumRight)
            {
                Console.WriteLine($"The winner is left with total time: {sumLeft}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {sumRight}");
            }
        }
    }
}