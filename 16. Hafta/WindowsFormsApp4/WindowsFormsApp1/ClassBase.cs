using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ClassBase
    {
        //public ClassBase _classBase;
        //public ClassBase()
        //{
        //    if (_classBase == null)
        //    {
        //        Adı = "Ekin";
        //    }
        //}

        public int id { get; set; }
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public DateTime dogumTarihi { get; set; }
        public int Yaşı { get; set; }

        public  ClassBase(string ad ,string soyadı)
        {
            string fulname = ad + soyadı;
        }
       

    }
}
