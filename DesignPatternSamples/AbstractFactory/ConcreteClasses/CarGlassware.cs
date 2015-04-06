using AbstractFactory.Contracts;

namespace AbstractFactory.ConcreteClasses
{
    public class CarGlassware : IGlassware
    {
        public virtual string GlasswareParts
        {
            get
            {
                return "Window glassware for a car";
            }
        }
    }
}