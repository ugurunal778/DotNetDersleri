using BA_SOLID.ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.ISP.Bad
{
    public class BadHawk : IBird
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
