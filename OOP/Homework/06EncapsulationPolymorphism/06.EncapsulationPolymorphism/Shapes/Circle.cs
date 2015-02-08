using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle:IShape
    {
        private double radius;

        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }
    }
}
