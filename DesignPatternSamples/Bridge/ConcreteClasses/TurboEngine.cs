
using Bridge.AbstractClasses;
namespace Bridge.ConcreteClasses
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