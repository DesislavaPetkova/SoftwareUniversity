using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class BasicShape :IShape
    {
        private double width;
        private double height;

        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        
    }
}
