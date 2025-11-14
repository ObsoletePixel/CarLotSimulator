using System;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            
            var lot = new CarLot();
            
            var firstCar = new Car();
            
            firstCar.Year = 2016;
            firstCar.Make = "BMW";
            firstCar.Model = "330i";
            firstCar.IsDriveable = true;
            firstCar.MakeEngineNoise("Good");
            firstCar.MakeHonkNoise("loud");
            lot.Cars.Add(firstCar);

            var secondCar = new Car()
            {
                Make = "Kia",
                Model = "Sorento",
                Year = 2020,
                IsDriveable = true
            };
            secondCar.MakeEngineNoise("Good");
            secondCar.MakeHonkNoise("normal");
            lot.Cars.Add(secondCar);
            

            var thirdCar = new Car(2016, "Jeep", "Liberty", false);
            thirdCar.MakeEngineNoise("Quiet");
            thirdCar.MakeHonkNoise("none");
            lot.Cars.Add(thirdCar);
            
            Console.WriteLine($"Number of Cars in the lot: {CarLot.NumberOfCars}");
            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }

            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
