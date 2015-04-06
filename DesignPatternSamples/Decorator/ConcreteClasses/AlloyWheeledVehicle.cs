using Decorator.AbstractClasses;
using Decorator.Contracts;

namespace Decorator.ConcreteClasses
{
    public class AlloyWheeledVehicle : AbstractVehicleOption
    {
        public AlloyWheeledVehicle(IVehicle vehicle)
            : base(vehicle)
        {
        }

        public override int Price
        {
            get
            {
                return decoratedVehicle.Price + 250;
            }
        }
    }
}
