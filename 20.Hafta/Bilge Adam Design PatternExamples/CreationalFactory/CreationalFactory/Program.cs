using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            FACTORY METHOD  
            creational grubununa ait, aynı arayüzü kullanan nesnelerin üretiminden sorumlu tasarım desenidir. 
            uluslar arası standartlarda en sık kullanılan tasarım desenlerindendir. 

             */

            Creater cr = new Creater();
            MobileApplication MobileAndroid = cr.FactoryMethod(AllMobileOS.Android);
            MobileApplication MobileWindows = cr.FactoryMethod(AllMobileOS.WindowsMobile);
            MobileApplication MobileIOS = cr.FactoryMethod(AllMobileOS.IphoneOS);

            MobileAndroid.Platform();
            MobileWindows.Platform();
            MobileIOS.Platform();

            Console.ReadLine();
        }
    }
}
