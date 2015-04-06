using System;

namespace mediator
{
    public class Accelerator
    {
        private EngineManagementSystem mediator;
        private bool enabled;
        private int speed;

        // Constructor accepts mediator as an argument
        public Accelerator(EngineManagementSystem mediator)
        {
            this.mediator = mediator;
            enabled = false;
            speed = 0;
            mediator.RegisterAccelerator(this);
        }

        public virtual void Enable()
        {
            enabled = true;
            mediator.AcceleratorEnabled();
            Console.WriteLine("Accelerator enabled");
        }

        public virtual void Disable()
        {
            enabled = false;
            mediator.AcceleratorDisabled();
            Console.WriteLine("Accelerator disabled");
        }

        public virtual bool Enabled
        {
            get
            {
                return enabled;
            }
        }

        public virtual void AccelerateToSpeed(int speed)
        {
            if (Enabled)
            {
                this.speed = speed;
                Console.WriteLine("Speed now " + Speed);
            }
        }

        public virtual int Speed
        {
            get
            {
                return speed;
            }
        }
    }
}
