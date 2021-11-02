using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    //ConcreteBuilder Class
    class MasterConcreteBuilder : KrediKartiBuilder
    {
        public MasterConcreteBuilder()
        {
            kart = new KrediKarti();
        }
        public override void BankaAdi()
        {
            kart.BankaAdi = "Turkiye Is Bankasi";
        }

        public override void KartLimiti()
        {
            kart.KartLimiti = 3500;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "Master Card";
        }

        public override void TaksitAtlatma()
        {
            kart.TaksitAtlatma = true;
        }
    }
}
