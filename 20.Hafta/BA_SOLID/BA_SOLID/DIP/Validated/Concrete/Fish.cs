using BA_SOLID.DIP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.DIP.Validated.Concrete
{
    public class Fish : IProduct
    {
        //public string GetCookingInstructions()
        //{
        //    return GetFishCookingInstructions();
        //}

        //public string GetFishCookingInstructions()
        //{
        //    throw new NotImplementedException();
        //}

        public string GetCookingInstructions()
        {
            return "50 dk";
        }
    }
}
