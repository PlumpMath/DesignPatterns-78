using AbstractFactory.Contracts;

namespace AbstractFactory.ConcreteClasses
{
    public class VanBody : IBody
    {
        public virtual string BodyParts
        {
            get
            {
                return "Body shell parts for a van";
            }
        }
    }
}
