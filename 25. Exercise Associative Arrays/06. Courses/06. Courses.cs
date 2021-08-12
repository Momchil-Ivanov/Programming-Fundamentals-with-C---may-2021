using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> registered = new Dictionary<string, List<string>>();

            string courseAndStudent;

            while ((courseAndStudent = Console.ReadLine()) != "end")
            {
                string[] courseSplitted = courseAndStudent.Split(" : ").ToArray();

                string courseName = courseSplitted[0];
                string studentName = courseSplitted[1];

                if (!registered.ContainsKey(courseName))
                {
                    registered.Add(courseName, new List<string>() { studentName });
                }
                else
                {
                    registered[courseName].Add(studentName);
                }
            }

            foreach (var course in registered.OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count()}");

                foreach (var name in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}