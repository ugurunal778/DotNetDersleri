using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.LSP.Bad
{
    //Karelerde birer dörtgen olduğu için alttaki yöntemi izlememiz yanlış olmayacaktır.
    //Yalnız dörtgen yerine kare sınıfını kullandığımızda işlemler istediğimiz gibi sonuçlanmayacaklardır.
    //Bunun nedeni ise kodun yazım şeklidir.

    public class BadSquare:BadRectangle
    {
        int _height;
        int _width;


        public override int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                _width = value;
            }
        }


        public override int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _height = value;
                _width = value;
            }
        }

    }
}
