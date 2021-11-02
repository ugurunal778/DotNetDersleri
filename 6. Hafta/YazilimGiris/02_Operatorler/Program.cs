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

            sayi++; //sayıyı 1 artırır
            ++sayi;//sayıyı 1 artırır


        }
    }
}
