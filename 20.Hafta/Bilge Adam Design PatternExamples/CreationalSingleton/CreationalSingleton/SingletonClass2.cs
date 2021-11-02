using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalSingleton
{
    class SingletonClass2
    {
        private static SingletonClass2 _TekNesne;

        private SingletonClass2() { }

        public static SingletonClass2 Sinif
        {
            get
            {
                /*static nesneye ilk erişimde sınıfın örneği atanıyor.*/
                if (_TekNesne == null)
                    _TekNesne = new SingletonClass2();

                return _TekNesne;
            }
        }
    }
}
