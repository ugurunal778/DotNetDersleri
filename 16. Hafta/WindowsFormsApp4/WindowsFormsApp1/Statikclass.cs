using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Statikclass
    {

        public static string Deneme(bool durum)
        {
            string mesaj = null;
            if (durum)
            {
                mesaj = "Durumu iyi";
            }
            else
            {
                mesaj = "Durumu Kötü";
            }
            return mesaj;
        }
        public static string GetFirstThreeCharacters(this String str)
        {
            if (str.Length < 3)
            {
                return str;
            }
            else
            {
                return str.Substring(0, 3);
            }
        }
        public static int GetMod(this int intvalue)
        {
            var result = intvalue % 2;
            return result;
        }


    }
}
