using System;
using Builder.AbstractClasses;
using Builder.ConcreteClasses;
using Builder.Contracts;
using Builder.Enums;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCar car = new Saloon(new TurboEngine(1500), VehicleColour.Blue);
            VehicleBuilder builder = new CarBuilder(car);
            VehicleDirector director = new CarDirector();
            IVehicle v = director.Build(builder);
            Console.WriteLine(v);
            Console.Read();
        }
    }
}