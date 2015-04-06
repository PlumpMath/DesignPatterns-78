﻿
using Bridge.AbstractClasses;
namespace Bridge.ConcreteClasses
{
    public class StandardEngine : AbstractEngine
    {
        public StandardEngine(int size)
            : base(size, false)
        {
            // not turbocharged
        }
    }
}