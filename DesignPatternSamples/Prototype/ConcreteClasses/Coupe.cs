
using Prototype.AbstractClasses;
using Prototype.Contracts;
using Prototype.Enums;
namespace Prototype.ConcreteClasses
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