using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralObserver
{
    class Program
    {
        /*
         
            Observer tasarım deseni behavior grubununa ait, bir nesnede meydana gelen değişikliklerde
        içinde bulundurduğu listede bulunan nesnelere haber gönderen tasarım desenidir. 
        Observer tasarım deseninin uluslar arası kullanıma  göre en sık kullanılan tasarım desenlerindendir. 

            Observer tasarım deseni; birbirleri ile bire çok (yani bir nesnenin içinde başka bir nesnenin listesinin bulunması olarak düşünebiliriz) ilişki olan nesneler arasında olay bazlı bir etkileşim olduğu durumları düzenler. 
        Örnek senaryo olarak;

            Bir e-ticaret sitesinde bir üründeki stok değişiminde o ürünü takip eden üyelere haber verilmesi.

            Ham madde – ürün ilişkisi olan bir durumda, ham maddenin fiyatı değişince ürünün fiyatının da değişmesi.

            Facebook da ki bir iletiye yorum yapılması durumunda o iletiye yorum yapan ve beğenen üyelere bildirim gitmesi

            Subject:Takip edilecek nesneyi Subject terimiyle ifade etmekteyiz.

            Observer:Subject’i takip edecek olan aboneler tek tip olmayabilirler.
        İşte böyle bir durumda birden fazla tipe arayüz görevi görecek abstract yahut interface yapımıza Observer denmektedir. 

            Concrete:Subject’i takip eden nesnelerdir.

             */
        static void Main(string[] args)
        {

            //İlk olarak Subject nesnemizi oluşturuyoruz.
            absUrun Kitap = new Urun("Kitap", 10.25M);

            //Subject nesnemiz ile ilgili olan Uye (observer) listesine nesne ekliyoruz.
            Kitap.TakipList.Add(new Uye { E_Mail = "ozhan@bilgeadam.com" });
            Kitap.TakipList.Add(new Uye { E_Mail = "verda@bilgeadam.com" });

            //Subject yani ürün fiyatını değiştirdiğimizde listedeki
            //observer nesnelerinin ilgili metodu çalıştırılacak
            Kitap.Fiyat = 8.99M;


            Console.ReadLine();

        }
    }
}
