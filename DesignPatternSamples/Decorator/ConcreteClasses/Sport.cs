
using Decorator.AbstractClasses;
using Decorator.Contracts;
using Decorator.Enums;
namespace Decorator.ConcreteClasses
{
    public class Sport : AbstractCar
    {
        public Sport(IEngine engine)
            : this(engine, VehicleColour.Unpainted)
        {
        }

        public Sport(IEngine engine, VehicleColour colour)
            : base(engine, colour)
        {
        }

        public override int Price
        {
            get
            {
                return 8000;
            }
        }
    }
}