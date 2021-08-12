using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given a count of wagons in a train n.On the next n lines you will receive how many people are going to get on each wagon. At the end print the whole train and after that, on the next line, the sum of the people in the train. 

            int n = int.Parse(Console.ReadLine());

            int[] train = new int[n];

            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());

                train[i] = people;
            }

            int totalPeople = 0;

            for (int i = 0; i < train.Length; i++)
            {
                totalPeople += train[i];

                Console.Write(train[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(totalPeople);
        }
    }
}
