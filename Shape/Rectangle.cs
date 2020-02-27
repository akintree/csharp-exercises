using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public class Rectangle : Shape
    {
        public double width { get; set; }
        public double height { get; set; }
        public override double area()
        {
            return width * height;
        }
    }
}
