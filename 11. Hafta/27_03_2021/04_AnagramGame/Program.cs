using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AnagramGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kelimeler = { "araba", "uçak", "kalem", "defter", "kitap", "anakara", "ankara" };

            int sorulanSoruSayisi = 0;
            int puan = 0;

            string[] sorulanSorular = new string[kelimeler.Length];
            //null null null null null null

            while (sorulanSoruSayisi < kelimeler.Length)
            {
                int sorulacakIndex;
                string suanSorulacakSorum;
                do
                {
                    Random rnd = new Random();
                    sorulacakIndex = rnd.Next(0, kelimeler.Length);
                    suanSorulacakSorum = kelimeler[sorulacakIndex];

                    //eğer while ın içi true ise demekki  suanSorulacakSorum sorulanSorular ımın içinde
                    //bu durumu ıstemıyorum
                } while (sorulanSorular.Contains(suanSorulacakSorum) == true);


                //yenı sorulacak soru kesınlıkle sorulanSorular dan değil 


                int[] karisimIndexleri = new int[suanSorulacakSorum.Length];
                for (int i = 0; i < karisimIndexleri.Length; i++)
                {
                    karisimIndexleri[i] = -1;
                }
                // 1 _ _ _ _

                int rIndex;
                int karisimIndexleriEklenen = 0;
                while (karisimIndexleriEklenen < suanSorulacakSorum.Length)
                {
                    Random rnd = new Random();
                    rIndex = rnd.Next(0, suanSorulacakSorum.Length);

                    if (!karisimIndexleri.Contains(rIndex))
                    {
                        karisimIndexleri[karisimIndexleriEklenen] = rIndex;
                        karisimIndexleriEklenen++;
                    }

                }

                string karistirilanSoru = "";
                foreach (var item in karisimIndexleri)
                {
                    karistirilanSoru += suanSorulacakSorum[item];
                }


                Console.WriteLine("BIL BAKALIM: " + karistirilanSoru);
                string giris = Console.ReadLine();

                if (giris == suanSorulacakSorum)
                {
                    puan += 100;
                    Console.WriteLine("Tebrikler... Yeni puanın " + puan);

                }

                sorulanSorular[sorulanSoruSayisi] = suanSorulacakSorum;
                sorulanSoruSayisi++;


            }




        }
    }
}
