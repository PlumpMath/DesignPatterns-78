
using Adapter.AbstractClasses;
namespace Adapter.ConcreteClasses
{
    public class StandardEngine : AbstractEngine
    {
        public StandardEngine(int size)
            : base(size, false)
        {
            // not turbocharged
        }
    }
}