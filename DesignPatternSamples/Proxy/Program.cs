using Proxy.ConcreteClasses;
using Proxy.Contracts;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new EngineProxy(1300, false);
            engine.Diagnose(new EngineDiagnosticTool());
            Console.Read();
        }
    }
}
