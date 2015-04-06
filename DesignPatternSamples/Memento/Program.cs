using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            InternalVisibilityApproach();
            ObjectSerializationApproach();
            Console.Read();
        }
        private static void InternalVisibilityApproach()
        {
            Console.WriteLine("Internal Visibility Approach");
            SpeedometerInternalVisibility speedo = new SpeedometerInternalVisibility();

            speedo.CurrentSpeed = 50;
            speedo.CurrentSpeed = 100;
            Console.WriteLine("Current speed: " + speedo.CurrentSpeed);
            Console.WriteLine("Previous speed: " + speedo.previousSpeed);

            // Save the state of 'speedo'
            SpeedometerMementoInternalVisibility memento = new SpeedometerMementoInternalVisibility(speedo);

            // Change the state of 'speed'
            speedo.CurrentSpeed = 80;
            Console.WriteLine("After setting to 80...");
            Console.WriteLine("Current speed: " + speedo.CurrentSpeed);
            Console.WriteLine("Previous speed: " + speedo.previousSpeed);

            // Restore the state of 'speedo'
            Console.WriteLine("Now restoring state...");
            memento.RestoreState();
            Console.WriteLine("Current speed: " + speedo.CurrentSpeed);
            Console.WriteLine("Previous speed: " + speedo.previousSpeed);
        }

        private static void ObjectSerializationApproach()
        {
            try
            {
                Console.WriteLine("Object Serialization Approach");
                SpeedometerObjectSerialization speedo = new SpeedometerObjectSerialization();

                speedo.CurrentSpeed = 50;
                speedo.CurrentSpeed = 100;
                Console.WriteLine("Current speed: " + speedo.CurrentSpeed);
                Console.WriteLine("Previous speed: " + speedo.PreviousSpeed);

                // Save the state of 'speedo'
                SpeedometerMementoObjectSerialization memento = new SpeedometerMementoObjectSerialization(speedo);

                // Change the state of 'speed'
                speedo.CurrentSpeed = 80;
                Console.WriteLine("After setting to 80...");
                Console.WriteLine("Current speed: " + speedo.CurrentSpeed);
                Console.WriteLine("Previous speed: " + speedo.PreviousSpeed);

                // Restore the state of 'speedo'
                Console.WriteLine("Now restoring state...");
                speedo = memento.RestoreState();
                Console.WriteLine("Current speed: " + speedo.CurrentSpeed);
                Console.WriteLine("Previous speed: " + speedo.PreviousSpeed);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.Write(ex.StackTrace);
            }
        }
    }
}
