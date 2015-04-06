using FactoryMethod.AbstractClasses;
using FactoryMethod.ConcreteClasses;
using FactoryMethod.Contracts;
using FactoryMethod.Enums;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // I want an economical car, coloured blue... 
            
            VehicleFactory carFactory = new CarFactory(); 
            IVehicle car = carFactory.Build(DrivingStyle.Economical, VehicleColour.Blue); 
            Console.WriteLine(car);   
            
            // I am a "white van man"... 
            VehicleFactory vanFactory = new VanFactory(); 
            IVehicle van = vanFactory.Build(DrivingStyle.Powerful, VehicleColour.White); 
            Console.WriteLine(van);

            // USING STATIC FACTORY

            // Create a red sports car...
            IVehicle sporty = VehicleFactory.Make(Category.Car,
                                                  DrivingStyle.Powerful,
                                                  VehicleColour.Red);
            Console.WriteLine(sporty);
            
            Console.Read();

        }
    }
}
