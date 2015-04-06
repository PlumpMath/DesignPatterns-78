using FactoryMethod.AbstractClasses;
using FactoryMethod.Contracts;
using FactoryMethod.Enums;

namespace FactoryMethod.ConcreteClasses
{
    public class VanFactory : VehicleFactory 
    {     
        protected internal override IVehicle SelectVehicle(DrivingStyle style)     
        {         
            if ((style == DrivingStyle.Economical) || (style == DrivingStyle.Midrange))
            {             
                return new Pickup(new StandardEngine(2200));         
            }         
            else         
            {             
                return new BoxVan(new TurboEngine(2500));         
            }     
        } 
    }
}
