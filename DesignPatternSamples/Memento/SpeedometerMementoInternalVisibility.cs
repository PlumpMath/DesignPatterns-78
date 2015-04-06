using System;

namespace Memento
{
    public class SpeedometerMementoInternalVisibility
    {
        private SpeedometerInternalVisibility speedometer;

        private int copyOfCurrentSpeed;
        private int copyOfPreviousSpeed;

        public SpeedometerMementoInternalVisibility(SpeedometerInternalVisibility speedometer)
        {
            this.speedometer = speedometer;
            copyOfCurrentSpeed = speedometer.CurrentSpeed;
            copyOfPreviousSpeed = speedometer.previousSpeed;
        }

        public virtual void RestoreState()
        {
            speedometer.CurrentSpeed = copyOfCurrentSpeed;
            speedometer.previousSpeed = copyOfPreviousSpeed;
        }
    }
}