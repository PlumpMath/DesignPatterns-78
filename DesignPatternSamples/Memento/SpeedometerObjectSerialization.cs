using System;

namespace Memento
{
    [Serializable]
    public class SpeedometerObjectSerialization
	{
        private int currentSpeed;
        private int previousSpeed;

        public SpeedometerObjectSerialization() {
            currentSpeed = 0;
            previousSpeed = 0;
        }

        public virtual int CurrentSpeed {
            set {
                previousSpeed = currentSpeed;
                currentSpeed = value;
            }
            get {
                return currentSpeed;
            }
        }

        // Only defined to help testing...
        public virtual int PreviousSpeed {
            get {
                return previousSpeed;
            }
		}
    }
}