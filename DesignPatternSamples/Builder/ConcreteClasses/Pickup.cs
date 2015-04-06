
using Builder.AbstractClasses;
using Builder.Contracts;
using Builder.Enums;
namespace Builder.ConcreteClasses
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