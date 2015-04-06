using System;
using Builder.AbstractClasses;
using Builder.Contracts;

namespace Builder.ConcreteClasses
{
    public class VanBuilder : VehicleBuilder
    {
        private AbstractVan vanInProgress;

        public VanBuilder(AbstractVan van)
        {
            vanInProgress = van;
        }

        public override void BuildBody()
        {
            Console.WriteLine("building van body");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("building van chassis");
        }

        public override void BuildReinforcedStorageArea()
        {
            Console.WriteLine("building van storage area");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("building van windows");
        }

        public override IVehicle Vehicle
        {
            get
            {
                return vanInProgress;
            }
        }
    }
}