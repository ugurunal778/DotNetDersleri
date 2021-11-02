using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_03_04_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ornek case 
            //Kullanıcıya bır sayı gir diyelim
            //Bu girilen sayıyı alalım--->sayı1
            //Kullanıcıya bir sayı daha gir diyekim--->sayi2
            //Bir işlem gir ----> islem diye alalım
            //2 sayı ile bu işlemi yapalım
            #region inputlar

            Console.WriteLine("Bir sayı gir :");
            string girilenSayi = Console.ReadLine();

            Console.WriteLine("Bir sayı daha gir :");
            string girilenSayi2 = Console.ReadLine();

            Console.WriteLine("Bir islem gir (+,*,/,+) :");
            string islem = Console.ReadLine();
            #endregion


            int sayi1 = int.Parse(girilenSayi);
            int sayi2 = Convert.ToInt32(girilenSayi2);


            int sonuc=0;
            bool islemBasariliMi = true;
            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
                default:
                   
                    islemBasariliMi = false;
                    Console.WriteLine("Beklenen işlem dısında bir işlem girişi yaptınız");
                    break;

            }

            if (islemBasariliMi)
            {
                //strıng ile int toplamsında sistem integer kısmını otomotık strıng olarak degerlendırır
                //Console.WriteLine("Sonuc: " + sonuc.ToString());
                Console.WriteLine("Sonuc: " + sonuc);
            }


            Console.ReadLine();

        }
    }
}
