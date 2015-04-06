
using SampleDesignPattern.AbstractClasses;
using SampleDesignPattern.Contracts;
using SampleDesignPattern.Enums;
namespace SampleDesignPattern.ConcreteClasses
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