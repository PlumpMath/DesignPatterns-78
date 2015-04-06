using Prototype.ConcreteClasses;
using Prototype.Contracts;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleManager manager = new VehicleManager(); 
            IVehicle saloon1 = manager.CreateSaloon(); 
            IVehicle saloon2 = manager.CreateSaloon(); 
            IVehicle pickup1 = manager.CreatePickup();

            Console.WriteLine(saloon1);
            Console.WriteLine(saloon2);
            Console.WriteLine(pickup1);
            
            Console.WriteLine();
            Console.WriteLine("Lazy...");
            Console.WriteLine();
            
            VehicleManagerLazy managerlazy = new VehicleManagerLazy();
            IVehicle saloon11 = manager.CreateSaloon();
            IVehicle saloon22 = manager.CreateSaloon();
            IVehicle pickup11 = manager.CreatePickup();

            Console.WriteLine(saloon11);
            Console.WriteLine(saloon22);
            Console.WriteLine(pickup11);

            Console.Read();
        }
    }
}
