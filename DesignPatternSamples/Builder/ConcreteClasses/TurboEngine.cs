
using Builder.AbstractClasses;
namespace Builder.ConcreteClasses
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