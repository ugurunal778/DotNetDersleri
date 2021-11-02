using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralProxy
{
    //Real Subject Class
    class Banka
    {
        public bool Pay(double Amount)
        {
            if (Amount < 100)
            {
                Console.WriteLine("Odeyeceginiz tutar 100 tlden az olamaz Fark:" + (100 - Amount));
            }
            else if (Amount > 100)
            {
                Console.WriteLine("Odeyeceginiz tutar 100 tlden fazla olamaz Fark:" + (Amount - 100));
            }
            else
            {
                Console.WriteLine("Odeme basari ile gerceklestirildi tutar:"+Amount);
                return true;
            }
            return false;
        }
    }
}
