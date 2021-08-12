using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that determines whether based on the given age a person is: baby, child, teenager, adult, elder.
            //The bounders are: •	0-2 – baby; •	3-13 – child; •	14-19 – teenager;•	20-65 – adult;•	>=66 – elder;
            //•	All the values are inclusive

            int age = int.Parse(Console.ReadLine());

            if (age>=0 && age<=2)
            {
                Console.WriteLine($"baby");
            }

            if (age >= 3 && age <= 13)
            {
                Console.WriteLine($"child");
            }

            if (age >= 14 && age <= 19)
            {
                Console.WriteLine($"teenager");
            }

            if (age >= 20 && age <= 65)
            {
                Console.WriteLine($"adult");
            }

            if (age >= 66)
            {
                Console.WriteLine($"elder");
            }

        }
    }
}
