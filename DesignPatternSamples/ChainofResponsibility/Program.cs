using ChainofResponsibility.AbstractClasses;
using System;

namespace ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "I need my car repaired";
            AbstractEmailHandler.Handle(email);
            Console.Read();
        }
    }
}
