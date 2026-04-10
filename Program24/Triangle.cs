using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program24
{
    internal class Triangle : Shape
    {
        double b, h;

        public Triangle(double b, double h)
        {
            this.b = b;
            this.h = h;
        }

        public override double Area()
        {
            return 0.5 * b * h;
        }
    }
}
