using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder.Vehicle
{

    //Product Class
    public class Vehicle
    {
        public string Brand { get; set; }
        public string FuelType { get; set; }
        public int MaxSpeedLimit { get; set; }
        public string GearBoxType { get; set; }

        public override string ToString()
        {
            return $"{Brand} markasına ait araç {FuelType} yakıt tipini ve {GearBoxType} şazımanı kullanmaktadır. Ayrıca en üst seviye hız limitic: {MaxSpeedLimit}";
        }

    }
}
