using System;

namespace Observer
{
    public class Speedometer
    {
        public event EventHandler ValueChanged;
        private int currentSpeed;

        public Speedometer()
        {
            currentSpeed = 0;
        }

        public virtual int CurrentSpeed
        {
            set
            {
                currentSpeed = value;

                // Tell all observers so they know value has changed...
                OnValueChanged();
            }
            get
            {
                return currentSpeed;
            }
        }

        protected void OnValueChanged()
        {
            if (ValueChanged != null)
            {
                ValueChanged(this, EventArgs.Empty);
            }
        }
    }
}
