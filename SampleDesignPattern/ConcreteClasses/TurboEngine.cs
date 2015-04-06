
using SampleDesignPattern.AbstractClasses;
namespace SampleDesignPattern.ConcreteClasses
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