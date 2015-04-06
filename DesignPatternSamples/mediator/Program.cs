using System;

namespace mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            EngineManagementSystem ems = new EngineManagementSystem();

            Ignition ignition = new Ignition(ems);
            Gearbox gearbox = new Gearbox(ems);
            Accelerator accelerator = new Accelerator(ems);
            Brake brake = new Brake(ems);

            ignition.Start();
            accelerator.AccelerateToSpeed(30);
            gearbox.Gear = Gear.Fourth;
            brake.Apply();

            Console.Read();
        }
    }
}
