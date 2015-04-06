using System;

namespace Adapter
{
    public class SuperGreenEngine
    {

        private int size;

        public SuperGreenEngine(int size)
        {
            this.size = size;
        }

        public virtual int EngineSize
        {
            get
            {
                return size;
            }
        }

        public override string ToString()
        {
            return "SUPER ENGINE " + size;
        }
    }
}
