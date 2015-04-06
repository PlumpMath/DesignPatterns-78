using AbstractFactory.Contracts;

namespace AbstractFactory.ConcreteClasses
{
    public class VanGlassware : IGlassware
    {
        public virtual string GlasswareParts
        {
            get
            {
                return "Window glassware for a van";
            }
        }
    }
}