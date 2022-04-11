using System;

namespace FactoryPatternExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels will your vehicle have?");
            string numberOfWheels = Console.ReadLine();

            VehicleFactory.GetVehicle(numberOfWheels);
            IVehicle vehicle = VehicleFactory.GetVehicle(numberOfWheels);
            Console.WriteLine();

            vehicle.Drive();
        }
    }
}
