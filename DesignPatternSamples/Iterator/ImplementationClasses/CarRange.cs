using Iterator.ConcreteClasses;
using Iterator.Contracts;
using System.Collections.Generic;

namespace Iterator.ImplementationClasses
{
    public class CarRange
    {
        private IList<IVehicle> cars;

        public CarRange()
        {
            cars = new List<IVehicle>();

            // Define the range of car models available
            cars.Add(new Saloon(new StandardEngine(1300)));
            cars.Add(new Saloon(new StandardEngine(1600)));
            cars.Add(new Coupe(new StandardEngine(2000)));
            cars.Add(new Sport(new TurboEngine(2500)));
        }

        public virtual IList<IVehicle> Range
        {
            get
            {
                return cars;
            }
        }

        public virtual IEnumerator<IVehicle> GetEnumerator()
        {
            return cars.GetEnumerator();
        }
    }
}