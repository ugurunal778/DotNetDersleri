using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalSingleton
{
    class SingletonClass
    {
        /*Constructor private yapılarak bu sınıf dışından instance (örneğinin) alınmasını engelliyoruz */
        private SingletonClass() { }

        private static SingletonClass _TekNesne = new SingletonClass();

        /*Oluşturulan static nesnenin(_TekNesne) dışarıdan erişilmesini sağlamak için property tanımı*/
        public static SingletonClass Sinif
        {
            get
            {
                return _TekNesne;
            }
        }

        /*Oluşturulan static nesnenin dışarıdan erişilmesini metot ile de sağlayabiliriz*/
        public static SingletonClass Sinif2()
        {
            return _TekNesne;
        }

        /*Sınıfın kullanılacak metot ve özellikleri tanımlanır*/
        public int toplam(int s1, int s2)
        {
            return s1 + s2;
        }
    }
}
