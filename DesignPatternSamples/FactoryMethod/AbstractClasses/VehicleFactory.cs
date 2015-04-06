using FactoryMethod.ConcreteClasses;
using FactoryMethod.Contracts;
using FactoryMethod.Enums;

namespace FactoryMethod.AbstractClasses
{
    public abstract class VehicleFactory 
    {     
        public virtual IVehicle Build(DrivingStyle style, VehicleColour colour)     
        {         
            IVehicle v = SelectVehicle(style);         
            v.Paint(colour);         
            return v;     
        }     // This is the "factory method"     
        
        protected internal abstract IVehicle SelectVehicle(DrivingStyle style);

        // Using Static factory
        public static IVehicle Make(Category cat,
                                    DrivingStyle style,
                                    VehicleColour colour)
        {
            VehicleFactory factory;

            if (cat == Category.Car)
            {
                factory = new CarFactory();

            }
            else
            {
                factory = new VanFactory();
            }

            return factory.Build(style, colour);
        }
    }
}
