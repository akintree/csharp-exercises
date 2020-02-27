using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public class Circle : Shape
    {
        public static double radius { get; set; }
        public double circumference = (2 * 3.14 * radius);
        public double diameter = 2 * radius;
        public override double area()
        {
            return 3.14 * (radius * radius);
        }
    }
}
