using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] splitted = input.Split();
                string name = splitted[0];
                string id = splitted[1];
                int age = int.Parse(splitted[2]);
                Student student = new Student();
                student.Name = name;
                student.ID = id;
                student.Age = age;
                students.Add(student);
                input = Console.ReadLine();
            }
            //for (int i = 0; i < students.Count; i++)
            //{
            //    int minIndex = i;
            //    for (int j = i; j < students.Count; j++)
            //    {
            //        if (students[j].Age<students[minIndex].Age)
            //        {
            //            minIndex = j;
            //        }
            //else if (students[j].Age==students[minIndex].Age)
            //{
            //    if (students[j].Name.CompareTo(students[minIndex].Name)>0
            //    {
            //        minIndex = j;
            //    }
            //}  
            //    Student temp = students[minIndex];
            //    students[minIndex] = students[i];
            //    students[i] = temp;
            //}

            students = students.OrderBy(student => student.Age).ThenBy(student => student.Name).ThenBy(student => student.ID).ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }

    class Student 
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return ($"{Name} with ID: {ID} is {Age} years old.");
        }
    }
}
