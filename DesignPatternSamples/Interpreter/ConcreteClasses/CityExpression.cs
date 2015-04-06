using Interpreter.Contracts;

namespace Interpreter.ConcreteClasses
{
    public class CityExpression : IExpression
    {
        private City city;

        public CityExpression(City city)
        {
            this.city = city;
        }

        public virtual City Interpret()
        {
            return city;
        }
    }
}
