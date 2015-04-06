﻿using Facade.Contracts;
using System;

namespace Facade.ConcreteClasses
{
    public class Registration
    {
        private IVehicle vehicle;

        public Registration(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public virtual void AllocateLicensePlate()
        {
            Console.WriteLine("Allocating license plate...");
        }

        public virtual void AllocateVehicleNumber()
        {
            Console.WriteLine("Allocating vehicle number...");
        }
    }
}
