using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralAdapter
{
    public class CalisanAdapter : CalisanSistem, ITarget, IHumanResources
    {
        public List<string> GetCalisanMaas()
        {
            var result = new List<string>() {
                "Ercan UYKAN;5000",
                "Mahmut Erdönmez 6000",
                "Berke Altınkaya 10000" };

            return result;
        }

        public List<string> GetEmployeeList()
        {
            List<string> calisanList = new List<string>();
            string[][] employees = CalisanGetir();
            foreach (string[] employee in employees)
            {
                calisanList.Add(employee[0]);
                calisanList.Add(",");
                calisanList.Add(employee[1]);
                calisanList.Add(",");
                calisanList.Add(employee[2]);
                calisanList.Add("\n");
            }

            return calisanList;
        }
    }
}
