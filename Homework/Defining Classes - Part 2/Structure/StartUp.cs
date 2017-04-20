using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var point1 = new Point3D(2, 3, 5);
            var point2 = new Point3D(0, 5, 9);
            var distance = Calculate.DistanceBetweenPoints(point1, point2);
            Console.WriteLine("Distance: {0:F2}", distance);

            var path = new Path();
            path.Add(point1);
            path.Add(point2);
            var points =path.ReturnPoints();
            foreach (var point in points)
            {
                Console.WriteLine(point.ToString());
            }

            PathStorage.Save("text",points);
            PathStorage.Load("text");

        }
    }
}
