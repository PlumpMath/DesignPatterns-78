
namespace Visitor.Contracts
{
    public interface IEngine : IVisitable
    {
        int Size { get; }
        bool Turbo { get; }
    }
}
