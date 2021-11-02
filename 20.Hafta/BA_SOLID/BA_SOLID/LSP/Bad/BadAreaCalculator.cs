using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.LSP.Bad
{
    public class BadAreaCalculator
    {
        public static double CalculateArea(BadRectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }

        public static double CalculateArea(BadSquare square)
        {
            return square.Height * square.Width;
        }

        //Bu metotları console üzerinde test edelim.
    }
}
