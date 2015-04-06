using Bridge.AbstractClasses;
using Bridge.Contracts;

namespace Bridge.ConcreteClasses
{
    public class SportControls : AbstractDriverControls
    {
        public SportControls(IEngine engine)
            : base(engine)
        {
        }

        public virtual void AccelerateHard()
        {
            Accelerate();
            Accelerate();
        }
    }
}
