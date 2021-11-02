using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalFactory
{
    class Creater
    {
        public MobileApplication FactoryMethod(AllMobileOS OSType)
        {
            MobileApplication ma = null;
            switch (OSType)
            {
                case AllMobileOS.Android:
                    ma = new AndroidOS();
                    break;
                case AllMobileOS.WindowsMobile:
                    ma = new WindowsMobileOS();
                    break;
                case AllMobileOS.IphoneOS:
                    ma = new IphoneOS();
                    break;
            }
            return ma;
        }
    }
}
