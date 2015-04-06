using ChainofResponsibility.AbstractClasses;
using System;

namespace ChainofResponsibility.ConcreteClasses
{
    public class SalesEmailHandler : AbstractEmailHandler
    {
        protected internal override string[] MatchingWords()
        {
            return new string[] { "buy", "purchase" };
        }

        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("Email handled by sales department.");
        }
    }
}
