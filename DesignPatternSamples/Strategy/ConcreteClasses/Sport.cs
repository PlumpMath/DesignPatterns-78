
using Strategy.AbstractClasses;
using Strategy.Contracts;
using Strategy.Enums;
namespace Strategy.ConcreteClasses
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
    }
}