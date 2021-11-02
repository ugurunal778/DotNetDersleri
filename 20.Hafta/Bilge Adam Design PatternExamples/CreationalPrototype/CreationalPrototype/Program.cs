using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            Prototype tasarim deseni creational grubuna aittir. 
            Aslında adından da anlaşılacağı gibi var olan nesnelerin kopyasının üretiminden sorumludur. 
            Dunya çapında kullanım oranı yaklaşık olarak %60 civarındadır. Bazı nesnelerin üretim maliyeti ciddi anlamda yüksektir. 
            Tabi burada maliyetten kasıt developeri yorması ve nesne yaratılırken sistemi ne kadar çok yorduğudur. 
            Bu tarz nesnelerin yeniden yaratmaktansa bir teknik ile kopyalanması söz konusudur. 
            Prottype işte tam olarak bu tarz bir durumda geçerlidir. Kullanilan yöntem ise deep copydir. yani nesne bire bir kopyalanarak yeni referans değerlere atanır.

            Prototype tasarım deseninde 3 nesne yapısı vardır.
                Prototype: Klonlama yapılacak sınıfların uygulaması gereken interface veya abstract sınıf.
                Concrete Prototype: Klonlama özelliği olacak gerçek sınıflar.
                Client: Klonlanmış nesneyi elde edecek nesne.

             */

            Game g1 = new Game(1, "PoolDay", "MultiPlayer", true);
            Game g2 = (Game)g1.Clone();

            if (g1.Equals(g2))
            {
                Console.WriteLine("types are equal !");
            }
            else
            {
                Console.WriteLine("types are not equal");
            }

            Console.ReadLine();

            /*
             
            En son Client(İstemci) tarafından bir talep gerçekleştirilmiştir.İkinci nesneyi new keywordü ile oluşturmaya kalkmayarak maliyeti göz ardı edip, var olan nesne üzerinden kopyalama işlemi gerçekleştirebiliyoruz. 
            Burada dikkat etmemiz gereken husus, Prototype tasarım desenini uygulayabilmek için ilgili sınıftan öncelikle new keywordü ile bir nesne üretilmeli, 
            ardından desenimiz üzerinden kopya üretimi tetiklenmelidir. 
            bu nesneler birbirlerinden farklı olacağından equals false dönmesi gerekmektedir.

             */
        }
    }
}
