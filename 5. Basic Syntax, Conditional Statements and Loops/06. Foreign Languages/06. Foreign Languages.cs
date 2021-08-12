using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            //By given country print its typical language:
            //English -> England, USA
            //Spanish -> Spain, Argentina, Mexico
            //other -> unknown

            string country = Console.ReadLine();

            if (country == "England" || country == "USA")
            {
                Console.WriteLine("English");
            }

            else if (country == "Spain" || country == "Argentina"|| country == "Mexico")
            {
                Console.WriteLine("Spanish");
            }

            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
