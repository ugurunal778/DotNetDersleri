using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.OCP.Validated
{
    public class Macchiato:GoodCoffee
    {
        public override double GetTotalPrice(double quantity)
        {
            double totalPrice = quantity * 6.75;
            return totalPrice;
        }
    }
}