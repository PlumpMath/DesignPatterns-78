using Decorator.Contracts;

namespace Decorator.AbstractClasses
{
    public abstract class AbstractVehicleOption : AbstractVehicle
    {
        protected internal IVehicle decoratedVehicle;

        public AbstractVehicleOption(IVehicle vehicle)
            : base(vehicle.Engine, vehicle.Colour)
        {
            decoratedVehicle = vehicle;
        }
    }
}
