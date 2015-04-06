using System;
using Builder.AbstractClasses;
using Builder.Contracts;

namespace Builder.ConcreteClasses
{
    public class CarBuilder : VehicleBuilder
    {
        private AbstractCar carInProgress;

        public CarBuilder(AbstractCar car)
        {
            carInProgress = car;
        }

        public override void BuildBody()
        {
            Console.WriteLine("building car body");
        }

        public override void BuildBoot()
        {
            Console.WriteLine("building car boot");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("building car chassis");
        }

        public override void BuildPassengerArea()
        {
            Console.WriteLine("building car passenger area");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("building car windows");
        }

        public override IVehicle Vehicle
        {
            get
            {
                return carInProgress;
            }
        }
    }
}