using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralObserver
{
    //ConcreteSubject
    class Urun : absUrun
    {
        public Urun(string UrunAd, decimal UrunFiyat) : base(UrunAd, UrunFiyat)
        {
        }
    }
}
