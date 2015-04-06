
using Iterator.AbstractClasses;
namespace Iterator.ConcreteClasses
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