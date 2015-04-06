using Builder.Enums;

namespace Builder.Contracts
{
    public interface IVehicle
    {
        IEngine Engine { get; }
        VehicleColour Colour { get; }
        void Paint(VehicleColour colour);
    }
}
