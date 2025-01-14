﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot parkingDeck = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            Car myCar = new Car("Toyota", "Camry", 2004, "BRUPBRUPBRUPBRUPBRUP", "HOOOONK", true);
            parkingDeck.carsInLot.Add(myCar);
            Console.WriteLine(CarLot.numberOfCars);

            Car momCar = new Car()
            {
                Make = "Volvo",
                Model = "S-60",
                Year = 2013,
                EngineNoise = "ngngngngngngngn",
                HonkNoise = "MEEEEEHHHH",
                IsDrivable = true,
            };
            parkingDeck.carsInLot.Add(momCar);
            Console.WriteLine(CarLot.numberOfCars);

            Car dadCar = new Car();
            dadCar.Make = "Lincoln";
            dadCar.Model = "MK-Z";
            dadCar.Year = 2014;
            dadCar.EngineNoise = "BZZZZZZZZZ";
            dadCar.HonkNoise = "BAP";
            dadCar.IsDrivable = true;
            parkingDeck.carsInLot.Add(dadCar);
            Console.WriteLine(CarLot.numberOfCars);
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            myCar.MakeEngineNoise("RRRRRRRRRR");
            myCar.MakeHonkNoise("HONK");
            momCar.MakeEngineNoise("kthunk");
            momCar.MakeHonkNoise("BEEP");
            dadCar.MakeEngineNoise("CHUGACHUGA");
            dadCar.MakeHonkNoise("BRRRRP");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(Car c in parkingDeck.carsInLot)
            {
                Console.WriteLine($"The make is {c.Make}");
                Console.WriteLine($"The model is {c.Model}");
                Console.WriteLine($"The year is {c.Year}");
            }
        }
    }
}
