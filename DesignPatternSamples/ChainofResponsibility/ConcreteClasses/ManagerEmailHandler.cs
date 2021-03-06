﻿using ChainofResponsibility.AbstractClasses;
using System;

namespace ChainofResponsibility.ConcreteClasses
{
    public class ManagerEmailHandler : AbstractEmailHandler
    {
        protected internal override string[] MatchingWords()
        {
            return new string[] { "complain", "bad" };
        }

        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("Email handled by manager.");
        }
    }
}
