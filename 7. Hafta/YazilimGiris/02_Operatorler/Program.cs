using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // 545 920 49 77 tolga

            //1 Matematiksel operatörler

            int a = 20, b = 20;
            int toplam = a + b;

            //toplama cıkartma carpma ve bolme işlemlerini matematiksel sıralaması ile yapar

            int islem = 20 * 10 + 2 * 3; //capma bolme toplama ve cıkartma

            //işlem önceliğini değiştirmem mümkündür.

            int islem2 = 20 * (10 + 2) * 3;


            //% işlemi ile kalan bulunur

            int kalan = 80 % 3; //80 sayısının 3 ile bolumunden kalanı verır



            int s1 = 9, s2 = 4;
            int i1 = s1 / s2;

            float i2 = s1 / s2; // işlem yapılan bir kod satırını önce işlem yapılan tarafı değerlendirerek düşünmem lazım. İşlem yapılan taraf (s1/s2--> integer bir sayıyı integer bir sayıya böldüm. 2 integer bolunur sonucta integer bir sayı). son olarak atama yapılan taraf düşünülür. float i2 ye işlem sonucu atıyorum. İşlem sonucu integer bır sonuc cıkmıstır integer değeri float a atarsam kucuk alandan buyuk alana atama oludugunda hata vermez ve float alana sonuc olarak bulunan tam sayı degerı atanmıs olur.


            float i3 = (float)s1 / (float)s2; //2.25


            int sayi = 90;

            sayi = sayi + 1; //sayının degerıne 1  ekle onu sayı ya tekrar ata
            //91 olacak sayım
            sayi += 1; //sayı=sayı+1;

            sayi -= 1;//sayi=sayi-1
            sayi *= 2;//sayi=sayi*2;
            sayi /= 2;//sayi=sayi/2;


            sayi++; //sayıyı 1 artırır
            ++sayi;//sayıyı 1 artırır


            sayi--;//sayıyı 1 azaltır
            --sayi;//sayıyı 1 azaltır


            int yenisayi = 20, yenisayi2 = 20;

            int islemx1 = yenisayi++ + 1; //  yenisayi benim 2 tane işlemim var - 1 ile toplanarak islemx1 e atanmak - kendimi 1 artırıcam
            //yeni sayı için ++ sonda olduggundan artırım işlemi onun için 2 cil bir işlemdir.
            //islemx1=21  yenisayi=21


            int islemx2 = ++yenisayi2 + 1;//yenisayı2 benim öncelikli olarak ++ işlemimim var ben bunu yapmadan başka bir işleme giremem
            //yenisayi2=21  islemx2=22


            //2 Mantıksal operatorler

            //ve veya değil


            bool b1 = true, b2 = false, b3 = true;

            bool sb1 = b1 && b2;  //v1 ve b2 anlamındadır. true ve false = false    ***eğer ve operatörü kullanılıyorsa işlem giren tüm parametrelerin true olması lazım
                                  //  
                                  // ve   true  false 
                                  //true  true   false
                                  //false false  faslse


            bool sb2 = b1 || b2; //b1 veya b2     true veya false= true   ** eğer işleme girenlerden herhangi biri biri true ise sonuc true. hepsi false ise sonuc false olur

            //  
            //veya  true  false 
            //true  true   true
            //false true  faslse


            bool sb3 = (b1 && b2) || b3; //true ve false=  false     false veya true=true



            int x1 = 20, x2 = 30, x3 = 55;


            //**matamatiksel karsılastırmalarda == bize true yada false sonucunu verecektir.
            bool kontrol1 = x1 == x2; //eşit mi ?  sorusunun cevabını aldıgımız operatordur(==)  20==30 -->false

            bool kontrol2 = x1 != x2;//x1 x2 'e eşit değil mi?  20!=30 --> true

            bool kontrol3 = x3 % 5 == 0; //x3 un 5 ile bölümünden kalan 0 mı (true)


            bool kontrol4 = x2 % 2 == 0 && x2 % 3 == 0; // x2 hem 2 ye hem 3 e bolunurmu


            bool kontrol5 = x2 % 7 == 0 & x2 % 3 == 0; // & kullanırsam işlem içinde false değer görülse bile kontrol edilmeye devam eder.
                                                       //&& kullanırsam  önce x2 % 7 == 0 bu kontrol edilir (x2 7 ile bolumunden kalan 0 mı--> false) bu durumda  (x2 % 3 == 0 bu kontrole hiç bakılmaz)
                                                       //& kullanırsam  önce x2 % 7 == 0 bu kontrol edilir (x2 7 ile bolumunden kalan 0 mı--> false)  false olasa bile (x2 % 3 == 0 bu da kontrol edilir.)



            bool kontrol6 = x2 % 7 == 0 | x2 % 3 == 0; //normalde veya içinde 1 tane true goruldugu anda sonuc true olur ve sonrakı kontrollere hiç bakılmaz
            //tek | olarak kullanıldıgında ise true ile karşılaşsam bile işelm sonuna kadar kontrole devam eder.

            bool kontrol7 = x2 > 20;//x2 20 den büyükmü  geriye true false doner

            bool kontrol8 = x2 < 20;//x2 20 den küçükmü  geriye true false doner

            bool kontrol9 = x2 <= 20; //x2 20 den küçük yada eşitmi

            bool kontrol10 = x2 >= 20;//x2 20 den büyük  yada eşitmi


            //new,sizeof,typeof (c# ın kendi yapısında kullandıgı her birinin bir görevi olan ileride gondeme getireceğim operatörler)
            //Dizi operatörü--> []

            //16:21-16-37
        }
    }
}
