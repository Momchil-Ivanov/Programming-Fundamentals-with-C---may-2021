using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> neighborhood = Console.ReadLine().Split('@').ToList();
            List<int> myIntList = neighborhood.Select(s => int.Parse(s)).ToList();
            List<int> compareList = myIntList.ToList();
            string action = Console.ReadLine();
            int currentIndex = 0;
            int failedPlaces = 0;
            while (action != "Love!")
            {
                List<string> partsOfAction = action.Split(' ').ToList();
                int jumpLenght = int.Parse(partsOfAction[1]);
                currentIndex += jumpLenght;
                if (currentIndex>=myIntList.Count)
                {
                    currentIndex = 0;
                }
                myIntList[currentIndex] -= 2;
                if (myIntList[currentIndex] <= 0)
                {
                    myIntList[currentIndex] = 0;
                }
                if (myIntList[currentIndex] <= 0 & compareList[currentIndex] > 0)
                {
                    Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                }
                else if (myIntList[currentIndex] <= 0 & compareList[currentIndex] <= 0)
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                }
                compareList.Insert(currentIndex, myIntList[currentIndex]);
                compareList.RemoveAt(currentIndex + 1);
                action = Console.ReadLine();
            }
            for (int i = 0; i < myIntList.Count; i++)
            {
                if (myIntList[i] > 0)
                {
                    failedPlaces++;
                }
            }
            if (failedPlaces>0)
            {
                Console.WriteLine($"Cupid's last position was {currentIndex}.");
                Console.WriteLine($"Cupid has failed {failedPlaces} places.");
            }
            else
            {
                Console.WriteLine($"Cupid's last position was {currentIndex}.");
                Console.WriteLine($"Mission was successful.");
            }
        }
    }
}
