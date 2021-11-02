using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class_Sample.Models
{
    public class Cat : Animal
    {
        public Cat()
        {
            BirthDate = DateTime.Now;

        }

        public string Type { get; set; }


        public DateTime BirthDate { get; set; }

        
    }
}
