using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.OCP
{
    public enum CoffeeType
    {
        Latte,
        Espresso,
        Macchiato,
        WhiteChocolateMocha,
        SutluKahve
    }
    public class BadCoffee
    {
        public double GetTotalPrice(double amount, CoffeeType coffeeType)
        {
            //Burada Daha fazla kahve çeşidi eklenirse, kodumuza bir tane daha else-if bloğu eklememiz gerekecek.
            //Bu da open/closed prensibi ihlali demektir.
            double totalPrice = 0;

            if (coffeeType == CoffeeType.Espresso)
            {
                totalPrice = amount * 4.50;
            }
            else if (coffeeType == CoffeeType.Latte)
            {
                totalPrice = amount * 5.25;
            }
            else if (coffeeType == CoffeeType.Macchiato)
            {
                totalPrice = amount * 6.75;
            }
            else if (coffeeType == CoffeeType.WhiteChocolateMocha)
            {
                totalPrice = amount * 6.75;
            }
            else if (coffeeType==CoffeeType.SutluKahve)
            { totalPrice = amount * 8; }

            return totalPrice;
        }
    }
}
