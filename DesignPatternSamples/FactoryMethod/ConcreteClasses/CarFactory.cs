using FactoryMethod.AbstractClasses;
using FactoryMethod.Contracts;
using FactoryMethod.Enums;

namespace FactoryMethod.ConcreteClasses
{
    public class CarFactory : VehicleFactory 
    {     
        protected internal override IVehicle SelectVehicle(DrivingStyle style)     
        {         
            if (style == DrivingStyle.Economical)         
            {             
                return new Saloon(new StandardEngine(1300));         
            }         
            else if (style == DrivingStyle.Midrange)         
            {             
                return new Coupe(new StandardEngine(1600));         
            }         
            else         
            {             
                return new Sport(new TurboEngine(2000));         
            }     
        } 
    }

}
