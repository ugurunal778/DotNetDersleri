using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama, ilk tanımlamada default eleman değerler aldığını bilme bilme
            //eleman sınır dışı hatası, 
            //index 0 dan başlar
            //index eksiye gidemez
            //direk değer atayarak dizi olusturma
            //Array sınıfına ait indexof,Sort,reverse,Resize,Copy methodlarını bilmek
            //length ile boyut alma


            //remde adı a olan değeri 20 olan bir sayı tut.
            int a = 20;
            int b = 90;

            // remde adı sayılar olan bir alan ac bu alan içinde 10 adet sayı tutabiliyim.
            //Dizi Tanımı -----
            // **Dizime boyut vermek zorundayım. int[10]--> dizinin boyutunu vermiş oluruz.
            int[] sayilar = new int[10];

            // 1 ci eleman dizimdeki 0 cı indexe karşılık gelir.
            // Diziler 0 cı index den başlar.
            sayilar[0] = 12;

            //Sayılar dizisi kaç elemanlıdır. 10 elemanlıdır.
            //Sayıların sonuncu elemanına 80 değerini ata
            sayilar[9] = 80; // ***** c# da dizi index0 dan başlar

            //0   1  ...................................9cı index 
            // _   _   _   _    _    _    _    _   _    _
            // 12                                      80

            //sayilar[i]-->   [i] -->indexer dır.


            // Sayilar dizisinin 2 cı elemanın değeri şuan kaçtır ???
            //0 DIR. Diziler içinde eleman değeri ataması yapılmadıysa ilgili tipin default değerini alır.
            //sayılar için default değer 0 dır.


            //sayı tiplerinin int,byte,short,long,decimal,float ... default değeri 0 dır. *** bu tipler nullable değildir. Null olabilen tipler

            //int asd = null; hata int e null atanamaz.

            //Value typelar null olamaz.

            // sayı tiplerinin default değeri 0 dır.



            string kelime = "";

            string[] kelimeler = new string[10];
            kelimeler[0] = "ali";

            //kelimelerin 2 ci elemanındaki değer nedir ?
            //string default değer null dur . Bu nedenle 2 ci eleman nulldır.


            //proje derlenir çalışma zamanında dizi sınır dısı işlemi anlatan IndexOutOfRangeException alırız.
            // kelimeler[11] = "selam"; //System.IndexOutOfRangeException: 'Dizin, dizi sınırlarının 



            // dizinin elmanlarını hemen vererek dizi tanımlama yöntemi
            string[] iller = { "Ankara", "Edirne", "Bursa" };
            int[] sayilarim = { 21, 32, 21, 32, 32, 32, 32 };

            //sayilarim dizisinin eleman sayısı kactır  7

            sayilarim[2] = 96;


            bool anahtar = true;

            bool[] anahtarlar = new bool[2];
            anahtarlar[0] = true;
            anahtarlar[1] = false;


            //***********************************************************
            int[] sayilarim2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int toplam = sayilarim2.Sum();

            // ** dizimin eleman sayısını almamı sağlar
            int elamanSayısi = sayilarim2.Length;
            int elamanSayısi2 = sayilarim2.Count();

            //sayilarim2 dizisi 9 elemanına sahip mi true/false
            bool kontrol = sayilarim2.Contains(9);
            bool kontrol2 = sayilarim2.Contains(20);

            //dizinin içinde 5 kaıncı index de 
            int sonuc = Array.IndexOf(sayilarim2, 5);
            //dizinin içinde yoksa -1 değerini döner
            int sonuc2 = Array.IndexOf(sayilarim2, 35);

            //dizimizi tam tersine cevirir.
            Array.Reverse(sayilarim2); //10,9,8,......1

            //dizimin 1 ci elemanı artık 10 olur.



            int[] sayilarim3 = { 4, 5, 6, 10 };

            int maxdeger = sayilarim3.Max();
            int mindeger = sayilarim3.Min();
            double ortalama = sayilarim3.Average();

            Array.Sort(sayilarim3);


            // 1 ci indexden başla 3 elemanı temizle (bu işlem silme değildir. Default değer atanarak clear yapılır)
            Array.Clear(sayilarim3, 1, 3);

            //{4,0,0,0}


            //sayilarim3 eleman sayısını 2 yapmak istiyorum.
            //dizilerde runtimeda eleman değişikliği mümkündür. artırma yada azaltma
            Array.Resize(ref sayilarim3, 2); //Dizinin boyutu 2 ye indirilir bu durumda  2 den sonraki elemanlar yok edilir.

            //Çok boyutlu diziler
            int[,] ikiBoyut = new int[2, 3];
            // _ _ _
            // _ _ _

            ikiBoyut[0, 0] = 1;
            ikiBoyut[0, 1] = 3;
            ikiBoyut[0, 2] = 5;
            // 1 3 5
            // 0 0 0

            ikiBoyut[1, 0] = 3;
            ikiBoyut[1, 1] = 7;
            ikiBoyut[1, 2] = 3;
            // 1 3 5
            // 3 7 3


            int[,,] ucBoyut = new int[2, 3, 2];
            ucBoyut[0, 0, 0] = 1;
            ucBoyut[0, 0, 1] = 3;


            //Dizilerde birbirine atama işlemleri

            string[] dizim1 = { "a", "b", "c" };

            string[] dizim2 = new string[3];

            dizim2 = dizim1;

            dizim2[0] = "a_degisti";

            //** diziler referans tiplerdir. 2 referans tip = ile birbirine atanırsa bırebır aynı değer olurlar.


            int x1 = 20;
            int x2 = x1;

            x2 = 90;
            //x1 kaçtır ??? 20   x2 deki değişim x 1 etkilemez. value type davranısı




            string[] dizim1_1 = { "a", "b", "c" };

            string[] dizim2_2 = new string[3];

            //dizim1_1 i dizim2_2 aktarmak istiyorum ama referans olarak değil sadece değerlerini aktarmak istiyorum.
            //bambaşka 2 dizi gibi davransın

            Array.Copy(dizim1_1, dizim2_2, 3);

            dizim2_2[0] = "a_değişti";




        }
    }
}
