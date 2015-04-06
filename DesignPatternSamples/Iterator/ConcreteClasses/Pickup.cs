using Iterator.AbstractClasses;
using Iterator.Contracts;
using Iterator.Enums;

namespace Iterator.ConcreteClasses
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