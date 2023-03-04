using System;
using System.Collections.Generic;

namespace CarClassLab02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car("Toyota Camry", 30000, 5));
            cars.Add(new Car("Honda Civic", 25000, 4));
            cars.Add(new TaxiCar("Ford Crown Victoria", 20000, 3, "Yellow Cab", 1.2));
            cars.Add(new TaxiCar("Chevrolet Impala", 22000, 3, "Green Cab", 1.1));
            cars.Add(new TaxiCar("Nissan Altima", 18000, 4, "Red Cab", 1.3));

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add a new car");
                Console.WriteLine("2. Print all cars");
                Console.WriteLine("3. Find the cheapest car");
                Console.WriteLine("4. Increase service life of all cars by one year");
                Console.WriteLine("5. Create a new collection with one car of each model");
                Console.WriteLine("6. Exit");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter car model:");
                        string model = Console.ReadLine();
                        Console.WriteLine("Enter car price:");
                        uint price = uint.Parse(Console.ReadLine());
                        Console.WriteLine("Enter car service life:");
                        uint serviceLife = uint.Parse(Console.ReadLine());
                        Console.WriteLine("Is this a taxi car? (y/n)");
                        string isTaxiCar = Console.ReadLine();
                        if (isTaxiCar == "y")
                        {
                            Console.WriteLine("Enter taxi company:");
                            string company = Console.ReadLine();
                            Console.WriteLine("Enter coefficient:");
                            double coefficient = Convert.ToDouble(Console.ReadLine());
                            cars.Add(new TaxiCar(model, price, serviceLife, company, coefficient));
                        }
                        else
                        {
                            cars.Add(new Car(model, price, serviceLife));
                        }
                        break;
                    case 2:
                        foreach (Car car in cars)
                        {
                            Console.WriteLine(car.ToString());
                        }
                        break;
                    case 3:
                        Car cheapestCar = null;
                        foreach (Car car in cars)
                        {
                            if (cheapestCar == null || car.Price < cheapestCar.Price)
                            {
                                cheapestCar = car;
                            }
                        }
                        Console.WriteLine("The cheapest car is:");
                        Console.WriteLine(cheapestCar.ToString());
                        break;
                    case 4:
                        foreach (Car car in cars)
                        {
                            car.ServiceLife++;
                        }
                        Console.WriteLine("Service life of all cars increased by one year.");
                        break;
                    case 5:
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
