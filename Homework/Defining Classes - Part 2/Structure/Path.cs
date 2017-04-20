using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public static class Path
    {

        private static List<Point3D> points = new List<Point3D>();
        public static List<Point3D> ReturnPoints
        {
            get
            {
                return Path.points;
            }

        }
        public static void Add(Point3D point)
        {
            Path.points.Add(point);
        }



    }
}
