using Command.ConcreteClasses;
using Command.Contracts;
using System;

namespace Command.ImplementationClasses
{
    public class WindowUpCommand : IVoiceCommand
    {
        private ElectricWindow window;

        public WindowUpCommand(ElectricWindow window)
        {
            this.window = window;
        }

        public virtual void Execute()
        {
            window.CloseWindow();
        }

        public void undo()
        {
            window.CloseWindow();
        }
    }
}
