using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder.Vehicle
{
    //Builder
    abstract class VehicleBuilder
    {
        protected Vehicle vehicle;
        public Vehicle Vehicle
        {
            get { return vehicle; }
        }
        public abstract void MaxSpeed();
        public abstract void GearType();
        public abstract void FuelType();

        public abstract void Brand();
    }


}
