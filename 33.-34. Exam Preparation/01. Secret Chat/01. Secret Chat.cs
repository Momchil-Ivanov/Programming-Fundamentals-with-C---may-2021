using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();

            string[] operation = Console.ReadLine().Split(":|:").ToArray();

            while (operation[0] != "Reveal")
            {
                if (operation[0] == "InsertSpace")
                {
                    int index = int.Parse(operation[1]);
                    concealedMessage = concealedMessage.Insert(index, " ");
                    Console.WriteLine(concealedMessage);
                }

                else if (operation[0] == "Reverse")
                {
                    string substring = operation[1];

                    if (concealedMessage.Contains(substring))
                    {
                        var regex = new Regex(Regex.Escape(substring));
                        concealedMessage = regex.Replace(concealedMessage, "", 1);

                        char[] reversed = substring.ToCharArray();
                        Array.Reverse(reversed);
                        concealedMessage += new string(reversed);

                        Console.WriteLine(concealedMessage);
                    }
                    else
                    {
                        Console.WriteLine($"error");
                    }
                }

                else if (operation[0] == "ChangeAll")
                {
                    string substring = operation[1];
                    string replacement = operation[2];
                    concealedMessage = concealedMessage.Replace(substring, replacement);
                    Console.WriteLine(concealedMessage);
                }
                operation = Console.ReadLine().Split(":|:").ToArray();
            }

            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }
    }
}
