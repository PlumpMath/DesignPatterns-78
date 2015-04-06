
using Builder.AbstractClasses;
using Builder.Contracts;
using Builder.Enums;
namespace Builder.ConcreteClasses
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
    }
}