using Facade.Contracts;
using System;

namespace Facade.ConcreteClasses
{
    public class Documentation
    {
        public static void PrintBrochure(IVehicle vehicle)
        {
            Console.WriteLine("Printing brochure...");
        }
    }
}
