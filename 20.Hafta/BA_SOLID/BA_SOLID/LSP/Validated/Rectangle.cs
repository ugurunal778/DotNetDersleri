using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.LSP.Validated
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
