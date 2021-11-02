using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    //ConcreteBuilder Class
    class AmericanExpressConcreteBuilder : KrediKartiBuilder
    {
        public AmericanExpressConcreteBuilder()
        {
            kart = new KrediKarti();
        }
        public override void BankaAdi()
        {
            kart.BankaAdi = "Bank of America";
        }

        public override void KartLimiti()
        {
            kart.KartLimiti = 4500;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "American Express";
        }

        public override void TaksitAtlatma()
        {
            kart.TaksitAtlatma = false;
        }
    }
}
