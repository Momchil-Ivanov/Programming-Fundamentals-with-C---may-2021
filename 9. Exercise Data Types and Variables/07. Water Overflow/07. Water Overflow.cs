﻿using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //            You have a water tank with capacity of 255 liters.On the next n lines, you will receive liters of water, which you have to pour in your tank. If the capacity is not enough, print "Insufficient capacity!" and continue reading the next line. On the last line, print the liters in the tank.
            //Input
            //The input will be on two lines:
            //•	On the first line, you will receive n – the number of lines, which will follow
            //•	On the next n lines – you receive quantities of water, which you have to pour in the tank
            //Output
            //Every time you do not have enough capacity in the tank to pour the given liters, print:
            //            Insufficient capacity!
            //            On the last line, print only the liters in the tank.
            //Constraints
            //•	n will be in the interval[1…20]
            //•	liters will be in the interval[1…1000]

            int numberOfLines = int.Parse(Console.ReadLine());
            int maxCapacity = 255;
            int sum = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                int currentLiters = int.Parse(Console.ReadLine());
                maxCapacity -= currentLiters;
                if (maxCapacity >= 0)
                {
                    sum += currentLiters;
                }
                else
                {
                    Console.WriteLine($"Insufficient capacity!");
                    maxCapacity += currentLiters;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
