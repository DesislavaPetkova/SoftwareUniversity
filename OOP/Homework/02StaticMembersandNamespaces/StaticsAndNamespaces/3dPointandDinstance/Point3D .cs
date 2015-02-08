using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Point3D
{
    public class Point3D
    {
        private string pointName;
        private double pointX;
        private double pointY;
        private double pointZ;
        private static readonly Point3D startingPoint;

        static Point3D()
        {
            startingPoint = new Point3D("center", 0);
        }
        public Point3D StartingPoint
        {
            get 
            {
                return Point3D.startingPoint;
            } 
        }        

        public Point3D(string pointName, double pointX = 0, double pointY = 0, double pointZ = 0)
        {
            this.Name = pointName;
            this.X = pointX;
            this.Y = pointY;
            this.Z = pointZ;
        }

        public string Name 
        {
            get
            {
                return this.pointName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("invalid name");
                }
                this.pointName = value;
            }
        }
        public double X
        {
            get
            {
                return this.pointX;
            }
            set
            {                
                this.pointX = value;
            }
        }
        public double Y
        {
            get
            {
                return this.pointY;
            }
            set
            {                
                this.pointY = value;
            }
        }
        public double Z
        {
            get
            {
                return this.pointZ;
            }
            set
            {                
                this.pointZ = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("The cordinates of point " + this.Name + " are: " + this.X + ", " + this.Y + ", " + this.Z);
            return result.ToString();
        }
        
        
    }
}
