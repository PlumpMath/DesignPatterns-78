using Visitor.Contracts;
namespace Visitor
{
    public class SparkPlug : IVisitable
    {
        public void AcceptEngineVisitor(IEngineVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
