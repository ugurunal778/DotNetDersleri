using BA_SOLID.DIP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.DIP.Validated.Concrete
{
    public class Poultry : IProduct
    {
        //public string GetCookingInstructions()
        //{
        //    return GetPoultryCookingInstructions();
        //}

        //public string GetPoultryCookingInstructions()
        //{
        //    throw new NotImplementedException();
        //}
        public string GetCookingInstructions()
        {
            return "55 dk";
        }
    }
}
