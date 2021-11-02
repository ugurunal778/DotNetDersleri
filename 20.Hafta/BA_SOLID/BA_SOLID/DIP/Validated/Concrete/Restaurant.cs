using BA_SOLID.DIP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.DIP.Validated.Concrete
{
    public class Restaurant
    {
        //Bu versiyonda ise restaurant sınıfı alt seviye modüllerden bağımsız hale gelmiştir.

        private List<IProduct> products;
        public Restaurant(List<IProduct> products)
        {
            this.products = products;
        }

        public string GenerateInstructions()
        {
            string instructions = string.Empty;

            foreach (var item in products)
            {
                instructions += item.GetCookingInstructions();
            }

            return instructions;
        }

    }
}
