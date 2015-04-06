using System;

namespace mediator
{
    public class Ignition
    {
        private EngineManagementSystem mediator;
        private bool on;

        // Constructor accepts mediator as an argument
        public Ignition(EngineManagementSystem mediator)
        {
            this.mediator = mediator;
            on = false;

            // Register back with the mediator;
            mediator.RegisterIgnition(this);
        }

        public virtual void Start()
        {
            on = true;
            mediator.IgnitionTurnedOn();
            Console.WriteLine("Ignition turned on");
        }

        public virtual void Stop()
        {
            on = false;
            mediator.IgnitionTurnedOff();
            Console.WriteLine("Ignition turned off");
        }

        public virtual bool On
        {
            get
            {
                return on;
            }
        }
    }
}
