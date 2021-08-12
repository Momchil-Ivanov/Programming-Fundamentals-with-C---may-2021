using System;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            double countOfStudents = double.Parse(Console.ReadLine());
            double countOfLectures = double.Parse(Console.ReadLine());
            double initialBonus = double.Parse(Console.ReadLine());

            double maxBonus = 0;
            double attendaceMax = 0;

            for (int i = 0; i < countOfStudents; i++)
            {
                double attendanceOfStudent = double.Parse(Console.ReadLine());
                if (attendanceOfStudent>attendaceMax)
                {
                    attendaceMax = attendanceOfStudent;
                }
            }

            maxBonus = (attendaceMax / countOfLectures) * (5 + initialBonus);

            if (maxBonus > 0)
            {
                Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            }
            else
            {
                Console.WriteLine($"Max Bonus: 0.");

            }
            Console.WriteLine($"The student has attended {attendaceMax} lectures.");
        }
    }
}
