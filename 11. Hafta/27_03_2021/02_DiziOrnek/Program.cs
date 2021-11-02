using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DiziOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] en = { "cat", "car", "room", "doctor" };
            string[] tr = { "kedi", "araba", "oda", "doktor" };

            string kapatılacakMi = "";

            while (kapatılacakMi != "c")
            {
                //output siyaha ekrana bilgi verme methodu
                Console.WriteLine("Bir kelime yaz ingilizceye ceviyim:");

                //siyah ekrandan veri alama methodu. 
                string girilenKelime = Console.ReadLine();



                //Girilen kelimeyi tr dizisinde aradım. Eğer varsa kacıncı indexte var . yoksa -1 donecek
                int arananIndex = Array.IndexOf(tr, girilenKelime);

                if (arananIndex == -1)
                {
                    Console.WriteLine("Aradığınız kelime sözlüğümde bulunmuyor.");
                }
                else
                {
                    //en dizisine gidip bu indexe karşılık gelen değeri buldum.
                    string enKarsiligi = en[arananIndex];
                    Console.WriteLine("EN :" + enKarsiligi);
                }

                Console.WriteLine("Kapatmak için c hafıne bas.");
                kapatılacakMi = Console.ReadLine();

            }


        }
    }
}
