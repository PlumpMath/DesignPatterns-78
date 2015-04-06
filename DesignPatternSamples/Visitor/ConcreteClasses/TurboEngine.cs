
using Visitor.AbstractClasses;
namespace Visitor.ConcreteClasses
{
    public class TurboEngine : AbstractEngine
    {
        public TurboEngine(int size)
            : base(size, true)
        {
            // turbocharged
        }
    }
}