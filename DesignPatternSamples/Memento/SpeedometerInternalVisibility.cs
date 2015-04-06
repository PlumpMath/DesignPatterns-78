using System;

namespace Memento
{
    public class SpeedometerInternalVisibility
    {
        // Normal private visibility but has accessor method...
        private int currentSpeed;

        // internal visibility and no accessor method...
        internal int previousSpeed;

        public SpeedometerInternalVisibility()
        {
            currentSpeed = 0;
            previousSpeed = 0;
        }

        public virtual int CurrentSpeed
        {
            set
            {
                previousSpeed = currentSpeed;
                currentSpeed = value;
            }
            get
            {
                return currentSpeed;
            }
        }
    }
}