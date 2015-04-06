using Facade.ConcreteClasses;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFacade facade = new VehicleFacade();
            facade.PrepareForSale(new Saloon(new StandardEngine(1300)));

            Console.Read();
        }
    }
}
