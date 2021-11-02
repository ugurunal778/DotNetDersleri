using BA_SOLID.ISP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.ISP.Validated.Concrete
{
    public class GoodChicken : IFlightlessBird
    {
        public string Walk()
        {
            return "Bu tavuk yürüyebilir!";
        }
    }
}
