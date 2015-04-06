using Decorator.AbstractClasses;
using Decorator.Contracts;

namespace Decorator.ConcreteClasses
{
    public class SatNavVehicle : AbstractVehicleOption
    {
        public SatNavVehicle(IVehicle vehicle)
            : base(vehicle)
        {
        }

        public override int Price
        {
            get
            {
                return decoratedVehicle.Price + 1500;
            }
        }

        public virtual string Destination
        {
            set
            {
                // code to set the destination...
            }
        }

    }
}
