using Visitor.Contracts;
namespace Visitor
{
    public class Piston : IVisitable
    {
        public void AcceptEngineVisitor(IEngineVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
