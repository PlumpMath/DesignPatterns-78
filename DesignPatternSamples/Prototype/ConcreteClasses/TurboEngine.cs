
using Prototype.AbstractClasses;
namespace Prototype.ConcreteClasses
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