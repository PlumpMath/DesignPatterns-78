using Visitor.Contracts;

namespace Visitor
{
    public class Camshaft : IVisitable
    {
        public void AcceptEngineVisitor(IEngineVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
