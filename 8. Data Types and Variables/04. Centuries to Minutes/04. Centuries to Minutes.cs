using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Write program to enter an integer number of centuries and convert it to years, days, hours and minutes.
            //Examples
            //Input   Output
            //1   1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
            //5   5 centuries = 500 years = 182621 days = 4382904 hours = 262974240 minutes
            //Hints
            //•	Use appropriate data type to fit the result after each data conversion.
            //•	Assume that a year has 365.2422 days at average(the Tropical year).

            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int) (years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years:f0} years = {days:f0} days = {hours:f0} hours = {minutes:f0} minutes");          
        }
    }
}
