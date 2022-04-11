using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExcercise
{
    public class Car : IVehicle
    {
        public Car()
        {
            Console.WriteLine("Building a new Car!");
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving");
        }
    }
}
