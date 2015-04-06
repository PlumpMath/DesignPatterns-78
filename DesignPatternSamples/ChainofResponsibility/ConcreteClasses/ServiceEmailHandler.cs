﻿using ChainofResponsibility.AbstractClasses;
using System;

namespace ChainofResponsibility.ConcreteClasses
{
    public class ServiceEmailHandler : AbstractEmailHandler
    {
        protected internal override string[] MatchingWords()
        {
            return new string[] { "service", "repair" };
        }

        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("Email handled by service department.");
        }
    }
}
