using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            tasarım desenleri arasında creational grubuna ait en populer yapılardan biridir. uluslar arası standartlarda %80 kullanım oranına sahiptir. Esas amaç her daim nesnenin kullanım süresi boyunca bir nesnenin bir kez oluşturulup defalarca farklı konumlarda kullanılmasını sağlamaktır. 



             */

            int t1 = SingletonClass.Sinif.toplam(1, 2); //bir sefer yazdik kullandik
 
            int t2 = SingletonClass.Sinif2().toplam(2, 3); //bir sefer yazdik 2. defa kullandik 

            /*
             
            Örneğimizdeki sınıfı sınıf dışından new anahtar sözcüğü ile oluşturamayız, çünkü constructor metot private olarak tanımlanmıştır fakat private ile tanımlanmış metot sınıf içinden erişilebilir olduğu için sınıf içinde new ile örneği static bir değişkene atanabilinir. Yani constructor metodu private yaparak sınıfın dışarıdan örneğinin alınmasını engelledik ve sınıf içinde static bir değişkene örneğini alarak bir örnek elde ettik. Bu örneğin dışarıdan erişilebilinmesi için de bu örneği geri döndüren static bir metot veya property ekledik.
             
             */
        }
    }
}
