using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string price = Console.ReadLine();

            double totalSum = 0;
            while (price != "regular" && price != "special")
            {
                double doublePrice = double.Parse(price);
                if (doublePrice<0)
                {
                    Console.WriteLine($"Invalid price!");
                }
                else
                {
                    totalSum += doublePrice;
                }
                price = Console.ReadLine();
            }
            double taxes = totalSum * 0.2;
            double totalPrice = totalSum + taxes;
            double totalPriceIfSpecial = totalPrice * 0.9;
            if (totalPrice == 0)
            {
                Console.WriteLine($"Invalid order!");
            }
            else if (price == "regular")
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalSum:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
            else if (price == "special")
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalSum:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {totalPriceIfSpecial:f2}$");
            }
        }
    }
}
