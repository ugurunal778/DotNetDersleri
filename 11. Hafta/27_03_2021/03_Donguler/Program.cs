using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //while, do while
            //for
            //foreach
            //break,continue


            int[] sayilarim = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //  bslangıc    kosul       artırım yada azalım
            for (int i = 0; i < sayilarim.Length; i++)
            {
                //once ilk değer ataması yapılır i=0
                //Kosul kontrol edilir 0<8  kosul dogru oldugundan süslü parantez içindeki işlem yapılır.
                //artırım kısmına gidilir i=1 ve kosula bakılır 1<8 kosul dogru oldugundan süslü parantez içindeki işlem yapılır.
                //artırım kısmına gidilir i=2 ve kosula bakılır 2<8 kosul dogru oldugundan süslü parantez içindeki işlem yapılır.
                //artırım kısmına gidilir i=3 ve kosula bakılır 3<8 kosul dogru oldugundan süslü parantez içindeki işlem yapılır.
                //artırım kısmına gidilir i=4 ve kosula bakılır 4<8 kosul dogru oldugundan süslü parantez içindeki işlem yapılır.
                //artırım kısmına gidilir i=5 ve kosula bakılır 5<8 kosul dogru oldugundan süslü parantez içindeki işlem yapılır.
                //artırım kısmına gidilir i=6 ve kosula bakılır 6<8 kosul dogru oldugundan süslü parantez içindeki işlem yapılır.
                //artırım kısmına gidilir i=7 ve kosula bakılır 7<8 kosul dogru oldugundan süslü parantez içindeki işlem yapılır.
                //artırım kısmına gidilir i=8 ve kosula bakılır 8<8 kosul sağlanmaz süslü içi yapılmayıp fordan cıkılır.


                sayilarim[i] = sayilarim[i] * 2;
            }




            int[] sayilarim2 = { 11, 21, 31, 40, 5, 6, 7, 8 };
            //bu dizideki 2 ile bolunen ilk elemanı bul

            int ikiIleBolunenIlkEleman = -1;
            for (int i = 0; i < sayilarim2.Length; i++)
            {
                if (sayilarim2[i] % 2 == 0)
                {
                    ikiIleBolunenIlkEleman = sayilarim2[i];
                    //break sahibi olduğu döngüyü devam ettirme cıkış yap anlamına gelir.
                    break;

                }

            }

            //bu dizideki 2 ile bolunen ilk elemanı sondan ilk elemanı bul

            int ikiIleBolunenIlkElemanSondan = -1;
            for (int i = sayilarim2.Length - 1; i >= 0; i--)
            {
                if (sayilarim2[i] % 2 == 0)
                {
                    ikiIleBolunenIlkElemanSondan = sayilarim2[i];
                    //break sahibi olduğu döngüyü devam ettirme cıkış yap anlamına gelir.
                    break;

                }
            }



            //10  1  2

            //1  10  2
            //2 10


            //2    3
            int[] sayilarim3 = { 11, 21, 31, 40, 5, 6, 7, 8 };
            //bu sayıları sırala ama sort methoduyla değil kendin dongul kullanarak yap
            for (int i = 0; i < sayilarim3.Length; i++)
            {
                for (int j = i + 1; j < sayilarim3.Length; j++)
                {
                    if (sayilarim3[i] < sayilarim3[j])
                    {
                        int temp = sayilarim3[i];
                        sayilarim3[i] = sayilarim3[j];
                        sayilarim3[j] = temp;

                    }

                }

            }

            int[] sayilarim4 = { 11, 21, 31, 40, 5, 6, 7, 8 };
            Array.Sort(sayilarim4);




            int[] sayilarim5 = { 11, 21, 31, 40, 5, 6, 7, 8 };
            //dizideki tüm sayıları topla,
            int toplam = 0;
            for (int i = 0; i < sayilarim5.Length; i++)
            {
                toplam += sayilarim5[i];
            }

            int[] sayilarim6 = { 11, 21, 31, 40, 5, 6, 7, 8 };
            //dizideki minimum sayıyı bul
            int minSayi = sayilarim6.Min();

            int minBulunan = sayilarim6[0];
            for (int i = 1; i < sayilarim6.Length; i++)
            {
                if (sayilarim6[i] < minBulunan)
                {
                    minBulunan = sayilarim6[i];
                }
            }


            int[] sayilarim7 = { 11, 21, 31, 40, 5, 6, 7, 8 };

            int maxBulunan = sayilarim7[0];
            for (int i = 1; i < sayilarim7.Length; i++)
            {
                if (sayilarim7[i] < maxBulunan)
                {
                    maxBulunan = sayilarim7[i];
                }
            }


            //**************************************************************************


            int[] dizim8 = { 1, 2, 3, 4, 5, 6 };
            int toplam8 = 0, sayac = 0;

            //for içindeki break aynı mantıkla while içinde geçerlidir.
            while (sayac < dizim8.Length) //içindeki kosul true oldugu surece suslu ıcındeki işlem yapılır.
            {
                toplam8 += dizim8[sayac];
                sayac++;
            }



            //do-while

            int x = 1;
            Random random = new Random();

            do
            {
                //do nun içi kesinlikle 1 kere de olsa yapılır.
                //önce 1 kere do yapılır sonra eğer kosul doğru ise while ile aynı mantıkla calısmayaya devam eder.
                int rastage = random.Next(10000);
                x = x + rastage;
            } while (x % 2 == 0);



            //foreach
            int[] sayilarim10 = { 1, 2, 3, 4, 5, 6, 7 };
            int toplam10 = 0;
            foreach (int item in sayilarim10)
            {
                //dizi 0 ı elemandan son indexdeki elemana kadar doner
                //her iterasyonda(her donuste) sırasıyla dizi elemanlarını item değişkenine koyarak bize verir 

                //1 ci iterasyonda item=1 dir
                //2 ci iterasyonda item=2 dir.....

                toplam10 += item;

            }



            int[] sayilarim11 = { 11, 21, 31, 40, 5, 6, 7, 8 };
            //bu dizideki 2 ile bolunen ilk elemanı bul

            int ikiIleBolunenIlkEleman11 = -1;
            foreach (var item in sayilarim11)
            {
                if (item % 2 == 0)
                {
                    ikiIleBolunenIlkEleman11 = item;
                    break;
                }

            }





            int[] sayilarim12 = { 11, 21, 31, 40, 5, 6, 7, 8 };
            //dizideki tek sayıları topla

            int toplam12 = 0;
            foreach (var item in sayilarim12)
            {
                if (item % 2 == 0) continue; // tüm döngülerde kullanılabilir
                //amacı donguyu bu noktadan sonra devam ettir. Yeni iterasyona geç
                //continue dan sonrakı kısımdaki kod yapılmaz yenı ıterasyona gecilir.

                toplam12 += item;

            }



            int[] sayilarim13 = { 11, 21, 31, 40, 5, 6, 7, 8 };
            //her bir sayının değerini 2 katına cıkar
            foreach (var item in sayilarim13)
            {
                // item = item * 2; //item a yeni değer ataması yapılamaz .Foreach için bilinmesi gereken önemli bir kuraldır.
                //ben sana her iterasyonda ilgili item ı verırırım ama bunu değiştiremezsin. Bu sadece okunabilirdir.
                //foreach ın iterasyon değeri (item) değiştirilemez hatası alırız
            }


        }
    }
}
