using Decorator.AbstractClasses;
using Decorator.Contracts;
using Decorator.Enums;

namespace Decorator.ConcreteClasses
{
    public class Pickup : AbstractVan
    {
        public Pickup(IEngine engine)
            : this(engine, VehicleColour.Unpainted)
        {
        }

        public Pickup(IEngine engine, VehicleColour colour)
            : base(engine, colour)
        {
        }

        public override int Price
        {
            get
            {
                return 9000;
            }
        }
    }
}