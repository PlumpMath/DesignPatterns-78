using SampleDesignPattern.AbstractClasses;
using SampleDesignPattern.Contracts;
using SampleDesignPattern.Enums;
namespace SampleDesignPattern.ConcreteClasses
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