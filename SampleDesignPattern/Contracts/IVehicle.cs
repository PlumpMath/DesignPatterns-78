
using SampleDesignPattern.Enums;
namespace SampleDesignPattern.Contracts
{
    public interface IVehicle
    {
        IEngine Engine { get; }
        VehicleColour Colour { get; }
        void Paint(VehicleColour colour);
    }
}
