using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program24
{
    internal class Rectangle : Shape
    {
        double length, width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public override double Area()
        {
            return length * width;
        }
    }
}
