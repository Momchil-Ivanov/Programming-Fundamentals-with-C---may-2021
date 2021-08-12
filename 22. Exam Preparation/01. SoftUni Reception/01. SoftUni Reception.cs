using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstEmployee = double.Parse(Console.ReadLine());
            double secondEmployee = double.Parse(Console.ReadLine());
            double thirdEmployee = double.Parse(Console.ReadLine());
            double studentsCount = double.Parse(Console.ReadLine());

            double totalStudentsHour = firstEmployee + secondEmployee + thirdEmployee;
            double hours = 0;


            if (studentsCount<=0)
            {
                Console.WriteLine($"Time needed: 0h.");              
            }
            else
            {
                while (studentsCount > 0)
                {
                    studentsCount -= totalStudentsHour;
                    hours++;
                    if (hours%4==0)
                    {
                        hours++;
                    }
                }
                Console.WriteLine($"Time needed: {hours}h.");
            }          
        }
    }
}
