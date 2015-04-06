using System;

namespace Command.ConcreteClasses
{
    public class ElectricWindow
    {
        private bool open;

        public ElectricWindow()
        {
            open = false;
            Console.WriteLine("Window is closed");
        }

        public virtual bool Open
        {
            get
            {
                return open;
            }
        }

        public virtual bool Closed
        {
            get
            {
                return (!open);
            }
        }

        public virtual void OpenWindow()
        {
            if (Closed)
            {
                open = true;
                Console.WriteLine("Window is now open");
            }
        }

        public virtual void CloseWindow()
        {
            if (Open)
            {
                open = false;
                Console.WriteLine("Window is now closed");
            }
        }
    }
}