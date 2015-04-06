using Bridge.AbstractClasses;
using Bridge.Contracts;

namespace Bridge.ConcreteClasses
{
    public class StandardControls : AbstractDriverControls
    {
        public StandardControls(IEngine engine)
            : base(engine)
        {
        }
        // No extra functions
    }
}
