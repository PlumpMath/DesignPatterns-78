
using Builder.AbstractClasses;
using Builder.Contracts;
using Builder.Enums;
namespace Builder.ConcreteClasses
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