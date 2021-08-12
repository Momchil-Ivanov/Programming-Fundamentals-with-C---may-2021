using System;
using System.Linq;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string[] instruction = Console.ReadLine().Split("|").ToArray();

            while (instruction[0] != "Decode")
            {
                if (instruction[0] == "Move")
                {
                    int numberOfLetters = int.Parse(instruction[1]);
                    string substring = message.Substring(0, numberOfLetters);
                    message = message.Remove(0, numberOfLetters);
                    message += substring;
                }

                else if (instruction[0] == "Insert")
                {
                    int index = int.Parse(instruction[1]);
                    string value = instruction[2];

                    message = message.Insert(index, value);
                }

                else if (instruction[0] == "ChangeAll")
                {
                    string substring = instruction[1];
                    string replacement = instruction[2];

                    message = message.Replace(substring, replacement);
                }

                instruction = Console.ReadLine().Split("|").ToArray();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
