using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the evaluator
            DirectionalEvaluator evaluator = new DirectionalEvaluator();

            // This should output "London"...
            Console.WriteLine(evaluator.Evaluate
                        ("london edinburgh manchester southerly"));

            // This should output "Aberdeen"...
            Console.WriteLine(evaluator.Evaluate
                        ("london edinburgh manchester southerly aberdeen westerly"));

            Console.Read();
        }
    }
}
