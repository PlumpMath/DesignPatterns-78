using Builder.AbstractClasses;
using Builder.Contracts;

namespace Builder.ConcreteClasses
{
    public class VanDirector : VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildChassis();
            builder.BuildBody();
            builder.BuildReinforcedStorageArea();
            builder.BuildWindows();
            return builder.Vehicle;
        }
    }
}