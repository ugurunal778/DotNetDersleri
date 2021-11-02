using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder.Vehicle
{
    class BMWConcreteBuilder : VehicleBuilder
    {
        public BMWConcreteBuilder()
        {
            vehicle = new Vehicle();
        }

        public override void Brand()
        {
            vehicle.Brand = "BMW";
        }

        public override void FuelType()
        {
            vehicle.FuelType = "Benzin";
        }

        public override void GearType()
        {
            vehicle.GearBoxType = "ZF Şanzıman";
        }

        public override void MaxSpeed()
        {
            vehicle.MaxSpeedLimit = 250;
        }
    }
}
