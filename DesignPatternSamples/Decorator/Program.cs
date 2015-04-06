using Decorator.ConcreteClasses;
using Decorator.Contracts;
using Decorator.Enums;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a blue saloon car
            IVehicle myCar = new Saloon(new StandardEngine(1300));
            myCar.Paint(VehicleColour.Blue);
            Console.WriteLine(myCar);

            // Add air-conditioning to the car...
            myCar = new AirConditionedVehicle(myCar);
            Console.WriteLine(myCar);

            // Now add alloy wheels...
            myCar = new AlloyWheeledVehicle(myCar);
            Console.WriteLine(myCar);

            // Now add leather seats...
            myCar = new LeatherSeatedVehicle(myCar);
            Console.WriteLine(myCar);

            // Now add metallic paint...
            myCar = new MetallicPaintedVehicle(myCar);
            Console.WriteLine(myCar);

            // Now add satellite navigation
            myCar = new SatNavVehicle(myCar);
            Console.WriteLine(myCar);

            Console.Read();
        }
    }
}
