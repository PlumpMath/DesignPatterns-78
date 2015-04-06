using Builder.AbstractClasses;
using Builder.Contracts;

namespace Builder.ConcreteClasses
{
    public class CarDirector : VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildChassis();
            builder.BuildBody();
            builder.BuildPassengerArea();
            builder.BuildBoot();
            builder.BuildWindows();
            return builder.Vehicle;
        }
    }
}