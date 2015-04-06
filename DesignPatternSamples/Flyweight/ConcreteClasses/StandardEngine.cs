
using FlyWeight.AbstractClasses;
namespace FlyWeight.ConcreteClasses
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