using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    class VisaConcreteBuilder : KrediKartiBuilder
    {
        //ConcreteBuilder Class
        public VisaConcreteBuilder()
        {
            kart = new KrediKarti();
        }
        public override void BankaAdi()
        {
            kart.BankaAdi = "Garanti Bankasi";
        }

        public override void KartLimiti()
        {
            kart.KartLimiti = 6500;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "Visa";
        }

        public override void TaksitAtlatma()
        {
            kart.TaksitAtlatma = true;
        }
    }
}
