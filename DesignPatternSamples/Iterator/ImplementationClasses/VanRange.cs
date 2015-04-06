using Iterator.ConcreteClasses;
using Iterator.Contracts;
using System.Collections.Generic;

namespace Iterator.ImplementationClasses
{
    public class VanRange
    {
        private IVehicle[] vans;

        public VanRange()
        {
            vans = new IVehicle[3];

            // Define the range of van models available
            vans[0] = new BoxVan(new StandardEngine(1600));
            vans[1] = new BoxVan(new StandardEngine(2000));
            vans[2] = new Pickup(new TurboEngine(2200));
        }

        public virtual IVehicle[] Range
        {
            get
            {
                return vans;
            }
        }

        public virtual IEnumerator<IVehicle> GetEnumerator()
        {
            return ((IEnumerable<IVehicle>) vans).GetEnumerator();
        }
    }
}