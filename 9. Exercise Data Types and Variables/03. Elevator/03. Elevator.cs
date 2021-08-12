using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Calculate how many courses will be needed to elevate n persons by using an elevator of capacity of p persons.The input holds two lines: the number of people n and the capacity p of the elevator.
            //                Hints
            //•	You should divide n by p. This gives you the number of full courses(e.g. 17 / 3 = 5).
            //•	If n does not divide p without a remainder, you will need one additional partially full course(e.g. 17 % 3 = 2).
            //•	Another approach is to round up n / p to the nearest integer(ceiling), e.g. 17 / 3 = 5.67  rounds up to 6.
            //•	Sample code for the round-up calculation:


            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityNumber = int.Parse(Console.ReadLine());
            int additionalCourse = 0;

            int remaining = numberOfPeople % capacityNumber;
            if (remaining > 0)
            {
                additionalCourse = 1;

            }
            int coursesNumber = numberOfPeople / capacityNumber + additionalCourse;

            Console.WriteLine(coursesNumber);
        }
    }
}
