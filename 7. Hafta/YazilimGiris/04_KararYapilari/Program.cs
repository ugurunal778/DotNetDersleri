using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kazanımlar
            //if, if - else  , if-elseif kullanımını yorumlar
            //swich-case (bize elseif yapısını farklı bir yazımla sunar) yapısını yorumlar.


            int sayi = 20;

            //if(true-false)  if in içene yazadığım kontrolun true yada false a karşılık gelmesi gerek
            if (sayi % 2 == 0)
            {
                sayi *= 2;
                //eğer if içi doğru ise bu block çalışır
            }
            else
            {
                //eğer if in içi doğru değilse bu block çalışır.
                sayi++;
            }


            int sayi2 = 100;

            if (sayi2 % 5 == 0)
            {
                //sayının 5 ile bolumunden kalan 0 sa calısır
            }//bu ifin else i yok (her ifin else i olmak zorunda değil)
            if (sayi2 % 2 == 0) // kendinden önceki if ile hiç bir bağı yoktur
            {

            }
            else //else olarak kendimden onceki ilk ife baglıyım if gerçekleşmesse ben gerçeklesirim .Tek başına else diye bir kavram yoktur. İf varsa else olabilir.
            {

            }



            if (sayi2 % 5 != 0) // (sayi2 % 5 != 0) false oldugundan if atlanır else i varsa oraya girer
            {
                //hiç girmez
            }
            else
            {//burası calısacak ccunku sayının 5 ile bolumunden kalan 0 dır.

                if (sayi2 % 2 == 0)
                {
                    //burası calısır
                }
                else
                {
                    //hiç çalışmaz
                }
            }


            //------------------------------------------------------

            string gun = "Pazartesi";
            sbyte haftaninKacinciGunu;
            //if-else if yapısı birbirine bağlı 1 den çok if oluşturmamızı sağlar
            //Zincir yapısı olusur zincire dahil olan iflerden 1 tanesi gerçekleşirse zincirin kalan kısmı kontrol edilmez
            //Ornegın gun=Pazartesi ise 2 ci ifden sonrasına hic bakılmaz

            if (gun == "Pazar")
            {
                haftaninKacinciGunu = 1;
            }
            else if (gun == "Pazartesi")
            {
                haftaninKacinciGunu = 2;
            }
            else if (gun == "Salı")
            {
                haftaninKacinciGunu = 3;
            }
            else if (gun == "Çarşamba")
            {
                haftaninKacinciGunu = 4;
            }
            else// else olmak zorunda değil koyarsam zincirde hiç bir kosul uygun değilse bura calısır.
            {
                haftaninKacinciGunu = -1;
            }




            int sayimx = 10;
            bool islem = false;

            // eğer if ve | veya elseden sonra 1 satırda işi bitireksen süslü gerekmez
            if (sayimx % 2 == 0) islem = true; else islem = false;

            if (sayimx % 2 == 0)
            {
                islem = true;
            }
            else islem = false;

            if (sayimx % 2 == 0)
                islem = true;
            else { islem = false; }

            //ternary if ifadesi
            islem = sayimx % 2 == 0 ? true : false;
            //eğer dogru ise --> soru işaretinden sonraki 1 ci değer
            //eğer dogru değil ise -->soru işaretinden sonraki 2 ci değer atanır


            byte haftaninGunu = 4;
            string durum;

            //elimde bir değer var ve bu değer x ise su iş yapılsın
            //y vaya z ise bu iş yapılsın gibi senaryolardan if-elseif yerine switch case kullanalım.
            //** mantıksal olarak fark olmasada kod okunurlugu olarak switch case daha okunaklı olacaktır.
            switch (haftaninGunu)
            {
                case 1:
                    durum = "İlk çalışma günüm";
                    break;//işi bitir. switch-case yapısını terket
                case 2:
                    durum = "2 ci çalışma günüm";
                    break;
                case 3:
                case 4:
                case 5://3 veya 4 veya 5 ise buraya dussun
                    durum = "Tatil günüm";
                    break;
                default://default case i olmak zorunda değiş . 
                    //hiç bir case ile eşleşmezse default calısır
                    durum = "Tanımsız bir durum";
                    break;
            }

            //yukarıdaki switch case ile yazdığımız karar yapısını if-else if şekline çevirdik
            //okunaklılıgın switch case e gore daha kotu oldugun bakarak gorunuyor

            if (haftaninGunu == 1)
            {
                durum = "İlk çalışma günüm";
            }
            else if (haftaninGunu == 2)
            {
                durum = "2 ci çalışma günüm";
            }
            else if (haftaninGunu == 3 || haftaninGunu == 4 || haftaninGunu == 5)
            {
                durum = "Tatil günüm";
            }
            else
            {
                durum = "Tanımsız bir durum";
            }



            //if ler içinde çeşitli işlemler yapılırsa bu switch case için uygun değil.
            int sayimz = 983;
            if (sayimz % 2 == 0 && sayimz % 3 == 0)
            {

            }
            else if (sayimz % 5 == 0 && sayimz % 4 == 0)
            {

            }


            //switch ve case ile her tipi için kontrol yapısı kurabiliriz. Mesela karakter tipince bir değişken için bir örnek.
            char c = 'a';

            switch (c)
            {
                case 'a':
                    break;
                case 'b':
                    break;
                case 'c':
                    break;

                default:
                    break;
            }


        }
    }
}
