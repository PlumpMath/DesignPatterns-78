using System.Collections.Generic;
using Interpreter.Contracts;

namespace Interpreter.ImplementationClasses
{
    public class MostEasterlyExpression : IExpression
    {
        private IList<IExpression> expressions;

        public MostEasterlyExpression(IList<IExpression> expressions)
        {
            this.expressions = expressions;
        }

        public virtual City Interpret()
        {
            City resultingCity = new City("Nowhere", -999.9, -999.9);
            foreach (IExpression currentExpression in expressions)
            {
                City currentCity = currentExpression.Interpret();
                if (currentCity.Longitude > resultingCity.Longitude)
                {
                    resultingCity = currentCity;
                }
            }
            return resultingCity;
        }
    }
}
