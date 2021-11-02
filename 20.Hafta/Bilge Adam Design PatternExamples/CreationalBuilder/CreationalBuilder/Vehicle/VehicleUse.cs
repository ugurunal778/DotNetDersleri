using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder.Vehicle
{
    //Director Class
    class VehicleUse
    {
        public void UseVehicle(VehicleBuilder vehicle)
        {
            vehicle.MaxSpeed();
            vehicle.FuelType();
            vehicle.GearType();
            vehicle.Brand();

        }
    }
}
