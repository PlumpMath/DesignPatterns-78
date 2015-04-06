
using FactoryMethod.AbstractClasses;
using FactoryMethod.Contracts;
using FactoryMethod.Enums;
namespace FactoryMethod.ConcreteClasses
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