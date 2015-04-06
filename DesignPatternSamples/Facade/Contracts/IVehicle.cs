
using Facade.Enums;
namespace Facade.Contracts
{
    public interface IVehicle
    {
        IEngine Engine { get; }
        VehicleColour Colour { get; }
        void Paint(VehicleColour colour);

        void CleanInterior();
        void CleanExteriorBody();
        void PolishWindows();
        void TakeForTestDrive();
    }
}
