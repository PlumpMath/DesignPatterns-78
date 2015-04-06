using Prototype.AbstractClasses;
using Prototype.Contracts;
using Prototype.Enums;

namespace Prototype.ConcreteClasses
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
    }
}