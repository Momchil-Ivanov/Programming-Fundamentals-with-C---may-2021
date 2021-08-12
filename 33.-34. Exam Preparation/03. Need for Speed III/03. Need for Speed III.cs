using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            Dictionary<string, int> carsMileage = new Dictionary<string, int>();
            Dictionary<string, int> carsFuel = new Dictionary<string, int>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split("|").ToArray();
                string model = carInfo[0];
                int mileage = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);

                if (fuel > 75)
                {
                    fuel = 75;
                }

                carsMileage.Add(model, mileage);
                carsFuel.Add(model, fuel);
            }

            string[] command = Console.ReadLine().Split(" : ").ToArray();

            while (command[0] != "Stop")
            {
                string car = command[1];

                if (command[0] == "Drive")
                {
                    int distance = int.Parse(command[2]);
                    int fuel = int.Parse(command[3]);

                    if (carsFuel[car] < fuel)
                    {
                        Console.WriteLine($"Not enough fuel to make that ride");
                    }
                    else
                    {
                        carsFuel[car] -= fuel;
                        carsMileage[car] += distance;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                        if (carsMileage[car] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            carsFuel.Remove(car);
                            carsMileage.Remove(car);
                        }
                    }
                }

                else if (command[0] == "Refuel")
                {
                    int fuel = int.Parse(command[2]);

                    int originalFuel = carsFuel[car];

                    carsFuel[car] += fuel;

                    if (carsFuel[car] > 75)
                    {
                        carsFuel[car] = 75;
                    }

                    Console.WriteLine($"{car} refueled with {carsFuel[car]-originalFuel} liters");
                }

                else if (command[0] == "Revert")
                {
                    int kilometeres = int.Parse(command[2]);

                    carsMileage[car] -= kilometeres;

                    if (carsMileage[car] < 10000)
                    {
                        carsMileage[car] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometeres} kilometers");
                    }
                }

                command = Console.ReadLine().Split(" : ").ToArray();
            }

            var ordered = carsMileage.OrderByDescending(x => x.Value).ThenBy(key => key.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var car in ordered)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value} kms, Fuel in the tank: {carsFuel[car.Key]} lt.");
            }
        }
    }
}
