using Strategy.AbstractClasses;
using Strategy.Contracts;
using Strategy.Enums;

namespace Strategy.ConcreteClasses
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