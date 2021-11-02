using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.ISP.Bad
{
    public class BadChicken : IBird
    {
        public string Fly()
        {
            throw new NotImplementedException();
        }

        public string Walk()
        {
            return "Bu tavuk yürüyebilir!";
        }
    }
}
