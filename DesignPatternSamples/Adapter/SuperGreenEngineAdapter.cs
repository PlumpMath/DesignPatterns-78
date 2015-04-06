using Adapter.AbstractClasses;
using System;

namespace Adapter
{
    public class SuperGreenEngineAdapter : AbstractEngine
    {
        public SuperGreenEngineAdapter(SuperGreenEngine greenEngine)
            : base(greenEngine.EngineSize, false)
        {
        }
    }
}
