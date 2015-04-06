using Strategy.AbstractClasses;
using Strategy.Contracts;
using Strategy.Enums;
namespace Strategy.ConcreteClasses
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