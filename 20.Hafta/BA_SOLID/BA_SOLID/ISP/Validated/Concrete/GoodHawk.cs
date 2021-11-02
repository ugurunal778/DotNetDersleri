using BA_SOLID.ISP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.ISP.Validated.Concrete
{
    public class GoodHawk : IFlightlessBird, IFlyingBird
    {
        public string Fly()
        {
            return "Bu şahin uçabilir!";
        }

        public string Walk()
        {
            return "Bu şahin yürüyebilir!";
        }
    }
}
