
using Prototype.Enums;
using System;
namespace Prototype.Contracts
{
    public interface IVehicle : ICloneable 
    {
        IEngine Engine { get; }
        VehicleColour Colour { get; }
        void Paint(VehicleColour colour);
    }
}
