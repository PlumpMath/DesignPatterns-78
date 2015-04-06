using Bridge.AbstractClasses;
using Bridge.ConcreteClasses;
using Bridge.Contracts;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new StandardEngine(1300);
            AbstractDriverControls controls = new StandardControls(engine);
            controls.IgnitionOn();
            controls.Accelerate();
            controls.Brake(); 
            controls.IgnitionOff();

            // Can use a different engine without changing the driver controls
            IEngine turbo = new TurboEngine(1300);
            controls = new SportControls(turbo);
            controls.IgnitionOn();
            controls.Accelerate();
            controls.Brake();
            controls.IgnitionOff();

            Console.Read();
        }
    }
}
