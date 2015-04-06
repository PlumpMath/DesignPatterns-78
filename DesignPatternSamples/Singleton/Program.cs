using System;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;

            Console.WriteLine("next serial: " +
                                        SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("next serial: " +
                                        SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("next serial: " +
                                        SerialNumberGenerator.Instance.NextSerial);
            Console.Read();
        }
    }
}
