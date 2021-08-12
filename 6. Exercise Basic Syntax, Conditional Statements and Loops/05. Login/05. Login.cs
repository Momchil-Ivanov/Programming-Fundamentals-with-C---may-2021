using System;
using System.Linq;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given a string representing a username. The password will be that username reversed.Until you receive the correct password print on the console "Incorrect password. Try again.".When you receive the correct password print "User {username} logged in." However on the fourth try if the password is still not correct print "User {username} blocked!" and end the program.
            string name = Console.ReadLine();
            string password = string.Join("", name.Reverse());

           

            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine($"User {name} logged in.");
                    break;
                }

                if (i==3)
                {
                    Console.WriteLine($"User {name} blocked!");
                    break;
                }

                if (input != password)
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
            }
       
        }
}
}
