using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralAdapter
{
    public class CalisanSistem
    {
        public string[][] CalisanGetir()
        {
            string[][] calisanlar = new string[4][];
            calisanlar[0] = new string[] { "100", "Ozhan", "Team Leader" };
            calisanlar[1] = new string[] { "101", "Gizem", "Developer" };
            calisanlar[2] = new string[] { "102", "Polat", "Developer" };
            calisanlar[3] = new string[] { "103", "Sena", "Tester" };

            return calisanlar;
        }
    }
}
