using SampleDesignPattern.AbstractClasses;
using SampleDesignPattern.Contracts;
using SampleDesignPattern.Enums;

namespace SampleDesignPattern.ConcreteClasses
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