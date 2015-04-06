
namespace Strategy.Contracts
{
    public interface IGearboxStrategy
    {
        void EnsureCorrectGear(IEngine engine, int speed);
    }
}