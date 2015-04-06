
using Strategy.AbstractClasses;
namespace Strategy.ConcreteClasses
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