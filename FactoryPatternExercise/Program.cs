using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           int numberOfWheels;
            bool input = false;

            do
            {
                Console.WriteLine("Enter the amount of wheels for the vehicle you would like to create");

               input = int.TryParse(Console.ReadLine(), out numberOfWheels);
            } while (input == false);

            var vehicle = VehicleFactory.GetVehicle(numberOfWheels);

            vehicle.Drive();

        }
    }
}

//Possible steps:
//Create an Interface named IVehicle that has a stubbed out public void Drive method---DONE
//Create 2 new classes that will conform to IVehicle
//Example) Car, Motorcycle,  BigRig---DONE (Motorcyle and Truck)
//These classes must conform to IVehicle and implement the Drive() method - which will just Console.WriteLine(“Building a new Car!”)
//Now we will make our static VehicleFactory class
//It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given as a parameter
//Call this functionality in the Main method

