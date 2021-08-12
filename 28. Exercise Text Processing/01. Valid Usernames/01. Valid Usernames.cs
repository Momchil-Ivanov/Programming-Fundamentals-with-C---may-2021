using System;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            //sh, too_long_username, !lleg@l ch@rs, jeffbutt
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var currentUsername in input)
            {
                if (currentUsername.Length<3 || currentUsername.Length > 16)
                {
                    continue;
                }

                bool isValid = false;

                foreach (var symbol  in currentUsername)
                {
                    if (!(char.IsLetterOrDigit(symbol) ||                      
                        symbol == '-' ||
                        symbol == '_'))
                    {
                        isValid = false;
                        break;
                    }

                    isValid = true;
                }

                if (isValid)
                {
                    Console.WriteLine(currentUsername);
                }
            }
        }
    }
}
