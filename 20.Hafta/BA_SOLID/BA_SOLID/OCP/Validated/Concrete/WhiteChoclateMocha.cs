using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.OCP.Validated.Concrete
{
    public class WhiteChoclateMocha : GoodCoffee
    {
        public override double GetTotalPrice(double quantity)
        {
            return quantity * 10;
        }
    }
}
