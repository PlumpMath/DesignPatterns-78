using FactoryMethod.AbstractClasses;
using FactoryMethod.Contracts;
using FactoryMethod.Enums;

namespace FactoryMethod.ConcreteClasses
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