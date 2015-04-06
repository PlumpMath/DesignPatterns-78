
using FlyWeight.AbstractClasses;
namespace FlyWeight.ConcreteClasses
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