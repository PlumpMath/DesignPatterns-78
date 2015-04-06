using Command.ConcreteClasses;
using Command.Contracts;
using System;

namespace Command.ImplementationClasses
{
    public class WindowDownCommand : IVoiceCommand
    {
        private ElectricWindow window;

        public WindowDownCommand(ElectricWindow window)
        {
            this.window = window;
        }

        public virtual void Execute()
        {
            window.OpenWindow();
        }

        public void undo()
        {
            window.CloseWindow();
        }
    }
}
