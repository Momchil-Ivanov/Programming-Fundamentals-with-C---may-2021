using System;
using System.Text;

namespace _00._Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNames = int.Parse(Console.ReadLine()); // четем броя на имената

            int[] finalArray = new int[countOfNames]; // правим масив, в който ще съхраним финалните числени стойности от имената

            for (int j = 0; j < countOfNames; j++) // правим цикъл, който да се повтори толкова пъти, колкото е броят на имената
            {
                string value = Console.ReadLine(); // четем ново име
                // Convert the string into a byte[].
                byte[] asciiBytes = Encoding.ASCII.GetBytes(value); // правим масив, който да съхрани името като сума
                int sum = 0; // начална сума, която е празна
                int currentValue = 0; // начална стойност, която е празна
                for (int i = 0; i < asciiBytes.Length; i++) // цикъл с дължина на масива с името в цифри 
                {
                    if (asciiBytes[i] == 65 || asciiBytes[i] == 97 || asciiBytes[i] == 69 || asciiBytes[i] == 101 || asciiBytes[i] == 73 || asciiBytes[i] == 105 || asciiBytes[i] == 79 || asciiBytes[i] == 111 || asciiBytes[i] == 85 || asciiBytes[i] == 117) // това са стойностите за гласнити по ascii
                    {
                        currentValue = asciiBytes[i]; // настоящата стойност придобива тази по asci
                        currentValue *= value.Length; // умножаваме, тъй като имаме гласна
                    }
                    else
                    {
                        currentValue = asciiBytes[i]; // настоящата стойност придобива тази по asci
                        currentValue /= value.Length; // делим, тъй като имаме гласна
                    }
                    sum += currentValue; // увеличаваме сумата с получената стойност за буквата докато не получим пълната стойност за името

                }
                finalArray[j] = sum; // накрая записваме крайната сума за името като позиция j във финалния масив 
            }
            bool didSwap;
            do
            {
                didSwap = false; // няма размяна
                for (int i = 0; i < finalArray.Length - 1; i++) // дължината е намалена с единица, за да не излезем от масива накрая
                {
                    if (finalArray[i] > finalArray[i + 1]) // проверяваме дали старата сума е по-голяма от новата п
                    {
                        int temp = finalArray[i + 1]; // временна крайна сума
                        finalArray[i + 1] = finalArray[i]; // новата стойност приема старата
                        finalArray[i] = temp; // старата стойност приема новата
                        didSwap = true; // тоест имало е размяна, защото старата стойност е била по-голяма от новата и затова старата трябва да е по-наляво от новата 
                    }
                }
            } while (didSwap); // командата се изпълнява докато има стара стойност, която е по-голяма от новата, защото искаме винаги старата стойност да е по-малка от новата, защото в крайното подреждаме в крайния резултат започваме от най-малкото число към най-голямото
            for (int i = 0; i != finalArray.Length; i++)
            {
                Console.WriteLine(finalArray[i]); // първата нулева позиция ще има число с най-голяма стойност, след което ще последват останалите числа с намаляваща стойност и задачата е решена
            }
        }
    }
}
