using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Point3D
{
    class Test
    {
        static void Main()
        {
            Point3D pointA = new Point3D("pointA", 1.2, 3, 5.6);
            Point3D pointB = new Point3D("pointB", -1.2, 3, 5.6);
            Point3D pointc = new Point3D("pointC", 0, 2, 3);
            //Point3D pointTest = new Point3D();
            Console.WriteLine(pointA.ToString());
            Console.WriteLine(pointB.ToString());
            Console.WriteLine(pointc.ToString());
            Console.WriteLine(DistanceCalculator.GetDistance(pointA, pointB));
        }
        
    }
}
