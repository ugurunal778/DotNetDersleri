using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ChildClass : ClassBase
    {
        public ChildClass(string f, string l) : base(f, l) { }
        public string Durumu { get; set; }


    }
}
