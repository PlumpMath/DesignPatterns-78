using SampleDesignPattern.AbstractClasses;
using SampleDesignPattern.Contracts;
using SampleDesignPattern.Enums;

namespace SampleDesignPattern.ConcreteClasses
{
    public class BoxVan : AbstractVan
    {
        public BoxVan(IEngine engine)
            : this(engine, VehicleColour.Unpainted)
        {
        }

        public BoxVan(IEngine engine, VehicleColour colour)
            : base(engine, colour)
        {
        }
    }
}