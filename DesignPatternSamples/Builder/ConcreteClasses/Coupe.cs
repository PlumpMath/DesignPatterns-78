
using Builder.AbstractClasses;
using Builder.Contracts;
using Builder.Enums;
namespace Builder.ConcreteClasses
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
    }
}