using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralProxy
{
    //ProxyBanka
    class ProxyBanka : IBank
    {
        Banka banka;
        bool Login;
        string UserName, Password;

        public ProxyBanka(string UserName,string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }

        bool GirisYap()
        {
            if (UserName.Equals("BilgeAdam") && Password.Equals("1234"))
            {
                banka = new Banka();
                Login = true;
                Console.WriteLine("Hesaba giris basarili");
                return true;
            }
            else
                Console.WriteLine("sifre ya da kullanici ismi yanlis");

            Login = false;
            return false;
        }
        public bool OdemeYap(double Tutar)
        {
            GirisYap();
            if (!Login)
            {
                Console.WriteLine("Hesaba giris basarisiz odeme gerceklestirilemedi");
                return false;
            }

            banka.Pay(Tutar);
            return true;
        }
    }
}
