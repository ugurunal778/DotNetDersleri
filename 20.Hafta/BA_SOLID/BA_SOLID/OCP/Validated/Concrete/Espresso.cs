using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.OCP.Validated
{
    public class Espresso : GoodCoffee
    {
        public override double GetTotalPrice(double quantity)
        {
            double totalPrice = quantity * 5.25;
            return totalPrice;
        }
    }
}