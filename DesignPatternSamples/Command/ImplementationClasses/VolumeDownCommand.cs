using Command.ConcreteClasses;
using Command.ConcreteClasses;
using Command.Contracts;
using System;

namespace Command.ImplementationClasses
{
    public class VolumeDownCommand : IVoiceCommand
    {
        private Radio radio;

        public VolumeDownCommand(Radio radio)
        {
            this.radio = radio;
        }

        public virtual void Execute()
        {
            radio.VolumeDown();
        }

        public void undo()
        {
            radio.VolumeDown();
        }
    }
}
