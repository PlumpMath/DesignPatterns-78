
using FactoryMethod.AbstractClasses;
using FactoryMethod.Contracts;
using FactoryMethod.Enums;
namespace FactoryMethod.ConcreteClasses
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