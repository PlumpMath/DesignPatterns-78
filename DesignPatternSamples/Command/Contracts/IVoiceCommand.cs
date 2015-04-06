
namespace Command.Contracts
{
    public interface IVoiceCommand
    {
        void Execute();
        void undo();
    }
}
