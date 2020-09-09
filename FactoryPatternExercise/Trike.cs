using System;
namespace FactoryPatternExercise
{
    public class Trike : IVehicle
    {
        public Trike()
        {
        }

        public void Drive()
        {
            Console.WriteLine("This trike is gonna flip");
        }
    }
}
