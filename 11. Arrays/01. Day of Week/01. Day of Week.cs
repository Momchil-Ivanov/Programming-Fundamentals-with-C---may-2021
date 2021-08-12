using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter a day number[1…7] and print the name(in English) or "Invalid day!"
            int day = int.Parse(Console.ReadLine());
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            if (day < 1 || day > 7)
            {
                Console.WriteLine($"Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[day - 1]);

            }
        }
    }
}
