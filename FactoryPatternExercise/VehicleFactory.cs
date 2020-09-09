using System;
namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelCount)
        {
            switch (wheelCount)
            {
                case 2:
                    return new Motorcycle();
                case 3:
                    return new Trike();
                case 4:
                    return new Truck();
                default:
                    return new Truck();
                    
            }
        }
    }
}
