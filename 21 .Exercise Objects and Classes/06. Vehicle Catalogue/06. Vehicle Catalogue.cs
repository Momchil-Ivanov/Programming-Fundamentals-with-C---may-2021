using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string input = Console.ReadLine();
            double totalHsCar = 0;
            double totalHsTruck = 0;
            double dividerCar = 0;
            double dividerTruck = 0;
            while (input != "End")
            {
                string[] splitted = input.Split();
                string type = splitted[0];
                string model = splitted[1];
                string color = splitted[2];
                double horsePower = int.Parse(splitted[3]);
                if (type == "car")
                {
                    type = "Car";
                    dividerCar++;
                    totalHsCar += horsePower;
                }
                else
                {
                    type = "Truck";
                    dividerTruck++;
                    totalHsTruck += horsePower;
                }
                Vehicle vehicle = new Vehicle();
                vehicle.Type = type;
                vehicle.Model = model;
                vehicle.Color = color;
                vehicle.Horsepower = horsePower;
                vehicles.Add(vehicle);
                input = Console.ReadLine();
            }
            if (dividerCar==0)
            {
                dividerCar = 1;
            }
            if (dividerTruck==0)
            {
                dividerTruck = 1;
            }
            List<string> models = new List<string>();
            while (input != "Close the Catalogue")
            {
                models.Add(input);
                input = Console.ReadLine();
            }
            for (int i = 0; i < models.Count; i++)
            {
                foreach (var vehicle in vehicles)
                {
                    if (models[i] == vehicle.Model)
                    {
                        Console.WriteLine($"Type: {vehicle.Type}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                    }
                }
            }
            double averageHsCar = totalHsCar / dividerCar;
            double averageHsTruck = totalHsTruck / dividerTruck;
            Console.WriteLine($"Cars have average horsepower of: {averageHsCar:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHsTruck:f2}.");
        }
    }
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }
    }

}
