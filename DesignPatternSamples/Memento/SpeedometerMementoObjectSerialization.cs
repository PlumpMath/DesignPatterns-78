using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Memento
{
    public class SpeedometerMementoObjectSerialization
    {
        public SpeedometerMementoObjectSerialization(SpeedometerObjectSerialization speedometer)
        {
            // Serialize...
            Stream stream = File.Open("speedometer.ser", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, speedometer);
            stream.Close();
        }

        public virtual SpeedometerObjectSerialization RestoreState()
        {
            // Deserialize...
            SpeedometerObjectSerialization speedo;
            Stream stream = File.Open("speedometer.ser", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            speedo = (SpeedometerObjectSerialization)formatter.Deserialize(stream);
            stream.Close();
            return speedo;
        }
    }
}