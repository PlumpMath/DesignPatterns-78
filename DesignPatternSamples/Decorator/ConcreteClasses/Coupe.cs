
using Decorator.AbstractClasses;
using Decorator.Contracts;
using Decorator.Enums;
namespace Decorator.ConcreteClasses
{
    public class Coupe : AbstractCar
    {
        public Coupe(IEngine engine)
            : this(engine, VehicleColour.Unpainted)
        {
        }

        public Coupe(IEngine engine, VehicleColour colour)
            : base(engine, colour)
        {
        }

        public override int Price
        {
            get
            {
                return 7000;
            }
        }
    }
}