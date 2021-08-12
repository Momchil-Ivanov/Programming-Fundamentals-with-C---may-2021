using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{
    class Program
    {
        static void Main(string[] args)
        {


            // the string that we want to decode
            string s = Console.ReadLine();
            // the string with the decoded message
            string message = "";

            // array definitions
            string alphabetChars = "abcdefghijklmnopqrstuvwxyz";
            string[] morseChars = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
"..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-",
"...-", ".--", "-..-", "-.--", "--.."};

            // splitting a string into Morse characters
            string[] characters = s.Split(' ');

            // iteration over Morse characters
            foreach (string morseChar in characters)
            {
                char alphabetChar = ' ';
                int index = Array.IndexOf(morseChars, morseChar);
                if (index >= 0) // character was found
                    alphabetChar = alphabetChars[index];
                message += alphabetChar;
            }

            Console.WriteLine(message.ToUpper());
        }
    }
}