using Builder.Contracts;

namespace Builder.AbstractClasses
{
    public abstract class VehicleDirector
    {
        public abstract IVehicle Build(VehicleBuilder builder);
    }
}
