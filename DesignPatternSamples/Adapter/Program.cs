﻿using Adapter.ConcreteClasses;
using Adapter.Contracts;
using System;
using System.Collections.Generic;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IEngine> engines = new List<IEngine>();

            engines.Add(new StandardEngine(1300));
            engines.Add(new StandardEngine(1600));
            engines.Add(new TurboEngine(2000));

            // "Adapt" the new engine type
            SuperGreenEngine greenEngine = new SuperGreenEngine(1200);
            engines.Add(new SuperGreenEngineAdapter(greenEngine));

            foreach (IEngine engine in engines)
            {
                Console.WriteLine(engine);
            }
            Console.Read();
        }
    }
}
