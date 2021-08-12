using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args) // задачата няма нужда от коментар
        {
            string password = Console.ReadLine();

            bool isValidLenght = isValidLength(password);
            bool isValidSymbols = IsValidSymbols(password);
            bool containsTwoDigits = ContainsTwoDigits(password);

            if (isValidLenght && isValidSymbols && containsTwoDigits)
            {
                Console.WriteLine($"Password is valid");
            }
        }

        static bool ContainsTwoDigits(string password)
        {
            bool containsTwoDigits = password.Count(char.IsDigit) >= 2; ;
            if (!containsTwoDigits)
            {
                Console.WriteLine($"Password must have at least 2 digits");
                return false;
            }
            return true;
        }

        static bool IsValidSymbols(string password)
        {
            bool isValidSymbols = password.All(char.IsLetterOrDigit);
            if (!isValidSymbols)
            {
                Console.WriteLine($"Password must consist only of letters and digits");
                return false;
            }
            return true;

        }

         static bool isValidLength(string password)
        {
            bool isValidLength = password.Length >= 6 && password.Length <= 10;
            if (!isValidLength)
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
                return false;
            }
            return true;
        }

        
        
    }
} 
