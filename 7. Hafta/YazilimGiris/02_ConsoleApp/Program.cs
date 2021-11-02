using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ConsoleApp
{
    class Program
    {
        static int globalDegisken = 20;
        static void Main(string[] args)
        {

            //1 Veri tipi nedir
            //İstediğimiz kazanımlar

            //ilkel(Primitive) Veri tipleri bilir ve doğru veri tipini doğru anda kullanır.
            //İmplicit ve explicit dönüşümleri bilir. Cast işleminin ne olduğunu bilir.
            //Global ve lacal değişken kavramı bilir.
            //Referans tip value tip kavaramı nedir bilir


            //int,short ,byte....string gibi ifadeler keyword lerdir. 

            int a = 20;// bir değişken tanımlaması yaptım
                       //tip  adı=deger

            short b = 20;

            int yas_olmamali = 40;// bir insanın yası max 100 olur.Bu durumda ben neden remde 32 bitlik bir alan actım.

            byte yas = 40;//rem de 8 bitlik bir alan ayırdım ve bu alana 40 yazdım.

            // yas = 300;// bir değişkene kendi boyut sınırları dısında değer ataması hata oluştur.

            //byte(0-255) **sadece pozitif değeleri alır
            sbyte sb = -100;// sbye -128 , +127 arasında değerleri tutabilir.

            //*** int ,short ve long  - değerler alabilir. bunların  sadece + değerler almasını istersem
            //int (-+)   uint (0-4,294,967,295)
            //uint,ushort,ulong ile ilgili tiplerin sadece pozitif değer almasını sağlarım. Bu tiplerin remde kapladığı alan değişmez. Pozitif yonde max değerlerine 2 katına çıkar.

            //- short(65,535) -int (2,147,483,647)

            //------------------ byte,int,short,long ***tam sayı değeri alır.


            //float (f 32bit),double (d 64bit) ,decimal (m 128bit)
            //parasal işlem olan uygularımda decimal


            char c = 'a'; //remde bir alan actım adına c dedim içindeki değer 'a' karakterini atadım. Karakterler tek tırnakla verilir.

            string password = "?_=**43*_"; //string ifadeler birden cok karakterin bir araya gelmesi ile olusmus yapılardır.


            bool anahtar = true;//false (8 bit)

            //1byte= 8 bit


            //İlkel tipler (tam sayı tipleri ve noktalı sayı tipleri, bool ve char)


            int sayi1 = 300;

            //byte sayi2 = sayi1; // byte ım ben 255 e kadar değer tutarım  ben ona int bir değer atmaya calısıyorum. Hata alırım.

            int sayi3 = 100;
            byte sayi4 = (byte)sayi3;//explicit (Açık donusum onerısı yaptı (cast))
            //int dan byte direk donusum olsaydı değer kaybetme sanısım olurdu

            byte sayi5 = (byte)sayi1;//burada bu donusum yapılır ama değer kaybederim!!!!!!!
            //buyuk alan kaplayan tipleri daha kucuk alan kaplayan tiplere donustururken değer yaşamam olasıdır.
            //bu işleme cast denir.


            byte sayi6 = 255;
            int sayi7 = sayi6;//** kucuk alan kaplayan sayı tiplerinden buyuk alan kaplayan sayı tiplerine geçtiğimde matamatiksel olarak değer kaybetme sansım yok.
            //(Gizli donusumler (Implicit))


            //int a = 40;// Bu block içinde yukarıda a isminde değişken daha önce tanımlandığı için tekrar tanımlamam mümkün değildir.

            int y_1 = 20, y_2 = 30, y_3 = 30; //bir satırda aynı tipden istediğim kadar değişken tanımlabilirim.


            //int 1_y = 20; ** sayı ile bağlayan bir değişken adı verilemez. Özel karakterlerle değişadı başlatamam.

            int z_1, z2; //Bu değişkenlere ilk değer ataması yapmadım.


            //int t_1 = z_1 + 10; ** ilk değer ataması yapmadığım değişkeni işleme sokakmam hata alırım.

            string kelime1 = "ahmet";
            string kelime2 = kelime1;
            kelime2 = "Veli";
            //string bir class olmasına rağmen değer atama mantığı value type gibidir.
            //value type için rem işlemleri referans type lara göre çok daha hızlı gerçekleşir.
            //bu nedenle yapısal olarak class olan string .net içinde value type olarak değerlendirilen nadir tiptir.

            //kelime1  değeri nedir ??==> ahmet neden value type davranısı

            int s_11 = 90;
            int s_12 = s_11;
            s_12 = 100;

            //s_11 kactır-->90 neden value type davranısı

            Insan insan1 = new Insan();
            insan1.ad = "ahmet";
            insan1.soyad = "soylu";
            insan1.yas = 20;

            Insan insan2 = insan1;
            insan2.ad = "ayşe";

            //insan1 ad ne olur ??  oda ayşe olur. neden referans type davranısı

            //---------------------------------------------------------------------------

            //float(f 32bit),double(d 64bit) ,decimal(m 128bit)

            //12.5 sonuna bir haf koumuyorsam bu noktalı sayı double dır
            float f1 = 12.5f;
            double d1 = 12.5; //sonuna harf koymasam bile bu defaultunda d harfi ile gelir
            double d2 = 12.5d;

            decimal d3 = 12.90m;

            int f1_i = (int)f1; //cast işlemi yapmasını söyledim. Değer kaybı yaşadım (12.5 değeri 12 olarak artık int f1_i alanında tasınmaya basladı)

            // string ka_1 = (string)f1; bır sayıyı bır string e cast etmem mumkun değil
            //cast ıslemı sayı tıplerım arasında gercekleşir. Ayrıca ilerleyen konularda class larda gundeme gelecektir.


            //her blockta tanımlanan deişkenler o block ozelınde local deüşkenlerdir. Sadece kendi blocklarında erişilir.

            globalDegisken = 90;

            Console.ReadLine();
        }
        static int Topla(int a, int b)
        {
            //ben bu scope ıcınde Main methodunda tanılanan herhangi bir değişkene erişemiyorum.
            // yas bu değer main içinde tanımlı bir değişken burada goremıyorum.

            //globalDegisken---- i görebiliyor ve erişebiliyor. Bu değişken bu block ozelınde global bir değişkendir.
            return a + b;
        }
    }
}
