using AbstractFactory.Contracts;

namespace AbstractFactory.ConcreteClasses
{
    public class CarChassis : IChassis
    {
        public virtual string ChassisParts
        {
            get
            {
                return "Chassis parts for a car";
            }
        }
    }
}