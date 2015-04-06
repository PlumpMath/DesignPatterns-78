using Decorator.AbstractClasses;
using Decorator.Contracts;
using Decorator.Enums;
namespace Decorator.ConcreteClasses
{
    public class Saloon : AbstractCar
    {
        public Saloon(IEngine engine)
            : this(engine, VehicleColour.Unpainted)
        {
        }

        public Saloon(IEngine engine, VehicleColour colour)
            : base(engine, colour)
        {
        }

        public override int Price
        {
            get
            {
                return 6000;
            }
        }
    }
}