using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kazanımlar
            //1 cast işlemini ve Gizli donusum kavramını bilir (İmplicit,exclicit)
            //Cast ve convert methodlarıyla donusumler yapabilir.


            //sayı değerleri arasında eğer mümkünse otomatik bir dönüştürme işlemi oldugunu 01_Veri tiplerinde konusmustuk
            //(Gizli donusumler (Implicit)) Küçük veri tiplerinden büyük veri tiplerine dönüşüm otomotik olarak yapılmıştır

            byte a = 40;

            int i = a; //atama işlemi yapılan sağ taraftaki değişkenin sol taraftaki değişkenin tipiyle aynı olması lazım
            // sağ taraf (byte)  tipinde sol taraf int tipinde
            //** gizli donusum yapıldıgından hata almam


            int y = 900;
            //byte b = y;//sistem bize kızar sağ tarafta alanı deaha geniş olan bir tip var solda ise alanı daha küçük bir tip var. Bu değer kaybı yaratabilir.
            byte b = (byte)y;//değer kaybı olsa bıle bu işlemi yap


            string k = "1";

            // int sayi = (int)k;  string ile sayı tipleri arasında cast işlemi geçekleşemez.!!!


            int sayi = Convert.ToInt32(k);

            int islem = sayi++; //sayı olarak 2 işleme sahibim kendimi artırmak ve islem değerine eşitlenmek
                                //++ 2 cil işlemim
                                //islem=1

            int sayi2 = Convert.ToInt32(k);
            int islem2 = ++sayi2;//islem=2


            string k2 = "a1";
            // int sayi3 = Convert.ToInt32(k2);//çalışma anında bana hata fırlatır kodum calısmaz
            //donusum mumkun olmayan işlem için convert methodu hataya duser
            //runtime hata olusur

            // int sayi4 = int.Parse(k2);
            int sayi4 = int.Parse(k);
            //byte.Parse

            int sayi6 = 100;
            bool bol = Convert.ToBoolean(sayi6);
           

            //Convert.ToInt32 //inter a cevirir
            //Convert.ToInt64 //long a cevirir
            //Convert.ToInt16 //short
            //Convert.ToByte //byte


            //default değer 
            //sayı değerlerinin default değerleri 0 dır

           // int ilkdegersizSayi=null; //referans tip olmadıgından null atanamaz


            string ilkdegersizString=null; //string gibi referans tiplerin default değeri nulldır

            int cevir = Convert.ToInt32(ilkdegersizString);//integerın default degeri 0 oldugundan sonuc 0 dır.

            // int cevir2 = int.Parse(ilkdegersizString);//parse null da hata fırlatır.

            //****Parse methodlarıyla convert methodları mantıksal olarak aynı işe yapar
            //ister parse kullan ister convert fark etmez
            //convert  null ile işlem yaptıgındas hata vermez ilgili tipin default değerini set eder. 


            int sayim = 1200;
            string sayimStr = Convert.ToString(sayim);
            string sayimStr2 = sayim.ToString();
        }
    }
}
