using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle :BasicShape,IShape 
    {
        private double a;
        private double b;
        private double c;
        private double p;
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.p = (this.A + this.B + this.C) / 2;
        }

        public override double CalculateArea()
        {
            return Math.Sqrt(this.p * (this.p - this.A) * (this.p - this.B) * (this.p - this.C));
        }

        public override double CalculatePerimeter()
        {
            return this.p * 2;
        }
    }
}
