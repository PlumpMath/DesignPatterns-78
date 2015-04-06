using System;
using AbstractFactory.AbstractClasses;
using AbstractFactory.Contracts;
using AbstractFactory.ConcreteClasses;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string whatToMake = "car"; // or "van"

            AbstractVehicleFactory factory = null;

            if (whatToMake.Equals("car"))
            {
                factory = new CarFactory();
            }
            else
            {
                factory = new VanFactory();
            }

            // Create the vehicle's component parts...
            // These will either be all car parts or all van parts
            IBody vehicleBody = factory.CreateBody();
            IChassis vehicleChassis = factory.CreateChassis();
            IGlassware vehicleWindows = factory.CreateGlassware();

            // Show what we've created...
            Console.WriteLine(vehicleBody.BodyParts);
            Console.WriteLine(vehicleChassis.ChassisParts);
            Console.WriteLine(vehicleWindows.GlasswareParts);
            Console.Read();
        }
    }
}