using Iterator.Contracts;
using Iterator.ImplementationClasses;
using System;
using System.Collections;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // USING CONSISTENT iterator() METHODS
            Console.WriteLine("=== Our Cars ===");
            CarRange carRange2 = new CarRange();
            PrintIterator(carRange2.GetEnumerator());

            Console.WriteLine("=== Our Vans ===");
            VanRange vanRange2 = new VanRange();
            PrintIterator(vanRange2.GetEnumerator());


            // USING FOR-EACH
            Console.WriteLine("=== Our Cars ===");
            CarRange carRange3 = new CarRange();
            foreach (IVehicle currentVehicle in carRange3.Range)
            {
                Console.WriteLine(currentVehicle);
            }

            Console.WriteLine("=== Our Vans ===");
            VanRange vanRange3 = new VanRange();
            foreach (IVehicle currentVehicle in vanRange3.Range)
            {
                Console.WriteLine(currentVehicle);
            }

            Console.Read();
        }

        private static void PrintIterator(IEnumerator iter)
        {
            while(iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }
        }
    }
}