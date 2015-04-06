using Proxy.Contracts;
using System;
using System.Threading;

namespace Proxy.ConcreteClasses
{
    public class EngineDiagnosticTool : IDiagnosticTool
    {
        public virtual void RunDiagnosis(object obj)
        {
            Console.WriteLine("Starting engine diagnostic tool for "
                                                                + obj);
            Thread.Sleep(5000);
            Console.WriteLine("Engine diagnosis complete");
        }
    }
}
