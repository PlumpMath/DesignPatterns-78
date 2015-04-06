using Decorator.AbstractClasses;
using Decorator.Contracts;

namespace Decorator.ConcreteClasses
{
    public class LeatherSeatedVehicle : AbstractVehicleOption
    {
        public LeatherSeatedVehicle(IVehicle vehicle)
            : base(vehicle)
        {
        }

        public override int Price
        {
            get
            {
                return decoratedVehicle.Price + 1200;
            }
        }
    }
}
