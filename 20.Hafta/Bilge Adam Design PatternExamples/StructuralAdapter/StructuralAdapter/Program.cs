using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralAdapter
{
    class Program
    {
        /*
         
            Adapter tasarım deseni structural grubuna aittir. uluslar arası standartlarda %80 olaslıkla kullanıldığı gözlenmiştir. 
            Uygulama içerisinde ki bir yapıya dışarıdaki bir yapıyı duzenleyen tasarım desenidir. 

            Bazı durumlarda zaten var olan başka bir yapıyı uygulamamız içinde ki bir yapıya uyarlayıp kullanmamız gerekebilir. 
        Burada uyarlanacak yapı net kütüphanesi olması gerekmez. 
        Com nesnesi gibi bir yapı da olabilir veya zaten geliştirdiğimiz uygulamadaki başka bir yapı da olabilir. Bu uyarlama işlemini yazacağımız bir Adapter nesnesi ile sağlayabiliriz.

             */

        static void Main(string[] args)
        {
            var target = new CalisanAdapter();
           
            
            FaturaSistemi kullanici = new FaturaSistemi(target);
            kullanici.CalisanGoster();

            IHumanResources humanResources = new CalisanAdapter();
            humanResources.GetCalisanMaas();

            Console.ReadLine();
        }
    }
}
