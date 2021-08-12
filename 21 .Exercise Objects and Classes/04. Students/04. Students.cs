using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] splitted = input.Split();
                string firstName = splitted[0];
                string secondName = splitted[1];
                double grade = double.Parse(splitted[2]);
                Student student = new Student();
                student.FirstName = firstName;
                student.SecondName = secondName;
                student.Grade = grade;
                students.Add(student);
            }
            students = students.OrderByDescending(student => student.Grade).ThenBy(student => student.FirstName).ThenBy(student => student.SecondName).ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {SecondName}: {Grade:f2}";
        }
    }
}
