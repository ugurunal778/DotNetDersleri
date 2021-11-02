using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.LSP.Validated
{
    public class Square : Shape
    {
        public int Width { get; set; }

        public override double CalculateArea()
        {
            return Width * Width;
        }

    }
}