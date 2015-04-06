using Flyweight.ConcreteClasses;
using FlyWeight.Contracts;
using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the flyweight factory...
            EngineFlyweightFactory factory = new EngineFlyweightFactory();

            // Create the diagnostic tool
            IDiagnosticTool tool = new EngineDiagnosticTool();

            // Get the flyweights and run diagnostics on them
            IEngine standard1 = factory.GetStandardEngine(1300);
            standard1.Diagnose(tool);

            IEngine standard2 = factory.GetStandardEngine(1300);
            standard2.Diagnose(tool);

            IEngine standard3 = factory.GetStandardEngine(1300);
            standard3.Diagnose(tool);

            IEngine standard4 = factory.GetStandardEngine(1600);
            standard4.Diagnose(tool);

            IEngine standard5 = factory.GetStandardEngine(1600);
            standard5.Diagnose(tool);

            // Show that objects are shared
            Console.WriteLine(standard1.GetHashCode());
            Console.WriteLine(standard2.GetHashCode());
            Console.WriteLine(standard3.GetHashCode());
            Console.WriteLine(standard4.GetHashCode());
            Console.WriteLine(standard5.GetHashCode());

            Console.Read();
        }
    }
}
