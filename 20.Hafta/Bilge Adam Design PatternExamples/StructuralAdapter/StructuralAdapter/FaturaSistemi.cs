using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralAdapter
{
    public class FaturaSistemi
    {
        private ITarget calisanlar;
        public FaturaSistemi(ITarget calisanlar)
        {
            this.calisanlar = calisanlar;
        }

        public void CalisanGoster()
        {
            List<string> calisan = calisanlar.GetEmployeeList();

            Console.WriteLine("--**--**--** Calisanlar --**--**--**");
            foreach (var item in calisan)
            {
                Console.Write(item);
            }
        }
    }
}
