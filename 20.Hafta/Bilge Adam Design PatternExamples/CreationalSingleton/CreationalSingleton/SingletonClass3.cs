using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalSingleton
{
    class SingletonClass3
    {
        private static SingletonClass3 _TekNesne;
        private static Object lockObject = new Object();

        private SingletonClass3() { }

        public static SingletonClass3 Sinif
        {
            get
            {
                if (_TekNesne == null)
                {
                    lock (lockObject)
                    {
                        if (_TekNesne == null)
                            _TekNesne = new SingletonClass3();
                    }
                }

                return _TekNesne;
            }
        }
    }
}
/*
 
    Bu yöntem de; nesne oluşturulmadığında yani null olduğunda lock anatarı arasındaki blok kilitlenerek başka kanalların lock bloğunun içine erişimini engeller ve nesne hayla null ise nesne örneği oluşturulur.
     
     */
