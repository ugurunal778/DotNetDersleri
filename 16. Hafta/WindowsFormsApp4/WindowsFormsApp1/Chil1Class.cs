using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Child1Class : ClassBase
    {
        public Child1Class(string firstname, string lastName) : base(firstname, lastName)
        {

        }
        public string test { get; set; }
    }
}
