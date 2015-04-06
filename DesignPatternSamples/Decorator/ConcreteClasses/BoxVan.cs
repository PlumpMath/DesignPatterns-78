using Decorator.AbstractClasses;
using Decorator.Contracts;
using Decorator.Enums;

namespace Decorator.ConcreteClasses
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

        public override int Price
        {
            get
            {
                return 10000;
            }
        }
    }
}