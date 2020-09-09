using System;
namespace FactoryPatternExercise
{
    public class Truck : IVehicle
    {
        public Truck()
        {
        }

        public void Drive()
        {
            Console.WriteLine("This truck is truckin'!"); 
        }
    }
}
