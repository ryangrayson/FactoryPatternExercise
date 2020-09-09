using System;
namespace FactoryPatternExercise
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {

        }

        public void Drive()
        {
            Console.WriteLine("This motorcycle is ripping! Woo!");
        }

      
        
    }
}
