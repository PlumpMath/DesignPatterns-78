using System;
using Visitor.ConcreteClasses;
using Visitor.Contracts;
using Visitor.ImplementationClasses;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an engine...
            IEngine engine = new StandardEngine(1300);

            // Run diagnostics on the engine...
            engine.AcceptEngineVisitor(new EngineDiagnostics());

            // Run inventory on the engine...
            engine.AcceptEngineVisitor(new EngineInventory());

            Console.Read();
        }
    }
}
