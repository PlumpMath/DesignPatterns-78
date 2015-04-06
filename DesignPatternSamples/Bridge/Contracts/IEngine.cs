
namespace Bridge.Contracts
{
    public interface IEngine
    {
        int Size { get; }
        bool Turbo { get; }

        void Start();
        void Stop();
        void IncreasePower();
        void DecreasePower();
    }
}
