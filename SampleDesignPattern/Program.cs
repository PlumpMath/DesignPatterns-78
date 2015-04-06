using SampleDesignPattern.ConcreteClasses;
using SampleDesignPattern.Contracts;
using SampleDesignPattern.Enums;
using System;

namespace DesignPatternSample
{
    public class Program
    {
        static void Main()
        {
            IEngine e1 = new StandardEngine(1300);
            IEngine e2 = new TurboEngine(1600);

            IVehicle v1 = new Saloon(e1);
            IVehicle v2 = new Coupe(e1, VehicleColour.Blue);
            IVehicle v3 = new BoxVan(e2, VehicleColour.White);

            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            Console.Read();
        }
    }
}