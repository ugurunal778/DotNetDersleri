using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalFactory
{
    class AndroidOS : MobileApplication
    {
        public override void Platform()
        {
            Console.WriteLine("bu uygulama android için çalışmaktadır.");
        }
    }
}
