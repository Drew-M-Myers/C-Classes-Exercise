using ClassesExercise;
using System;
using System.Collections.Generic;

namespace ClassExercise
{
    class program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Supra";
            myCar.Year = 1993;

            var NewCar = new Car()
            {
                Make = "Subra",
                Model = "Tribeca",
                Year = 2011
            };

            var NewCar2 = new Car("Ford", "Escape", 2005);

            var carList = new List<Car>() { myCar, NewCar, NewCar2 };

            Console.WriteLine($"I drive a {myCar.Year} {myCar.Make} {myCar.Model}.");
            Console.WriteLine("");
            Console.WriteLine("List of cars I own (not actually)");
            Console.WriteLine("");
            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Year}, {car.Make}, {car.Model}");
            }

        }
    }
}