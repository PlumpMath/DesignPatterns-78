
using Prototype.AbstractClasses;
using Prototype.Contracts;
using Prototype.Enums;
namespace Prototype.ConcreteClasses
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