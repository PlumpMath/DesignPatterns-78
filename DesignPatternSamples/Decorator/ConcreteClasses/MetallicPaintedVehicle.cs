using Decorator.AbstractClasses;
using Decorator.Contracts;

namespace Decorator.ConcreteClasses
{
    public class MetallicPaintedVehicle : AbstractVehicleOption
    {
        public MetallicPaintedVehicle(IVehicle vehicle)
            : base(vehicle)
        {
        }

        public override int Price
        {
            get
            {
                return decoratedVehicle.Price + 750;
            }
        }
    }
}
