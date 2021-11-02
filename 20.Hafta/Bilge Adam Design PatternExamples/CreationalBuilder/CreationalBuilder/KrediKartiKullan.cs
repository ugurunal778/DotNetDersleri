﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    //Director Class
    class KrediKartiKullan
    {
        public void KartKullan(KrediKartiBuilder Kart)
        {
            Kart.BankaAdi();
            Kart.KartTipi();
            Kart.KartLimiti();
            Kart.TaksitAtlatma();
        }
    }
}
