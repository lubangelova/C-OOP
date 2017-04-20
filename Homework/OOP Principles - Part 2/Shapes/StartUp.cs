using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(1.2, 5);
            Triangle triangle = new Triangle(5, 2);
            Square square = new Square(2.5);


            List<Shape> shapes = new List<Shape> { rect, triangle, square };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0} surface:{1}", shape.GetType().Name, shape.CalculateSurface());
            }

        }
    }
}
