
using SampleDesignPattern.AbstractClasses;
using SampleDesignPattern.Contracts;
using SampleDesignPattern.Enums;
namespace SampleDesignPattern.ConcreteClasses
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