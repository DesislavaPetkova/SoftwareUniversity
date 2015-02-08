using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Point3D
{
    public static class DistanceCalculator
    {
        public static double GetDistance(Point3D a, Point3D b)
        {
            double distance = 0; 
            distance= Math.Sqrt(((a.X-b.X) * (a.X-b.X))+ ((a.Y-b.Y) * (a.Y-b.Y))+ ((a.Z-b.Z) * (a.Z-b.Z)));
            return distance;
        }
    }
}
