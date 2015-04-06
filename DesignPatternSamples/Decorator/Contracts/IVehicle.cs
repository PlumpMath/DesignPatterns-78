
using Decorator.Enums;
namespace Decorator.Contracts
{
    public interface IVehicle
    {
        IEngine Engine { get; }
        VehicleColour Colour { get; }
        void Paint(VehicleColour colour);

        int Price { get; }
    }
}
