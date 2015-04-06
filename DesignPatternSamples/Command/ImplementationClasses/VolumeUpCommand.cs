using Command.ConcreteClasses;
using Command.Contracts;
using System;

namespace Command.ImplementationClasses
{
    public class VolumeUpCommand : IVoiceCommand
    {
        private Radio radio;

        public VolumeUpCommand(Radio radio)
        {
            this.radio = radio;
        }

        public virtual void Execute()
        {
            radio.VolumeUp();
        }

        public void undo()
        {
            radio.VolumeDown();
        }
    }
}
