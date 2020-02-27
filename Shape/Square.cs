using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class Square : Rectangle
    {
        public override double area()
        {
            return width * width;
        }
    }
}
