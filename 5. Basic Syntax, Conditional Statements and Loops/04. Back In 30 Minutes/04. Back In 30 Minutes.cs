using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads hours and minutes from the console and calculates the time after 30 minutes
            //The hours and the minutes come on separate lines

            int hours = int.Parse(Console.ReadLine());

            int minutes = int.Parse(Console.ReadLine());

            if (minutes>=30)
            {
                minutes -= 30;
                hours += 1;
                if (hours == 24)
                {
                    hours = 0;
                }
            }

            else
            {
                minutes += 30;
            }

            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
